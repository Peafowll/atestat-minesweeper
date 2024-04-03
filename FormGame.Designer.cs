
namespace AtestatMinesweeper
{
    partial class FormGame
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
            this.textBoxBombsRemaining = new System.Windows.Forms.TextBox();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.textBoxBombsFound = new System.Windows.Forms.TextBox();
            this.labelFound = new System.Windows.Forms.Label();
            this.buttontest = new System.Windows.Forms.Button();
            this.panelGame = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxBombsRemaining
            // 
            this.textBoxBombsRemaining.BackColor = System.Drawing.Color.Black;
            this.textBoxBombsRemaining.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxBombsRemaining.Font = new System.Drawing.Font("alarm clock", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxBombsRemaining.ForeColor = System.Drawing.Color.Red;
            this.textBoxBombsRemaining.HideSelection = false;
            this.textBoxBombsRemaining.Location = new System.Drawing.Point(23, 12);
            this.textBoxBombsRemaining.Name = "textBoxBombsRemaining";
            this.textBoxBombsRemaining.ReadOnly = true;
            this.textBoxBombsRemaining.Size = new System.Drawing.Size(71, 39);
            this.textBoxBombsRemaining.TabIndex = 0;
            this.textBoxBombsRemaining.TabStop = false;
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Location = new System.Drawing.Point(100, 22);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(80, 20);
            this.labelRemaining.TabIndex = 1;
            this.labelRemaining.Text = "Remaining";
            // 
            // textBoxBombsFound
            // 
            this.textBoxBombsFound.BackColor = System.Drawing.Color.Black;
            this.textBoxBombsFound.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxBombsFound.Font = new System.Drawing.Font("alarm clock", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxBombsFound.ForeColor = System.Drawing.Color.Aqua;
            this.textBoxBombsFound.HideSelection = false;
            this.textBoxBombsFound.Location = new System.Drawing.Point(23, 57);
            this.textBoxBombsFound.Name = "textBoxBombsFound";
            this.textBoxBombsFound.ReadOnly = true;
            this.textBoxBombsFound.Size = new System.Drawing.Size(71, 39);
            this.textBoxBombsFound.TabIndex = 2;
            this.textBoxBombsFound.TabStop = false;
            // 
            // labelFound
            // 
            this.labelFound.AutoSize = true;
            this.labelFound.Location = new System.Drawing.Point(100, 67);
            this.labelFound.Name = "labelFound";
            this.labelFound.Size = new System.Drawing.Size(73, 20);
            this.labelFound.TabIndex = 3;
            this.labelFound.Text = "Disarmed";
            // 
            // buttontest
            // 
            this.buttontest.Location = new System.Drawing.Point(505, 22);
            this.buttontest.Name = "buttontest";
            this.buttontest.Size = new System.Drawing.Size(94, 29);
            this.buttontest.TabIndex = 4;
            this.buttontest.Text = "test";
            this.buttontest.UseVisualStyleBackColor = true;
            this.buttontest.Click += new System.EventHandler(this.buttontest_Click);
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelGame.Location = new System.Drawing.Point(206, 122);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(802, 515);
            this.panelGame.TabIndex = 5;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 672);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.buttontest);
            this.Controls.Add(this.labelFound);
            this.Controls.Add(this.textBoxBombsFound);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.textBoxBombsRemaining);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBombsRemaining;
        private System.Windows.Forms.Label labelRemaining;
        private System.Windows.Forms.TextBox textBoxBombsFound;
        private System.Windows.Forms.Label labelFound;
        private System.Windows.Forms.Button buttontest;
        private System.Windows.Forms.Panel panelGame;
    }
}