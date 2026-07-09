namespace ScadaControlsLibrary
{
    partial class PipeControl
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.picturePipe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePipe)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePipe
            // 
            this.picturePipe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturePipe.Location = new System.Drawing.Point(0, 0);
            this.picturePipe.Name = "picturePipe";
            this.picturePipe.Size = new System.Drawing.Size(800, 450);
            this.picturePipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePipe.TabIndex = 0;
            this.picturePipe.TabStop = false;
            // 
            // PipeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picturePipe);
            this.Name = "PipeControl";
            this.Size = new System.Drawing.Size(800, 450);
            ((System.ComponentModel.ISupportInitialize)(this.picturePipe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picturePipe;
    }
}
