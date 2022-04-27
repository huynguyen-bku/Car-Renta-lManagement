using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
namespace CarRentalManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CarRentalManagement carRentalManagement = new CarRentalManagement();
            // read file
            FileStream fs = new FileStream(@"F:\C#\CarRentalManagement\CarRentalManagement\CaD.xlsx", FileMode.Open);
            XSSFWorkbook wb = new XSSFWorkbook(fs);
            ISheet sheet = wb.GetSheetAt(0);
            int rowIndex = 1;
            while (sheet.GetRow(rowIndex).GetCell(0).ToString() != "end")
            {
                var nowRow = sheet.GetRow(rowIndex);
                var price = Int32.Parse(nowRow.GetCell(1).ToString());
                var capa = Int32.Parse(nowRow.GetCell(2).ToString());
                var color = nowRow.GetCell(3).ToString();
                var id= nowRow.GetCell(4).ToString();
                var brand= nowRow.GetCell(5).ToString();
                var od= Int32.Parse(nowRow.GetCell(6).ToString());
                var status= Int32.Parse(nowRow.GetCell(7).ToString());
                carRentalManagement.listVehicle.AddVehicle(price, color, id, brand, capa, od, status, 0);
               rowIndex++;
            }
            //
            FileStream fs1 = new FileStream(@"F:\C#\CarRentalManagement\CarRentalManagement\TrD.xlsx", FileMode.Open);
            XSSFWorkbook wb1 = new XSSFWorkbook(fs1);
            ISheet sheet1 = wb1.GetSheetAt(0);
            int rowIndex1 = 1;
            while (sheet1.GetRow(rowIndex1).GetCell(0).ToString() != "end")
            {
                var nowRow1 = sheet1.GetRow(rowIndex1);
                var price1 = Int32.Parse(nowRow1.GetCell(1).ToString());
                var capa1 = Int32.Parse(nowRow1.GetCell(2).ToString());
                var color1 = nowRow1.GetCell(3).ToString();
                var id1 = nowRow1.GetCell(4).ToString();
                var brand1 = nowRow1.GetCell(5).ToString();
                var od1 = Int32.Parse(nowRow1.GetCell(6).ToString());
                var status1 = Int32.Parse(nowRow1.GetCell(7).ToString());
                carRentalManagement.listVehicle.AddVehicle(price1, color1, id1, brand1, capa1, status1, od1, 1);
                rowIndex1++;
            }
            //
            FileStream fs2 = new FileStream(@"F:\C#\CarRentalManagement\CarRentalManagement\CD.xlsx", FileMode.Open);
            XSSFWorkbook wb2 = new XSSFWorkbook(fs2);
            ISheet sheet2 = wb2.GetSheetAt(0);
            int rowIndex2 = 1;
            while (sheet1.GetRow(rowIndex2).GetCell(0).ToString() != "end")
            {
                var nowRow2 = sheet2.GetRow(rowIndex2);
                var name = nowRow2.GetCell(1).ToString();
                var id = nowRow2.GetCell(2).ToString();
                var date = nowRow2.GetCell(3).ToString();
                var point = Int32.Parse(nowRow2.GetCell(5).ToString());
                var phone = Int32.Parse(nowRow2.GetCell(4).ToString());
                carRentalManagement.listCustonmer.AddNewCustomer(name, date, id, phone, point);
                rowIndex2++;
            }
            //end//
            FormMain formMain = new FormMain(carRentalManagement);
            Application.Run(formMain);
            carRentalManagement = formMain.MySystem();
        }
    }
}
