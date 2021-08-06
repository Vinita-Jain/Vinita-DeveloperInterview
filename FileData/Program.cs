using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;
using System.IO;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                FileDetails fd = new FileDetails();
                int argCount = 3;
                switch (argCount)
                {
                    case 1 : 
                        if(args[0] == "v")
                        {
                            string res = fd.Version(args[1]);                            
                            Console.WriteLine(res);
                        }
                        break;
                    case 2:
                        if (args[0] == "v" || args[0] == "--v" || args[0] == "/v")
                        {
                            string res = fd.Version(args[1]);
                            Console.WriteLine(res);
                        }
                        break;
                    case 3:
                        if(args[0] == "s" || args[0] == "--s" || args[0] == "/s")
                        {
                           int res = fd.Size(args[1]);
                            Console.WriteLine(res);
                        }
                        break;
                    default:                        
                        break;
                }                              
            }
            catch(Exception e)
            {
                Console.Write("Exception:" + e.Message);
            }
        }
    }
}
