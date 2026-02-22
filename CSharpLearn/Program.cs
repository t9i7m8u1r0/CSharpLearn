using System;

namespace CSharpLearn
{
    class Program
    {
        static void Main()
        {
            IUpdater<Account> updater = new UserService();
        }
    }

    public class User { }
    public class Account : User { }

    public interface IUpdater<in T>
    {
        void Update(T entity);
    }

    class UserService : IUpdater<User>
    {
        public void Update(User entity) { }
    }
}