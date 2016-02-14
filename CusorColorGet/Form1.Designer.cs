namespace CusorColorGet {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.C1_label = new System.Windows.Forms.Label();
            this.C_tb = new System.Windows.Forms.TextBox();
            this.C2_label = new System.Windows.Forms.Label();
            this.dragimg_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.C1Text_label = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // C1_label
            // 
            this.C1_label.AutoSize = true;
            this.C1_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C1_label.Font = new System.Drawing.Font("新細明體", 15F);
            this.C1_label.Location = new System.Drawing.Point(12, 4);
            this.C1_label.Name = "C1_label";
            this.C1_label.Size = new System.Drawing.Size(19, 20);
            this.C1_label.TabIndex = 0;
            this.C1_label.Text = "  ";
            // 
            // C_tb
            // 
            this.C_tb.Location = new System.Drawing.Point(37, 27);
            this.C_tb.Name = "C_tb";
            this.C_tb.ReadOnly = true;
            this.C_tb.Size = new System.Drawing.Size(48, 22);
            this.C_tb.TabIndex = 1;
            this.C_tb.Text = "#FFFFFF";
            // 
            // C2_label
            // 
            this.C2_label.AutoSize = true;
            this.C2_label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.C2_label.Font = new System.Drawing.Font("新細明體", 15F);
            this.C2_label.Location = new System.Drawing.Point(12, 27);
            this.C2_label.Name = "C2_label";
            this.C2_label.Size = new System.Drawing.Size(19, 20);
            this.C2_label.TabIndex = 2;
            this.C2_label.Text = "  ";
            // 
            // dragimg_label
            // 
            this.dragimg_label.AutoSize = true;
            this.dragimg_label.Font = new System.Drawing.Font("新細明體", 24F);
            this.dragimg_label.Image = global::CursorColorGet.Properties.Resources.Target_icon;
            this.dragimg_label.Location = new System.Drawing.Point(91, 9);
            this.dragimg_label.Name = "dragimg_label";
            this.dragimg_label.Size = new System.Drawing.Size(39, 32);
            this.dragimg_label.TabIndex = 3;
            this.dragimg_label.Text = "   ";
            this.dragimg_label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragimg_label_MouseDown);
            this.dragimg_label.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragimg_label_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // C1Text_label
            // 
            this.C1Text_label.AutoSize = true;
            this.C1Text_label.Font = new System.Drawing.Font("新細明體", 9F);
            this.C1Text_label.Location = new System.Drawing.Point(38, 9);
            this.C1Text_label.Name = "C1Text_label";
            this.C1Text_label.Size = new System.Drawing.Size(47, 12);
            this.C1Text_label.TabIndex = 4;
            this.C1Text_label.Text = "#FFFFFF";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(75, 52);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 12);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "darkautism\r\n";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(137, 69);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.C1Text_label);
            this.Controls.Add(this.dragimg_label);
            this.Controls.Add(this.C2_label);
            this.Controls.Add(this.C_tb);
            this.Controls.Add(this.C1_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CursorColorGet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label C1_label;
        private System.Windows.Forms.TextBox C_tb;
        private System.Windows.Forms.Label C2_label;
        private System.Windows.Forms.Label dragimg_label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label C1Text_label;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

