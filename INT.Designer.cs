﻿namespace PN
{
    partial class INT
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
            this.IDC_COMBO = new System.Windows.Forms.ComboBox();
            this.IDC_INP = new System.Windows.Forms.Button();
            this.IDC_FORWARD = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.IDC_STOP = new System.Windows.Forms.Button();
            this.IDC_EXPLORER = new System.Windows.Forms.WebBrowser();
            this.IDC_PROGRESS = new System.Windows.Forms.ProgressBar();
            this.IDC_EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес:";
            // 
            // IDC_COMBO
            // 
            this.IDC_COMBO.ForeColor = System.Drawing.SystemColors.WindowText;
            this.IDC_COMBO.FormattingEnabled = true;
            this.IDC_COMBO.Items.AddRange(new object[] {
            "http://localhost/MF/beg.html",
            "http://127.0.0.1/MF/Int3d.htm",
            "http://127.0.0.1/MF/ParamComp.html",
            "http://yandex.ru",
            "http://mail.ru"});
            this.IDC_COMBO.Location = new System.Drawing.Point(70, 13);
            this.IDC_COMBO.Name = "IDC_COMBO";
            this.IDC_COMBO.Size = new System.Drawing.Size(279, 24);
            this.IDC_COMBO.TabIndex = 1;
            // 
            // IDC_INP
            // 
            this.IDC_INP.Location = new System.Drawing.Point(355, 14);
            this.IDC_INP.Name = "IDC_INP";
            this.IDC_INP.Size = new System.Drawing.Size(75, 23);
            this.IDC_INP.TabIndex = 2;
            this.IDC_INP.Text = "Ввод";
            this.IDC_INP.UseVisualStyleBackColor = true;
            this.IDC_INP.Click += new System.EventHandler(this.IDC_INP_Click);
            // 
            // IDC_FORWARD
            // 
            this.IDC_FORWARD.Location = new System.Drawing.Point(473, 14);
            this.IDC_FORWARD.Name = "IDC_FORWARD";
            this.IDC_FORWARD.Size = new System.Drawing.Size(75, 23);
            this.IDC_FORWARD.TabIndex = 3;
            this.IDC_FORWARD.Text = "Вперед";
            this.IDC_FORWARD.UseVisualStyleBackColor = true;
            this.IDC_FORWARD.Click += new System.EventHandler(this.IDC_FORWARD_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(596, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.IDC_BACK_Click);
            // 
            // IDC_STOP
            // 
            this.IDC_STOP.Location = new System.Drawing.Point(713, 14);
            this.IDC_STOP.Name = "IDC_STOP";
            this.IDC_STOP.Size = new System.Drawing.Size(75, 23);
            this.IDC_STOP.TabIndex = 5;
            this.IDC_STOP.Text = "Стоп";
            this.IDC_STOP.UseVisualStyleBackColor = true;
            this.IDC_STOP.Click += new System.EventHandler(this.IDC_STOP_Click);
            // 
            // IDC_EXPLORER
            // 
            this.IDC_EXPLORER.Location = new System.Drawing.Point(16, 43);
            this.IDC_EXPLORER.MinimumSize = new System.Drawing.Size(20, 20);
            this.IDC_EXPLORER.Name = "IDC_EXPLORER";
            this.IDC_EXPLORER.Size = new System.Drawing.Size(772, 374);
            this.IDC_EXPLORER.TabIndex = 6;
            this.IDC_EXPLORER.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.IDC_EXPLORER_Navigated);
            this.IDC_EXPLORER.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.IDC_EXPLORER_Navigating);
            this.IDC_EXPLORER.ProgressChanged += new System.Windows.Forms.WebBrowserProgressChangedEventHandler(this.IDC_EXPLORER_ProgressChanged);
            // 
            // IDC_PROGRESS
            // 
            this.IDC_PROGRESS.Location = new System.Drawing.Point(115, 423);
            this.IDC_PROGRESS.Name = "IDC_PROGRESS";
            this.IDC_PROGRESS.Size = new System.Drawing.Size(287, 23);
            this.IDC_PROGRESS.TabIndex = 7;
            // 
            // IDC_EXIT
            // 
            this.IDC_EXIT.Location = new System.Drawing.Point(516, 423);
            this.IDC_EXIT.Name = "IDC_EXIT";
            this.IDC_EXIT.Size = new System.Drawing.Size(75, 23);
            this.IDC_EXIT.TabIndex = 8;
            this.IDC_EXIT.Text = "Закрыть";
            this.IDC_EXIT.UseVisualStyleBackColor = true;
            this.IDC_EXIT.Click += new System.EventHandler(this.IDC_EXIT_Click);
            // 
            // INT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IDC_EXIT);
            this.Controls.Add(this.IDC_PROGRESS);
            this.Controls.Add(this.IDC_EXPLORER);
            this.Controls.Add(this.IDC_STOP);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.IDC_FORWARD);
            this.Controls.Add(this.IDC_INP);
            this.Controls.Add(this.IDC_COMBO);
            this.Controls.Add(this.label1);
            this.Name = "INT";
            this.Text = "INT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox IDC_COMBO;
        private System.Windows.Forms.Button IDC_INP;
        private System.Windows.Forms.Button IDC_FORWARD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button IDC_STOP;
        private System.Windows.Forms.WebBrowser IDC_EXPLORER;
        private System.Windows.Forms.ProgressBar IDC_PROGRESS;
        private System.Windows.Forms.Button IDC_EXIT;
    }
}