﻿namespace Assembler
{
    partial class MicrocodeForm
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
            this.microcodeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // microcodeListBox
            // 
            this.microcodeListBox.FormattingEnabled = true;
            this.microcodeListBox.Location = new System.Drawing.Point(23, 56);
            this.microcodeListBox.Name = "microcodeListBox";
            this.microcodeListBox.Size = new System.Drawing.Size(537, 225);
            this.microcodeListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Microcode";
            // 
            // MicrocodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.microcodeListBox);
            this.Name = "MicrocodeForm";
            this.Text = "MicrocodeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox microcodeListBox;
        public System.Windows.Forms.Label label1;
    }
}