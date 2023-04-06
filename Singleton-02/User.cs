namespace Singleton_02
{
    public sealed class User
    {
        public string Name { get; set; }
        
        
        public User () {}
        
        // private static User _instance;
        //
        // public static User GetInstance()
        // {
        //     return _instance ?? new User();
        // }
        
    }
}