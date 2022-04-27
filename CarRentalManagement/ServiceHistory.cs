using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class ServiceHistory
    {
        public string IDcar;
        public List<Record> record = new List<Record>();
        public int count = 0;
        
        public ServiceHistory()
        {
            IDcar = " ";
            record = new List<Record>();
        }
        public class Record
        {
            // THUOC TINH
            public string ID;
            public string engine;
            public string transmission;
            public string tires;
            public int odometerOfEngine;
            public int odometerOfTrasmission;
            public int odometerOfTires;
            public string date;
            // PHUONG THUC
            public Record()
            {
                ID = "";
                engine = "";
                transmission = "";
                tires = "";
                odometerOfEngine = 0;
                odometerOfTrasmission = 0;
                odometerOfTires = 0;
                date = "";
            }
            public Record(string e, string tra, string ti, int km, string time)
            {
                engine = e;
                transmission = tra;
                tires = ti;
                odometerOfEngine = km;
                odometerOfTrasmission = km;
                odometerOfTires = km;
                date = time;
            }
            ~Record() { }
            //
            public int OdometerOfRecord()
            {
                int text = odometerOfEngine;
                if (text < odometerOfTires) text = odometerOfTires;
                if (text < odometerOfTrasmission) text = odometerOfTrasmission;
                return text;
            }
            public static int operator -(Record a, Record b)
            {
                if (a == b)
                {
                    if (a.OdometerOfRecord() > b.OdometerOfRecord())
                        return a.OdometerOfRecord() - b.OdometerOfRecord();
                    else
                        return b.OdometerOfRecord() - a.OdometerOfRecord();
                }
                else { return -1; }
            }
            public static bool operator ==(Record a,Record b)
           {
                if (a.ID == b.ID) return true;
               else return false;
            }
            public void SetID(string ID)
            {
                this.ID = ID;
            }
           public static bool operator !=(Record a, Record b)
            {
               if (a.ID == b.ID) return false;
                else return true;
            }
        }
        public void AddEngine(string newEngine, string time, int km)
        {
            if (count == 0)
            {
                Record add = new Record
                {
                    engine = newEngine,
                    odometerOfEngine = km,
                    transmission = "",
                    tires = "",
                    odometerOfTrasmission = 0,
                    odometerOfTires = 0,
                    date = time
                };
                add.SetID(IDcar);
                record.Add(add);
                this.count++;
            }
            else
            {
                var text = record[record.Count - 1];
                if ((text.date == time) || (text.date == time))
                {
                    record[record.Count - 1].engine = newEngine;
                    record[record.Count - 1].odometerOfEngine = km;
                }
                else
                {
                    Record add = new Record
                    {
                        engine = newEngine,
                        odometerOfEngine = km,
                        transmission = text.transmission,
                        tires = text.tires,
                        odometerOfTrasmission = text.odometerOfTrasmission,
                        odometerOfTires = text.odometerOfTires,
                        date = time
                    };
                    add.SetID(IDcar);
                    record.Add(add);
                    this.count++;
                }
            }
        }
        public void AddTrans(string newTransmission, string time, int km)
        {
            if (count == 0)
            {
                Record add = new Record
                {
                    transmission = newTransmission,
                    odometerOfTrasmission = km,
                    engine = "",
                    tires = "",
                    odometerOfEngine = 0,
                    odometerOfTires = 0,
                    date = time
                };
                add.SetID(IDcar);
                record.Add(add);
                this.count++;
            }
            else
            {
                var text = record[record.Count - 1];
                if ((text.date == time) || (text.date == time))
                {
                    record[record.Count - 1].transmission = newTransmission;
                    record[record.Count - 1].odometerOfTrasmission = km;
                }
                else
                {
                    Record add = new Record
                    {
                        transmission = newTransmission,
                        odometerOfTrasmission = km,
                        engine = text.engine,
                        tires = text.tires,
                        odometerOfEngine = text.odometerOfEngine,
                        odometerOfTires = text.odometerOfTires,
                        date = time
                    };
                    add.SetID(IDcar);
                    record.Add(add);
                    this.count++;
                }
            }
        }
        public void AddTires(string newTires, string time, int km)
        {
            if (count == 0)
            {
                Record add = new Record
                {
                    tires = newTires,
                    odometerOfTires = km,
                    transmission = "",
                    odometerOfTrasmission = 0,
                    engine = "",
                    odometerOfEngine = 0,
                    date = time
                };
                add.SetID(IDcar);
                record.Add(add);
                this.count++;
            }
            else
            {
                var text = record[record.Count - 1];
                if ((text.date == time) || (text.date == time))
                {
                    record[record.Count - 1].tires = newTires;
                    record[record.Count - 1].odometerOfTires = km;
                }
                else
                {
                    Record add = new Record
                    {
                        tires = newTires,
                        odometerOfTires = km,
                        transmission = text.transmission,
                        odometerOfTrasmission = text.odometerOfTrasmission,
                        engine = text.engine,
                        odometerOfEngine = text.odometerOfEngine,
                        date = time
                    };
                    add.SetID(IDcar);
                    record.Add(add);
                    this.count++;
                }
            }
        }
        public void SetIDcar(string ID)
        {
            IDcar = ID;
        }
    }
}
