using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_ex02
{
    internal class Game
    {
        private int code;
        private string name;
        private string category;
        private DateTime date;
        private List<string> categorys = new List<string>() {"ação", "luta", "tiro", "esportes"};

        public void SetCode(int cod)
        {
            if (cod <= 0)
            {
                throw new Exception("The game code can't be 0 or less");
            }
            else
            {
                code = cod;
            }
        }

        public int GetCode() => code;

        public void SetName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new Exception("The game should have a valid name");
            }
            else
            {
                this.name = name;
            }
        }

        public string GetName() => name;

        public void SetCategory(string category)
        {
            if (String.IsNullOrEmpty(category) || !categorys.Contains(category.ToLower()))
            {
                throw new Exception("The game should have a valid category name");
            }
            else
            {
                this.category = category;
            }
        }
        public string GetCategory() => category;

        public void SetDate(DateTime date)
        {
            if (date > DateTime.Now)
            {
                throw new Exception("The game should have a valid release date");
            }
            else
            {
                this.date = date;
            }
        }
        public DateTime GetDate() => date;

        public void GetInfo()
        {
            Console.WriteLine(code + "\n" + name + "\n" + category + "\n" + date);
        }
    }
}
