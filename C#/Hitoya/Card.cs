using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Hitoya
{
    [Serializable()]
    class Card
    {

        public Card()
        {
            //Load card information from file

            /* 
             TODO: Learn how serialization works in order to learn how to retrieve data. Relevant link: 
             https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/serialization/index
             */
        }

        private Card[] ReadFromFile(String filename)
        {
            Card[] cards;


            try
            {
                Stream stream = File.Open(filename, FileMode.Open);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Deserialize(stream);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                return null;
            }



            return cards;
        }

    }
}
