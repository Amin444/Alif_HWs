using System;

namespace HW_30_01_21
{
    class Program
    {
        static void Main(string[] args)
        {
            string sign =Console.ReadLine();
           string pro ="ProAdmin";
           string exp ="ExpAdmin";

           var DW =new DocumentWorker();
           DW.OpenDocument();
           DW.EditDocument();
           DW.SaveDocument();
           if(sign.Equals(pro))
           {
               var PDW =new ProDocumentWorker();
               PDW.EditDocument();
               PDW.SaveDocument();
           }
           else if (sign.Equals(exp))
           {
               var EDW =new ExpertDocumentWorker();
               EDW.SaveDocument();
           }
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
    class ProDocumentWorker
    {
         public void EditDocument()
        {
            System.Console.WriteLine("Документ отредактирован");
        }
         public void SaveDocument()
        {
            System.Console.WriteLine("Документ сохранен в старом формате, сохранение в остальныхформатах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker
    {
         public void SaveDocument()
        {
            System.Console.WriteLine("Документ сохранен в новомформате");
        }
    }
}
