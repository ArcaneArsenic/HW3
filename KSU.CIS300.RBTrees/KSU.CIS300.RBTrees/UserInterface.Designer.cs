namespace KSU.CIS300.RBTrees
{
    partial class uxUserInterface
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
            this.uxOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxLoadNames = new System.Windows.Forms.Button();
            this.uxLookUp = new System.Windows.Forms.Button();
            this.uxRemoveName = new System.Windows.Forms.Button();
            this.uxInput = new System.Windows.Forms.TextBox();
            this.uxRankOut = new System.Windows.Forms.TextBox();
            this.uxFreqOut = new System.Windows.Forms.TextBox();
            this.uxRankLabel = new System.Windows.Forms.Label();
            this.uxFreqLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxLoadNames
            // 
            this.uxLoadNames.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLoadNames.Location = new System.Drawing.Point(12, 12);
            this.uxLoadNames.Name = "uxLoadNames";
            this.uxLoadNames.Size = new System.Drawing.Size(310, 42);
            this.uxLoadNames.TabIndex = 0;
            this.uxLoadNames.Text = "Load Names";
            this.uxLoadNames.UseVisualStyleBackColor = true;
            this.uxLoadNames.Click += new System.EventHandler(this.uxLoadNames_Click);
            // 
            // uxLookUp
            // 
            this.uxLookUp.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLookUp.Location = new System.Drawing.Point(12, 115);
            this.uxLookUp.Name = "uxLookUp";
            this.uxLookUp.Size = new System.Drawing.Size(310, 41);
            this.uxLookUp.TabIndex = 1;
            this.uxLookUp.Text = "Lookup Name";
            this.uxLookUp.UseVisualStyleBackColor = true;
            this.uxLookUp.Click += new System.EventHandler(this.uxLookUp_Click);
            // 
            // uxRemoveName
            // 
            this.uxRemoveName.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRemoveName.Location = new System.Drawing.Point(12, 237);
            this.uxRemoveName.Name = "uxRemoveName";
            this.uxRemoveName.Size = new System.Drawing.Size(310, 42);
            this.uxRemoveName.TabIndex = 2;
            this.uxRemoveName.Text = "Remove Name";
            this.uxRemoveName.UseVisualStyleBackColor = true;
            this.uxRemoveName.Click += new System.EventHandler(this.uxRemoveName_Click);
            // 
            // uxInput
            // 
            this.uxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInput.Location = new System.Drawing.Point(12, 63);
            this.uxInput.Multiline = true;
            this.uxInput.Name = "uxInput";
            this.uxInput.Size = new System.Drawing.Size(310, 41);
            this.uxInput.TabIndex = 3;
            // 
            // uxRankOut
            // 
            this.uxRankOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRankOut.Location = new System.Drawing.Point(140, 162);
            this.uxRankOut.Name = "uxRankOut";
            this.uxRankOut.ReadOnly = true;
            this.uxRankOut.Size = new System.Drawing.Size(182, 29);
            this.uxRankOut.TabIndex = 4;
            // 
            // uxFreqOut
            // 
            this.uxFreqOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFreqOut.Location = new System.Drawing.Point(140, 202);
            this.uxFreqOut.Name = "uxFreqOut";
            this.uxFreqOut.ReadOnly = true;
            this.uxFreqOut.Size = new System.Drawing.Size(182, 29);
            this.uxFreqOut.TabIndex = 5;
            // 
            // uxRankLabel
            // 
            this.uxRankLabel.AutoSize = true;
            this.uxRankLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxRankLabel.Location = new System.Drawing.Point(63, 170);
            this.uxRankLabel.Name = "uxRankLabel";
            this.uxRankLabel.Size = new System.Drawing.Size(65, 21);
            this.uxRankLabel.TabIndex = 6;
            this.uxRankLabel.Text = "Rank:";
            // 
            // uxFreqLabel
            // 
            this.uxFreqLabel.AutoSize = true;
            this.uxFreqLabel.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxFreqLabel.Location = new System.Drawing.Point(8, 208);
            this.uxFreqLabel.Name = "uxFreqLabel";
            this.uxFreqLabel.Size = new System.Drawing.Size(120, 21);
            this.uxFreqLabel.TabIndex = 7;
            this.uxFreqLabel.Text = "Frequency:";
            // 
            // uxUserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 291);
            this.Controls.Add(this.uxFreqLabel);
            this.Controls.Add(this.uxRankLabel);
            this.Controls.Add(this.uxFreqOut);
            this.Controls.Add(this.uxRankOut);
            this.Controls.Add(this.uxInput);
            this.Controls.Add(this.uxRemoveName);
            this.Controls.Add(this.uxLookUp);
            this.Controls.Add(this.uxLoadNames);
            this.Name = "uxUserInterface";
            this.Text = "RBTrees";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog uxOpenFileDialog;
        private System.Windows.Forms.Button uxLoadNames;
        private System.Windows.Forms.Button uxLookUp;
        private System.Windows.Forms.Button uxRemoveName;
        private System.Windows.Forms.TextBox uxInput;
        private System.Windows.Forms.TextBox uxRankOut;
        private System.Windows.Forms.TextBox uxFreqOut;
        private System.Windows.Forms.Label uxRankLabel;
        private System.Windows.Forms.Label uxFreqLabel;
    }
}

