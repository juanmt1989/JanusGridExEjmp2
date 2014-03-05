using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace JanusGridExEjmp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);
            // TODO: esta línea de código carga datos en la tabla 'northwindDataSet.Invoices' Puede moverla o quitarla según sea necesario.
            this.invoicesTableAdapter.Fill(this.northwindDataSet.Invoices);         
            FillCategoriesValueList();
        }

        private void FillCategoriesValueList()
        {
            //Get the CategoryID column
            GridEXColumn column = gridEX1.RootTable.Columns["CustomerID"];
           
            //Set HasValueList property equal to true in order to be able to use the ValueList property
            column.HasValueList = true;
            //Get the ValueList collection associated to this column
            GridEXValueListItemCollection valueList = column.ValueList;

            //Fill the ValueList           
            //valueList.PopulateValueList(northwindDataSet.Customers.DefaultView,"CustomerID", "CompanyName");

            //An alternative way to fill the value list is using the Add method as follows:


            DataView view = northwindDataSet.Customers.DefaultView;
            foreach(DataRowView row in view)
            {
                valueList.Add(row["CustomerID"],(string)row["CompanyName"]);
            }
            


            //Setting other column related properties

            //When using a value list you could use DropDownList and Combo EditType 
            //in the column and the values for the dropdown list will be the values
            //in the ValueList collection
            column.EditType = EditType.DropDownList;
            //To be able to sort using the replaced value and not the value in the
            //CategoryID field change the CompareTarget property to Text instead of value
            column.CompareTarget = ColumnCompareTarget.Text;

            //Likewise, to group by the replaced text do:
            column.DefaultGroupInterval = GroupInterval.Text;

        }
    }
}
