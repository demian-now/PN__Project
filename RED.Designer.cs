namespace PN
{
    partial class RED
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
            this.m_redlist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_n = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IDC_OUT_BUTTON = new System.Windows.Forms.Button();
            this.IDC_NP1_STATIC = new System.Windows.Forms.Label();
            this.m_np1 = new System.Windows.Forms.TextBox();
            this.IDC_NM1_STATIC = new System.Windows.Forms.Label();
            this.m_nm1 = new System.Windows.Forms.TextBox();
            this.IDC_NM2_STATIC = new System.Windows.Forms.Label();
            this.m_nm2 = new System.Windows.Forms.TextBox();
            this.IDC_NP2_STATIC = new System.Windows.Forms.Label();
            this.m_np2 = new System.Windows.Forms.TextBox();
            this.IDC_Z2_STATIC = new System.Windows.Forms.Label();
            this.m_z2 = new System.Windows.Forms.TextBox();
            this.IDC_Z1_STATIC = new System.Windows.Forms.Label();
            this.m_z1 = new System.Windows.Forms.TextBox();
            this.IDC_Z4_STATIC = new System.Windows.Forms.Label();
            this.m_z4 = new System.Windows.Forms.TextBox();
            this.IDC_Z3_STATIC = new System.Windows.Forms.Label();
            this.m_z3 = new System.Windows.Forms.TextBox();
            this.IDC_Z6_STATIC = new System.Windows.Forms.Label();
            this.m_z6 = new System.Windows.Forms.TextBox();
            this.IDC_Z5_STATIC = new System.Windows.Forms.Label();
            this.m_z5 = new System.Windows.Forms.TextBox();
            this.IDC_IN_BUTTON = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_redlist
            // 
            this.m_redlist.FormattingEnabled = true;
            this.m_redlist.ItemHeight = 16;
            this.m_redlist.Items.AddRange(new object[] {
            "Резисторы",
            "Конденсаторы",
            "Индуктивности"});
            this.m_redlist.Location = new System.Drawing.Point(12, 41);
            this.m_redlist.Name = "m_redlist";
            this.m_redlist.Size = new System.Drawing.Size(169, 180);
            this.m_redlist.TabIndex = 0;
            this.m_redlist.SelectedIndexChanged += new System.EventHandler(this.m_redlist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип компонента";
            // 
            // m_n
            // 
            this.m_n.Location = new System.Drawing.Point(470, 12);
            this.m_n.Name = "m_n";
            this.m_n.Size = new System.Drawing.Size(141, 22);
            this.m_n.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Номер компонента";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // IDC_OUT_BUTTON
            // 
            this.IDC_OUT_BUTTON.Location = new System.Drawing.Point(365, 41);
            this.IDC_OUT_BUTTON.Name = "IDC_OUT_BUTTON";
            this.IDC_OUT_BUTTON.Size = new System.Drawing.Size(148, 23);
            this.IDC_OUT_BUTTON.TabIndex = 4;
            this.IDC_OUT_BUTTON.Text = "Вывод описания";
            this.IDC_OUT_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_OUT_BUTTON.Click += new System.EventHandler(this.IDC_OUT_BUTTON_Click);
            // 
            // IDC_NP1_STATIC
            // 
            this.IDC_NP1_STATIC.AutoSize = true;
            this.IDC_NP1_STATIC.Location = new System.Drawing.Point(215, 89);
            this.IDC_NP1_STATIC.Name = "IDC_NP1_STATIC";
            this.IDC_NP1_STATIC.Size = new System.Drawing.Size(44, 16);
            this.IDC_NP1_STATIC.TabIndex = 6;
            this.IDC_NP1_STATIC.Text = "label3";
            // 
            // m_np1
            // 
            this.m_np1.Location = new System.Drawing.Point(312, 86);
            this.m_np1.Name = "m_np1";
            this.m_np1.Size = new System.Drawing.Size(100, 22);
            this.m_np1.TabIndex = 5;
            // 
            // IDC_NM1_STATIC
            // 
            this.IDC_NM1_STATIC.AutoSize = true;
            this.IDC_NM1_STATIC.Location = new System.Drawing.Point(215, 127);
            this.IDC_NM1_STATIC.Name = "IDC_NM1_STATIC";
            this.IDC_NM1_STATIC.Size = new System.Drawing.Size(44, 16);
            this.IDC_NM1_STATIC.TabIndex = 8;
            this.IDC_NM1_STATIC.Text = "label4";
            // 
            // m_nm1
            // 
            this.m_nm1.Location = new System.Drawing.Point(312, 124);
            this.m_nm1.Name = "m_nm1";
            this.m_nm1.Size = new System.Drawing.Size(100, 22);
            this.m_nm1.TabIndex = 7;
            // 
            // IDC_NM2_STATIC
            // 
            this.IDC_NM2_STATIC.AutoSize = true;
            this.IDC_NM2_STATIC.Location = new System.Drawing.Point(446, 127);
            this.IDC_NM2_STATIC.Name = "IDC_NM2_STATIC";
            this.IDC_NM2_STATIC.Size = new System.Drawing.Size(44, 16);
            this.IDC_NM2_STATIC.TabIndex = 12;
            this.IDC_NM2_STATIC.Text = "label5";
            // 
            // m_nm2
            // 
            this.m_nm2.Location = new System.Drawing.Point(543, 124);
            this.m_nm2.Name = "m_nm2";
            this.m_nm2.Size = new System.Drawing.Size(100, 22);
            this.m_nm2.TabIndex = 11;
            // 
            // IDC_NP2_STATIC
            // 
            this.IDC_NP2_STATIC.AutoSize = true;
            this.IDC_NP2_STATIC.Location = new System.Drawing.Point(446, 89);
            this.IDC_NP2_STATIC.Name = "IDC_NP2_STATIC";
            this.IDC_NP2_STATIC.Size = new System.Drawing.Size(44, 16);
            this.IDC_NP2_STATIC.TabIndex = 10;
            this.IDC_NP2_STATIC.Text = "label6";
            // 
            // m_np2
            // 
            this.m_np2.Location = new System.Drawing.Point(543, 86);
            this.m_np2.Name = "m_np2";
            this.m_np2.Size = new System.Drawing.Size(100, 22);
            this.m_np2.TabIndex = 9;
            // 
            // IDC_Z2_STATIC
            // 
            this.IDC_Z2_STATIC.AutoSize = true;
            this.IDC_Z2_STATIC.Location = new System.Drawing.Point(446, 202);
            this.IDC_Z2_STATIC.Name = "IDC_Z2_STATIC";
            this.IDC_Z2_STATIC.Size = new System.Drawing.Size(44, 16);
            this.IDC_Z2_STATIC.TabIndex = 16;
            this.IDC_Z2_STATIC.Text = "label7";
            // 
            // m_z2
            // 
            this.m_z2.Location = new System.Drawing.Point(543, 199);
            this.m_z2.Name = "m_z2";
            this.m_z2.Size = new System.Drawing.Size(100, 22);
            this.m_z2.TabIndex = 15;
            // 
            // IDC_Z1_STATIC
            // 
            this.IDC_Z1_STATIC.AutoSize = true;
            this.IDC_Z1_STATIC.Location = new System.Drawing.Point(446, 164);
            this.IDC_Z1_STATIC.Name = "IDC_Z1_STATIC";
            this.IDC_Z1_STATIC.Size = new System.Drawing.Size(44, 16);
            this.IDC_Z1_STATIC.TabIndex = 14;
            this.IDC_Z1_STATIC.Text = "label8";
            // 
            // m_z1
            // 
            this.m_z1.Location = new System.Drawing.Point(543, 161);
            this.m_z1.Name = "m_z1";
            this.m_z1.Size = new System.Drawing.Size(100, 22);
            this.m_z1.TabIndex = 13;
            // 
            // IDC_Z4_STATIC
            // 
            this.IDC_Z4_STATIC.AutoSize = true;
            this.IDC_Z4_STATIC.Location = new System.Drawing.Point(446, 282);
            this.IDC_Z4_STATIC.Name = "IDC_Z4_STATIC";
            this.IDC_Z4_STATIC.Size = new System.Drawing.Size(44, 16);
            this.IDC_Z4_STATIC.TabIndex = 20;
            this.IDC_Z4_STATIC.Text = "label9";
            // 
            // m_z4
            // 
            this.m_z4.Location = new System.Drawing.Point(543, 279);
            this.m_z4.Name = "m_z4";
            this.m_z4.Size = new System.Drawing.Size(100, 22);
            this.m_z4.TabIndex = 19;
            // 
            // IDC_Z3_STATIC
            // 
            this.IDC_Z3_STATIC.AutoSize = true;
            this.IDC_Z3_STATIC.Location = new System.Drawing.Point(446, 244);
            this.IDC_Z3_STATIC.Name = "IDC_Z3_STATIC";
            this.IDC_Z3_STATIC.Size = new System.Drawing.Size(51, 16);
            this.IDC_Z3_STATIC.TabIndex = 18;
            this.IDC_Z3_STATIC.Text = "label10";
            // 
            // m_z3
            // 
            this.m_z3.Location = new System.Drawing.Point(543, 241);
            this.m_z3.Name = "m_z3";
            this.m_z3.Size = new System.Drawing.Size(100, 22);
            this.m_z3.TabIndex = 17;
            // 
            // IDC_Z6_STATIC
            // 
            this.IDC_Z6_STATIC.AutoSize = true;
            this.IDC_Z6_STATIC.Location = new System.Drawing.Point(446, 361);
            this.IDC_Z6_STATIC.Name = "IDC_Z6_STATIC";
            this.IDC_Z6_STATIC.Size = new System.Drawing.Size(51, 16);
            this.IDC_Z6_STATIC.TabIndex = 24;
            this.IDC_Z6_STATIC.Text = "label11";
            // 
            // m_z6
            // 
            this.m_z6.Location = new System.Drawing.Point(543, 358);
            this.m_z6.Name = "m_z6";
            this.m_z6.Size = new System.Drawing.Size(100, 22);
            this.m_z6.TabIndex = 23;
            // 
            // IDC_Z5_STATIC
            // 
            this.IDC_Z5_STATIC.AutoSize = true;
            this.IDC_Z5_STATIC.Location = new System.Drawing.Point(446, 323);
            this.IDC_Z5_STATIC.Name = "IDC_Z5_STATIC";
            this.IDC_Z5_STATIC.Size = new System.Drawing.Size(51, 16);
            this.IDC_Z5_STATIC.TabIndex = 22;
            this.IDC_Z5_STATIC.Text = "label12";
            // 
            // m_z5
            // 
            this.m_z5.Location = new System.Drawing.Point(543, 320);
            this.m_z5.Name = "m_z5";
            this.m_z5.Size = new System.Drawing.Size(100, 22);
            this.m_z5.TabIndex = 21;
            // 
            // IDC_IN_BUTTON
            // 
            this.IDC_IN_BUTTON.Location = new System.Drawing.Point(365, 415);
            this.IDC_IN_BUTTON.Name = "IDC_IN_BUTTON";
            this.IDC_IN_BUTTON.Size = new System.Drawing.Size(148, 23);
            this.IDC_IN_BUTTON.TabIndex = 25;
            this.IDC_IN_BUTTON.Text = "Ввод описания";
            this.IDC_IN_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_IN_BUTTON.Click += new System.EventHandler(this.IDC_IN_BUTTON_Click);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(16, 415);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(148, 23);
            this.OK.TabIndex = 26;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // RED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.IDC_IN_BUTTON);
            this.Controls.Add(this.IDC_Z6_STATIC);
            this.Controls.Add(this.m_z6);
            this.Controls.Add(this.IDC_Z5_STATIC);
            this.Controls.Add(this.m_z5);
            this.Controls.Add(this.IDC_Z4_STATIC);
            this.Controls.Add(this.m_z4);
            this.Controls.Add(this.IDC_Z3_STATIC);
            this.Controls.Add(this.m_z3);
            this.Controls.Add(this.IDC_Z2_STATIC);
            this.Controls.Add(this.m_z2);
            this.Controls.Add(this.IDC_Z1_STATIC);
            this.Controls.Add(this.m_z1);
            this.Controls.Add(this.IDC_NM2_STATIC);
            this.Controls.Add(this.m_nm2);
            this.Controls.Add(this.IDC_NP2_STATIC);
            this.Controls.Add(this.m_np2);
            this.Controls.Add(this.IDC_NM1_STATIC);
            this.Controls.Add(this.m_nm1);
            this.Controls.Add(this.IDC_NP1_STATIC);
            this.Controls.Add(this.m_np1);
            this.Controls.Add(this.IDC_OUT_BUTTON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_n);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_redlist);
            this.Name = "RED";
            this.Text = "Редактирование элементов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox m_redlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_n;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button IDC_OUT_BUTTON;
        private System.Windows.Forms.Label IDC_NP1_STATIC;
        private System.Windows.Forms.TextBox m_np1;
        private System.Windows.Forms.Label IDC_NM1_STATIC;
        private System.Windows.Forms.TextBox m_nm1;
        private System.Windows.Forms.Label IDC_NM2_STATIC;
        private System.Windows.Forms.TextBox m_nm2;
        private System.Windows.Forms.Label IDC_NP2_STATIC;
        private System.Windows.Forms.TextBox m_np2;
        private System.Windows.Forms.Label IDC_Z2_STATIC;
        private System.Windows.Forms.TextBox m_z2;
        private System.Windows.Forms.Label IDC_Z1_STATIC;
        private System.Windows.Forms.TextBox m_z1;
        private System.Windows.Forms.Label IDC_Z4_STATIC;
        private System.Windows.Forms.TextBox m_z4;
        private System.Windows.Forms.Label IDC_Z3_STATIC;
        private System.Windows.Forms.TextBox m_z3;
        private System.Windows.Forms.Label IDC_Z6_STATIC;
        private System.Windows.Forms.TextBox m_z6;
        private System.Windows.Forms.Label IDC_Z5_STATIC;
        private System.Windows.Forms.TextBox m_z5;
        private System.Windows.Forms.Button IDC_IN_BUTTON;
        private System.Windows.Forms.Button OK;
    }
}