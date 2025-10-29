using Assignment10._3._1.Models;
using Assignment10._3._1.Services;
using System.Diagnostics.Eventing.Reader;

namespace Assignment10._3._1
{
    public partial class Form1 : Form
    {
        CRUD crud = new CRUD();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            carGrid.DataSource = crud.GetAllCars();
            btnSubmit.Enabled = false;
            btnUpdate.Enabled = false;
        }
       
        private void btnAddCar_Click(object sender, EventArgs e)
        {
            txtVIN.Text = crud.GetNextVIN().ToString();
            txtVIN.ReadOnly = true;
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtPrice.Clear();
            btnSubmit.Enabled = true;
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMake.Text) &&
                !string.IsNullOrEmpty(txtModel.Text) &&
                !string.IsNullOrEmpty(txtYear.Text) &&
                !string.IsNullOrEmpty(txtPrice.Text))
            {
                Car newCar = new Car
                {
                    VIN = int.Parse(txtVIN.Text),
                    Make = txtMake.Text,
                    Model = txtModel.Text,
                    Year = int.Parse(txtYear.Text),
                    Price = double.Parse(txtPrice.Text)
                };
                crud.AddCar(newCar);
                carGrid.DataSource = crud.GetAllCars();
                btnSubmit.Enabled = false;
                MessageBox.Show("Car added successfully.");
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMake.Text) &&
                !string.IsNullOrEmpty(txtModel.Text) &&
                !string.IsNullOrEmpty(txtYear.Text) &&
                !string.IsNullOrEmpty(txtPrice.Text))
            {
                Car updatedCar = new Car
                {
                    VIN = int.Parse(txtVIN.Text),
                    Make = txtMake.Text,
                    Model = txtModel.Text,
                    Year = int.Parse(txtYear.Text),
                    Price = double.Parse(txtPrice.Text)
                };
                crud.UpdateCar(updatedCar);
                carGrid.DataSource = crud.GetAllCars();
                btnUpdate.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (carGrid.CurrentRow != null)
            {
                int vin = (int)carGrid.CurrentRow.Cells["VIN"].Value;
                int carVin = (int)vin;
                crud.DeleteCar(carVin);
                carGrid.DataSource = crud.GetAllCars();
                btnUpdate.Enabled = false;
            }
        }

        private void btnSelectRecord_Click_1(object sender, EventArgs e)
        {
            if (carGrid.CurrentRow != null)
            {
                int vin = (int)carGrid.CurrentRow.Cells["VIN"].Value;
                Car selectedCar = crud.GetCarByVIN(vin);
                if (selectedCar != null)
                {
                    txtVIN.Text = selectedCar.VIN.ToString();
                    txtMake.Text = selectedCar.Make;
                    txtModel.Text = selectedCar.Model;
                    txtYear.Text = selectedCar.Year.ToString();
                    txtPrice.Text = selectedCar.Price.ToString();
                    txtVIN.ReadOnly = true;
                    btnUpdate.Enabled = true;
                    btnSubmit.Enabled = false;
                }
            }
        }
    }
}
