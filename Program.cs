using Reign_of_Grelok.stages;
using Reign_of_Grelok.state;

namespace Reign_of_Grelok
{
    class Program
    {
        static void Main(string[] args) {
            var inventory = new Inventory();
            var plains = new Plains(inventory);
            plains.Load();
        }
    }
}