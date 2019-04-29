namespace TwoDecks
{
    partial class FormRandomCard
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRandomCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRandomCard
            // 
            this.buttonRandomCard.Location = new System.Drawing.Point(68, 64);
            this.buttonRandomCard.Name = "buttonRandomCard";
            this.buttonRandomCard.Size = new System.Drawing.Size(74, 35);
            this.buttonRandomCard.TabIndex = 0;
            this.buttonRandomCard.Text = "Random Card";
            this.buttonRandomCard.UseVisualStyleBackColor = true;
            this.buttonRandomCard.Click += new System.EventHandler(this.buttonRandomCard_Click);
            // 
            // FormRandomCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 190);
            this.Controls.Add(this.buttonRandomCard);
            this.Name = "FormRandomCard";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRandomCard;
    }
}

