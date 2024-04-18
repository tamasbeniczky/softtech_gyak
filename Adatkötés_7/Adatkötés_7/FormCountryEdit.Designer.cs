namespace Adatkötés_7
{
    partial class FormCountryEdit
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleDescription = "";
            textBox1.AccessibleName = "";
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Name", true));
            textBox1.Location = new Point(35, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 26);
            textBox1.TabIndex = 0;
            textBox1.Tag = "";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Population", true));
            textBox2.Location = new Point(36, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(261, 26);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "AreaInSquareKm", true));
            textBox3.Location = new Point(36, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(261, 26);
            textBox3.TabIndex = 2;

            // 
            // button1
            // 
            button1.Location = new Point(222, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Ok";
            button1.UseVisualStyleBackColor = true;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(CountryData);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 4;
            label1.Text = "Country Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 105);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 5;
            label2.Text = "Population";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 192);
            label3.Name = "label3";
            label3.Size = new Size(83, 19);
            label3.TabIndex = 6;
            label3.Text = "Area in km2";
            // 
            // FormCountryEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 343);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormCountryEdit";
            Text = "FormCountryEdit";
            Load += FormCountryEdit_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private BindingSource bindingSource1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}