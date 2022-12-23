using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3) Финансовая накладная
//Содержит поля:
//-Итоговая сумма за месяц
//- Дата документа
//- Номер документа
//- Код департамента
namespace DocumentSystem
{
    public class СonsignmentNote : Documents
    {
        public uint documentNumber;
        public string documentDate;
        public uint departmentCode;
        public uint summOfTheMonth;

        public СonsignmentNote(uint documentNumber, string documentDate, uint departmentCode, uint summOfTheMonth)
        {
            this.documentNumber = documentNumber;
            this.documentDate = documentDate;
            this.departmentCode = departmentCode;
            this.summOfTheMonth = summOfTheMonth;
        }

        public override string PrintDocumentInformation()
        {
            return
                $"Document number : {documentNumber}\n" +
                $"Document date : {documentDate}\n" +
                $"Department code : {departmentCode}\n" +
                $"Summ of the month: {summOfTheMonth}";
        }
    }
}
