namespace Probabilistyka_projekt
{
    partial class Simulation
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
            this.textBox_field_count = new System.Windows.Forms.TextBox();
            this.fieldsCount_text = new System.Windows.Forms.Label();
            this.Start_Simulation_button = new System.Windows.Forms.Button();
            this.Back_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_field_count
            // 
            this.textBox_field_count.Location = new System.Drawing.Point(111, 81);
            this.textBox_field_count.Name = "textBox_field_count";
            this.textBox_field_count.Size = new System.Drawing.Size(109, 20);
            this.textBox_field_count.TabIndex = 1;
            this.textBox_field_count.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_field_count_KeyPress);
            // 
            // fieldsCount_text
            // 
            this.fieldsCount_text.AutoSize = true;
            this.fieldsCount_text.Location = new System.Drawing.Point(56, 84);
            this.fieldsCount_text.Name = "fieldsCount_text";
            this.fieldsCount_text.Size = new System.Drawing.Size(49, 13);
            this.fieldsCount_text.TabIndex = 1;
            this.fieldsCount_text.Text = "Ilość pól:";
            // 
            // Start_Simulation_button
            // 
            this.Start_Simulation_button.Location = new System.Drawing.Point(126, 107);
            this.Start_Simulation_button.Name = "Start_Simulation_button";
            this.Start_Simulation_button.Size = new System.Drawing.Size(75, 35);
            this.Start_Simulation_button.TabIndex = 2;
            this.Start_Simulation_button.Text = "Start Simulation";
            this.Start_Simulation_button.UseVisualStyleBackColor = true;
            this.Start_Simulation_button.Click += new System.EventHandler(this.Start_Simulation_button_Click);
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(126, 263);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 3;
            this.Back_button.Text = "Wróć";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ilość symulacji:";
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 298);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.Start_Simulation_button);
            this.Controls.Add(this.fieldsCount_text);
            this.Controls.Add(this.textBox_field_count);
            this.Name = "Simulation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.Simulation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_field_count;
        private System.Windows.Forms.Label fieldsCount_text;
        private System.Windows.Forms.Button Start_Simulation_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}