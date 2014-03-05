namespace JanusGridExEjmp2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Janus.Windows.GridEX.GridEXLayout gridEX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gridEX1 = new Janus.Windows.GridEX.GridEX();
            this.invoicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.northwindDataSet = new JanusGridExEjmp2.northwindDataSet();
            this.invoicesTableAdapter = new JanusGridExEjmp2.northwindDataSetTableAdapters.InvoicesTableAdapter();
            this.CustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new JanusGridExEjmp2.northwindDataSetTableAdapters.CustomersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridEX1
            // 
            this.gridEX1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridEX1.DataSource = this.invoicesBindingSource;
            gridEX1_DesignTimeLayout.LayoutString = resources.GetString("gridEX1_DesignTimeLayout.LayoutString");
            this.gridEX1.DesignTimeLayout = gridEX1_DesignTimeLayout;
            this.gridEX1.Location = new System.Drawing.Point(12, 50);
            this.gridEX1.Name = "gridEX1";
            this.gridEX1.Size = new System.Drawing.Size(608, 376);
            this.gridEX1.TabIndex = 0;
            // 
            // invoicesBindingSource
            // 
            this.invoicesBindingSource.DataMember = "Invoices";
            this.invoicesBindingSource.DataSource = this.northwindDataSet;
            // 
            // northwindDataSet
            // 
            this.northwindDataSet.DataSetName = "northwindDataSet";
            this.northwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoicesTableAdapter
            // 
            this.invoicesTableAdapter.ClearBeforeFill = true;
            // 
            // CustomersBindingSource
            // 
            this.CustomersBindingSource.DataMember = "Customers";
            this.CustomersBindingSource.DataSource = this.northwindDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 438);
            this.Controls.Add(this.gridEX1);
            this.Name = "Form1";
            this.Text = "Adding ValueList in GidEx ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.northwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.GridEX.GridEX gridEX1;
        private northwindDataSet northwindDataSet;
        private System.Windows.Forms.BindingSource invoicesBindingSource;
        private northwindDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        private System.Windows.Forms.BindingSource CustomersBindingSource;
        private northwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    }
}

