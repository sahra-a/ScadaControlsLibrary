namespace ValveControlsLibrary
{
    partial class DigitalSensorControl
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
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSensor
            // 
            this.pictureSensor.Image = global::ValveControlsLibrary.Resources.DigitalSensor_Off;
            this.pictureSensor.Location = new System.Drawing.Point(374, 30);
            this.pictureSensor.Name = "pictureSensor";
            this.pictureSensor.Size = new System.Drawing.Size(550, 410);
            this.pictureSensor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSensor.TabIndex = 0;
            this.pictureSensor.TabStop = false;
            // 
            // lblSensorNameTitle
            // 
            this.lblSensorNameTitle.AutoSize = true;
            this.lblSensorNameTitle.Location = new System.Drawing.Point(952, 127);
            this.lblSensorNameTitle.Name = "lblSensorNameTitle";
            this.lblSensorNameTitle.Size = new System.Drawing.Size(114, 20);
            this.lblSensorNameTitle.TabIndex = 1;
            this.lblSensorNameTitle.Text = "Sensor Name :";
            this.lblSensorNameTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSensorName
            // 
            this.lblSensorName.AutoSize = true;
            this.lblSensorName.Location = new System.Drawing.Point(1072, 127);
            this.lblSensorName.Name = "lblSensorName";
            this.lblSensorName.Size = new System.Drawing.Size(108, 20);
            this.lblSensorName.TabIndex = 2;
            this.lblSensorName.Text = "Digital Sensor";
            this.lblSensorName.Click += new System.EventHandler(this.lblSensorName_Click);
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Location = new System.Drawing.Point(973, 174);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(64, 20);
            this.lblStatusTitle.TabIndex = 3;
            this.lblStatusTitle.Text = "Status :";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(1059, 174);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 20);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "OFF";
            // 
            // DigitalSensorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblStatusTitle);
            this.Controls.Add(this.lblSensorName);
            this.Controls.Add(this.lblSensorNameTitle);
            this.Controls.Add(this.pictureSensor);
            this.Name = "DigitalSensorControl";
            this.Size = new System.Drawing.Size(1602, 722);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSensor;
        private System.Windows.Forms.Label lblSensorNameTitle;
        private System.Windows.Forms.Label lblSensorName;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblStatus;
    }
}
