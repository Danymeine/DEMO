using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Panda
    {
        public double _height;
        public double _weight;
        public string _name;
        public Uri linkToPhoto;

        public void crawl() {
            _weight = _weight - 1;
        }
        public void eat() {
            _weight = _weight + 1;
        }
        public string say() {
            return "Hi";
        }

    }
    class random
    {
        Random Iv = new Random();
        public int Color = Iv.Next
        System.ConsoleColor color = (System.ConsoleColor)Iv.Next(1, 15);

    }

}
