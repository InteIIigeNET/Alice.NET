using Alice.Ioc;
using SimpleInjector;

namespace Alice
{
    public class HandleRegister
    {
        public void EnrolHandler(string url, IAliceHandler handler, params IAliceListener[] listeners)
        {
            //TODO : handle events
            IocRegister.Init(new Container());
        }
    }
}
