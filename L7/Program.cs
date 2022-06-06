using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab07_c_sharp
{
    
    class Program
    {
        static void Main(string[] args)
        {          
            Action pointer_akcja = null;            

            while(true)
            {
                string wybor_programu = "";
                string wybor_podstawowy = "";
                Console.Clear();

                try
                {
                    pointer_akcja();        // Wykonanie akcji
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Obecnie nie wykonuje sie zaden program!\n");
                }

                Console.WriteLine("----- Pralka -----");
                Console.WriteLine("Co chcesz zrobic ?");
                Console.WriteLine("1. Wlacz program");
                Console.WriteLine("2. Wylacz program");
                wybor_podstawowy = Console.ReadKey().KeyChar.ToString();

                Console.WriteLine("\nWybierz program:");
                Console.WriteLine("1. Namaczanie");
                Console.WriteLine("2. Pranie");
                Console.WriteLine("3. Gotowanie");
                Console.WriteLine("4. Wirowanie");
                Console.WriteLine("5. Suszenie");                
                wybor_programu = Console.ReadKey().KeyChar.ToString();

                if (wybor_programu == "1")
                {
                    if (wybor_podstawowy == "1")
                    {
                            pointer_akcja += Namaczanie;                        
                    }
                    else
                    {                       
                        try
                        {
                            pointer_akcja -= Namaczanie;                           
                        }
                        catch(Exception ex)
                        {                            
                        }                        
                    }             
                }
                else if (wybor_programu == "2")
                {
                    if (wybor_podstawowy == "1")
                    {
                        pointer_akcja += Pranie;                                            
                    }
                    else
                    {                        
                        try
                        {
                            pointer_akcja -= Pranie;
                        }
                        catch (Exception ex)
                        {                            
                        }
                    }                    
                }
                else if (wybor_programu == "3")
                {
                    if (wybor_podstawowy == "1")
                    {
                         pointer_akcja += Gotowanie;                                              
                    }
                    else
                    {
                        try
                        {
                            pointer_akcja -= Gotowanie;
                        }
                        catch (Exception ex)
                        {                           
                        }
                    }                    
                }
                else if (wybor_programu == "4")
                {
                    if (wybor_podstawowy == "1")
                    {
                        pointer_akcja += Wirowanie;                                           
                    }
                    else
                    {
                        try
                        {
                            pointer_akcja -= Wirowanie;
                        }
                        catch (Exception ex)
                        {                            
                        }
                    }                   
                }
                else if (wybor_programu == "5")
                {
                    if (wybor_podstawowy == "1")
                    {
                        pointer_akcja += Suszenie;                                             
                    }
                    else
                    {
                        try
                        {
                            pointer_akcja -= Suszenie;
                        }
                        catch (Exception ex)
                        {                          
                        }
                    }                    
                }

                void Namaczanie()
                {
                    Console.WriteLine("Pralka wykonuje : Namaczanie\n");
                }
                void Pranie()
                {
                    Console.WriteLine("Pralka wykonuje : Pranie\n");
                }
                void Gotowanie()
                {
                    Console.WriteLine("Pralka wykonuje : Gotowanie\n");
                }
                void Wirowanie()
                {
                    Console.WriteLine("Pralka wykonuje : Wirowanie\n");
                }
                void Suszenie()
                {
                    Console.WriteLine("Pralka wykonuje : Suszenie\n");
                }
            }       
        }      
    }
}
