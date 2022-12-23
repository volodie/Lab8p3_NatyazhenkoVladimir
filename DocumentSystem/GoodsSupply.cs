using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1) Контракт на поставку товаров
// Содержит поля:
//-Номер документа
//- Тип товаров
//- Количество товаров
//- Дата документа
namespace DocumentSystem
{
    public class GoodsSupply : Documents
    {
        public uint documentNumber;
        public string supplyType;
        public uint goodsQuantity;
        public string documentDate;

        public GoodsSupply(uint documentNumber, string supplyType, uint goodsQuantity, string documentDate)
        {
            this.documentNumber = documentNumber;
            this.supplyType = supplyType;
            this.goodsQuantity = goodsQuantity;
            this.documentDate = documentDate;
        }

        public override string PrintDocumentInformation()
        {
            return
                $"Document number : {documentNumber}\n" +
                $"Document date : {documentDate}\n" +
                $"Goods quantity : {goodsQuantity}\n" +
                $"Supply type : {supplyType}";
        }
    }
}
