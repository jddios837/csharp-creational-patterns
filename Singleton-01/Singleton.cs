namespace Singleton_01
{
    public sealed class Singleton
    {
        // Constructor should always be private to prevent
        // direct construction
        private Singleton() { }

        // The Singleton's instance is stored in a static field.
        private static Singleton _instance;

        // This is the static method that controls the access to the singleton
        // instance. On the first run, it creates a singleton object and places
        // it into the static field. On subsequent runs, it returns the client
        // existing object stored in the static field.
        public static Singleton GetInstance()
        {
            return _instance ??= new Singleton();
            // if (_instance == null)
            // {
            //     _instance = new Singleton();
            // }
            // return _instance;
        }

        public void someBusinessLogic()
        {
            
        }
    }
}