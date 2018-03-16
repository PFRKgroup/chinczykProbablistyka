namespace Probabilistyka_projekt
{
    partial class Main_menu
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
            this.exit_button = new System.Windows.Forms.Button();
            this.open_simulatoin_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(141, 202);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 0;
            this.exit_button.Text = "Wyjście";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // open_simulatoin_form
            // 
            this.open_simulatoin_form.Location = new System.Drawing.Point(132, 121);
            this.open_simulatoin_form.Name = "open_simulatoin_form";
            this.open_simulatoin_form.Size = new System.Drawing.Size(92, 36);
            this.open_simulatoin_form.TabIndex = 1;
            this.open_simulatoin_form.Text = "Prepare Simulation";
            this.open_simulatoin_form.UseVisualStyleBackColor = true;
            this.open_simulatoin_form.Click += new System.EventHandler(this.open_simulatoin_form_Click);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 292);
            this.Controls.Add(this.open_simulatoin_form);
            this.Controls.Add(this.exit_button);
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button open_simulatoin_form;
    }
}

