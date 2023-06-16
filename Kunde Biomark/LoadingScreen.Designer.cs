namespace Kunde_Biomark
{
    partial class LoadingScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loadingProgressBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLoadingProgress = new System.Windows.Forms.Label();
            this.loadingbarTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loadingProgressBar
            // 
            this.loadingProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingProgressBar.Location = new System.Drawing.Point(29, 322);
            this.loadingProgressBar.Name = "loadingProgressBar";
            this.loadingProgressBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.loadingProgressBar.Size = new System.Drawing.Size(720, 29);
            this.loadingProgressBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(330, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loading";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLoadingProgress
            // 
            this.lblLoadingProgress.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblLoadingProgress.AutoSize = true;
            this.lblLoadingProgress.Location = new System.Drawing.Point(381, 306);
            this.lblLoadingProgress.Name = "lblLoadingProgress";
            this.lblLoadingProgress.Size = new System.Drawing.Size(21, 13);
            this.lblLoadingProgress.TabIndex = 2;
            this.lblLoadingProgress.Text = "0%";
            // 
            // loadingbarTimer
            // 
            this.loadingbarTimer.Tick += new System.EventHandler(this.loadingbarTimer_Tick);
            // 
            // LoadingScreen
            // 
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(776, 378);
            this.ControlBox = false;
            this.Controls.Add(this.lblLoadingProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadingProgressBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biomarkt GmbH";
            this.Load += new System.EventHandler(this.LoadingScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar loadingProgressBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoadingProgress;
        private System.Windows.Forms.Timer loadingbarTimer;
    }
}

