namespace hajos_vizsgakerdesek
{
    partial class FormAddNew
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
            button1oke = new Button();
            button2mégse = new Button();
            SuspendLayout();
            // 
            // button1oke
            // 
            button1oke.DialogResult = DialogResult.OK;
            button1oke.Location = new Point(660, 382);
            button1oke.Name = "button1oke";
            button1oke.Size = new Size(90, 35);
            button1oke.TabIndex = 0;
            button1oke.Text = "Ok";
            button1oke.UseVisualStyleBackColor = true;
            button1oke.Click += this.button1oke_Click;
            // 
            // button2mégse
            // 
            button2mégse.DialogResult = DialogResult.Cancel;
            button2mégse.Location = new Point(556, 382);
            button2mégse.Name = "button2mégse";
            button2mégse.Size = new Size(90, 35);
            button2mégse.TabIndex = 1;
            button2mégse.Text = "Mégse";
            button2mégse.UseVisualStyleBackColor = true;
            button2mégse.Click += this.button2mégse_Click;
            // 
            // FormAddNew
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2mégse);
            Controls.Add(button1oke);
            Name = "FormAddNew";
            Text = "FormAddNew";
            Load += FormAddNew_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1oke;
        private Button button2mégse;
    }
}