using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace assignment4.DHClasses
{
    class DHProvince
    {
        private string provinceCode;
        private string name;
        private string countryCode;
        private string taxCode;
        private double taxRate;
        private bool includesFederalTax;
        private string error;
        private bool isEdit;
        
        private StreamReader reader;

        private string fileName = "province.txt";

        public DHProvince(string _provinceCode, string _name, string _countryCode, string _taxCode, double _taxRate, bool _includesFederalTax)
        {
            provinceCode = _provinceCode;
            name = _name;
            countryCode = _countryCode;
            taxCode = _taxCode;
            taxRate = _taxRate;
            includesFederalTax = _includesFederalTax;
        }

        public DHProvince()
        {
            provinceCode = "";
            name = "";
            countryCode = "";
            taxCode = "";
            taxRate = 0;
            includesFederalTax = false;
            error = "";
            isEdit = false;
    }

        public string ProvinceCode
        {
            get { return provinceCode; }
            set { provinceCode = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }
        public string TaxCode
        {
            get { return taxCode; }
            set { taxCode = value; }
        }
        public double TaxRate
        {
            get { return taxRate; }
            set { taxRate = value; }
        }
        public bool IncludesFederalTax
        {
            get { return includesFederalTax; }
            set { includesFederalTax = value; }
        }

        public string Error
        {
            get { return error; }
            set { error = value; }
        }

        public override string ToString()
        {
            return string.Format("{0,-20}{1,-20}{2,-20}{3,-20}{4,-20}{5,-20}", provinceCode, name, countryCode, taxCode, taxRate.ToString(), includesFederalTax.ToString());
        }

        public DHProvince DHParseProvince(string str)
        {
            DHProvince provinceInstance = new DHProvince();
            try
            {
                provinceInstance.ProvinceCode = str.Substring(0, 20).Trim().ToUpper();
                provinceInstance.Name = CapitalizeFirstLetter(str.Substring(20, 20).Trim());
                provinceInstance.CountryCode = str.Substring(40, 20).Trim().ToUpper();
                provinceInstance.TaxCode = str.Substring(60, 20).Trim().ToUpper();
                provinceInstance.TaxRate = Convert.ToDouble(str.Substring(80, 20).Trim());
                provinceInstance.IncludesFederalTax = Convert.ToBoolean(str.Substring(100, 20).Trim());
                return provinceInstance;
            }
            catch(Exception ex)
            {
                this.Error = "Not a province record\n" + ex.Message;
                return null;
            }
        }

        public DHProvince DHGetByProvinceCode(string provCode)
        {
            DHProvince provinceInstance = new DHProvince();
            List<DHProvince> provList = DHGetProvinces();
            int i;
            bool isFound = false;

            for (i = 0; i < provList.Count; i++)
            {
                if (provList[i].ProvinceCode.Equals(provCode))
                {
                    provinceInstance = provList[i];
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                return provinceInstance;
            }
            else
            {
                this.Error = "Cannot find a record";
                return null;
            }
        }

        public DHProvince DHGetByProvinceName(string provName)
        {
            DHProvince provinceInstance = new DHProvince();
            List<DHProvince> provList = DHGetProvinces();
            int i;
            bool isFound = false;

            for(i = 0; i < provList.Count; i++)
            {
                if (provList[i].Name.Equals(provName))
                {
                    provinceInstance = provList[i];
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                return provinceInstance;
            }
            else
            {
                this.Error = "Cannot find a record";
                return null;
            }
        }

        public List<DHProvince> DHGetProvinces()
        {
            List<DHProvince> provList = new List<DHProvince>();
            try
            {
                using (reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        DHProvince prov = DHParseProvince(line);
                        provList.Add(prov);
                    }
                    reader.Close();
                }
                return provList;
            }
            catch(Exception ex)
            {
                this.Error = ex.Message;
                return null;
            }
        }
        //For province names, this function will capitalize the first letters of each word
        private string CapitalizeFirstLetter(string str)
        {
            string returnStr = "";
            string[] strArray = str.Split(' ');
            int i;
            for (i = 0; i < strArray.Length; i++)
            {
                strArray[i] = strArray[i].Substring(0, 1).ToUpper() + strArray[i].Substring(1).ToLower();
            }
            returnStr = string.Join(" ", strArray);
            return returnStr;
        }
        
        private void DHEdit(DHProvince prov)
        {
            string errorMessage = "";
            isEdit = false;

            Regex provinceCodeRgx = new Regex(@"^[a-zA-Z]{2}$");
            Regex nameCodeRgx = new Regex(@"^[a-zA-Z]+$");
            Regex countryCodeRgx = new Regex(@"^[a-zA-Z]{2}$");
            Regex taxCodeRgx = new Regex(@"^[a-zA-Z]+$");

            try
            {
                if (!provinceCodeRgx.IsMatch(prov.ProvinceCode))
                {
                    errorMessage += "Province Code must be exactly 2 letters\n";
                }
                else
                {
                    prov.ProvinceCode = prov.ProvinceCode.Trim().ToUpper();
                }

                if (string.IsNullOrWhiteSpace(prov.Name))
                {
                    errorMessage += "Province Name is required\n";
                }
                else
                {
                    prov.Name = CapitalizeFirstLetter(prov.Name.Trim());
                }

                if (!countryCodeRgx.IsMatch(prov.CountryCode))
                {
                    errorMessage += "Country Code must be exactly 2 letters\n";
                }
                else
                {
                    prov.CountryCode = prov.CountryCode.Trim().ToUpper();
                }

                if (!string.IsNullOrWhiteSpace(prov.TaxCode))
                {
                    if (taxCodeRgx.IsMatch(prov.TaxCode))
                    {
                        prov.TaxCode = prov.taxCode.Trim().ToUpper();
                        if (prov.TaxRate < 0 || prov.TaxRate > 1)
                        {
                            errorMessage += "Tax Rate must be between 0 and 1\n";
                        }
                    }
                    else
                    {
                        errorMessage += "Tax Code must be letters or blank\n";
                    }
                }
                else
                {
                    if (prov.TaxRate != 0)
                    {
                        errorMessage += "If Tax Code is not provided, Tax Rate must be 0\n";
                    }
                }
            }
            catch(Exception ex)
            {
                errorMessage += ex.Message;
            }

            if (string.IsNullOrWhiteSpace(errorMessage))
            {
                if (File.Exists(fileName))
                {
                    List<DHProvince> provList = DHGetProvinces();
                    int i;
                    for (i = 0; i < provList.Count; i++)
                    {
                        if (provList[i].ProvinceCode.Equals(prov.ProvinceCode))
                        {
                            isEdit = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                prov.Error = errorMessage;
            }
        }
        //Passing in the list as an argument makes it possible to handle data within the list
        //Sending the data in the list to the txt file will be taken care of by UpdateFileAndDisplay method in Form1.cs
        public void DHAdd(List<DHProvince> provList)
        {
            string errorMessage = "";
            DHEdit(this);
            
            if(string.IsNullOrWhiteSpace(this.Error))
            {
                if (!isEdit)
                {
                    provList.Add(this);
                }
                else
                {
                    errorMessage += "Province code already on file\n";
                }

                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    this.Error += errorMessage;
                }
            }
        }
        //Passing in the list as an argument makes it possible to handle data within the list
        //Sending the data in the list to the txt file will be taken care of by UpdateFileAndDisplay method in Form1.cs
        public void DHDelete(List<DHProvince> provList)
        {
            bool isFound = false;
            DHEdit(this);
            
            if(string.IsNullOrWhiteSpace(this.Error))
            {
                int i;
                for (i = 0; i < provList.Count; i++)
                {
                    if (provList[i].ProvinceCode.Equals(this.ProvinceCode))
                    {
                        provList.RemoveAt(i);
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    this.Error += "No record on file with the same province code\n";
                }
            }
        }
        //Passing in the list as an argument makes it possible to handle data within the list
        //Sending the data in the list to the txt file will be taken care of by UpdateFileAndDisplay method in Form1.cs
        public void DHUpdate(List<DHProvince> provList)
        {
            bool isFound = false;
            DHEdit(this);

            if (string.IsNullOrWhiteSpace(this.Error))
            {
                int i;
                for (i = 0; i < provList.Count; i++)
                {
                    if (provList[i].ProvinceCode.Equals(this.ProvinceCode))
                    {
                        isFound = true;
                        provList[i] = this;
                    }
                }

                if (!isFound)
                {
                    this.Error += "No record on file with the same province code\n";
                }
            }
        }
    }
}