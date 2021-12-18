using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_homework.Extension
{
    public static class Extension
    {

        public static void Wordfinder(this string sentence, string word)
        {

            //Asagida qeyd etdiyim metodu internet arasdirmasi zamani tapmisam. Boolean ile yazaga calisdim asagida da gorduyunz kimi commente atilmis varianti var alinmadigina gore bu variantla etdim.Dersin 1 ci saatinda bu tapsirigin izahini verseniz sevinerem :)  
            string sentence1=sentence.ToUpper();
            string word1=word.ToUpper();    
            if (sentence1.Contains(word1))
            {
                Console.WriteLine($"Daxil edilmis cumlede {word} sozu ve ya hisseciyi movcuddur ");
            }
            else
            {
                Console.WriteLine($"Daxil etdiyiniz cumlede {word} sozu ve ya hisseciyi movcud deyil ");
            }
            //String[] words = sentence.Split(' ');


            //for (int i = 0; i < word.Length; i++)
            //{
            //    if (words[i] == word)
            //    {
            //       return true;

            //    }
            //    else
            //    {
            //        
            //        return false;
            //    }

            //}
            //return false;   


        }
    }
}

