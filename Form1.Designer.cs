
namespace B0226497_段昱如_PDPR_week14_1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCHAR = new System.Windows.Forms.ComboBox();
            this.lstCOLOR = new System.Windows.Forms.ListBox();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNORMAL = new System.Windows.Forms.RadioButton();
            this.rdbUNDERLINE = new System.Windows.Forms.RadioButton();
            this.rdbITALIC = new System.Windows.Forms.RadioButton();
            this.rdbBOLD = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "B0226497_段昱如_PDPR_week14_1";
            this.label1.FontChanged += new System.EventHandler(this.label1_FontChanged);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "字型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "顏色：";
            // 
            // cboCHAR
            // 
            this.cboCHAR.FormattingEnabled = true;
            this.cboCHAR.Items.AddRange(new object[] {
            "標楷體",
            "微軟正黑體",
            "新細明體",
            "Times New Roman",
            "Arial"});
            this.cboCHAR.Location = new System.Drawing.Point(145, 123);
            this.cboCHAR.Name = "cboCHAR";
            this.cboCHAR.Size = new System.Drawing.Size(267, 31);
            this.cboCHAR.TabIndex = 4;
            this.cboCHAR.SelectedIndexChanged += new System.EventHandler(this.cboCHAR_SelectedIndexChanged);
            // 
            // lstCOLOR
            // 
            this.lstCOLOR.FormattingEnabled = true;
            this.lstCOLOR.ItemHeight = 23;
            this.lstCOLOR.Location = new System.Drawing.Point(528, 126);
            this.lstCOLOR.Name = "lstCOLOR";
            this.lstCOLOR.Size = new System.Drawing.Size(221, 188);
            this.lstCOLOR.TabIndex = 5;
            this.lstCOLOR.SelectedIndexChanged += new System.EventHandler(this.lstCOLOR_SelectedIndexChanged);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(57, 413);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(154, 54);
            this.btnEXIT.TabIndex = 6;
            this.btnEXIT.Text = "btnEXIT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNORMAL);
            this.groupBox1.Controls.Add(this.rdbUNDERLINE);
            this.groupBox1.Controls.Add(this.rdbITALIC);
            this.groupBox1.Controls.Add(this.rdbBOLD);
            this.groupBox1.Location = new System.Drawing.Point(61, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 115);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "樣式：";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbNORMAL
            // 
            this.rdbNORMAL.AutoSize = true;
            this.rdbNORMAL.Location = new System.Drawing.Point(375, 47);
            this.rdbNORMAL.Name = "rdbNORMAL";
            this.rdbNORMAL.Size = new System.Drawing.Size(79, 28);
            this.rdbNORMAL.TabIndex = 3;
            this.rdbNORMAL.TabStop = true;
            this.rdbNORMAL.Text = "正常";
            this.rdbNORMAL.UseVisualStyleBackColor = true;
            this.rdbNORMAL.CheckedChanged += new System.EventHandler(this.rdbNORMAL_CheckedChanged);
            // 
            // rdbUNDERLINE
            // 
            this.rdbUNDERLINE.AutoSize = true;
            this.rdbUNDERLINE.Location = new System.Drawing.Point(252, 47);
            this.rdbUNDERLINE.Name = "rdbUNDERLINE";
            this.rdbUNDERLINE.Size = new System.Drawing.Size(79, 28);
            this.rdbUNDERLINE.TabIndex = 2;
            this.rdbUNDERLINE.TabStop = true;
            this.rdbUNDERLINE.Text = "底線";
            this.rdbUNDERLINE.UseVisualStyleBackColor = true;
            this.rdbUNDERLINE.CheckedChanged += new System.EventHandler(this.rdbUNDERLINE_CheckedChanged);
            // 
            // rdbITALIC
            // 
            this.rdbITALIC.AutoSize = true;
            this.rdbITALIC.Location = new System.Drawing.Point(129, 47);
            this.rdbITALIC.Name = "rdbITALIC";
            this.rdbITALIC.Size = new System.Drawing.Size(79, 28);
            this.rdbITALIC.TabIndex = 1;
            this.rdbITALIC.TabStop = true;
            this.rdbITALIC.Text = "斜體";
            this.rdbITALIC.UseVisualStyleBackColor = true;
            this.rdbITALIC.CheckedChanged += new System.EventHandler(this.rdbITALIC_CheckedChanged);
            // 
            // rdbBOLD
            // 
            this.rdbBOLD.AutoSize = true;
            this.rdbBOLD.Location = new System.Drawing.Point(6, 47);
            this.rdbBOLD.Name = "rdbBOLD";
            this.rdbBOLD.Size = new System.Drawing.Size(79, 28);
            this.rdbBOLD.TabIndex = 0;
            this.rdbBOLD.TabStop = true;
            this.rdbBOLD.Text = "粗體";
            this.rdbBOLD.UseVisualStyleBackColor = true;
            this.rdbBOLD.CheckedChanged += new System.EventHandler(this.rdbBOLD_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.lstCOLOR);
            this.Controls.Add(this.cboCHAR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "B0226497_段昱如_PDPR_week14_1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCHAR;
        private System.Windows.Forms.ListBox lstCOLOR;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNORMAL;
        private System.Windows.Forms.RadioButton rdbUNDERLINE;
        private System.Windows.Forms.RadioButton rdbITALIC;
        private System.Windows.Forms.RadioButton rdbBOLD;
    }
}

