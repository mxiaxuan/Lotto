namespace 作業提示
{
    partial class Fm作業提示
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
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.btn產生號碼 = new System.Windows.Forms.Button();
            this.btn加入選號 = new System.Windows.Forms.Button();
            this.btn刪除所選號碼 = new System.Windows.Forms.Button();
            this.btn刪除所有號碼 = new System.Windows.Forms.Button();
            this.lstb選號紀錄 = new System.Windows.Forms.ListBox();
            this.lbl筆數 = new System.Windows.Forms.Label();
            this.lblfour = new System.Windows.Forms.Label();
            this.lblfive = new System.Windows.Forms.Label();
            this.lblsix = new System.Windows.Forms.Label();
            this.lblseven = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOne.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblOne.Location = new System.Drawing.Point(12, 61);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(68, 76);
            this.lblOne.TabIndex = 0;
            this.lblOne.Text = "0";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTwo.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTwo.Location = new System.Drawing.Point(148, 61);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(68, 76);
            this.lblTwo.TabIndex = 1;
            this.lblTwo.Text = "0";
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblThree.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblThree.Location = new System.Drawing.Point(292, 61);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(68, 76);
            this.lblThree.TabIndex = 2;
            this.lblThree.Text = "0";
            this.lblThree.Click += new System.EventHandler(this.lblThree_Click);
            // 
            // btn產生號碼
            // 
            this.btn產生號碼.AutoSize = true;
            this.btn產生號碼.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn產生號碼.Location = new System.Drawing.Point(411, 413);
            this.btn產生號碼.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn產生號碼.Name = "btn產生號碼";
            this.btn產生號碼.Size = new System.Drawing.Size(318, 50);
            this.btn產生號碼.TabIndex = 3;
            this.btn產生號碼.Text = "產生號碼";
            this.btn產生號碼.UseVisualStyleBackColor = true;
            this.btn產生號碼.Click += new System.EventHandler(this.btn產生號碼_Click);
            // 
            // btn加入選號
            // 
            this.btn加入選號.AutoSize = true;
            this.btn加入選號.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入選號.Location = new System.Drawing.Point(18, 171);
            this.btn加入選號.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn加入選號.Name = "btn加入選號";
            this.btn加入選號.Size = new System.Drawing.Size(224, 50);
            this.btn加入選號.TabIndex = 4;
            this.btn加入選號.Text = "產生選號";
            this.btn加入選號.UseVisualStyleBackColor = true;
            this.btn加入選號.Click += new System.EventHandler(this.btn加入選號_Click);
            // 
            // btn刪除所選號碼
            // 
            this.btn刪除所選號碼.AutoSize = true;
            this.btn刪除所選號碼.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除所選號碼.Location = new System.Drawing.Point(18, 249);
            this.btn刪除所選號碼.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn刪除所選號碼.Name = "btn刪除所選號碼";
            this.btn刪除所選號碼.Size = new System.Drawing.Size(224, 50);
            this.btn刪除所選號碼.TabIndex = 5;
            this.btn刪除所選號碼.Text = "刪除所選號碼";
            this.btn刪除所選號碼.UseVisualStyleBackColor = true;
            this.btn刪除所選號碼.Click += new System.EventHandler(this.btn刪除所選號碼_Click);
            // 
            // btn刪除所有號碼
            // 
            this.btn刪除所有號碼.AutoSize = true;
            this.btn刪除所有號碼.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除所有號碼.Location = new System.Drawing.Point(18, 335);
            this.btn刪除所有號碼.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn刪除所有號碼.Name = "btn刪除所有號碼";
            this.btn刪除所有號碼.Size = new System.Drawing.Size(224, 50);
            this.btn刪除所有號碼.TabIndex = 6;
            this.btn刪除所有號碼.Text = "刪除所有號碼";
            this.btn刪除所有號碼.UseVisualStyleBackColor = true;
            this.btn刪除所有號碼.Click += new System.EventHandler(this.btn刪除所有號碼_Click);
            // 
            // lstb選號紀錄
            // 
            this.lstb選號紀錄.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lstb選號紀錄.FormattingEnabled = true;
            this.lstb選號紀錄.ItemHeight = 35;
            this.lstb選號紀錄.Location = new System.Drawing.Point(273, 171);
            this.lstb選號紀錄.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstb選號紀錄.Name = "lstb選號紀錄";
            this.lstb選號紀錄.Size = new System.Drawing.Size(576, 214);
            this.lstb選號紀錄.TabIndex = 7;
            // 
            // lbl筆數
            // 
            this.lbl筆數.AutoSize = true;
            this.lbl筆數.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl筆數.Location = new System.Drawing.Point(883, 171);
            this.lbl筆數.Name = "lbl筆數";
            this.lbl筆數.Size = new System.Drawing.Size(85, 35);
            this.lbl筆數.TabIndex = 8;
            this.lbl筆數.Text = "共0筆";
            // 
            // lblfour
            // 
            this.lblfour.AutoSize = true;
            this.lblfour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblfour.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblfour.Location = new System.Drawing.Point(438, 61);
            this.lblfour.Name = "lblfour";
            this.lblfour.Size = new System.Drawing.Size(68, 76);
            this.lblfour.TabIndex = 9;
            this.lblfour.Text = "0";
            // 
            // lblfive
            // 
            this.lblfive.AutoSize = true;
            this.lblfive.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblfive.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblfive.Location = new System.Drawing.Point(582, 61);
            this.lblfive.Name = "lblfive";
            this.lblfive.Size = new System.Drawing.Size(68, 76);
            this.lblfive.TabIndex = 10;
            this.lblfive.Text = "0";
            // 
            // lblsix
            // 
            this.lblsix.AutoSize = true;
            this.lblsix.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblsix.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblsix.Location = new System.Drawing.Point(712, 61);
            this.lblsix.Name = "lblsix";
            this.lblsix.Size = new System.Drawing.Size(68, 76);
            this.lblsix.TabIndex = 11;
            this.lblsix.Text = "0";
            // 
            // lblseven
            // 
            this.lblseven.AutoSize = true;
            this.lblseven.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblseven.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblseven.Location = new System.Drawing.Point(866, 61);
            this.lblseven.Name = "lblseven";
            this.lblseven.Size = new System.Drawing.Size(68, 76);
            this.lblseven.TabIndex = 12;
            this.lblseven.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 35);
            this.label1.TabIndex = 13;
            this.label1.Text = "第一區(1~38)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(802, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 35);
            this.label2.TabIndex = 14;
            this.label2.Text = "第二區(1~8)";
            // 
            // Fm作業提示
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1011, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblseven);
            this.Controls.Add(this.lblsix);
            this.Controls.Add(this.lblfive);
            this.Controls.Add(this.lblfour);
            this.Controls.Add(this.lbl筆數);
            this.Controls.Add(this.lstb選號紀錄);
            this.Controls.Add(this.btn刪除所有號碼);
            this.Controls.Add(this.btn刪除所選號碼);
            this.Controls.Add(this.btn加入選號);
            this.Controls.Add(this.btn產生號碼);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Fm作業提示";
            this.Text = "作業提示";
            this.Load += new System.EventHandler(this.Fm作業提示_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Button btn產生號碼;
        private System.Windows.Forms.Button btn加入選號;
        private System.Windows.Forms.Button btn刪除所選號碼;
        private System.Windows.Forms.Button btn刪除所有號碼;
        private System.Windows.Forms.ListBox lstb選號紀錄;
        private System.Windows.Forms.Label lbl筆數;
        private System.Windows.Forms.Label lblfour;
        private System.Windows.Forms.Label lblfive;
        private System.Windows.Forms.Label lblsix;
        private System.Windows.Forms.Label lblseven;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

