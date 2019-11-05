﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.DAL.Entity
{
    class NhomDS
    {
        public string TenNhom { get; set; }
        public static List<NhomDS> GetListFromFile(string pathData)
        {
            var arrayLines = File.ReadAllLines(pathData);
            List<NhomDS> ketQua = new List<NhomDS>();
            foreach (var line in arrayLines)
            {
                var lsValue = line.Split(new char[] { '#' });
                var nhomDS = new NhomDS
                {
                    TenNhom = lsValue[0],
                };

                ketQua.Add(nhomDS);
            }
            return ketQua;
        }
    }
}
