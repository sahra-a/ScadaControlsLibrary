namespace test7
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
            this.pipeControl1 = new ScadaControlsLibrary.PipeControl();
            this.SuspendLayout();
            // 
            // pipeControl1
            // 
            this.pipeControl1.Location = new System.Drawing.Point(89, 38);
            this.pipeControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pipeControl1.Name = "pipeControl1";
            this.pipeControl1.Size = new System.Drawing.Size(1044, 591);
            this.pipeControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 709);
            this.Controls.Add(this.pipeControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ScadaControlsLibrary.PipeControl pipeControl1;
    }
}

