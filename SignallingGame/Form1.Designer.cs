namespace SignallingGame
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
            this.State1 = new System.Windows.Forms.Label();
            this.saveConfig = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtSignals = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInterations = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.State2 = new System.Windows.Forms.Label();
            this.state3 = new System.Windows.Forms.Label();
            this.signal1 = new System.Windows.Forms.Label();
            this.signal2 = new System.Windows.Forms.Label();
            this.signal3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // State1
            // 
            this.State1.AutoSize = true;
            this.State1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.State1.Location = new System.Drawing.Point(182, 136);
            this.State1.Name = "State1";
            this.State1.Size = new System.Drawing.Size(124, 31);
            this.State1.TabIndex = 0;
            this.State1.Text = "Estado A";
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(690, 14);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(106, 37);
            this.saveConfig.TabIndex = 4;
            this.saveConfig.Text = "Save";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.saveConfig_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantidade de estados do experimento";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(16, 30);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(189, 20);
            this.txtState.TabIndex = 6;
            // 
            // txtSignals
            // 
            this.txtSignals.Location = new System.Drawing.Point(243, 30);
            this.txtSignals.Name = "txtSignals";
            this.txtSignals.Size = new System.Drawing.Size(189, 20);
            this.txtSignals.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantidade de sinais do experimento";
            // 
            // txtInterations
            // 
            this.txtInterations.Location = new System.Drawing.Point(474, 30);
            this.txtInterations.Name = "txtInterations";
            this.txtInterations.Size = new System.Drawing.Size(189, 20);
            this.txtInterations.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Quantidade de iterações";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(16, 412);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 11;
            this.Start.Text = "start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // State2
            // 
            this.State2.AutoSize = true;
            this.State2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.State2.Location = new System.Drawing.Point(438, 136);
            this.State2.Name = "State2";
            this.State2.Size = new System.Drawing.Size(124, 31);
            this.State2.TabIndex = 12;
            this.State2.Text = "Estado B";
            // 
            // state3
            // 
            this.state3.AutoSize = true;
            this.state3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.state3.Location = new System.Drawing.Point(672, 136);
            this.state3.Name = "state3";
            this.state3.Size = new System.Drawing.Size(126, 31);
            this.state3.TabIndex = 13;
            this.state3.Text = "Estado C";
            // 
            // signal1
            // 
            this.signal1.AutoSize = true;
            this.signal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.signal1.Location = new System.Drawing.Point(182, 361);
            this.signal1.Name = "signal1";
            this.signal1.Size = new System.Drawing.Size(96, 31);
            this.signal1.TabIndex = 14;
            this.signal1.Text = "Sinal 1";
            // 
            // signal2
            // 
            this.signal2.AutoSize = true;
            this.signal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.signal2.Location = new System.Drawing.Point(438, 361);
            this.signal2.Name = "signal2";
            this.signal2.Size = new System.Drawing.Size(96, 31);
            this.signal2.TabIndex = 15;
            this.signal2.Text = "Sinal 2";
            // 
            // signal3
            // 
            this.signal3.AutoSize = true;
            this.signal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.signal3.Location = new System.Drawing.Point(672, 361);
            this.signal3.Name = "signal3";
            this.signal3.Size = new System.Drawing.Size(96, 31);
            this.signal3.TabIndex = 16;
            this.signal3.Text = "Sinal 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 519);
            this.Controls.Add(this.signal3);
            this.Controls.Add(this.signal2);
            this.Controls.Add(this.signal1);
            this.Controls.Add(this.state3);
            this.Controls.Add(this.State2);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.txtInterations);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSignals);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.State1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label State1;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtSignals;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtInterations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label State2;
        private System.Windows.Forms.Label state3;
        private System.Windows.Forms.Label signal1;
        private System.Windows.Forms.Label signal2;
        private System.Windows.Forms.Label signal3;
    }
}

