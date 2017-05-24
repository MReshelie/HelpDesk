using System;
using System.Linq;

namespace HelpDesk.Classes
{
    public class StatusList : System.Collections.CollectionBase
    {
        public int Статус_ID { get; set; }
        public string Статус { get; set; }
        public string Записал { get; set; }
        public DateTime Дата_Записи { get; set; }
        public string Исправил { get; set; }
        public DateTime Дата_Исправления { get; set; }
        public string Примечание { get; set; }
    }

    /*
    public StatusList()
    {

    }
     */


    public class JobList : System.Collections.CollectionBase
    {
        public int КодID { get; set; }
        public string Код { get; set; }
        public int КЧ { get; set; }
        public string Наименование_должности { get; set; }
        public string Код_категории { get; set; }
        public string Код_по_ОКЗ { get; set; }
        public string Записал { get; set; }
        public DateTime Дата_Записи { get; set; }
        public string Исправил { get; set; }
        public DateTime Дата_Исправления { get; set; }
        public string Примечание { get; set; }
    }

    /*
    [КодID]                  INT            IDENTITY (1, 1) NOT FOR REPLICATION NOT NULL,
    [Код]                    NCHAR (10)     NOT NULL,
    [КЧ]                     INT            NOT NULL,
    [Наименование должности] NVARCHAR (MAX) NOT NULL,
    [Код категории]          NCHAR (10)     NOT NULL,
    [Код по ОКЗ]             NCHAR (10)     NOT NULL,
    [Записал]                NVARCHAR (50)  NULL,
    [Дата записи]            DATE           CONSTRAINT [DF_Должности_Дата записи] DEFAULT (getdate()) NULL,
    [Изменил]                NVARCHAR (50)  NULL,
    [Дата изменения]         DATE           NULL,
    [Примечание]             NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Должности] PRIMARY KEY CLUSTERED ([КодID] ASC) WITH (FILLFACTOR = 90)
     */
}
