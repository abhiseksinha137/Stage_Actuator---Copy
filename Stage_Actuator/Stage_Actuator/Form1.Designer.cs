namespace Stage_Actuator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtBxCurrent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSavePos = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtBxTarget = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.txtBxMoveRel = new System.Windows.Forms.TextBox();
            this.clearSavedPositonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setBaudrateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commStage = new customControl.comboSerial();
            this.tareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableWarningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnLstBxGo = new System.Windows.Forms.Button();
            this.btnLstBxRemove = new System.Windows.Forms.Button();
            this.txtBxSerialReceive = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(364, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(127, 212);
            this.listBox1.TabIndex = 19;
            // 
            // txtBxCurrent
            // 
            this.txtBxCurrent.Enabled = false;
            this.txtBxCurrent.Location = new System.Drawing.Point(224, 121);
            this.txtBxCurrent.Name = "txtBxCurrent";
            this.txtBxCurrent.Size = new System.Drawing.Size(76, 20);
            this.txtBxCurrent.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Current";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Saved Positions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Target";
            // 
            // btnSavePos
            // 
            this.btnSavePos.Location = new System.Drawing.Point(315, 119);
            this.btnSavePos.Name = "btnSavePos";
            this.btnSavePos.Size = new System.Drawing.Size(43, 23);
            this.btnSavePos.TabIndex = 8;
            this.btnSavePos.TabStop = false;
            this.btnSavePos.Text = "Save";
            this.btnSavePos.UseVisualStyleBackColor = true;
            this.btnSavePos.Click += new System.EventHandler(this.btnSavePos_Click);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(131, 119);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(43, 23);
            this.btnGo.TabIndex = 9;
            this.btnGo.TabStop = false;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtBxTarget
            // 
            this.txtBxTarget.Location = new System.Drawing.Point(49, 121);
            this.txtBxTarget.Name = "txtBxTarget";
            this.txtBxTarget.Size = new System.Drawing.Size(76, 20);
            this.txtBxTarget.TabIndex = 11;
            this.txtBxTarget.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBxTarget_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Relative Motion";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.btnMinus);
            this.panel1.Controls.Add(this.txtBxMoveRel);
            this.panel1.Location = new System.Drawing.Point(8, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 64);
            this.panel1.TabIndex = 12;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(212, 8);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(75, 51);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(8, 8);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(75, 51);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // txtBxMoveRel
            // 
            this.txtBxMoveRel.Location = new System.Drawing.Point(111, 24);
            this.txtBxMoveRel.Name = "txtBxMoveRel";
            this.txtBxMoveRel.Size = new System.Drawing.Size(70, 20);
            this.txtBxMoveRel.TabIndex = 2;
            // 
            // clearSavedPositonsToolStripMenuItem
            // 
            this.clearSavedPositonsToolStripMenuItem.Name = "clearSavedPositonsToolStripMenuItem";
            this.clearSavedPositonsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clearSavedPositonsToolStripMenuItem.Text = "Clear Saved Positons";
            this.clearSavedPositonsToolStripMenuItem.Click += new System.EventHandler(this.clearSavedPositonsToolStripMenuItem_Click);
            // 
            // setBaudrateToolStripMenuItem
            // 
            this.setBaudrateToolStripMenuItem.Name = "setBaudrateToolStripMenuItem";
            this.setBaudrateToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.setBaudrateToolStripMenuItem.Text = "Set Baudrate";
            this.setBaudrateToolStripMenuItem.Click += new System.EventHandler(this.setBaudrateToolStripMenuItem_Click);
            // 
            // commStage
            // 
            this.commStage.Location = new System.Drawing.Point(8, 36);
            this.commStage.Name = "commStage";
            this.commStage.Size = new System.Drawing.Size(102, 72);
            this.commStage.TabIndex = 10;
            this.commStage.TabStop = false;
            // 
            // tareToolStripMenuItem1
            // 
            this.tareToolStripMenuItem1.Name = "tareToolStripMenuItem1";
            this.tareToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.tareToolStripMenuItem1.Text = "Tare";
            this.tareToolStripMenuItem1.Click += new System.EventHandler(this.tareToolStripMenuItem_Click);
            // 
            // tareToolStripMenuItem
            // 
            this.tareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareToolStripMenuItem1,
            this.enableWarningToolStripMenuItem,
            this.setBaudrateToolStripMenuItem,
            this.clearSavedPositonsToolStripMenuItem});
            this.tareToolStripMenuItem.Name = "tareToolStripMenuItem";
            this.tareToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.tareToolStripMenuItem.Text = "Options";
            // 
            // enableWarningToolStripMenuItem
            // 
            this.enableWarningToolStripMenuItem.Name = "enableWarningToolStripMenuItem";
            this.enableWarningToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.enableWarningToolStripMenuItem.Text = "Enable Warning";
            this.enableWarningToolStripMenuItem.Click += new System.EventHandler(this.enableWarningToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(494, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnLstBxGo
            // 
            this.btnLstBxGo.Location = new System.Drawing.Point(364, 256);
            this.btnLstBxGo.Name = "btnLstBxGo";
            this.btnLstBxGo.Size = new System.Drawing.Size(64, 23);
            this.btnLstBxGo.TabIndex = 20;
            this.btnLstBxGo.Text = "Go To";
            this.btnLstBxGo.UseVisualStyleBackColor = true;
            this.btnLstBxGo.Click += new System.EventHandler(this.btnLstBxGo_Click);
            // 
            // btnLstBxRemove
            // 
            this.btnLstBxRemove.Location = new System.Drawing.Point(434, 256);
            this.btnLstBxRemove.Name = "btnLstBxRemove";
            this.btnLstBxRemove.Size = new System.Drawing.Size(57, 23);
            this.btnLstBxRemove.TabIndex = 20;
            this.btnLstBxRemove.Text = "Remove";
            this.btnLstBxRemove.UseVisualStyleBackColor = true;
            this.btnLstBxRemove.Click += new System.EventHandler(this.btnLstBxRemove_Click);
            // 
            // txtBxSerialReceive
            // 
            this.txtBxSerialReceive.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBxSerialReceive.ForeColor = System.Drawing.Color.Yellow;
            this.txtBxSerialReceive.Location = new System.Drawing.Point(8, 249);
            this.txtBxSerialReceive.Multiline = true;
            this.txtBxSerialReceive.Name = "txtBxSerialReceive";
            this.txtBxSerialReceive.Size = new System.Drawing.Size(292, 51);
            this.txtBxSerialReceive.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 302);
            this.Controls.Add(this.txtBxSerialReceive);
            this.Controls.Add(this.btnLstBxRemove);
            this.Controls.Add(this.btnLstBxGo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txtBxCurrent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSavePos);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtBxTarget);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.commStage);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txtBxCurrent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSavePos;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtBxTarget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.TextBox txtBxMoveRel;
        private System.Windows.Forms.ToolStripMenuItem clearSavedPositonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setBaudrateToolStripMenuItem;
        private customControl.comboSerial commStage;
        private System.Windows.Forms.ToolStripMenuItem tareToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableWarningToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnLstBxGo;
        private System.Windows.Forms.Button btnLstBxRemove;
        private System.Windows.Forms.TextBox txtBxSerialReceive;
    }
}

