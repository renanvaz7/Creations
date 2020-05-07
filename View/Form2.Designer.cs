namespace Creations.View
{
    partial class frm_TelaBoasVindas
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
            this.pnl_TelaBoasVindas_Superior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // pnl_TelaBoasVindas_Superior
            // 
            this.pnl_TelaBoasVindas_Superior.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnl_TelaBoasVindas_Superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TelaBoasVindas_Superior.Location = new System.Drawing.Point(0, 0);
            this.pnl_TelaBoasVindas_Superior.Name = "pnl_TelaBoasVindas_Superior";
            this.pnl_TelaBoasVindas_Superior.Size = new System.Drawing.Size(1053, 129);
            this.pnl_TelaBoasVindas_Superior.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(543, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(424, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bem Vindo(a)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(615, 444);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(363, 28);
            this.progressBar1.TabIndex = 2;
            // 
            // frm_TelaBoasVindas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1053, 531);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_TelaBoasVindas_Superior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_TelaBoasVindas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_TelaBoasVindas_Superior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}