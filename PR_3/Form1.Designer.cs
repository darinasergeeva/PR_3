namespace PR_3
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
            labelTabl = new Label();
            labelBottom = new Label();
            SuspendLayout();
            // 
            // labelTabl
            // 
            labelTabl.Dock = DockStyle.Top;
            labelTabl.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTabl.Location = new Point(0, 0);
            labelTabl.Name = "labelTabl";
            labelTabl.Size = new Size(800, 97);
            labelTabl.TabIndex = 0;
            labelTabl.Text = "Список партнёров";
            labelTabl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelBottom
            // 
            labelBottom.Dock = DockStyle.Bottom;
            labelBottom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelBottom.Location = new Point(0, 103);
            labelBottom.Name = "labelBottom";
            labelBottom.Size = new Size(800, 347);
            labelBottom.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBottom);
            Controls.Add(labelTabl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelTabl;
        private Label labelBottom;
    }
}
