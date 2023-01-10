using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stage_Actuator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void tareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the default baudrate
            commStage.baudrate = 115200;
            txtBxCurrent.Text = Properties.Settings.Default.pos;
            enableWarningToolStripMenuItem.Checked = Properties.Settings.Default.enableWarning;

            // Disable Resizing
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;


            // Save Positons List Update
            updateSavePositionList();
            commStage.com.DataReceived += dataReceived;
        }

        private void dataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string receiveText = commStage.ReadData();
            ThreadHelperClass.SetText(this, txtBxSerialReceive, receiveText);
        }

        private void moveTo(int target)
        {
            int current = int.Parse(txtBxCurrent.Text);
            int steps = target - current;
            moveStage(steps);
        }
        void moveStage(int steps)
        {
            if (commStage.com.IsOpen)
            {
                commStage.sendSerial(steps.ToString());
                int currentPos = int.Parse(Properties.Settings.Default.pos) + steps;
                Properties.Settings.Default.pos = currentPos.ToString();
                Properties.Settings.Default.Save();
                txtBxCurrent.Text = Properties.Settings.Default.pos;
            }
            else
               if (enableWarningToolStripMenuItem.Checked)
                MessageBox.Show("Connection to COM port unavailable");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            int rel;
            bool isNum = int.TryParse(txtBxMoveRel.Text, out rel);
            if (isNum)
            {
                moveStage(Math.Abs(rel));
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            int rel;
            bool isNum = int.TryParse(txtBxMoveRel.Text, out rel);
            if (isNum)
            {
                moveStage(-Math.Abs(rel));
            }
        }


        private void btnGo_Click(object sender, EventArgs e)
        {
            int target;

            bool isNum = int.TryParse(txtBxTarget.Text, out target);
            if (isNum)
            {
                moveTo(target);
            }
        }

        private void txtBxTarget_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBxTarget_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGo.PerformClick();
            }
        }

        private void tare()
        {
            Properties.Settings.Default.pos = "0";
            txtBxCurrent.Text = Properties.Settings.Default.pos;
        }

        private void tareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tare();
        }

        private void enableWarningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool state = enableWarningToolStripMenuItem.Checked;
            setEnableWarningToolStrip(!state);
        }
        public void setEnableWarningToolStrip(bool target)
        {
            enableWarningToolStripMenuItem.Checked = target;
            Properties.Settings.Default.enableWarning = target;
            Properties.Settings.Default.Save();
        }

        public void setBaudrate()
        {
            formBaudrate frm = new formBaudrate();
            frm.ShowDialog();
        }

        private void setBaudrateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setBaudrate();
        }

        private void btnSavePos_Click(object sender, EventArgs e)
        {
            string tag = "";
            if (InputBox("Save New Position", "Enter the Tag for the current Postion", ref tag) == DialogResult.OK)
            {
                savePosition(txtBxCurrent.Text, tag);
            }

        }
        public void savePosition(string position, string tag)
        {
            if (Properties.Settings.Default.savedPositions != "")
            {
                Properties.Settings.Default.savedPositions = Properties.Settings.Default.savedPositions + "," + position;
                Properties.Settings.Default.savedPositionTags = Properties.Settings.Default.savedPositionTags + "," + tag;
            }
            else
            {
                Properties.Settings.Default.savedPositions = position;
                Properties.Settings.Default.savedPositionTags = tag;
            }
            Properties.Settings.Default.Save();
            updateSavePositionList();
        }

        public void updateSavePositionList()
        {
            if (Properties.Settings.Default.savedPositions != "")
            {
                string savedPositions = Properties.Settings.Default.savedPositions;
                string savedPositionTags = Properties.Settings.Default.savedPositionTags;
                List<string> savedPositionsList = savedPositions.Split(',').ToList();
                List<string> savedPositionTagsList = savedPositionTags.Split(',').ToList();

                listBox1.Items.Clear();
                for (int i = 0; i < savedPositionsList.Count; i++)
                {
                    string str = savedPositionTagsList[i] + " : " + savedPositionsList[i];
                    listBox1.Items.Add(str);
                }
            }
            else
            {
                listBox1.Items.Clear();
            }


        }

        private void clearSavedPositonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.savedPositions = "";
            Properties.Settings.Default.savedPositionTags = "";
            Properties.Settings.Default.Save();
            updateSavePositionList();
        }
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }

        private void btnLstBxGo_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Selct one of the saved positions!");
            }
            else
            {
                int index = listBox1.SelectedIndex;
                string target = getsavedPositionValue(index);
                moveTo(int.Parse(target));
               
            }
        }
        public string getsavedPositionValue(int index)
        {
            if (Properties.Settings.Default.savedPositions != "")
            {
                
                string savedPositions = Properties.Settings.Default.savedPositions;
                string savedPositionTags = Properties.Settings.Default.savedPositionTags;
                List<string> savedPositionsList = savedPositions.Split(',').ToList();
                List<string> savedPositionTagsList = savedPositionTags.Split(',').ToList();

                if (index<savedPositionsList.Count )
                {
                    return savedPositionsList[index];
                }
            }
            return "";
        }

        private void btnLstBxRemove_Click(object sender, EventArgs e)
        {
            removeFromoListBox();
        }
        public void removeFromoListBox()
        {
            if (listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex;
                removeSavedPosition(index);
            }
            else
            {
                MessageBox.Show("Select a pre-saved position!");
            }
        }

        public void removeSavedPosition(int index)
        {
            string savedPositions = Properties.Settings.Default.savedPositions;
            string savedPositionTags = Properties.Settings.Default.savedPositionTags;
            List<string> savedPositionsList = savedPositions.Split(',').ToList();
            List<string> savedPositionTagsList = savedPositionTags.Split(',').ToList();

            savedPositionsList.RemoveAt(index);
            savedPositionTagsList.RemoveAt(index);
            updateSavedPositionsSettings(savedPositionsList, savedPositionTagsList);
            

        }

        public void updateSavedPositionsSettings(List<string> savedPositionsList, List<string> savedPositionTagsList)
        {
            Properties.Settings.Default.savedPositions = ""; // Clear the positions first
            Properties.Settings.Default.savedPositionTags = "";
            if (savedPositionsList.Count > 0)
            {
                for (int i = 0; i < savedPositionsList.Count; i++)
                {
                    string position = savedPositionsList[i];
                    string tag = savedPositionTagsList[i];
                    savePosition(position, tag);
                }
            }
            else
            {
                savePosition("", "");
            }
        }
    }
}
