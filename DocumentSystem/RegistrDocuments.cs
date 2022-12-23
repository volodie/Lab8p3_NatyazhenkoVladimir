using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
// Создать класс Регистр, который будет иметь методы:
//- сохранения документа в регистре
//- предоставление информации о документе
//Класс регистр должен содержать внутри себя массив и при добавлении документа в регистр этот добавляемый документ должен добавляться в массив;
//Массив для класса регистра должен быть размером 10;
//В методе предоставления информации о документе следует выводить на экран информацию о переданном входным параметром документе;

namespace DocumentSystem 
{
    
    public class RegistrDocuments 
    {
        Documents[] docArray;
        private int i = 0;
        public RegistrDocuments()
        {
            docArray = new Documents[10];
            i = 0;
        }

        public string saveDocument(Documents doc)
        {
            docArray[i] = doc;
            i++;
            return "Document added to register"; 
        }
        public string GetDocumentInfo(Documents doc)
        {
            foreach (var d in docArray)
            {
                if (d == doc)
                {
                    return d.PrintDocumentInformation();
                }
            }
            return "Document not in registry";
        }
    }

}
