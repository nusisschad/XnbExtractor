namespace XnbExtractor
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.TextBoxTexturesPath = new System.Windows.Forms.TextBox();
            this.ButtonBrowseTextures = new System.Windows.Forms.Button();
            this.ListBoxTexturesFound = new System.Windows.Forms.ListBox();
            this.ButtonExtract = new System.Windows.Forms.Button();
            this.BrowserDialogFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.TextBoxOutputPath = new System.Windows.Forms.TextBox();
            this.ButtonBrowseOutput = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(268, 13);
            label1.TabIndex = 1000;
            label1.Text = "Select Folder that contains .Xnb Texture/Graphics Files";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 96);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 13);
            label2.TabIndex = 1001;
            label2.Text = "Valid .Xnb Textures Found";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 48);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(121, 13);
            label3.TabIndex = 1003;
            label3.Text = "PNG Files Output Folder";
            // 
            // TextBoxTexturesPath
            // 
            this.TextBoxTexturesPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTexturesPath.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxTexturesPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxTexturesPath.Location = new System.Drawing.Point(12, 25);
            this.TextBoxTexturesPath.Name = "TextBoxTexturesPath";
            this.TextBoxTexturesPath.Size = new System.Drawing.Size(456, 20);
            this.TextBoxTexturesPath.TabIndex = 0;
            // 
            // ButtonBrowseTextures
            // 
            this.ButtonBrowseTextures.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowseTextures.Location = new System.Drawing.Point(474, 24);
            this.ButtonBrowseTextures.Name = "ButtonBrowseTextures";
            this.ButtonBrowseTextures.Size = new System.Drawing.Size(60, 22);
            this.ButtonBrowseTextures.TabIndex = 1;
            this.ButtonBrowseTextures.Text = "Browse...";
            this.ButtonBrowseTextures.UseVisualStyleBackColor = true;
            this.ButtonBrowseTextures.Click += new System.EventHandler(this.ButtonBrowseTextures_Click);
            // 
            // ListBoxTexturesFound
            // 
            this.ListBoxTexturesFound.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxTexturesFound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListBoxTexturesFound.FormattingEnabled = true;
            this.ListBoxTexturesFound.IntegralHeight = false;
            this.ListBoxTexturesFound.Location = new System.Drawing.Point(12, 112);
            this.ListBoxTexturesFound.MultiColumn = true;
            this.ListBoxTexturesFound.Name = "ListBoxTexturesFound";
            this.ListBoxTexturesFound.Size = new System.Drawing.Size(600, 324);
            this.ListBoxTexturesFound.TabIndex = 3;
            this.ListBoxTexturesFound.TabStop = false;
            // 
            // ButtonExtract
            // 
            this.ButtonExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExtract.Location = new System.Drawing.Point(540, 24);
            this.ButtonExtract.Name = "ButtonExtract";
            this.ButtonExtract.Size = new System.Drawing.Size(72, 61);
            this.ButtonExtract.TabIndex = 2;
            this.ButtonExtract.Text = "Extract Textures";
            this.ButtonExtract.UseVisualStyleBackColor = true;
            this.ButtonExtract.Click += new System.EventHandler(this.ButtonExtract_Click);
            // 
            // BrowserDialogFolder
            // 
            this.BrowserDialogFolder.ShowNewFolderButton = false;
            // 
            // TextBoxOutputPath
            // 
            this.TextBoxOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxOutputPath.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxOutputPath.Location = new System.Drawing.Point(12, 64);
            this.TextBoxOutputPath.Name = "TextBoxOutputPath";
            this.TextBoxOutputPath.Size = new System.Drawing.Size(456, 20);
            this.TextBoxOutputPath.TabIndex = 1002;
            // 
            // ButtonBrowseOutput
            // 
            this.ButtonBrowseOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonBrowseOutput.Location = new System.Drawing.Point(474, 63);
            this.ButtonBrowseOutput.Name = "ButtonBrowseOutput";
            this.ButtonBrowseOutput.Size = new System.Drawing.Size(60, 22);
            this.ButtonBrowseOutput.TabIndex = 1004;
            this.ButtonBrowseOutput.Text = "Browse...";
            this.ButtonBrowseOutput.UseVisualStyleBackColor = true;
            this.ButtonBrowseOutput.Click += new System.EventHandler(this.ButtonBrowseOutput_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 448);
            this.Controls.Add(this.ButtonBrowseOutput);
            this.Controls.Add(label3);
            this.Controls.Add(this.TextBoxOutputPath);
            this.Controls.Add(label2);
            this.Controls.Add(this.ButtonExtract);
            this.Controls.Add(this.ListBoxTexturesFound);
            this.Controls.Add(label1);
            this.Controls.Add(this.ButtonBrowseTextures);
            this.Controls.Add(this.TextBoxTexturesPath);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "Xnb Extractor by Kaven Gagne";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxTexturesPath;
        private System.Windows.Forms.Button ButtonBrowseTextures;
        private System.Windows.Forms.ListBox ListBoxTexturesFound;
        private System.Windows.Forms.Button ButtonExtract;
        private System.Windows.Forms.FolderBrowserDialog BrowserDialogFolder;
        private System.Windows.Forms.TextBox TextBoxOutputPath;
        private System.Windows.Forms.Button ButtonBrowseOutput;
    }
}