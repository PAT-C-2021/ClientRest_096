using System;
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Net;
using static ClientRest_20190140096_Amalia_Husna.Program;
using System.Collections.Generic;

namespace ClientRest_20190140096_Amalia_Husna
{
    internal class ClassData
    {
        internal void getData()
        {
            var json = new WebClient().DownloadString("http://localhost:1907/Mahasiswa");
            var data = JsonConvert.DeserializeObject<List<Mahasiswa>>(json);

            foreach (var mhs in data)
            {
                Console.WriteLine("Nama: " + mhs.nama);
                Console.WriteLine("NIM: " + mhs.nim);
                Console.WriteLine("Prodi: " + mhs.prodi);
                Console.WriteLine("Angkatan: " + mhs.angkatan);
            }
            Console.ReadLine();
        }
    }
}