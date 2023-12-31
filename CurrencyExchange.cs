using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyExchange
{
    class Converter : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private double usd;
        private double usdToEuro = 0.89;
        private double euro;
        private double usdToBitcoin = 0.000033;
        private double bitcoin;
        private double ether;
        private double usdToEther = 0.00052;
        public double USDToBitcoin{
            get { return this.usdToBitcoin; }
            set { this.usdToBitcoin = value;
                if(value != 0)
                {
                    this.bitcoin = this.usd * this.usdToBitcoin;
                    if (this.PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("BITCOIN"));
                    }
                }
            }
        }
        public double Bitcoin
        {
            get { return this.bitcoin; }
            set { this.bitcoin = value;
                this.usd = this.bitcoin / this.usdToBitcoin;
                if (this.PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("USD"));
                }
            }
        }
        public double USDToEuro 
        {
            get { return this.usdToEuro; }
            set { 
                this.usdToEuro = value;
                if (value != 0)
                {
                    this.euro = this.usd * usdToEuro;
                    if (this.PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("EURO"));
                    }
                }
            }
        }
        public double Euro
        {
            get { return this.euro; }
            set
            {
                this.euro = value;
                this.usd = this.euro / usdToEuro;
                if (this.PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("USD"));
                }
            }
        }
        public double USD {
            get { return this.usd; }
            set  {
                this.usd = value;
                this.euro = this.usd * usdToEuro;
                this.bitcoin = this.usd * usdToBitcoin;
                this.ether = this.usd * usdToEther;
                if (this.PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("EURO"));
                    PropertyChanged(this, new PropertyChangedEventArgs("BITCOIN"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Ether"));
                }
            }
        }
        public double Ether
        {
           get { return this.ether; }
            set {  this.ether = value;

                this.ether = value;
                this.usd = this.ether / usdToEther;
             if (this.PropertyChanged != null)
                {

                    PropertyChanged(this, new PropertyChangedEventArgs("USD"));
                }
            
            
            
            }

        }


        public double USDToEther
       { 

            get{ return this.USDToEther; }
            set { 
                this.usdToEther = value;    
                
                
            
            
            if(value != 0)
                {
                    this.ether = this.usd * usdToEther;
                    if(this.PropertyChanged != null)
                    {
                        PropertyChanged(this, new PropertyChangedEventArgs("Ether"));
                    }

                }
            
            
            }
            
            
            
            
            
            }

    }
}
