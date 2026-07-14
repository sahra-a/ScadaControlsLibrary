namespace ValveControlsLibrary
{
    partial class CounterControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblCounterName = new System.Windows.Forms.Label();
            this.pictureCounter = new System.Windows.Forms.PictureBox();
            this.lblCounterValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCounterName
            // 
            this.lblCounterName.AutoSize = true;
            this.lblCounterName.Location = new System.Drawing.Point(957, 269);
            this.lblCounterName.Name = "lblCounterName";
            this.lblCounterName.Size = new System.Drawing.Size(66, 20);
            this.lblCounterName.TabIndex = 1;
            this.lblCounterName.Text = "Counter";
            this.lblCounterName.Click += new System.EventHandler(this.lblCounterName_Click);
            // 
            // pictureCounter
            // 
            this.pictureCounter.Image = global::ValveControlsLibrary.Resources.sayaç;
            this.pictureCounter.Location = new System.Drawing.Point(14, -105);
            this.pictureCounter.Name = "pictureCounter";
            this.pictureCounter.Size = new System.Drawing.Size(1052, 770);
            this.pictureCounter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureCounter.TabIndex = 3;
            this.pictureCounter.TabStop = false;
            this.pictureCounter.Click += new System.EventHandler(this.pictureCounter_Click);
            // 
            // lblCounterValue
            // 
            this.lblCounterValue.BackColor = System.Drawing.Color.Transparent;
            this.lblCounterValue.Font = new System.Drawing.Font("Consolas", 24F);
            this.lblCounterValue.ForeColor = System.Drawing.Color.White;
            this.lblCounterValue.Location = new System.Drawing.Point(347, 445);
            this.lblCounterValue.Name = "lblCounterValue";
            this.lblCounterValue.Size = new System.Drawing.Size(575, 180);
            this.lblCounterValue.TabIndex = 4;
            this.lblCounterValue.Text = "000000";
            this.lblCounterValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCounterValue.Click += new System.EventHandler(this.lblCounterValue_Click_1);
            // 
            // CounterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCounterValue);
            this.Controls.Add(this.pictureCounter);
            this.Controls.Add(this.lblCounterName);
            this.ForeColor = System.Drawing.Color.Coral;
            this.Name = "CounterControl";
            this.Size = new System.Drawing.Size(1083, 683);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCounterName;
        private System.Windows.Forms.PictureBox pictureCounter;
        private System.Windows.Forms.Label lblCounterValue;
    }
}