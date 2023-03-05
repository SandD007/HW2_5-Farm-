using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public static class Interface
    {
        public static void Run()
        {
            Messenger.SendMessage(ChoiseOfMessage.ChoiseOfQuantity);
            Actions.SendMessage();
            Messenger.SendCalculateAge(Actions.CalculateAge());
            Actions.SortByAge();
            Messenger.SendMessage(ChoiseOfMessage.ChosieOfAge);
            Actions.FineByAge(Reader.GetAnswerInt());
            Console.WriteLine();
        }
    }
}
