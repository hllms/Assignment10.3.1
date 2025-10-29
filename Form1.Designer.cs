namespace Assignment10._3._1
{
    partial class Form1
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
            carGrid = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtVIN = new TextBox();
            txtMake = new TextBox();
            txtModel = new TextBox();
            txtYear = new TextBox();
            txtPrice = new TextBox();
            btnAddCar = new Button();
            btnSubmit = new Button();
            btnSelectRecord = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)carGrid).BeginInit();
            SuspendLayout();
            // 
            // carGrid
            // 
            carGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            carGrid.Location = new Point(37, 102);
            carGrid.Name = "carGrid";
            carGrid.RowHeadersWidth = 62;
            carGrid.Size = new Size(962, 321);
            carGrid.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            label1.Location = new Point(37, -8);
            label1.Name = "label1";
            label1.Size = new Size(314, 96);
            label1.TabIndex = 1;
            label1.Text = "Car App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1087, 119);
            label2.Name = "label2";
            label2.Size = new Size(41, 25);
            label2.TabIndex = 2;
            label2.Text = "VIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1087, 193);
            label3.Name = "label3";
            label3.Size = new Size(55, 25);
            label3.TabIndex = 3;
            label3.Text = "Make";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1087, 262);
            label4.Name = "label4";
            label4.Size = new Size(63, 25);
            label4.TabIndex = 4;
            label4.Text = "Model";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1087, 333);
            label5.Name = "label5";
            label5.Size = new Size(44, 25);
            label5.TabIndex = 5;
            label5.Text = "Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1087, 398);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 6;
            label6.Text = "Price";
            // 
            // txtVIN
            // 
            txtVIN.Location = new Point(1217, 125);
            txtVIN.Name = "txtVIN";
            txtVIN.Size = new Size(150, 31);
            txtVIN.TabIndex = 7;
            // 
            // txtMake
            // 
            txtMake.Location = new Point(1217, 187);
            txtMake.Name = "txtMake";
            txtMake.Size = new Size(150, 31);
            txtMake.TabIndex = 8;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(1217, 256);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(150, 31);
            txtModel.TabIndex = 9;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(1217, 333);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(150, 31);
            txtYear.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(1217, 398);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(150, 31);
            txtPrice.TabIndex = 11;
            // 
            // btnAddCar
            // 
            btnAddCar.Location = new Point(37, 474);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(112, 34);
            btnAddCar.TabIndex = 12;
            btnAddCar.Text = "Add New";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(37, 547);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(112, 34);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // btnSelectRecord
            // 
            btnSelectRecord.Location = new Point(239, 474);
            btnSelectRecord.Name = "btnSelectRecord";
            btnSelectRecord.Size = new Size(112, 34);
            btnSelectRecord.TabIndex = 14;
            btnSelectRecord.Text = "Select to Update";
            btnSelectRecord.UseVisualStyleBackColor = true;
            btnSelectRecord.Click += btnSelectRecord_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(239, 547);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(112, 34);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(461, 474);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1601, 819);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSelectRecord);
            Controls.Add(btnSubmit);
            Controls.Add(btnAddCar);
            Controls.Add(txtPrice);
            Controls.Add(txtYear);
            Controls.Add(txtModel);
            Controls.Add(txtMake);
            Controls.Add(txtVIN);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(carGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)carGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView carGrid;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtVIN;
        private TextBox txtMake;
        private TextBox txtModel;
        private TextBox txtYear;
        private TextBox txtPrice;
        private Button btnAddCar;
        private Button btnSubmit;
        private Button btnSelectRecord;
        private Button btnUpdate;
        private Button btnDelete;
    }
}
