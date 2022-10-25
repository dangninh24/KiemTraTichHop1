using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_3
{
    class CuonSach
    {
        private int iD;
        private string tenSach;
        private int soTrang;
        private string tacGia;
        private float giaTien;

        public string TenSach { get => tenSach; set => tenSach = value; }
        public int SoTrang { get => soTrang; set => soTrang = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }
        public int ID { get => iD; set => iD = value; }

        public CuonSach(int id, string tenSach, int soTrang, string tacGia, float giaTien)
        {
            ID = id;
            TenSach = tenSach;
            SoTrang = soTrang;
            TacGia = tacGia;
            GiaTien = giaTien;
        }
    }
}
