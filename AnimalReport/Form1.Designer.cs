namespace AnimalReport
{
    partial class CusMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DescPanel = new System.Windows.Forms.Panel();
            this.CusInputPanel = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CusListBoxPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CusInputPanel.SuspendLayout();
            this.CusListBoxPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DescPanel
            // 
            this.DescPanel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescPanel.Location = new System.Drawing.Point(457, 12);
            this.DescPanel.Name = "DescPanel";
            this.DescPanel.Size = new System.Drawing.Size(319, 315);
            this.DescPanel.TabIndex = 0;
            // 
            // CusInputPanel
            // 
            this.CusInputPanel.Controls.Add(this.txtDescription);
            this.CusInputPanel.Controls.Add(this.txtBirthday);
            this.CusInputPanel.Controls.Add(this.txtAddress);
            this.CusInputPanel.Controls.Add(this.txtLastName);
            this.CusInputPanel.Controls.Add(this.txtFirstName);
            this.CusInputPanel.Controls.Add(this.btnInput);
            this.CusInputPanel.Controls.Add(this.label5);
            this.CusInputPanel.Controls.Add(this.label4);
            this.CusInputPanel.Controls.Add(this.label3);
            this.CusInputPanel.Controls.Add(this.label2);
            this.CusInputPanel.Controls.Add(this.label1);
            this.CusInputPanel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CusInputPanel.Location = new System.Drawing.Point(372, 145);
            this.CusInputPanel.Name = "CusInputPanel";
            this.CusInputPanel.Size = new System.Drawing.Size(319, 233);
            this.CusInputPanel.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(125, 159);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(173, 29);
            this.txtDescription.TabIndex = 10;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(125, 122);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(173, 29);
            this.txtBirthday.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(125, 85);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(173, 29);
            this.txtAddress.TabIndex = 8;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(123, 48);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(173, 29);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(125, 15);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(173, 29);
            this.txtFirstName.TabIndex = 6;
            // 
            // btnInput
            // 
            this.btnInput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInput.Location = new System.Drawing.Point(101, 199);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(108, 31);
            this.btnInput.TabIndex = 5;
            this.btnInput.Text = "Input";
            this.btnInput.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(18, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Description :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Birthday :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "FirstName :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CusListBoxPanel
            // 
            this.CusListBoxPanel.Controls.Add(this.dataGridView1);
            this.CusListBoxPanel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CusListBoxPanel.Location = new System.Drawing.Point(12, 12);
            this.CusListBoxPanel.Name = "CusListBoxPanel";
            this.CusListBoxPanel.Size = new System.Drawing.Size(319, 315);
            this.CusListBoxPanel.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "FirstName";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "LastName";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Birthday";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Description";
            this.Column5.Name = "Column5";
            // 
            // CusMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CusListBoxPanel);
            this.Controls.Add(this.CusInputPanel);
            this.Controls.Add(this.DescPanel);
            this.Name = "CusMain";
            this.Text = "CusMain";
            this.CusInputPanel.ResumeLayout(false);
            this.CusInputPanel.PerformLayout();
            this.CusListBoxPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel DescPanel;
        private Panel CusInputPanel;
        private TextBox txtDescription;
        private TextBox txtBirthday;
        private TextBox txtAddress;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnInput;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel CusListBoxPanel;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}