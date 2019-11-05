using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraGiuaKi.DAL.Entity
{
    class danh_sach
    {
        private string tenGoi;
        private string email;
        private string sDT;
        private string tenNhom;
        private string diaChi;

        public string TenGoi { get => tenGoi; set => tenGoi = value; }
        public string Email { get => email; set => email = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string TenNhom { get => tenNhom; set => tenNhom = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }

        public static List<danh_sach> GetFromFile(string pathDataFile, string tenNhom)
        {
      
            CultureInfo cultureInfo = CultureInfo.InvariantCulture;
            List<danh_sach> kq = new List<danh_sach>();
            var arrayLines = File.ReadAllLines(pathDataFile);
            foreach (var line in arrayLines)
            {
                var lsValue = line.Split(new char[] { '#' });
                var ds = new danh_sach
                {
                    
                    TenGoi = lsValue[0],
                    Email = lsValue[1],
                    SDT = lsValue[2],
                    DiaChi = lsValue[3],
                    TenNhom = lsValue[4]
                
                };
                if (ds.TenNhom == tenNhom )
                    kq.Add(ds);
                
            }
            return kq;
        }


    }
}

