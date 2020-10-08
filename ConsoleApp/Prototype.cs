using System;

namespace ConsoleApp
{
    /*
     * 需要了解浅层复制，值复制与引用复制
     * .NET通过引用ICloneable实现克隆
     */
    abstract class Prototype
    {
        private string id;

        public string Id
        {
            get => id;
            set => id = value;
        }

        public Prototype(string id)
        {
            this.id = id;
        }

        public abstract Prototype Clone();

    }

    class ConcretePrototype:Prototype
    {
        public ConcretePrototype(string id) : base(id)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype) this.MemberwiseClone();//如果是值类型，则逐位复制，如果是引用类型将会复制引用将不会复制对象
        }
    }

    class WorkInformation:ICloneable
    {
        private string workDate;
        private string company;
        
        public string WorkDate
        {
            get => workDate;
            set => workDate = value;
        }

        public string Company
        {
            get => company;
            set => company = value;
        }

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
    
    class Resume:ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private WorkInformation _workInformation;

        public Resume(string name)
        {
            this.name = name;
            _workInformation = new WorkInformation();
        }

        private Resume(WorkInformation workInformation)
        {
            _workInformation = (ConsoleApp.WorkInformation) workInformation.Clone();
        }

        public void SetAgeAndSex(string sex, string age)
        {
            this.age = age;
            this.sex = sex;
        }

        public void SetWorkInformation(string workDate, string company)
        {
            _workInformation.Company = company;
            _workInformation.WorkDate = workDate;
        }

        public WorkInformation WorkInformation => _workInformation;

        public object Clone()
        {
            Resume resume = new Resume(this._workInformation);
            resume.age = this.age;
            resume.sex = this.sex;
            resume.name = this.name;
            return resume;
        }
    }
}