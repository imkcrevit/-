using System;
using System.Xml.Schema;

namespace ConsoleApp
{
    class AbstractFactory
    {
        public IUser CreateUser(string symbol)
        {
            IUser result = null;
            switch (symbol)
            {
                case "sql":
                    result = new SqlUser();
                    break;
                case "mysql":
                    result = new MySqlUser();
                    break;
            }

            return result;
        }
        
    }

    class User
    {
        private int _id;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
    /// <summary>
    /// 插入用户
    /// </summary>
    interface IUser
    {
        void Insert(User user);
        int GetUser(int id);
    }

    class SqlUser:IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("sql:insert  database values {0}",user.Name);
        }

        public int GetUser(int id)
        {
            Console.WriteLine("sql:select name where id = {0}",id);
            return - 1;
        }
    }

    class MySqlUser:IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("mysql:insert  database values {0}",user.Name);
        }

        public int GetUser(int id)
        {
            Console.WriteLine("mysql:select name where id = {0}",id);
            return - 1;
        }
    }
}