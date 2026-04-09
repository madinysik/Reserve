namespace Reserve
{
    partial class DetailsForm
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
            panel = new Panel();
            lblTitle = new Label();
            txtDetails = new TextBox();
            btnClose = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BackColor = Color.Green;
            panel.Controls.Add(lblTitle);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(800, 56);
            panel.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(306, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(181, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = " Информация";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDetails
            // 
            txtDetails.Dock = DockStyle.Fill;
            txtDetails.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtDetails.Location = new Point(0, 0);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.ReadOnly = true;
            txtDetails.Size = new Size(800, 345);
            txtDetails.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Bottom;
            btnClose.BackColor = Color.Silver;
            btnClose.Location = new Point(338, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(120, 45);
            btnClose.TabIndex = 0;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 401);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 49);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtDetails);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 345);
            panel2.TabIndex = 2;
            // 
            // DetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel);
            Name = "DetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel;
        private Label lblTitle;
        private TextBox txtDetails;
        private Button btnClose;
        private Panel panel1;
        private Panel panel2;
    }
}