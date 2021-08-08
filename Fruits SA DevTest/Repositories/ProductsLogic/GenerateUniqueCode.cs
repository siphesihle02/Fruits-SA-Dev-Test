using System;
using System.Text;

namespace Repositories
{
   
    public class GenerateUniqueCode
    {
        private readonly Random _random = new Random();
        static StringBuilder Main()
        {
            
        StringBuilder sb = new StringBuilder(6);
            sb.Append(2021);
            sb.Append((char)1000, 9999);
            return sb;
        }
      
        }
    }
    
        
   

