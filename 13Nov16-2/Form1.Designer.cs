namespace _13Nov16_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.joinViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.joinDataSet = new _13Nov16_2.JoinDataSet();
            this.joinViewTableAdapter = new _13Nov16_2.JoinDataSetTableAdapters.JoinViewTableAdapter();
            this.tableAdapterManager1 = new _13Nov16_2.JoinDataSetTableAdapters.TableAdapterManager();
            this.joinViewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // joinViewBindingSource
            // 
            this.joinViewBindingSource.DataMember = "JoinView";
            this.joinViewBindingSource.DataSource = this.joinDataSet;
            // 
            // joinDataSet
            // 
            this.joinDataSet.DataSetName = "JoinDataSet";
            this.joinDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // joinViewTableAdapter
            // 
            this.joinViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = _13Nov16_2.JoinDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // joinViewDataGridView
            // 
            this.joinViewDataGridView.AutoGenerateColumns = false;
            this.joinViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.joinViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.joinViewDataGridView.DataSource = this.joinViewBindingSource;
            this.joinViewDataGridView.Location = new System.Drawing.Point(39, 31);
            this.joinViewDataGridView.Name = "joinViewDataGridView";
            this.joinViewDataGridView.Size = new System.Drawing.Size(469, 220);
            this.joinViewDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Last Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Street";
            this.dataGridViewTextBoxColumn3.HeaderText = "Street";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn4.HeaderText = "City";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 346);
            this.Controls.Add(this.joinViewDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.joinViewDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        // private AddressDataSet addressDataSet;
        private System.Windows.Forms.BindingSource addressBindingSource;
        // private AddressDataSetTableAdapters.AddressTableAdapter addressTableAdapter;
        // private AddressDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private JoinDataSet joinDataSet;
        private System.Windows.Forms.BindingSource joinViewBindingSource;
        private JoinDataSetTableAdapters.JoinViewTableAdapter joinViewTableAdapter;
        private JoinDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView joinViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

