using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Calculator
{
    class AirthmeticViewModel : INotifyPropertyChanged
    {
        public double first =0,second=0,option=0,lastoption=0;
        bool operand;
        public AirthmeticViewModel()
        {         
            operand = false;
        }        
       
        public double updateNumber
        {
            get{return second;}
            set
            {
                if (second == 0)
                    second = value;
                else if (operand)
                {
                    second = value;
                    operand = false;
                }
                else
                    second = double.Parse(second.ToString() + value.ToString());

                RaisePropertyChanged("updateNumber");
            }
        }
                
        public void operation(double index)
        {
            option = index;
            if(option!=5)
            {if(lastoption !=0)
            {
              switch(lastoption)
              {
                  case 1:
                       first += second;
                       break;
                  case 2:
                       first -= second;
                       break;
                  case 3:
                       first *= second;
                       break;
                  case 4:
                       first /= second;
                       break;
              }
              second=0;
              updateNumber = first;            
            }
            else
            {
                first = second;           
            }
            operand = true; 
            lastoption = option;
            }
            else{
                operand = true;
                first=0;
                lastoption=0;
                updateNumber = 0;
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}