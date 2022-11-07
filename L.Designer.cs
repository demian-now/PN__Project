namespace PN
{
    partial class L
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
            this.m_nextl = new System.Windows.Forms.TextBox();
            this.m_npl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_nml = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.m_zl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IDC_NEXTL_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Индуктивность L";
            // 
            // m_nextl
            // 
            this.m_nextl.Location = new System.Drawing.Point(184, 35);
            this.m_nextl.Name = "m_nextl";
            this.m_nextl.Size = new System.Drawing.Size(100, 22);
            this.m_nextl.TabIndex = 1;
            // 
            // m_npl
            // 
            this.m_npl.Location = new System.Drawing.Point(184, 72);
            this.m_npl.Name = "m_npl";
            this.m_npl.Size = new System.Drawing.Size(100, 22);
            this.m_npl.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Узел n+";
            // 
            // m_nml
            // 
            this.m_nml.Location = new System.Drawing.Point(184, 113);
            this.m_nml.Name = "m_nml";
            this.m_nml.Size = new System.Drawing.Size(100, 22);
            this.m_nml.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Узел n-";
            // 
            // m_zl
            // 
            this.m_zl.Location = new System.Drawing.Point(184, 154);
            this.m_zl.Name = "m_zl";
            this.m_zl.Size = new System.Drawing.Size(100, 22);
            this.m_zl.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Индукция (мкГ)";
            // 
            // IDC_NEXTL_BUTTON
            // 
            this.IDC_NEXTL_BUTTON.Location = new System.Drawing.Point(96, 215);
            this.IDC_NEXTL_BUTTON.Name = "IDC_NEXTL_BUTTON";
            this.IDC_NEXTL_BUTTON.Size = new System.Drawing.Size(118, 23);
            this.IDC_NEXTL_BUTTON.TabIndex = 8;
            this.IDC_NEXTL_BUTTON.Text = "Следующий";
            this.IDC_NEXTL_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTL_BUTTON.Click += new System.EventHandler(this.IDC_NEXTL_BUTTON_Click);
            // 
            // L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 276);
            this.Controls.Add(this.IDC_NEXTL_BUTTON);
            this.Controls.Add(this.m_zl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_nml);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_npl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_nextl);
            this.Controls.Add(this.label1);
            this.Name = "L";
            this.Text = "L";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_nextl;
        private System.Windows.Forms.TextBox m_npl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_nml;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox m_zl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button IDC_NEXTL_BUTTON;
    }
}