namespace WfGitHubTest_PV221
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
            lblData = new Label();
            SuspendLayout();
            // 
            // lblData
            // 
            lblData.BackColor = Color.FromArgb(255, 255, 192);
            lblData.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lblData.Location = new Point(179, 126);
            lblData.Name = "lblData";
            lblData.Size = new Size(416, 162);
            lblData.TabIndex = 0;
            lblData.Text = "Hello, World";
            lblData.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblData);
            Name = "Form1";
            Text = "GitHub Test";
            ResumeLayout(false);
        }

        #endregion

        private Label lblData;
    }
}