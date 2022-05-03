namespace ChessBoard
{
    partial class Form1
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
            this.CrtChssBoard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CrtChssBoard
            // 
            this.CrtChssBoard.Location = new System.Drawing.Point(574, 1);
            this.CrtChssBoard.Name = "CrtChssBoard";
            this.CrtChssBoard.Size = new System.Drawing.Size(169, 562);
            this.CrtChssBoard.TabIndex = 0;
            this.CrtChssBoard.Text = "Create Cheess Board";
            this.CrtChssBoard.UseVisualStyleBackColor = true;
            this.CrtChssBoard.Click += new System.EventHandler(this.CrtChssBoard_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.CrtChssBoard);
            this.Name = "Form1";
            this.Text = "Chess Board";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CrtChssBoard;
    }
}

