using System;

namespace OOP
{
    class Kaffeetrinker
    {
        public void Register(Kaffeemaschine k)
        {
            k.KaffeIstZubereitet += MyHandler;
        }

        public void MyHandler(object sender, EventArgs e)
        {
            Console.WriteLine("Yam!");
        }
    }
}
