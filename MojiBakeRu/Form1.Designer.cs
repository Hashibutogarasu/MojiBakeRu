
namespace MojiBakeRu
{
    partial class MojiBakeRuMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MojiBakeRuMainForm));
            this.InputBox = new System.Windows.Forms.TextBox();
            this.InputLabel = new System.Windows.Forms.Label();
            this.MojiBakeLabel = new System.Windows.Forms.Label();
            this.MojiBaketaBox = new System.Windows.Forms.TextBox();
            this.FormCloseButton = new System.Windows.Forms.Button();
            this.HowToUseButton = new System.Windows.Forms.Button();
            this.EncodeTypeBox = new System.Windows.Forms.ComboBox();
            this.EncodeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(12, 27);
            this.InputBox.Multiline = true;
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(454, 133);
            this.InputBox.TabIndex = 0;
            this.InputBox.TextChanged += new System.EventHandler(this.InputBox_TextChanged);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(12, 9);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(43, 15);
            this.InputLabel.TabIndex = 1;
            this.InputLabel.Text = "入力：";
            // 
            // MojiBakeLabel
            // 
            this.MojiBakeLabel.AutoSize = true;
            this.MojiBakeLabel.Location = new System.Drawing.Point(13, 167);
            this.MojiBakeLabel.Name = "MojiBakeLabel";
            this.MojiBakeLabel.Size = new System.Drawing.Size(64, 15);
            this.MojiBakeLabel.TabIndex = 2;
            this.MojiBakeLabel.Text = "↓文字化け";
            // 
            // MojiBaketaBox
            // 
            this.MojiBaketaBox.Location = new System.Drawing.Point(12, 185);
            this.MojiBaketaBox.Multiline = true;
            this.MojiBaketaBox.Name = "MojiBaketaBox";
            this.MojiBaketaBox.ReadOnly = true;
            this.MojiBaketaBox.Size = new System.Drawing.Size(454, 133);
            this.MojiBaketaBox.TabIndex = 1;
            // 
            // FormCloseButton
            // 
            this.FormCloseButton.Location = new System.Drawing.Point(12, 324);
            this.FormCloseButton.Name = "FormCloseButton";
            this.FormCloseButton.Size = new System.Drawing.Size(75, 23);
            this.FormCloseButton.TabIndex = 2;
            this.FormCloseButton.Text = "閉じる";
            this.FormCloseButton.UseVisualStyleBackColor = true;
            this.FormCloseButton.Click += new System.EventHandler(this.FormCloseButton_Click);
            // 
            // HowToUseButton
            // 
            this.HowToUseButton.Location = new System.Drawing.Point(390, 324);
            this.HowToUseButton.Name = "HowToUseButton";
            this.HowToUseButton.Size = new System.Drawing.Size(76, 23);
            this.HowToUseButton.TabIndex = 4;
            this.HowToUseButton.Text = "使い方";
            this.HowToUseButton.UseVisualStyleBackColor = true;
            this.HowToUseButton.Click += new System.EventHandler(this.HowToUseButton_Click);
            // 
            // EncodeTypeBox
            // 
            this.EncodeTypeBox.FormattingEnabled = true;
            this.EncodeTypeBox.Location = new System.Drawing.Point(184, 324);
            this.EncodeTypeBox.Name = "EncodeTypeBox";
            this.EncodeTypeBox.Size = new System.Drawing.Size(200, 23);
            this.EncodeTypeBox.TabIndex = 3;
            this.EncodeTypeBox.Text = "Unicode";
            this.EncodeTypeBox.SelectedIndexChanged += new System.EventHandler(this.EncodeTypeBox_SelectedIndexChanged);
            this.EncodeTypeBox.TextUpdate += new System.EventHandler(this.EncodeTypeBox_SelectedIndexChanged);
            // 
            // EncodeLabel
            // 
            this.EncodeLabel.AutoSize = true;
            this.EncodeLabel.Location = new System.Drawing.Point(93, 328);
            this.EncodeLabel.Name = "EncodeLabel";
            this.EncodeLabel.Size = new System.Drawing.Size(85, 15);
            this.EncodeLabel.TabIndex = 9;
            this.EncodeLabel.Text = "エンコード形式：";
            // 
            // MojiBakeRuMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.FormCloseButton;
            this.ClientSize = new System.Drawing.Size(478, 361);
            this.Controls.Add(this.EncodeLabel);
            this.Controls.Add(this.EncodeTypeBox);
            this.Controls.Add(this.HowToUseButton);
            this.Controls.Add(this.FormCloseButton);
            this.Controls.Add(this.MojiBaketaBox);
            this.Controls.Add(this.MojiBakeLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(494, 400);
            this.MinimumSize = new System.Drawing.Size(494, 400);
            this.Name = "MojiBakeRuMainForm";
            this.Text = "MojiBakeRu";
            this.Load += new System.EventHandler(this.MojiBakeRuMainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label MojiBakeLabel;
        private System.Windows.Forms.TextBox MojiBaketaBox;
        private System.Windows.Forms.Button FormCloseButton;
        private System.Windows.Forms.Button HowToUseButton;
        private System.Windows.Forms.ComboBox EncodeTypeBox;
        private System.Windows.Forms.Label EncodeLabel;
    }
}

