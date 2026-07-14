namespace ScadaControlsTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.analogSensorControl1 = new ValveControlsLibrary.AnalogSensorControl();
            this.digitalSensorControl1 = new ValveControlsLibrary.DigitalSensorControl();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Toggle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // analogSensorControl1
            // 
            this.analogSensorControl1.Location = new System.Drawing.Point(-46, -140);
            this.analogSensorControl1.Name = "analogSensorControl1";
            this.analogSensorControl1.Size = new System.Drawing.Size(1131, 580);
            this.analogSensorControl1.TabIndex = 3;
            // 
            // digitalSensorControl1
            // 
            this.digitalSensorControl1.Location = new System.Drawing.Point(-90, 545);
            this.digitalSensorControl1.Name = "digitalSensorControl1";
            this.digitalSensorControl1.Size = new System.Drawing.Size(1602, 722);
            this.digitalSensorControl1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 229);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.digitalSensorControl1);
            this.Controls.Add(this.analogSensorControl1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private ValveControlsLibrary.AnalogSensorControl analogSensorControl1;
        private ValveControlsLibrary.DigitalSensorControl digitalSensorControl1;
        private System.Windows.Forms.Button button2;
    }
}

