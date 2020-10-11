namespace VB2_AI.Demo
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtM = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGenResult = new System.Windows.Forms.Button();
            this.txtManualResult = new System.Windows.Forms.TextBox();
            this.cboC = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboP2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboP1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAutoResult = new System.Windows.Forms.TextBox();
            this.btnGenerateAllValid = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chủ ngữ (S):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vị ngữ (P):";
            // 
            // txtS
            // 
            this.txtS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtS.Location = new System.Drawing.Point(133, 27);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(386, 26);
            this.txtS.TabIndex = 3;
            this.txtS.TextChanged += new System.EventHandler(this.cboManual_SelectedIndexChanged);
            // 
            // txtP
            // 
            this.txtP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtP.Location = new System.Drawing.Point(133, 62);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(386, 26);
            this.txtP.TabIndex = 4;
            this.txtP.TextChanged += new System.EventHandler(this.cboManual_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trung từ (M):";
            // 
            // txtM
            // 
            this.txtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtM.Location = new System.Drawing.Point(133, 96);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(386, 26);
            this.txtM.TabIndex = 6;
            this.txtM.TextChanged += new System.EventHandler(this.cboManual_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 136);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(639, 404);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGenResult);
            this.tabPage2.Controls.Add(this.txtManualResult);
            this.tabPage2.Controls.Add(this.cboC);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.cboP2);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cboP1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cboType);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(631, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thủ công";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGenResult
            // 
            this.btnGenResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenResult.Location = new System.Drawing.Point(481, 8);
            this.btnGenResult.Name = "btnGenResult";
            this.btnGenResult.Size = new System.Drawing.Size(131, 30);
            this.btnGenResult.TabIndex = 9;
            this.btnGenResult.Text = "Sinh và kiểm tra";
            this.btnGenResult.UseVisualStyleBackColor = true;
            this.btnGenResult.Click += new System.EventHandler(this.btnGenResult_Click);
            // 
            // txtManualResult
            // 
            this.txtManualResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtManualResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManualResult.Location = new System.Drawing.Point(16, 51);
            this.txtManualResult.Multiline = true;
            this.txtManualResult.Name = "txtManualResult";
            this.txtManualResult.ReadOnly = true;
            this.txtManualResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtManualResult.Size = new System.Drawing.Size(596, 303);
            this.txtManualResult.TabIndex = 8;
            // 
            // cboC
            // 
            this.cboC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboC.FormattingEnabled = true;
            this.cboC.Items.AddRange(new object[] {
            "A",
            "E",
            "P",
            "B",
            "T",
            "D",
            "K",
            "G",
            "I",
            "O"});
            this.cboC.Location = new System.Drawing.Point(398, 10);
            this.cboC.Name = "cboC";
            this.cboC.Size = new System.Drawing.Size(46, 28);
            this.cboC.TabIndex = 7;
            this.cboC.SelectedIndexChanged += new System.EventHandler(this.cboManual_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "C:";
            // 
            // cboP2
            // 
            this.cboP2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboP2.FormattingEnabled = true;
            this.cboP2.Items.AddRange(new object[] {
            "A",
            "E",
            "P",
            "B",
            "T",
            "D",
            "K",
            "G",
            "I",
            "O"});
            this.cboP2.Location = new System.Drawing.Point(290, 10);
            this.cboP2.Name = "cboP2";
            this.cboP2.Size = new System.Drawing.Size(46, 28);
            this.cboP2.TabIndex = 5;
            this.cboP2.SelectedIndexChanged += new System.EventHandler(this.cboManual_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "P2:";
            // 
            // cboP1
            // 
            this.cboP1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboP1.FormattingEnabled = true;
            this.cboP1.Items.AddRange(new object[] {
            "A",
            "E",
            "P",
            "B",
            "T",
            "D",
            "K",
            "G",
            "I",
            "O"});
            this.cboP1.Location = new System.Drawing.Point(174, 10);
            this.cboP1.Name = "cboP1";
            this.cboP1.Size = new System.Drawing.Size(46, 28);
            this.cboP1.TabIndex = 3;
            this.cboP1.SelectedIndexChanged += new System.EventHandler(this.cboManual_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "P1:";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboType.Location = new System.Drawing.Point(51, 10);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(50, 28);
            this.cboType.TabIndex = 1;
            this.cboType.SelectedIndexChanged += new System.EventHandler(this.cboManual_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAutoResult);
            this.tabPage1.Controls.Add(this.btnGenerateAllValid);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(631, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tam đoạn luận hợp lệ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtAutoResult
            // 
            this.txtAutoResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAutoResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoResult.Location = new System.Drawing.Point(6, 41);
            this.txtAutoResult.Multiline = true;
            this.txtAutoResult.Name = "txtAutoResult";
            this.txtAutoResult.ReadOnly = true;
            this.txtAutoResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAutoResult.Size = new System.Drawing.Size(619, 222);
            this.txtAutoResult.TabIndex = 1;
            // 
            // btnGenerateAllValid
            // 
            this.btnGenerateAllValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateAllValid.Location = new System.Drawing.Point(6, 6);
            this.btnGenerateAllValid.Name = "btnGenerateAllValid";
            this.btnGenerateAllValid.Size = new System.Drawing.Size(158, 29);
            this.btnGenerateAllValid.TabIndex = 0;
            this.btnGenerateAllValid.Text = "Sinh tất cả";
            this.btnGenerateAllValid.UseVisualStyleBackColor = true;
            this.btnGenerateAllValid.Click += new System.EventHandler(this.btnGenerateAllValid_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 552);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.txtS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Demo - Tam đoạn luận";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAutoResult;
        private System.Windows.Forms.Button btnGenerateAllValid;
        private System.Windows.Forms.ComboBox cboP2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboP1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtManualResult;
        private System.Windows.Forms.Button btnGenResult;
    }
}

