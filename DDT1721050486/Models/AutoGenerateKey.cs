using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace DDT1721050486.Models
{
    public class AutoGenerateKey
    {
        public string GenerateKey(string id)
        {
            string strkey = "";

            string numPart = "", strPart = "", strPhanSo = "";
            //Tách phần số: 001
            numPart = Regex.Match(id, @"\d+").Value;
            strPart = Regex.Match(id, @"\D+").Value;
            //Thêm cả số 0 để kích thước = phân số => 1+1 = 2
            int phanso = (Convert.ToInt32(numPart) + 1);
            for (int i = 0; i < numPart.Length - phanso.ToString().Length; i++)
            {
                strPhanSo += "0";
            }
            strPhanSo += phanso;
            //Tách phần chữ
            strkey = strPart + strPhanSo;
            return strkey;
        }
    }
}