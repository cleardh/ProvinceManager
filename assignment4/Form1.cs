/*
 * Program: Assignment 4
 * 
 * History: Written by Dongha Kang
 *          08 April, 2018
 */


using assignment4.DHClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Subroutine that clears all the fields
        private void ClearFields()
        {
            provinceCodeTextBox.Text = "";
            provinceNameTextBox.Text = "";
            countryCodeTextBox.Text = "";
            taxCodeTextBox.Text = "";
            taxRateTextBox.Text = "";
            includesFederalTaxCheckBox.Checked = false;
        }
        //When the form loads initially, data from the txt file will be read and a list will be created
        private void Form1_Load(object sender, EventArgs e)
        {
            List<DHProvince> provList = new DHProvince().DHGetProvinces();
            int i;
            for (i = 0; i < provList.Count; i++)
            {
                provinceCodeListBox.Items.Add(provList[i].ProvinceCode);
            }

            provinceCodeTextBox.Enabled = false;
            provinceNameTextBox.Enabled = false;
            countryCodeTextBox.Enabled = false;
            taxCodeTextBox.Enabled = false;
            taxRateTextBox.Enabled = false;
            includesFederalTaxCheckBox.Enabled = false;
        }
        //When the selected index of the province code is changed, data linked to it will appear in the fields
        private void provinceCodeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            provinceNameTextBox.Enabled = true;
            countryCodeTextBox.Enabled = true;
            taxCodeTextBox.Enabled = true;
            taxRateTextBox.Enabled = true;
            includesFederalTaxCheckBox.Enabled = true;
            isNew = false;
            btnDelete.Enabled = true;
            if (provinceCodeListBox.SelectedIndex >= 0)
            {
                string provCode = provinceCodeListBox.SelectedItem.ToString().Trim();
                DHProvince prov = new DHProvince();
                prov = prov.DHGetByProvinceCode(provCode);
                
                provinceCodeTextBox.Text = prov.ProvinceCode;
                provinceCodeTextBox.Enabled = false;
                provinceNameTextBox.Text = prov.Name;
                countryCodeTextBox.Text = prov.CountryCode;
                taxCodeTextBox.Text = prov.TaxCode;
                taxRateTextBox.Text = prov.TaxRate.ToString();
                if (prov.IncludesFederalTax)
                {
                    includesFederalTaxCheckBox.Checked = true;
                }
                else
                {
                    includesFederalTaxCheckBox.Checked = false;
                }
            }
        }
        //Initially clear the txt file and recreates the file based on the data in the list
        private void UpdateFileAndDisplay(List<DHProvince> provList)
        {
            int i;
            try
            {
                using (StreamWriter writer = new StreamWriter("province.txt"))
                {
                    writer.Flush();
                    provinceCodeListBox.Items.Clear();

                    for (i = 0; i < provList.Count; i++)
                    {
                        writer.WriteLine(provList[i].ToString());
                        provinceCodeListBox.Items.Add(provList[i].ProvinceCode);
                    }
                    writer.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //The global variable isNew decides whether it is in New Record mode or not
        private bool isNew;
        //When New Record is clicked, province code textbox will be activated and all fields will appear as blank
        private void btnNewRecord_Click(object sender, EventArgs e)
        {
            provinceCodeTextBox.Enabled = true;
            provinceNameTextBox.Enabled = true;
            countryCodeTextBox.Enabled = true;
            taxCodeTextBox.Enabled = true;
            taxRateTextBox.Enabled = true;
            includesFederalTaxCheckBox.Enabled = true;
            btnDelete.Enabled = false;
            isNew = true;
            ClearFields();
        }
        //According to whether it is a new record or an existing one, it fires Add or Update method
        private void btnSave_Click(object sender, EventArgs e)
        {
            DHProvince prov = new DHProvince();
            List<DHProvince> provList;
            if (string.IsNullOrWhiteSpace(provinceCodeTextBox.Text))
            {
                prov.ProvinceCode = "";
            }
            else
            {
                prov.ProvinceCode = provinceCodeTextBox.Text.Trim();
            }
            if (string.IsNullOrWhiteSpace(provinceNameTextBox.Text))
            {
                prov.Name = "";
            }
            else
            {
                prov.Name = provinceNameTextBox.Text.Trim();
            }
            if (string.IsNullOrWhiteSpace(countryCodeTextBox.Text))
            {
                prov.CountryCode = "";
            }
            else
            {
                prov.CountryCode = countryCodeTextBox.Text.Trim();
            }
            if (string.IsNullOrWhiteSpace(taxCodeTextBox.Text))
            {
                prov.TaxCode = "";
            }
            else
            {
                prov.TaxCode = taxCodeTextBox.Text.Trim();
            }
            if (string.IsNullOrWhiteSpace(taxRateTextBox.Text))
            {
                prov.TaxRate = 0;
            }
            else
            {
                prov.TaxRate = Convert.ToDouble(taxRateTextBox.Text.Trim());
            }
            if(includesFederalTaxCheckBox.Checked)
            {
                prov.IncludesFederalTax = true;
            }
            else
            {
                prov.IncludesFederalTax = false;
            }

            if(isNew)
            {
                provList = prov.DHGetProvinces();
                prov.DHAdd(provList);                
                UpdateFileAndDisplay(provList);
                provinceCodeListBox.SelectedIndex = provinceCodeListBox.Items.Count - 1;
            }
            else
            {
                provList = prov.DHGetProvinces();
                prov.DHUpdate(provList);
                UpdateFileAndDisplay(provList);
            }

            if (!string.IsNullOrWhiteSpace(prov.Error))
            {
                MessageBox.Show(prov.Error);
            }
            isNew = false;
            btnDelete.Enabled = true;
        }
        //It deletes the record and clear all fields
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DHProvince prov = new DHProvince();
            prov = prov.DHGetByProvinceCode(provinceCodeListBox.SelectedItem.ToString());
            List<DHProvince> provList = prov.DHGetProvinces();

            prov.DHDelete(provList);
            UpdateFileAndDisplay(provList);
            ClearFields();
        }
        //It simply closes the application
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}