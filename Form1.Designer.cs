
namespace AuthemticatorForHospital
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblContactID;
            System.Windows.Forms.Label lblName;
            System.Windows.Forms.Label lblSurname;
            System.Windows.Forms.Label lblTelephone;
            System.Windows.Forms.Label lblWeight;
            System.Windows.Forms.Label lblHeight;
            System.Windows.Forms.Label lblGender;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._authDBDataSet = new AuthemticatorForHospital.AuthDBDataSet();
            this._bindContactList = new System.Windows.Forms.BindingSource(this.components);
            this._taContact = new AuthemticatorForHospital.AuthDBDataSetTableAdapters.ContactsTableAdapter();
            this._taContactAdapterManager = new AuthemticatorForHospital.AuthDBDataSetTableAdapters.TableAdapterManager();
            this._bndNavContactList = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contactsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txtboxContactID = new System.Windows.Forms.TextBox();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.txtboxSurname = new System.Windows.Forms.TextBox();
            this.txtboxTelephone = new System.Windows.Forms.TextBox();
            this.txtboxWeight = new System.Windows.Forms.TextBox();
            this.txtboxHeight = new System.Windows.Forms.TextBox();
            this.txtboxGender = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            lblContactID = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            lblSurname = new System.Windows.Forms.Label();
            lblTelephone = new System.Windows.Forms.Label();
            lblWeight = new System.Windows.Forms.Label();
            lblHeight = new System.Windows.Forms.Label();
            lblGender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._authDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindContactList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndNavContactList)).BeginInit();
            this._bndNavContactList.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.Location = new System.Drawing.Point(83, 96);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new System.Drawing.Size(77, 17);
            lblContactID.TabIndex = 1;
            lblContactID.Text = "Contact ID:";
            lblContactID.Click += new System.EventHandler(this.contactIDLabel_Click);
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(83, 124);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(49, 17);
            lblName.TabIndex = 3;
            lblName.Text = "Name:";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Location = new System.Drawing.Point(83, 152);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new System.Drawing.Size(69, 17);
            lblSurname.TabIndex = 5;
            lblSurname.Text = "Surname:";
            // 
            // lblTelephone
            // 
            lblTelephone.AutoSize = true;
            lblTelephone.Location = new System.Drawing.Point(83, 180);
            lblTelephone.Name = "lblTelephone";
            lblTelephone.Size = new System.Drawing.Size(80, 17);
            lblTelephone.TabIndex = 7;
            lblTelephone.Text = "Telephone:";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new System.Drawing.Point(83, 208);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new System.Drawing.Size(56, 17);
            lblWeight.TabIndex = 9;
            lblWeight.Text = "Weight:";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new System.Drawing.Point(83, 236);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new System.Drawing.Size(53, 17);
            lblHeight.TabIndex = 11;
            lblHeight.Text = "Height:";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new System.Drawing.Point(83, 264);
            lblGender.Name = "lblGender";
            lblGender.Size = new System.Drawing.Size(60, 17);
            lblGender.TabIndex = 13;
            lblGender.Text = "Gender:";
            // 
            // _authDBDataSet
            // 
            this._authDBDataSet.DataSetName = "AuthDBDataSet";
            this._authDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // _bindContactList
            // 
            this._bindContactList.DataMember = "Contacts";
            this._bindContactList.DataSource = this._authDBDataSet;
            // 
            // _taContact
            // 
            this._taContact.ClearBeforeFill = true;
            // 
            // _taContactAdapterManager
            // 
            this._taContactAdapterManager.BackupDataSetBeforeUpdate = false;
            this._taContactAdapterManager.ContactsTableAdapter = this._taContact;
            this._taContactAdapterManager.UpdateOrder = AuthemticatorForHospital.AuthDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // _bndNavContactList
            // 
            this._bndNavContactList.AddNewItem = this.bindingNavigatorAddNewItem;
            this._bndNavContactList.BindingSource = this._bindContactList;
            this._bndNavContactList.CountItem = this.bindingNavigatorCountItem;
            this._bndNavContactList.DeleteItem = this.bindingNavigatorDeleteItem;
            this._bndNavContactList.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._bndNavContactList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.contactsBindingNavigatorSaveItem});
            this._bndNavContactList.Location = new System.Drawing.Point(0, 0);
            this._bndNavContactList.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this._bndNavContactList.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this._bndNavContactList.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this._bndNavContactList.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this._bndNavContactList.Name = "_bndNavContactList";
            this._bndNavContactList.PositionItem = this.bindingNavigatorPositionItem;
            this._bndNavContactList.Size = new System.Drawing.Size(800, 27);
            this._bndNavContactList.TabIndex = 0;
            this._bndNavContactList.Text = "bindingNavigator1";
            this._bndNavContactList.RefreshItems += new System.EventHandler(this._bndNavContactList_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Yeni ekle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 24);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Toplam öğe sayısı";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Sil";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Başa taşı";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Öne taşı";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Konum";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Geçerli konum";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Arkaya taşı";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Sona taşı";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // contactsBindingNavigatorSaveItem
            // 
            this.contactsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactsBindingNavigatorSaveItem.Image")));
            this.contactsBindingNavigatorSaveItem.Name = "contactsBindingNavigatorSaveItem";
            this.contactsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.contactsBindingNavigatorSaveItem.Text = "Veriyi Sakla";
            this.contactsBindingNavigatorSaveItem.Click += new System.EventHandler(this.contactsBindingNavigatorSaveItem_Click);
            // 
            // txtboxContactID
            // 
            this.txtboxContactID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindContactList, "ContactID", true));
            this.txtboxContactID.Location = new System.Drawing.Point(169, 93);
            this.txtboxContactID.Name = "txtboxContactID";
            this.txtboxContactID.Size = new System.Drawing.Size(100, 22);
            this.txtboxContactID.TabIndex = 2;
            // 
            // txtboxName
            // 
            this.txtboxName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindContactList, "Name", true));
            this.txtboxName.Location = new System.Drawing.Point(169, 121);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(100, 22);
            this.txtboxName.TabIndex = 4;
            // 
            // txtboxSurname
            // 
            this.txtboxSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindContactList, "Surname", true));
            this.txtboxSurname.Location = new System.Drawing.Point(169, 149);
            this.txtboxSurname.Name = "txtboxSurname";
            this.txtboxSurname.Size = new System.Drawing.Size(100, 22);
            this.txtboxSurname.TabIndex = 6;
            // 
            // txtboxTelephone
            // 
            this.txtboxTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindContactList, "Telephone", true));
            this.txtboxTelephone.Location = new System.Drawing.Point(169, 177);
            this.txtboxTelephone.Name = "txtboxTelephone";
            this.txtboxTelephone.Size = new System.Drawing.Size(100, 22);
            this.txtboxTelephone.TabIndex = 8;
            // 
            // txtboxWeight
            // 
            this.txtboxWeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindContactList, "Weight", true));
            this.txtboxWeight.Location = new System.Drawing.Point(169, 205);
            this.txtboxWeight.Name = "txtboxWeight";
            this.txtboxWeight.Size = new System.Drawing.Size(100, 22);
            this.txtboxWeight.TabIndex = 10;
            // 
            // txtboxHeight
            // 
            this.txtboxHeight.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindContactList, "Height", true));
            this.txtboxHeight.Location = new System.Drawing.Point(169, 233);
            this.txtboxHeight.Name = "txtboxHeight";
            this.txtboxHeight.Size = new System.Drawing.Size(100, 22);
            this.txtboxHeight.TabIndex = 12;
            // 
            // txtboxGender
            // 
            this.txtboxGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this._bindContactList, "Gender", true));
            this.txtboxGender.Location = new System.Drawing.Point(169, 261);
            this.txtboxGender.Name = "txtboxGender";
            this.txtboxGender.Size = new System.Drawing.Size(100, 22);
            this.txtboxGender.TabIndex = 14;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(86, 301);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(183, 32);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(86, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(183, 30);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.onClose);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(lblContactID);
            this.Controls.Add(this.txtboxContactID);
            this.Controls.Add(lblName);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(lblSurname);
            this.Controls.Add(this.txtboxSurname);
            this.Controls.Add(lblTelephone);
            this.Controls.Add(this.txtboxTelephone);
            this.Controls.Add(lblWeight);
            this.Controls.Add(this.txtboxWeight);
            this.Controls.Add(lblHeight);
            this.Controls.Add(this.txtboxHeight);
            this.Controls.Add(lblGender);
            this.Controls.Add(this.txtboxGender);
            this.Controls.Add(this._bndNavContactList);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._authDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bindContactList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._bndNavContactList)).EndInit();
            this._bndNavContactList.ResumeLayout(false);
            this._bndNavContactList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AuthDBDataSet _authDBDataSet;
        private AuthDBDataSetTableAdapters.ContactsTableAdapter _taContact;
        private AuthDBDataSetTableAdapters.TableAdapterManager _taContactAdapterManager;
        private System.Windows.Forms.BindingNavigator _bndNavContactList;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton contactsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txtboxContactID;
        private System.Windows.Forms.TextBox txtboxName;
        private System.Windows.Forms.TextBox txtboxSurname;
        private System.Windows.Forms.TextBox txtboxTelephone;
        private System.Windows.Forms.TextBox txtboxWeight;
        private System.Windows.Forms.TextBox txtboxHeight;
        private System.Windows.Forms.TextBox txtboxGender;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.BindingSource _bindContactList;
        private System.Windows.Forms.Button btnClose;
    }
}

