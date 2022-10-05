namespace TimeAndAttendanceToCsv
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_GetCSV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GetCSV
            // 
            this.btn_GetCSV.Location = new System.Drawing.Point(12, 12);
            this.btn_GetCSV.Name = "btn_GetCSV";
            this.btn_GetCSV.Size = new System.Drawing.Size(154, 43);
            this.btn_GetCSV.TabIndex = 0;
            this.btn_GetCSV.Text = "Get Time and Attendance CSV";
            this.btn_GetCSV.UseVisualStyleBackColor = true;
            this.btn_GetCSV.Click += new System.EventHandler(this.btn_GetCSV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 69);
            this.Controls.Add(this.btn_GetCSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_GetCSV;
    }
}