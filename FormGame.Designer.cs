
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
        //int x;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxBombsRemaining = new System.Windows.Forms.TextBox();
            this.labelRemaining = new System.Windows.Forms.Label();
            this.textBoxBombsFound = new System.Windows.Forms.TextBox();
            this.labelFound = new System.Windows.Forms.Label();
            this.panelGame = new System.Windows.Forms.Panel();
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxBombsRemaining
            // 
            this.textBoxBombsRemaining.BackColor = System.Drawing.Color.Black;
            this.textBoxBombsRemaining.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxBombsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxBombsRemaining.ForeColor = System.Drawing.Color.Red;
            this.textBoxBombsRemaining.HideSelection = false;
            this.textBoxBombsRemaining.Location = new System.Drawing.Point(20, 9);
            this.textBoxBombsRemaining.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBombsRemaining.Name = "textBoxBombsRemaining";
            this.textBoxBombsRemaining.ReadOnly = true;
            this.textBoxBombsRemaining.Size = new System.Drawing.Size(63, 32);
            this.textBoxBombsRemaining.TabIndex = 0;
            this.textBoxBombsRemaining.TabStop = false;
            // 
            // labelRemaining
            // 
            this.labelRemaining.AutoSize = true;
            this.labelRemaining.Location = new System.Drawing.Point(88, 16);
            this.labelRemaining.Name = "labelRemaining";
            this.labelRemaining.Size = new System.Drawing.Size(64, 15);
            this.labelRemaining.TabIndex = 1;
            this.labelRemaining.Text = "Remaining";
            // 
            // textBoxBombsFound
            // 
            this.textBoxBombsFound.BackColor = System.Drawing.Color.Black;
            this.textBoxBombsFound.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxBombsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxBombsFound.ForeColor = System.Drawing.Color.Aqua;
            this.textBoxBombsFound.HideSelection = false;
            this.textBoxBombsFound.Location = new System.Drawing.Point(20, 43);
            this.textBoxBombsFound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxBombsFound.Name = "textBoxBombsFound";
            this.textBoxBombsFound.ReadOnly = true;
            this.textBoxBombsFound.Size = new System.Drawing.Size(63, 32);
            this.textBoxBombsFound.TabIndex = 2;
            this.textBoxBombsFound.TabStop = false;
            // 
            // labelFound
            // 
            this.labelFound.AutoSize = true;
            this.labelFound.Location = new System.Drawing.Point(88, 50);
            this.labelFound.Name = "labelFound";
            this.labelFound.Size = new System.Drawing.Size(57, 15);
            this.labelFound.TabIndex = 3;
            this.labelFound.Text = "Disarmed";
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelGame.Location = new System.Drawing.Point(253, 9);
            this.panelGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(569, 488);
            this.panelGame.TabIndex = 5;
            // 
            // timerGame
            // 
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick);
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.BackColor = System.Drawing.Color.Black;
            this.textBoxTimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxTimer.ForeColor = System.Drawing.Color.SpringGreen;
            this.textBoxTimer.HideSelection = false;
            this.textBoxTimer.Location = new System.Drawing.Point(20, 466);
            this.textBoxTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.ReadOnly = true;
            this.textBoxTimer.Size = new System.Drawing.Size(209, 32);
            this.textBoxTimer.TabIndex = 7;
            this.textBoxTimer.TabStop = false;
            this.textBoxTimer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 504);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.labelFound);
            this.Controls.Add(this.textBoxBombsFound);
            this.Controls.Add(this.labelRemaining);
            this.Controls.Add(this.textBoxBombsRemaining);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(440, 385);
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
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.Button buttonRandomizeTest;
    }
}