using DataLayer3.TableDataGateway;
using System;
using System.Data;

namespace DomainLayer.TableModule
{
    public class CustomerTableModule
    {
        private DataTable TableData;

        private CustomerTableGateway _dataGateway;
        public CustomerTableModule()
        {
            _dataGateway = new CustomerTableGateway();
        }

        /* Domain Logic Functions*/
        public double AverageSalary()
        {
            TableData = _dataGateway.Find();
            double SalarySum = 0;
            
            foreach ( DataRow row in this.TableData.Rows)
            {
                SalarySum += Double.Parse(row[4].ToString());
            }

            return SalarySum / TableData.Rows.Count;
        }
    }
}
