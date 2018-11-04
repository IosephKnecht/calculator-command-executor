namespace app.presentation
{
    partial class MainForm
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
            this.command_selector = new System.Windows.Forms.ComboBox();
            this.tv_first_operand = new System.Windows.Forms.TextBox();
            this.tv_second_operand = new System.Windows.Forms.TextBox();
            this.execute_button = new System.Windows.Forms.Button();
            this.tv_result = new System.Windows.Forms.TextBox();
            this.copy_first_operand = new System.Windows.Forms.Button();
            this.copy_second_operand = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // command_selector
            // 
            this.command_selector.FormattingEnabled = true;
            this.command_selector.Location = new System.Drawing.Point(12, 12);
            this.command_selector.Name = "command_selector";
            this.command_selector.Size = new System.Drawing.Size(171, 21);
            this.command_selector.TabIndex = 0;
            this.command_selector.SelectedIndexChanged += new System.EventHandler(this.command_selector_SelectedIndexChanged);
            // 
            // tv_first_operand
            // 
            this.tv_first_operand.Location = new System.Drawing.Point(12, 39);
            this.tv_first_operand.Name = "tv_first_operand";
            this.tv_first_operand.Size = new System.Drawing.Size(171, 20);
            this.tv_first_operand.TabIndex = 1;
            this.tv_first_operand.Text = "Please, enter operand";
            // 
            // tv_second_operand
            // 
            this.tv_second_operand.Location = new System.Drawing.Point(12, 65);
            this.tv_second_operand.Name = "tv_second_operand";
            this.tv_second_operand.Size = new System.Drawing.Size(171, 20);
            this.tv_second_operand.TabIndex = 2;
            this.tv_second_operand.Text = "Please, enter operand";
            // 
            // execute_button
            // 
            this.execute_button.Location = new System.Drawing.Point(189, 96);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(100, 23);
            this.execute_button.TabIndex = 3;
            this.execute_button.Text = "=";
            this.execute_button.UseVisualStyleBackColor = true;
            this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
            // 
            // tv_result
            // 
            this.tv_result.Enabled = false;
            this.tv_result.Location = new System.Drawing.Point(12, 98);
            this.tv_result.Name = "tv_result";
            this.tv_result.Size = new System.Drawing.Size(171, 20);
            this.tv_result.TabIndex = 4;
            // 
            // copy_first_operand
            // 
            this.copy_first_operand.Location = new System.Drawing.Point(189, 39);
            this.copy_first_operand.Name = "copy_first_operand";
            this.copy_first_operand.Size = new System.Drawing.Size(99, 23);
            this.copy_first_operand.TabIndex = 5;
            this.copy_first_operand.Text = "<";
            this.copy_first_operand.UseVisualStyleBackColor = true;
            // 
            // copy_second_operand
            // 
            this.copy_second_operand.Location = new System.Drawing.Point(189, 65);
            this.copy_second_operand.Name = "copy_second_operand";
            this.copy_second_operand.Size = new System.Drawing.Size(99, 23);
            this.copy_second_operand.TabIndex = 6;
            this.copy_second_operand.Text = "<";
            this.copy_second_operand.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 132);
            this.Controls.Add(this.copy_second_operand);
            this.Controls.Add(this.copy_first_operand);
            this.Controls.Add(this.tv_result);
            this.Controls.Add(this.execute_button);
            this.Controls.Add(this.tv_second_operand);
            this.Controls.Add(this.tv_first_operand);
            this.Controls.Add(this.command_selector);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox command_selector;
        private System.Windows.Forms.TextBox tv_first_operand;
        private System.Windows.Forms.TextBox tv_second_operand;
        private System.Windows.Forms.Button execute_button;
        private System.Windows.Forms.TextBox tv_result;
        private System.Windows.Forms.Button copy_first_operand;
        private System.Windows.Forms.Button copy_second_operand;
    }
}