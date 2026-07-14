namespace ValveControlsLibrary
{
    partial class AnalogSensorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureSensor = new System.Windows.Forms.PictureBox();
            this.lblSensorNameTitle = new System.Windows.Forms.Label();
            this.lblSensorName = new System.Windows.Forms.Label();
            this.lblValueTitle = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSensor
            // 
            this.pictureSensor.Image = global::ValveControlsLibrary.Resources.analog_sensör;
            this.pictureSensor.Location = new System.Drawing.Point(443, 156);
            this.pictureSensor.Name = "pictureSensor";
            this.pictureSensor.Size = new System.Drawing.Size(409, 361);
            this.pictureSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSensor.TabIndex = 0;
            this.pictureSensor.TabStop = false;
            // 
            // lblSensorNameTitle
            // 
            this.lblSensorNameTitle.AutoSize = true;
            this.lblSensorNameTitle.Location = new System.Drawing.Point(456, 177);
            this.lblSensorNameTitle.Name = "lblSensorNameTitle";
            this.lblSensorNameTitle.Size = new System.Drawing.Size(114, 20);
            this.lblSensorNameTitle.TabIndex = 1;
            this.lblSensorNameTitle.Text = "Sensor Name :";
            this.lblSensorNameTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSensorName
            // 
            this.lblSensorName.AutoSize = true;
            this.lblSensorName.Location = new System.Drawing.Point(576, 177);
            this.lblSensorName.Name = "lblSensorName";
            this.lblSensorName.Size = new System.Drawing.Size(114, 20);
            this.lblSensorName.TabIndex = 2;
            this.lblSensorName.Text = "Analog Sensor";
            this.lblSensorName.Click += new System.EventHandler(this.lblSensorName_Click);
            // 
            // lblValueTitle
            // 
            this.lblValueTitle.AutoSize = true;
            this.lblValueTitle.Location = new System.Drawing.Point(456, 449);
            this.lblValueTitle.Name = "lblValueTitle";
            this.lblValueTitle.Size = new System.Drawing.Size(58, 20);
            this.lblValueTitle.TabIndex = 3;
            this.lblValueTitle.Text = "Value :";
            this.lblValueTitle.Click += new System.EventHandler(this.lblValueTitle_Click);
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(530, 449);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(31, 20);
            this.lblValue.TabIndex = 4;
            this.lblValue.Text = "0.0";
            this.lblValue.Click += new System.EventHandler(this.lblValue_Click);
            // 
            // AnalogSensorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblValueTitle);
            this.Controls.Add(this.lblSensorName);
            this.Controls.Add(this.lblSensorNameTitle);
            this.Controls.Add(this.pictureSensor);
            this.Name = "AnalogSensorControl";
            this.Size = new System.Drawing.Size(1810, 755);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSensor;
        private System.Windows.Forms.Label lblSensorNameTitle;
        private System.Windows.Forms.Label lblSensorName;
        private System.Windows.Forms.Label lblValueTitle;
        private System.Windows.Forms.Label lblValue;
    }
}
