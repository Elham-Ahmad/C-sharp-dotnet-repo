using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Question_3
    {
        enum Countries {

                INDIA = 1, 
                AUSTRALIA = 2, 
                USA = 3, 
                JAPAN = 4, 
                FRANCE = 5, 
                ENGLAND = 6
        }
        public void question3()
        {

            Console.WriteLine($"\n{Countries.INDIA} is Land of Colors and it is number-{(int)Countries.INDIA}\n" +
                $"\n{Countries.AUSTRALIA} is Land of Golden Fleece and it is number-{(int)Countries.AUSTRALIA}\n" +
                $"\n{Countries.USA} is Land of Opportunities and it is number-{(int)Countries.USA}\n" +
                $"\n{Countries.JAPAN} is Land of Rising Sun and it is number-{(int)Countries.JAPAN}\n" +
                $"\n{Countries.FRANCE} is Land of Artists and it is number-{(int)Countries.FRANCE}\n" +
                $"\n{Countries.ENGLAND} is Land of Angles and it is number-{(int)Countries.ENGLAND}");

        }
    }
}
