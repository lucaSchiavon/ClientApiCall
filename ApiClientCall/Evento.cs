using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiClientCall
{
    class Evento
    {
        public int id;
        public int eventTypeId;
        public int bankReportEntryId;
        public object bankReportEntry;
        public int houseId;
        public string date;
        public string description;
        public double amount;
        public int invoiceId;
        public string reminderDate;
        public string reminderMessage;
        public object file;
        public string filePath;
    }
}
