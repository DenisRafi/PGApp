//-By Denis Rafi

using System;

namespace Password
{
    class Program
    {       
        public string makeRandomPassword(int length)
        {
            string UpperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string LowerCase = "abcdefghijklmnopqrstuvwxyz";
            string Digits = "1234567890";
            string allCharacters = UpperCase + LowerCase + Digits;  
            Random r = new Random();
            String password = "";
            for (int i = 0; i < length; i++)
            {
                double rand = r.NextDouble();
                if (i == 0)
                {
                    password += UpperCase.ToCharArray()[(int)Math.Floor(rand * UpperCase.Length)];
                }
                else
                {
                    password += allCharacters.ToCharArray()[(int)Math.Floor(rand * allCharacters.Length)];
                }
            }
            Console.WriteLine(password);
            Console.ReadLine();
            return password;
        }
        static void Main()
        {          
            string len = Console.ReadLine();
            Program n = new Program();            
            n.makeRandomPassword(Convert.ToInt32(len));
        }
    }
}