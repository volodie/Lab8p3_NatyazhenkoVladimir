//.Создать систему для учета документов.
//Создать класс Регистр, который будет иметь методы:
//-сохранения документа в регистре
//- предоставление информации о документе
//Система может работать с тремя типами документов:
//1) Контракт на поставку товаров
//Содержит поля:
//-Номер документа
//- Тип товаров
//- Количество товаров
//- Дата документа
//2) Контракт с сотрудником
//Содержит поля:
//-Номер документа
//- Дата документа
//- Дата окончания контракта
//- Имя сотрудника
//3) Финансовая накладная
//Содержит поля:
//-Итоговая сумма за месяц
//- Дата документа
//- Номер документа
//- Код департамента
//Класс регистр должен содержать внутри себя массив и при добавлении документа в регистр этот добавляемый документ должен добавляться в массив;
//Массив для класса регистра должен быть размером 10;
//В методе предоставления информации о документе следует выводить на экран информацию о переданном входным параметром документе;

using DocumentSystem;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)

    {
        var doc = new ContractEmployee(10, "2022-07-01", "2022 - 12 - 01", "Billy Sharp");
        var doc1 = new СonsignmentNote(2, "2021-01-01", 22, 100000);
        var doc2 = new GoodsSupply(5, "Food", 200, "2022-01-01");
        var doc3 = new ContractEmployee(10, "2022-07-01", "2023-11-30", "Anton Andreev");
        var doc4 = new СonsignmentNote(3, "2020-11-01", 7, 50000);
        var doc5 = new GoodsSupply(4, "Tree", 500, "2021-11-11"); 
        var doc6 = new ContractEmployee(1, "2022-01-01", "2023-12-01", "Ivan Ivanov");
        var doc7 = new ContractEmployee(2, "2022-02-01", "2023-04-30", "Petr Petrov");
        var reg = new RegistrDocuments();

        reg.saveDocument(doc);
        reg.saveDocument(doc1);
        reg.saveDocument(doc2);
        reg.saveDocument(doc3);
        reg.saveDocument(doc4);
        reg.saveDocument(doc5);
        reg.saveDocument(doc6);
        reg.saveDocument(doc7);
        Console.WriteLine(reg.GetDocumentInfo(doc));
        Console.WriteLine();
        Console.WriteLine(reg.GetDocumentInfo(doc1));
        Console.WriteLine();
        Console.WriteLine(reg.GetDocumentInfo(doc2));
        Console.WriteLine();
        Console.WriteLine(reg.GetDocumentInfo(doc3));
        Console.WriteLine();
        Console.WriteLine(reg.GetDocumentInfo(doc4));
        Console.WriteLine();
        Console.WriteLine(reg.GetDocumentInfo(doc5));
        Console.WriteLine();
        Console.WriteLine(reg.GetDocumentInfo(doc6));
        Console.WriteLine();
        Console.WriteLine(reg.GetDocumentInfo(doc7));

    }
}