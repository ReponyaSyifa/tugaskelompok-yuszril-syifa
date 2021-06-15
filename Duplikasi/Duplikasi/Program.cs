using System;
using System.Collections.Generic;

namespace Duplikasi
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            List<CodingCamp> codingCamps = new List<CodingCamp>();
            CodingCamp coding = new CodingCamp();
            ///DATA AWAL CODING CAMP
            codingCamps.Add(new CodingCamp { Id = "MCC-REG-50-NET", Name = "Coding Camp 50" });
            codingCamps.Add(new CodingCamp { Id = "MCC-REG-51-NET", Name = "Coding Camp 51" });
            codingCamps.Add(new CodingCamp { Id = "MCC-REG-52-NET", Name = "Coding Camp 52" });
            //DATA AWAL PARTICIPANT
            codingCamps[2].Partisipans.Add(new Partisipan {Nik="14003", Name="Yuszril" });
            codingCamps[0].Partisipans.Add(new Partisipan {Nik="14001", Name="Syifa" });
            codingCamps[1].Partisipans.Add(new Partisipan {Nik="14002", Name="Faiz" });

        Menu:
            MenuView();
            Console.Write("Option (1-6) : ");
            int pilih = int.Parse(Console.ReadLine());
            switch (pilih)
            {
                case 1:
                    TambahCamp(codingCamps) ;
                    string key1 = Console.ReadLine();
                    if (key1 == "")
                    {
                        goto Menu;
                    }
                    break;
                case 2:
                    if(UpdateDataCamp(coding, codingCamps) == 1)
                    {
                        goto Menu;
                    }
                    else
                    {
                        goto Menu;
                    }
                    break;
                case 3:
                    if (DeleteDataCamp(coding, codingCamps) == 1)
                    {
                        goto Menu;
                    }
                    else
                    {
                        goto Menu;
                    }
                    break;
                case 4:
                    TampilAllData(codingCamps,coding);
                    string key4 = Console.ReadLine();
                    if (key4 == "")
                    {
                        goto Menu;
                    }
                    else
                    {
                        goto Menu;
                    }
                    break;
                case 5:
                     if (AddParisipan(coding, codingCamps) == 1)
                    {
                        goto Menu;
                    }
                    else
                    {
                        goto Menu;
                    }
                    break;
                case 6:
                   
                    if (tampilDataPartisipan(coding, codingCamps) == 1)
                    {
                        goto Menu;
                    }
                    else
                    {
                        goto Menu;
                    }
                    break;
                case 7:
                    if (DeletePartisipan(coding, codingCamps) == 1)
                    {
                        goto Menu;
                    }
                    else
                    {
                        goto Menu;
                    }
                    break;

            }


        }
        static int DeletePartisipan(CodingCamp coding, List<CodingCamp> code)
        {
             awal:
            int hasil = 0;
            try
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("||     Delete Participan    ||");
                Console.WriteLine("==============================\n");
                coding.ShowDataCodingCamp(code);
                Console.Write("\nPilih berdasarkan no urut : ");
                int pilih1 = int.Parse(Console.ReadLine());
                if (pilih1 == 0)
                {
                    hasil = 0;
                }
                else if (pilih1 > code.Count)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("||     Index Coding Camp Tidak Ada    ||");
                    Console.WriteLine("========================================\n\n");
                    if (Console.ReadLine() == "")
                    {
                        goto awal;
                    }
                }
                else
                {
                    Tengah:
                    
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("==============================");
                        Console.WriteLine("||     Delete Participan    ||");
                        Console.WriteLine("==============================\n");
                        int jml = 0;
                        foreach (var item in code)
                        {
                            if (jml == (pilih1 - 1))
                            {
                                item.GetCampPartisipan();
                            }
                            jml++;
                        }
                        Console.Write("Pilih data partisipan berdasarkan no urut : ");

                        int pilih2= int.Parse(Console.ReadLine());
                        if((pilih2-1) > code[pilih1 - 1].Partisipans.Count || (pilih2-1)<0)
                        {
                            Console.WriteLine("========================================");
                            Console.WriteLine("||     Index Coding Camp Tidak Ada    ||");
                            Console.WriteLine("========================================\n\n");
                            if (Console.ReadLine() == "")
                            {
                                goto Tengah;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            jml = 0;
                            foreach (var item in code)
                            {
                                if (jml == (pilih1 - 1))
                                {
                                    item.GetPartisipan(pilih2-1);
                                }
                                jml++;
                            }
                            Console.Write("\n Apakah Anda yakin untuk menghapus data tersebut ? (y/n) ");
                            string jawab = Console.ReadLine();
                            if (jawab == "y" || jawab == "Y")
                            {
                                code[pilih1 - 1].Partisipans.RemoveAt(pilih2-1);
                                Console.WriteLine("\n==============================");
                                Console.WriteLine("||       Delete Success       ||");
                                Console.WriteLine("==============================\n");
                                string key3 = Console.ReadLine();
                                if (key3 == "")
                                {
                                    hasil = 1;
                                }
                            }
                            else
                            {
                                hasil = 0;
                            }

                           
                        }

                    }
                    catch (FormatException e)
                    {

                        Console.WriteLine("========================================");
                        Console.WriteLine("||       Format Penulisan Salah       ||");
                        Console.WriteLine("======================================\n");
                        goto Tengah;
                    }


                   
                }

            }
            catch (FormatException e)
            {

                Console.WriteLine("========================================");
                Console.WriteLine("||       Format Penulisan Salah       ||");
                Console.WriteLine("======================================\n");
                goto awal;
            }
            return hasil;
        }
        private static int tampilDataPartisipan(CodingCamp coding, List<CodingCamp> code)
        {
        awal:
            int hasil = 0;
            try
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("||     Update Participan    ||");
                Console.WriteLine("==============================\n");
                coding.ShowDataCodingCamp(code);
                Console.Write("\nPilih berdasarkan no urut : ");
                int pilih1 = int.Parse(Console.ReadLine());
                if (pilih1 == 0)
                {
                    hasil = 0;
                }
                else if (pilih1 > code.Count)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("||     Index Coding Camp Tidak Ada    ||");
                    Console.WriteLine("========================================\n\n");
                    if (Console.ReadLine() == "")
                    {
                        goto awal;
                    }
                }
                else
                {
                    Tengah:
                    
                    try
                    {
                        Console.Clear();
                        Console.WriteLine("==============================");
                        Console.WriteLine("||     Update Participan    ||");
                        Console.WriteLine("==============================\n");
                        int jml = 0;
                        foreach (var item in code)
                        {
                            if (jml == (pilih1 - 1))
                            {
                                item.GetCampPartisipan();
                            }
                            jml++;
                        }
                        Console.Write("Pilih data partisipan berdasarkan no urut : ");

                        int pilih2= int.Parse(Console.ReadLine());
                        if((pilih2-1) > code[pilih1 - 1].Partisipans.Count || (pilih2-1)<0)
                        {
                            Console.WriteLine("========================================");
                            Console.WriteLine("||     Index Coding Camp Tidak Ada    ||");
                            Console.WriteLine("========================================\n\n");
                            if (Console.ReadLine() == "")
                            {
                                goto Tengah;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            jml = 0;
                            foreach (var item in code)
                            {
                                if (jml == (pilih1 - 1))
                                {
                                    item.GetPartisipan(pilih2-1);
                                }
                                jml++;
                            }

                            Console.WriteLine("*Note");
                            Console.WriteLine("- Jika Tidak Ingin Mengganti suatu kolom maka beri tanda (-)");
                            Console.WriteLine("");
                            Console.Write("[" + code[pilih1 - 1].Partisipans[pilih2 - 1].Name + "] =>  ");
                            code[pilih1 - 1].Partisipans[pilih2-1].Name = cekData(code[pilih1 - 1].Partisipans[pilih2 - 1].Name, Console.ReadLine());

                            Console.WriteLine("\n==============================");
                            Console.WriteLine("||       Update Success       ||");
                            Console.WriteLine("==============================\n");
                            if (Console.ReadLine() == "")
                            {
                                hasil = 1;
                            }
                        }

                    }
                    catch (FormatException e)
                    {

                        Console.WriteLine("========================================");
                        Console.WriteLine("||       Format Penulisan Salah       ||");
                        Console.WriteLine("======================================\n");
                        goto Tengah;
                    }


                   
                }

            }
            catch (FormatException e)
            {

                Console.WriteLine("========================================");
                Console.WriteLine("||       Format Penulisan Salah       ||");
                Console.WriteLine("======================================\n");
                goto awal;
            }
            return hasil;
        }

        private static int AddParisipan(CodingCamp coding, List<CodingCamp> code)
        {
            awal:
            int hasil = 0;
            try
            {
                Console.Clear();
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("||     Add Coding Camp      ||");
                Console.WriteLine("==============================");
                coding.ShowDataCodingCamp(code);
                Console.Write("\nPilih berdasarkan no urut : ");
                int pilih1 = int.Parse(Console.ReadLine());
                if (pilih1 == 0)
                {
                    hasil = 0;
                }
                else if (pilih1 > code.Count)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("||     Index Coding Camp Tidak Ada    ||");
                    Console.WriteLine("========================================\n\n");
                    if (Console.ReadLine() == "")
                    {
                        goto awal;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("");
                    coding.CariData(code, pilih1 - 1);
                    Console.Write("\nNIK : ");
                    string nik = Console.ReadLine();
                    Console.Write("NAMA : ");
                    string nama = Console.ReadLine();
                    code[pilih1-1].Partisipans.Add(new Partisipan { Nik = nik, Name = nama });
                    Console.WriteLine("\n==============================");
                    Console.WriteLine("||      Insert Success      ||");
                    Console.WriteLine("==============================\n");
                    string key4 = Console.ReadLine();
                    if (key4 == "")
                    {
                        hasil = 1;
                    }

                }
            }
            catch (FormatException e)
            {

                Console.WriteLine("========================================");
                Console.WriteLine("||       Format Penulisan Salah       ||");
                Console.WriteLine("======================================\n");
                goto awal;
            }
            return hasil;
        }

        static void TampilAllData(List<CodingCamp> codingCamps,CodingCamp code)
        {
            Console.Clear();
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("||     List Coding Camp      ||");
            Console.WriteLine("==============================");

            foreach (var item in codingCamps)
            {
                item.ShowDataAll();
            }


        }

        static void TambahCamp(List<CodingCamp> code)
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("||      Add Coding Camp     ||");
            Console.WriteLine("==============================\n");

            Console.Write("Masukan ID : ");
            string idCamp = Console.ReadLine();
            Console.Write("Masukan Name : ");
            string nameCamp = Console.ReadLine();
            code.Add(new CodingCamp { Id = idCamp, Name = nameCamp });            
            Console.WriteLine("\n==============================");
            Console.WriteLine("||      Insert Success      ||");
            Console.WriteLine("==============================\n");
           
        }
        static int DeleteDataCamp(CodingCamp coding, List<CodingCamp> code)
        {
            int hasil = 0;
            awal:
            try
            {
                Console.Clear();
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("||    Delete Coding Camp    ||");
                Console.WriteLine("==============================");
                coding.ShowDataCodingCamp(code);
                Console.Write("\nPilih berdasarkan no urut : ");
                int pilih1 = int.Parse(Console.ReadLine());
                if (pilih1 == 0)
                {
                    hasil = 0;
                }
                else if (pilih1 > code.Count)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("||     Index Coding Camp Tidak Ada    ||");
                    Console.WriteLine("========================================\n\n");
                    if (Console.ReadLine() == "")
                    {
                        goto awal;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("");
                    coding.CariData(code, pilih1 - 1);
                    Console.Write("\n Apakah Anda yakin untuk menghapus data tersebut ? (y/n) ");
                    string jawab = Console.ReadLine();
                    if (jawab == "y" || jawab == "Y")
                    {
                        code.RemoveAt(pilih1-1);
                        Console.WriteLine("\n==============================");
                        Console.WriteLine("||       Delete Success       ||");
                        Console.WriteLine("==============================\n");
                        string key3 = Console.ReadLine();
                        if (key3 == "")
                        {
                            hasil = 1;
                        }
                    }
                    else
                    {
                        hasil = 0;
                    }

                }
               


            }
            catch (FormatException e)
            {

                Console.WriteLine("========================================");
                Console.WriteLine("||       Format Penulisan Salah       ||");
                Console.WriteLine("======================================\n");
                goto awal;
            }
            return hasil;
           
        }
        static int UpdateDataCamp(CodingCamp coding,List<CodingCamp> code)
        {
            awal:
            int hasil = 0;
            try
            {
                Console.Clear();
                Console.WriteLine("==============================");
                Console.WriteLine("||     Update Coding Camp    ||");
                Console.WriteLine("==============================\n");
                coding.ShowDataCodingCamp(code);
                Console.Write("\nPilih berdasarkan no urut : ");
                int pilih1 = int.Parse(Console.ReadLine());
                if (pilih1 == 0)
                {
                    hasil = 0;
                }
                else if (pilih1 > code.Count)
                {
                    Console.WriteLine("========================================");
                    Console.WriteLine("||     Index Coding Camp Tidak Ada    ||");
                    Console.WriteLine("========================================\n\n");
                    if (Console.ReadLine() == "")
                    {
                        goto awal;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("");
                    coding.CariData(code, pilih1 - 1);

                    Console.WriteLine("*Note");
                    Console.WriteLine("- Jika Tidak Ingin Mengganti suatu kolom maka beri tanda (-)");
                    Console.WriteLine("");
                    Console.Write("[" + code[pilih1 - 1].Name + "] =>  ");
                    code[pilih1 - 1].Name = cekData(code[pilih1-1].Name, Console.ReadLine());

                    Console.WriteLine("\n==============================");
                    Console.WriteLine("||       Update Success       ||");
                    Console.WriteLine("==============================\n");
                    if (Console.ReadLine() == "")
                    {
                        hasil = 1;
                    }
                }

            }
            catch (FormatException e)
            {

                Console.WriteLine("========================================");
                Console.WriteLine("||       Format Penulisan Salah       ||");
                Console.WriteLine("======================================\n");
                goto awal;
            }
            return hasil;
        }

        static void MenuView()
        {
            Console.Clear();
            Console.WriteLine("=============Menu=============");
            Console.WriteLine("|| 1. Add Coding Camp       ||");
            Console.WriteLine("==============================");
            Console.WriteLine("|| 2. Update Coding Camp    ||");
            Console.WriteLine("==============================");
            Console.WriteLine("|| 3. Delete Coding Camp    ||");
            Console.WriteLine("==============================");
            Console.WriteLine("|| 4. Show Coding Camp      ||");
            Console.WriteLine("==============================");
            Console.WriteLine("|| 5. Add Participant       ||");
            Console.WriteLine("==============================");
            Console.WriteLine("|| 6. Update Participant    ||");
            Console.WriteLine("==============================");
            Console.WriteLine("|| 7. Delete Participant    ||");
            Console.WriteLine("==============================\n");
        }
       
            static string cekData(string asli, string update)
            {
                if (update == "-")
                {
                    return asli;
                }
                else
                {
                    return update;
                }
            }
        }
    }

