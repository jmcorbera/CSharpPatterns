using System;

namespace CSharpPattern.Singleton
{
    public class Company
    {
        //The Company class has a property of the same data type
        //where the only Company instance in the entire system will be saved
        private static Company instance;

        //// Thread Safety Singleton syncLock
        // private static readonly object syncLock = new object();

        public String name { get; set; }
        public String street { get; set; }
        public int number { get; set; }
        public String telephone { get; set; }

        //We define the private constructor so that nobody from outside
        //the class can create an instance of Company
        private Company()
        {
            this.name = "Company Of IT Solution";
            this.street = "Main Street";
            this.number = 648;
            this.telephone = "5555-5555";
        }

        // The Company class has a static method which provides
        // the functionality of returning the only instance in the system,
        // if it does not exist it creates it and returns it, if it already exists it returns that one.
        // if you want to make a Thread Safety Singleton, lock is necessary to return a single instance to multiple threads.
        public static Company GetInstance()
        {
            if (instance == null)
            {
                instance = new Company();

                //// * Thread Safety Singleton * ////
                //lock (syncLock)
                //{
                //    if (instance == null)
                //    {
                //        instance = new Company();
                //    }
                //}
            }

            return instance;
        }
    }
}
