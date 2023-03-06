namespace AppNET.Infrastructure
{
    public class IOCContainer
    {
        //IRepository implenete etmiş objeyi istiyorum dediğimde
        //IRepostiory->EFCoreRepository döncek
        //ICategoryService->CategoryService
        //2 generic parametreye sahiptir. TKey:keyin tipi TValue: valuenın tipi verilerin kaybolmaması
        //ve değiştirilemesi için static readonly yaptık
        private static readonly Dictionary<Type, Func<object>> container = new Dictionary<Type, Func<object>>();
        //Resolve
        public static T Resolve<T>()
        {
            //var keyTipi=typeof(T);
            //var metot = container[keyTipi];
            //var nesne = metot();
            //var donusTipi=(T)nesne;
            //return donusTipi;

            return (T)container[typeof(T)]();
        }
        //REgister
        public static void Register<T>(Func<object> func)
        {
            if (container.ContainsKey(typeof(T)))
                container.Remove(typeof(T));
            container.Add(typeof(T), func);
        }

        //bu da üstteki ile aynı görevi görüyor
        //public static void kaydet(string key, int _value)
        //{
        //    container[key] = _value;
        //}

    }
}