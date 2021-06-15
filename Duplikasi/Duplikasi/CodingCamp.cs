using System;
using System.Collections.Generic;
using System.Text;

namespace Duplikasi
{
    class CodingCamp
    {
 

        public string Id { get; set; }
        public string Name { get; set; }
        public List<Partisipan> Partisipans { get; set; }

        public CodingCamp()
        {
            Partisipans = new List<Partisipan>();
        }

        public void ShowDataCodingCamp(List<CodingCamp> cc)
        {
            int jml = 0;
            foreach (var item in cc)
            {
               
                Console.WriteLine("No : "+(jml+1));
                Console.WriteLine("ID : "+item.Id);
                Console.WriteLine("Name : "+item.Name);
                Console.WriteLine("==========================");
                jml++;
            }
            
        }
        public void CariData(List<CodingCamp> cc,int index)
        {
            int jml = 0;
            foreach (var item in cc)
            {
                    if (jml == index)
                    {
                        Console.WriteLine("==========================");
                        Console.WriteLine("No : " + (jml + 1));
                        Console.WriteLine("ID : " + item.Id);
                        Console.WriteLine("Name : " + item.Name);
                        Console.WriteLine("==========================");
                }
                jml++;
                }
            }
            public void GetCampPartisipan()
            {

            int jml = 0;
                Console.WriteLine("==========================");
                Console.WriteLine("ID : " + Id);
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("==========================");
                Console.WriteLine("   Daftar Pasrticipant");
                Console.WriteLine("   -----------------------");
                foreach (var p in Partisipans)
                {
                    Console.WriteLine("   No  : " + (jml+1));
                    Console.WriteLine("   NIK  : " + p.Nik);
                    Console.WriteLine("   NAMA : " + p.Name);
                    Console.WriteLine("   -----------------------");
                jml++;
                }
        }public void GetPartisipan(int index)
            {

            int jml = 0;
                Console.WriteLine("==========================");
                Console.WriteLine("ID : " + Id);
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("==========================");
                Console.WriteLine("   Daftar Pasrticipant");
                Console.WriteLine("   -----------------------");
                foreach (var p in Partisipans)
                {
                    if (jml == index)
                    {
                        Console.WriteLine("   NIK  : " + p.Nik);
                        Console.WriteLine("   NAMA : " + p.Name);
                        Console.WriteLine("   -----------------------");
                    }
                    
                    jml++;
                }
        }
            public void ShowDataAll()
            {
                int jml = 0;
                    
                    Console.WriteLine("==========================");
                    Console.WriteLine("ID : " + Id);
                    Console.WriteLine("Name : " + Name);
                    Console.WriteLine("==========================");
                    Console.WriteLine("   Daftar Pasrticipant");
                    Console.WriteLine("   -----------------------");
                        foreach (var p in Partisipans)
                        {
                            Console.WriteLine("   NIK  : " + p.Nik);
                            Console.WriteLine("   NAMA : " + p.Name);
                            Console.WriteLine("   -----------------------");
                            jml++;
                         }

                    if (jml == 0)
                    {
                        Console.WriteLine("   [NO DATA]");
                    }
             }
            
            public void ShowDataParticipan()
            {
                int jml = 0;

                Console.WriteLine("==========================");
                Console.WriteLine("ID : " + Id);
                Console.WriteLine("Name : " + Name);
                Console.WriteLine("==========================");
                Console.WriteLine("   Daftar Pasrticipant");
                Console.WriteLine("   -----------------------");
                foreach (var p in Partisipans)
                {
                    Console.WriteLine("   NIK  : " + p.Nik);
                    Console.WriteLine("   NAMA : " + p.Name);
                    Console.WriteLine("   -----------------------");
                    jml++;
                }

                if (jml == 0)
                {
                    Console.WriteLine("   [NO DATA]");
                }
        }
        }
        
    }

