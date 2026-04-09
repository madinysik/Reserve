namespace Reserve
{
    partial class MainForm
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
            splitContainer1 = new SplitContainer();
            pictureBox = new PictureBox();
            treeView = new TreeView();
            panel1 = new Panel();
            btnLoadXML = new Button();
            btnLoadJSON = new Button();
            btnClose = new Button();
            btnShow = new Button();
            tableInfo = new DataGridView();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableInfo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.White;
            splitContainer1.Panel1.Controls.Add(pictureBox);
            splitContainer1.Panel1.Controls.Add(treeView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Green;
            splitContainer1.Panel2.Controls.Add(panel2);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(902, 588);
            splitContainer1.SplitterDistance = 300;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.Anchor = AnchorStyles.Top;
            pictureBox.BackColor = Color.White;
            pictureBox.Image = Properties.Resources.image;
            pictureBox.Location = new Point(0, 0);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(301, 113);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 5;
            pictureBox.TabStop = false;
            // 
            // treeView
            // 
            treeView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            treeView.BackColor = Color.White;
            treeView.LineColor = Color.White;
            treeView.Location = new Point(0, 119);
            treeView.Name = "treeView";
            treeView.Size = new Size(300, 469);
            treeView.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLoadXML);
            panel1.Controls.Add(btnLoadJSON);
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnShow);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 56);
            panel1.TabIndex = 6;
            // 
            // btnLoadXML
            // 
            btnLoadXML.BackColor = Color.Silver;
            btnLoadXML.Location = new Point(13, 3);
            btnLoadXML.Name = "btnLoadXML";
            btnLoadXML.Size = new Size(115, 45);
            btnLoadXML.TabIndex = 4;
            btnLoadXML.Text = "Загрузить XML";
            btnLoadXML.UseVisualStyleBackColor = false;
            // 
            // btnLoadJSON
            // 
            btnLoadJSON.BackColor = Color.Silver;
            btnLoadJSON.Location = new Point(134, 3);
            btnLoadJSON.Name = "btnLoadJSON";
            btnLoadJSON.Size = new Size(115, 45);
            btnLoadJSON.TabIndex = 5;
            btnLoadJSON.Text = "Загрузить JSON";
            btnLoadJSON.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Silver;
            btnClose.Location = new Point(376, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 45);
            btnClose.TabIndex = 2;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnShow
            // 
            btnShow.BackColor = Color.Silver;
            btnShow.Location = new Point(255, 3);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(115, 45);
            btnShow.TabIndex = 1;
            btnShow.Text = "Показать";
            btnShow.UseVisualStyleBackColor = false;
            // 
            // tableInfo
            // 
            tableInfo.AllowUserToAddRows = false;
            tableInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tableInfo.BackgroundColor = SystemColors.Control;
            tableInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableInfo.Dock = DockStyle.Fill;
            tableInfo.Location = new Point(0, 0);
            tableInfo.Name = "tableInfo";
            tableInfo.ReadOnly = true;
            tableInfo.Size = new Size(598, 532);
            tableInfo.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableInfo);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 532);
            panel2.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(902, 588);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заповедник";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableInfo).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView tableInfo;
        private Button btnShow;
        private Button btnClose;
        private TreeView treeView;
        private PictureBox pictureBox;
        private Button btnLoadJSON;
        private Button btnLoadXML;
        private Panel panel1;
        private Panel panel2;
    }
}