using System;
namespace Todolist.Droid
{
    public class Bootstrapper : Todolist.Bootstrapper
    {
        public static void Init() 
        {
            var instance = new Bootstrapper();
        }
    }
}
