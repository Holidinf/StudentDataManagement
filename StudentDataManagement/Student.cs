using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataManagement
{
    internal class Student
    {
        public string Nama { get; set; }
        public string NIM { get; set; }
        public string Jurusan { get; set; }
        public Image Foto { get; set; }  // Mengganti string dengan Image untuk menyimpan gambar

        public Student(string nama, string nim, string jurusan, Image foto)
        {
            Nama = nama;
            NIM = nim;
            Jurusan = jurusan;
            Foto = foto;

        }
    }
}


