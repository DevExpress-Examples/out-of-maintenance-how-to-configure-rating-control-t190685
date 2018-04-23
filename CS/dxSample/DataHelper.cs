using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace dxSample {
    public class DataHelper {
        public static object GetData() {
            DataTable dt = new DataTable("House");
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Adress");
            dt.Columns.Add("Year built");
            dt.Columns.Add("Cost");
            dt.Columns.Add("Mark", typeof(double));
            dt.Rows.Add(0, "652 Avonwick, Gate, Toronto, ON M3A25", "2008", 4000000, 3.5);
            dt.Rows.Add(1, "420234 Rogge St, Detroit, MI 48234", "2010", 1700000, 2.3);
            dt.Rows.Add(2, "82649 Topeka St, Riverbank, CA, 95360", "2011", -1, 10);
            dt.Rows.Add(3, "5119 Beryl Dr, San Antonio, TX 78212", "2007", 1300000, 7.95);
            dt.Rows.Add(4, "8512 Tranglewood Cir, Reform, AL, 35487", "2011", 1800000, 6.1);
            dt.Rows.Add(5, "620201 Plymouth Rd, Detroit, MI 48224", "2010", 100000, 4.2);
            return dt;
        }
    }
}
