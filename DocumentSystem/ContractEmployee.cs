using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2) Контракт с сотрудником
//Содержит поля:
//-Номер документа
//- Дата документа
//- Дата окончания контракта
//- Имя сотрудника
namespace DocumentSystem
{
    public class ContractEmployee : Documents
    {
        public uint documentNumber;
        public string documentDate;
        public string dateEndContract;
        public string nameEmployee;

        public ContractEmployee(uint documentNumber, string documentDate, string dateEndContract, string nameEmployee)
        {
            this.documentNumber = documentNumber;
            this.documentDate = documentDate;
            this.dateEndContract = dateEndContract;
            this.nameEmployee = nameEmployee;
        }
        public override string PrintDocumentInformation()
        {
            return
                $"Document number : {documentNumber}\n" +
                $"Document date: {documentDate}\n" +
                $"End date of contract: {dateEndContract}\n" +
                $"Employee name: {nameEmployee}";
        }

    }

}
