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
            this.button2 = new System.Windows.Forms.Button();
            this.counterControl1 = new ValveControlsLibrary.CounterControl();
            this.digitalSensorControl1 = new ValveControlsLibrary.DigitalSensorControl();
            this.analogSensorControl1 = new ValveControlsLibrary.AnalogSensorControl();
            this.button3 = new System.Windows.Forms.Button();
            this.pipeControl1 = new ScadaControlsLibrary.PipeControl();
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
            // counterControl1
            // 
            this.counterControl1.ForeColor = System.Drawing.Color.Coral;
            this.counterControl1.Location = new System.Drawing.Point(198, 32);
            this.counterControl1.Name = "counterControl1";
            this.counterControl1.Size = new System.Drawing.Size(801, 580);
            this.counterControl1.TabIndex = 6;
            // 
            // digitalSensorControl1
            // 
            this.digitalSensorControl1.Location = new System.Drawing.Point(-90, 545);
            this.digitalSensorControl1.Name = "digitalSensorControl1";
            this.digitalSensorControl1.Size = new System.Drawing.Size(1602, 722);
            this.digitalSensorControl1.TabIndex = 4;
            // 
            // analogSensorControl1
            // 
            this.analogSensorControl1.Location = new System.Drawing.Point(12, -2);
            this.analogSensorControl1.Name = "analogSensorControl1";
            this.analogSensorControl1.Size = new System.Drawing.Size(1131, 580);
            this.analogSensorControl1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(684, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pipeControl1
            // 
            this.pipeControl1.Location = new System.Drawing.Point(-13, -2);
            this.pipeControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pipeControl1.Name = "pipeControl1";
            this.pipeControl1.Size = new System.Drawing.Size(1200, 692);
            this.pipeControl1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.pipeControl1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.counterControl1);
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
        private ValveControlsLibrary.CounterControl counterControl1;
        private System.Windows.Forms.Button button3;
        private ScadaControlsLibrary.PipeControl pipeControl1;
    }
}

