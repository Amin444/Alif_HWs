using System;

namespace HW_30_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
           var DW =new DocumentWorker();
           var PDW =new ProDocumentWorker();
           var EDW =new ExpertDocumentWorker();

            System.Console.WriteLine("Enter the key : ");
             string sign =Console.ReadLine();
             string pro ="ProAdmin";
             string exp ="ExpAdmin";

          
           if(sign.Equals(pro))
           {
               PDW.OpenDocument();
               PDW.EditDocument();
               PDW.SaveDocument();
           }
           else if (sign.Equals(exp))
           {
               EDW.OpenDocument();
               EDW.EditDocument();
               EDW.SaveDocument();
           }
           else
           {
                DW.OpenDocument();
                DW.EditDocument();
                DW.SaveDocument();
           }
           var p =new Player();
           p.Play();
           p.Pause();
           p.Stop();
           p.Record();
           
        }
        
    }
    class DocumentWorker
    {
        public void OpenDocument()
        {
            System.Console.WriteLine("Документ открыт");
        }
        public void EditDocument()
        {
            System.Console.WriteLine("Редактирование документа доступно вверсии Про");
        }
        
         public void SaveDocument()
        {
            System.Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker : DocumentWorker 
    {
        new
         public void EditDocument()
        {
            System.Console.WriteLine("Документ отредактирован");
        }
        new
         public void  SaveDocument()
        {
            System.Console.WriteLine("Документ сохранен в старом формате, сохранение в остальныхформатах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        new
         public void SaveDocument()
        {
            System.Console.WriteLine("Документ сохранен в новомформате");
        }
    }

        class Player : IPlayable , IRecodable
        {
             public void Play()
        {
            Console.WriteLine("Play");
        }

        public void Pause()
        {
            Console.WriteLine("Pause");
        }

        public void Stop()
        {
            Console.WriteLine("Stop");
        }
         public void Record()
        {
            Console.WriteLine("Record");
        }
        }
    interface IPlayable
    {
             void Play();
         
             void Pause();
           
             void Stop();
           
    }
    interface IRecodable
    {
             void Record();
           
             void Pause();
           
             void Stop();
           
    }
}
