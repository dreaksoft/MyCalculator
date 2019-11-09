using System;

namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int number1, number2, secim;
            string decree;
            string yes = "Y";
            string no = "N";

            getLogin();

            void getLogin()
            {
                getLoginMenu();
                getNumber();
                getHandleCommand();
            }

            void getLoginMenu()
            {
                Console.WriteLine("Hesap makinesine hosgeldiniz. Yapmak istediginiz islemi seciniz");
                Console.WriteLine("1- Toplama");
                Console.WriteLine("2- Çıkartma");
                Console.WriteLine("3- Çarpma");
                Console.WriteLine("4- Bölme");
            }

            void getNumber()
            {
                getPick();
                
                Console.WriteLine("İlk sayıyı giriniz");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci sayıyı giriniz");
                number2 = Convert.ToInt32(Console.ReadLine());
            }

            void getHandleCommand()
            {
                switch (secim)
                {
                    case 1:
                        topla(number1, number2);
                        break;
                    case 2:
                        cikarma(number1, number2);
                        break;
                    case 3:
                        carpma(number1, number2);
                        break;
                    case 4:
                        bolme(number1, number2);
                        break;
                    
                }

                getStop();
            }

            void getPick()
            {
                secim = Convert.ToInt32(Console.ReadLine());

                if (secim==1){}
                else if(secim==2){}
                else if(secim==3){}
                else if(secim==4){}
                else
                {
                    Console.Clear();
                    Console.WriteLine("Lütfen belirtilen değer aralığında bir sayı giriniz!");
                    getLoginMenu();
                    getPick();
                }
            }
            
            void getStop()
            {
                Console.WriteLine("Devam etmek istiyor istiyor musunuz ? (Y/N) ");
                decree = Console.ReadLine();

                Console.Clear();

                if (decree.ToUpper() == yes)
                {
                    getLogin();
                }
                else if (decree.ToUpper() == no)
                {
                    Console.WriteLine("\nUygulamamızı kullandığınız için teşekkür ederiz.");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Lütfen belirtilen harfleri kullanınız.");
                    getStop();
                }
            }

            void topla(int sayi1, int sayi2)
            {
                Console.WriteLine(sayi1 + " + " + sayi2 + " = " + (sayi1 + sayi2));
            }

            void cikarma(int sayi1, int sayi2)
            {
                Console.WriteLine(sayi1 + " - " + sayi2 + " = " + (sayi1 - sayi2));
            }

            void carpma(int sayi1, int sayi2)
            {
                Console.WriteLine(sayi1 + " * " + sayi2 + " = " + (sayi1 * sayi2));
            }

            void bolme(int sayi1, int sayi2)
            {
                if (sayi2 == 0)
                {
                    Console.WriteLine("Bolen sıfır olamaz");
                }
                else
                {
                    Console.WriteLine(sayi1 + " / " + sayi2 + " = " + (sayi1 / sayi2));
                }
            }
        }
    }
}