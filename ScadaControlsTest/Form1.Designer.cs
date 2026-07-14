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
            this.pipeControl1 = new ScadaControlsLibrary.PipeControl();
            this.digitalSensorControl1 = new ValveControlsLibrary.DigitalSensorControl();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pipeControl1
            // 
            this.pipeControl1.Location = new System.Drawing.Point(0, -7);
            this.pipeControl1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.pipeControl1.Name = "pipeControl1";
            this.pipeControl1.PipeName = "Steam Line";
            this.pipeControl1.Pressure = 7.9D;
            this.pipeControl1.Size = new System.Drawing.Size(623, 332);
            this.pipeControl1.TabIndex = 0;
            this.pipeControl1.Temperature = 398.9D;
            // 
            // digitalSensorControl1
            // 
            this.digitalSensorControl1.Location = new System.Drawing.Point(-525, 331);
            this.digitalSensorControl1.Name = "digitalSensorControl1";
            this.digitalSensorControl1.Size = new System.Drawing.Size(1239, 349);
            this.digitalSensorControl1.TabIndex = 1;
            this.digitalSensorControl1.Load += new System.EventHandler(this.digitalSensorControl1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "Toggle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.digitalSensorControl1);
            this.Controls.Add(this.pipeControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ScadaControlsLibrary.PipeControl pipeControl1;
        private ValveControlsLibrary.DigitalSensorControl digitalSensorControl1;
        private System.Windows.Forms.Button button1;
    }
}

