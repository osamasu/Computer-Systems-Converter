namespace Design
{
    partial class Calculator
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BT_Convert = new FontAwesome.Sharp.IconButton();
            this.ResultPanel = new System.Windows.Forms.Panel();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.BT_Swap = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_ConvertFrom = new System.Windows.Forms.ComboBox();
            this.CB_ConvertTo = new System.Windows.Forms.ComboBox();
            this.InputPanel = new System.Windows.Forms.Panel();
            this.TB_Input = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ResultPanel.SuspendLayout();
            this.InputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.resetToolStripMenuItem.Text = "&Reset";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(224)))), ((int)(((byte)(242)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.BT_Convert);
            this.panel1.Controls.Add(this.ResultPanel);
            this.panel1.Controls.Add(this.BT_Swap);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CB_ConvertFrom);
            this.panel1.Controls.Add(this.CB_ConvertTo);
            this.panel1.Controls.Add(this.InputPanel);
            this.panel1.Location = new System.Drawing.Point(15, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 480);
            this.panel1.TabIndex = 1;
            // 
            // BT_Convert
            // 
            this.BT_Convert.BackColor = System.Drawing.Color.SeaGreen;
            this.BT_Convert.FlatAppearance.BorderSize = 3;
            this.BT_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Convert.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Convert.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleDown;
            this.BT_Convert.IconColor = System.Drawing.Color.Black;
            this.BT_Convert.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BT_Convert.Location = new System.Drawing.Point(268, 269);
            this.BT_Convert.Name = "BT_Convert";
            this.BT_Convert.Size = new System.Drawing.Size(116, 74);
            this.BT_Convert.TabIndex = 7;
            this.BT_Convert.Text = "Convert";
            this.BT_Convert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Convert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BT_Convert.UseVisualStyleBackColor = false;
            this.BT_Convert.Click += new System.EventHandler(this.BT_Convert_Click);
            // 
            // ResultPanel
            // 
            this.ResultPanel.BackColor = System.Drawing.SystemColors.GrayText;
            this.ResultPanel.Controls.Add(this.TB_Result);
            this.ResultPanel.Enabled = false;
            this.ResultPanel.Location = new System.Drawing.Point(14, 359);
            this.ResultPanel.Name = "ResultPanel";
            this.ResultPanel.Size = new System.Drawing.Size(625, 100);
            this.ResultPanel.TabIndex = 1;
            // 
            // TB_Result
            // 
            this.TB_Result.BackColor = System.Drawing.SystemColors.GrayText;
            this.TB_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Result.Font = new System.Drawing.Font("Trebuchet MS", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Result.ForeColor = System.Drawing.Color.White;
            this.TB_Result.Location = new System.Drawing.Point(12, 49);
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ReadOnly = true;
            this.TB_Result.Size = new System.Drawing.Size(597, 45);
            this.TB_Result.TabIndex = 0;
            this.TB_Result.TabStop = false;
            // 
            // BT_Swap
            // 
            this.BT_Swap.BackColor = System.Drawing.Color.LightCoral;
            this.BT_Swap.FlatAppearance.BorderSize = 3;
            this.BT_Swap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Swap.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Swap.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.BT_Swap.IconColor = System.Drawing.Color.Black;
            this.BT_Swap.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BT_Swap.Location = new System.Drawing.Point(268, 24);
            this.BT_Swap.Name = "BT_Swap";
            this.BT_Swap.Size = new System.Drawing.Size(116, 74);
            this.BT_Swap.TabIndex = 6;
            this.BT_Swap.Text = "Swap";
            this.BT_Swap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BT_Swap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BT_Swap.UseVisualStyleBackColor = false;
            this.BT_Swap.Click += new System.EventHandler(this.BT_Swap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bagnard Regular", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Convet To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bagnard Regular", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Convet From:";
            // 
            // CB_ConvertFrom
            // 
            this.CB_ConvertFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ConvertFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_ConvertFrom.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ConvertFrom.FormattingEnabled = true;
            this.CB_ConvertFrom.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.CB_ConvertFrom.Location = new System.Drawing.Point(55, 70);
            this.CB_ConvertFrom.Name = "CB_ConvertFrom";
            this.CB_ConvertFrom.Size = new System.Drawing.Size(164, 30);
            this.CB_ConvertFrom.TabIndex = 3;
            this.CB_ConvertFrom.SelectedIndexChanged += new System.EventHandler(this.CB_ConvertFrom_SelectedIndexChanged);
            // 
            // CB_ConvertTo
            // 
            this.CB_ConvertTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ConvertTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_ConvertTo.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ConvertTo.FormattingEnabled = true;
            this.CB_ConvertTo.Items.AddRange(new object[] {
            "Binary",
            "Octal",
            "Decimal",
            "Hexadecimal"});
            this.CB_ConvertTo.Location = new System.Drawing.Point(446, 70);
            this.CB_ConvertTo.Name = "CB_ConvertTo";
            this.CB_ConvertTo.Size = new System.Drawing.Size(164, 30);
            this.CB_ConvertTo.TabIndex = 2;
            this.CB_ConvertTo.SelectedIndexChanged += new System.EventHandler(this.CB_ConvertTo_SelectedIndexChanged);
            // 
            // InputPanel
            // 
            this.InputPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.InputPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.InputPanel.Controls.Add(this.TB_Input);
            this.InputPanel.Location = new System.Drawing.Point(14, 153);
            this.InputPanel.Name = "InputPanel";
            this.InputPanel.Size = new System.Drawing.Size(625, 100);
            this.InputPanel.TabIndex = 0;
            this.InputPanel.Click += new System.EventHandler(this.InputPanel_Click);
            // 
            // TB_Input
            // 
            this.TB_Input.BackColor = System.Drawing.Color.LightSteelBlue;
            this.TB_Input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TB_Input.Font = new System.Drawing.Font("Trebuchet MS", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Input.Location = new System.Drawing.Point(12, 49);
            this.TB_Input.Name = "TB_Input";
            this.TB_Input.Size = new System.Drawing.Size(597, 45);
            this.TB_Input.TabIndex = 0;
            this.TB_Input.TabStop = false;
            this.TB_Input.Validating += new System.ComponentModel.CancelEventHandler(this.TB_Input_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(220)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(682, 536);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResultPanel.ResumeLayout(false);
            this.ResultPanel.PerformLayout();
            this.InputPanel.ResumeLayout(false);
            this.InputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel InputPanel;
        private System.Windows.Forms.TextBox TB_Input;
        private System.Windows.Forms.ComboBox CB_ConvertTo;
        private System.Windows.Forms.ComboBox CB_ConvertFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton BT_Swap;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Panel ResultPanel;
        private System.Windows.Forms.TextBox TB_Result;
        private FontAwesome.Sharp.IconButton BT_Convert;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
