using Reign_of_Grelok.stages;
using Reign_of_Grelok.state;

namespace Reign_of_Grelok
{
    class Program
    {
        static void Main(string[] args) {
            var inventory = new Inventory();
            var stateManagement = new Management();
            var town = new Town(inventory, stateManagement);
            var chapel = new Chapel(inventory, stateManagement);
            var plains = new Plains(inventory, town, chapel);
            plains.Load();
        }
    }
}