namespace GestionEtudiant.front.views.form
{
    partial class FormProfesseur
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            AllClasse = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(checkedListBox2);
            groupBox1.Controls.Add(AllClasse);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(599, 615);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Affectation de Classe";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(comboBox2);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(636, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(708, 593);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Liste des Professeurs";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(229, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(338, 40);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 50);
            label1.Name = "label1";
            label1.Size = new Size(125, 32);
            label1.TabIndex = 1;
            label1.Text = "Telephone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 125);
            label2.Name = "label2";
            label2.Size = new Size(184, 32);
            label2.TabIndex = 3;
            label2.Text = "Nom et Prenom";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(229, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(338, 40);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(232, 199);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(335, 40);
            comboBox1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 207);
            label3.Name = "label3";
            label3.Size = new Size(80, 32);
            label3.TabIndex = 5;
            label3.Text = "Grade";
            // 
            // AllClasse
            // 
            AllClasse.FormattingEnabled = true;
            AllClasse.Location = new Point(21, 273);
            AllClasse.Name = "AllClasse";
            AllClasse.Size = new Size(232, 263);
            AllClasse.TabIndex = 6;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Classes affectees" });
            checkedListBox2.Location = new Point(308, 273);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(259, 263);
            checkedListBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 44);
            label4.Name = "label4";
            label4.Size = new Size(174, 32);
            label4.TabIndex = 8;
            label4.Text = "Annee Scolaire";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(249, 44);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(335, 40);
            comboBox2.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(39, 117);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(628, 456);
            dataGridView1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(602, 43);
            button1.Name = "button1";
            button1.Size = new Size(65, 41);
            button1.TabIndex = 10;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(21, 554);
            button2.Name = "button2";
            button2.Size = new Size(546, 41);
            button2.TabIndex = 11;
            button2.Text = "Enregistrer";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormProfesseur
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 649);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormProfesseur";
            Text = "Form Professeur";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox textBox2;
        private CheckedListBox checkedListBox2;
        private CheckedListBox AllClasse;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Label label4;
        private Button button2;
    }
}