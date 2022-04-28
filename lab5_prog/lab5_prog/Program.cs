using System;

namespace lab5_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            







        }
    }


    public class cokolwiek
    {
      
        string Wiadomosc { get; }

        public delegate void Dabidamdam(string status);
        public event Dabidamdam asd;




        public cokolwiek(string wiadomosc)
        {
            Wiadomosc = wiadomosc;
        }




    }





















    public class ObservableList1 
    {

        int Length { get; }
        

        public delegate void DeAdded(string status);
        public delegate void DeUpdated(string status);
        public delegate void DeRemoved(string status);

        public event DeAdded SampleEventLog;
        public event DeUpdated SampleEventLog2;
        public event DeRemoved SampleEventLog3;



        public void Add() {
        
        
        }
        public void Get() { 
        
        
        }
        public void Set() { 
        
        
        }
        public void RemoveAt() { 
        
        
        }

        public class ObservableList2 
        {
            public delegate void DeAdded(string status);
            public delegate void DeUpdated(string status);
            public delegate void DeRemoved(string status);







        }
        public class ObservableList3 
        { 

        }



    }





}
