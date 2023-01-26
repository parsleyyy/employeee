using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MauiApp1
{
    internal class EmployeeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Employee employee;
        public ICommand IncreaseSalary { get; }
        public ICommand DecreaseSalary { get; } 
        public ICommand IncreaseExp { get; }
        public ICommand DecreaseExp { get; }
        public ICommand IncreaseFactor { get; }
        public ICommand DecreaseFactor { get; }
        public ICommand Calc { get; }
        public EmployeeViewModel()

        { 
            employee= new Employee();
            IncreaseSalary = new Command(IncreaseSalaryVoid);
            DecreaseSalary = new Command(DecreaseSalaryVoid);
            IncreaseExp = new Command(IncreaseExpVoid);
            DecreaseExp = new Command(DecreaseExpVoid);
            IncreaseFactor = new Command(IncreaseFactorVoid);
            DecreaseFactor = new Command (DecreaseFactorVoid);
            Calc = new Command(CalcPrize);
        }
        public void IncreaseSalaryVoid()
        {
            if (employee != null)
                Salary += 100;
        }

        public void DecreaseSalaryVoid()
        { 
         if (employee != null)
                Salary -= 100;
        }

        public void IncreaseExpVoid()
        { 
          if (employee != null)
                Exp +=1;
        }

        public void DecreaseExpVoid()
        {
         if (employee != null)
                Exp -=1;
        }

        public void IncreaseFactorVoid()
        {
            if (employee != null)
                Factor += 1;
        }
        public void DecreaseFactorVoid()
        {
            if (employee != null)
                Factor -= 1;
        }

        public void CalcPrize()
        {
            Prize = Salary * Exp * Factor;
        }
        public string FIO
        {
            get { return FIO; }
            set
            {
                if (employee.FIO != value)
                {
                    employee.FIO = value;
                    OnPropertyChanged("FIO");
                }
            }
        }
        public string Stuff
        {
            get { return Stuff; }
            set
            {
                if (employee.Stuff != value)
                {
                    employee.Stuff = value;
                    OnPropertyChanged("Stuff");
                }
            }
        }
        public int Salary
        {
            get { return employee.Salary; }
            set
            {
                if (employee.Salary != value)
                {
                    employee.Salary = value;
                    OnPropertyChanged("Salary");
                }
            }
        }
        public int Exp
        {
            get { return employee.Exp; }
            set
            {
                if (employee.Exp != value)
                {
                    employee.Salary = value;
                    OnPropertyChanged("Exp");
                }
            }
        }
        public double Factor
        {
            get { return employee.Factor; }
            set
            {
                if (employee.Factor != value)
                {
                    employee.Factor = value;
                    OnPropertyChanged("Factor");
                }
            }
        }
        public double Prize
        {
            get { return employee.Prize; }
            set
            {
                if (employee.Prize != value)
                {
                    employee.Prize = value;
                    OnPropertyChanged("Prize");
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}

