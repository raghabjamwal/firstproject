using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.MicroKernel.Registration;

namespace DependencyInjectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //var client = new Client(new Service());
            //client.Start();
            //Console.ReadKey();

            var container = new WindsorContainer();
            container.Register(Component.For<IService>().ImplementedBy<Service>());
            var start = container.Resolve<IService>();
            start.Serve();
            Console.ReadKey();

        }
        
    }
    /// <summary>
    /// interface
    /// </summary>
    public interface IService
    {
        void Serve();
    }

    public class Service : IService
    {
        public void Serve()
        {
            Console.WriteLine("Service Consumed");
        }
    }

    //public class Client
    //{
    //    public IService _service;
    //    public Client(IService service)
    //    {
    //        this._service = service;
    //    }

    //    public void Start()
    //    {
    //        Console.WriteLine("Service Started");
    //        _service.Serve();
    //    }
    //}

}
