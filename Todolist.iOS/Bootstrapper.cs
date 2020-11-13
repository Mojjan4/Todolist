using System;
namespace Todolist.iOS
{
    public class Bootstrapper : Todolist.Bootstrapper
    {
        public static void Init()
        {
            var instance = new Bootstrapper();
        }
    }
}
