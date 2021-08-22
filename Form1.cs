using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AuthemticatorForHospital
{ 
    ///<summary>
    /// Class that represent the main form of the application
    ///</summary>
    public partial class Form1 : Form
    {
        ///<summary>
        ///constructor of the form which will create and initialize all the control on the form
        ///</summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event handler for saving a new person being added to contact table
        /// </summary>
        /// <param name="sender">save button on the binding navigator toolbar </param>
        /// <param name="e">not used</param>

        private void contactsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //perform data validation
            this.Validate();
            //ensure any temporary changes are made final
            this._bindContactList.EndEdit();
            //update the db with all changes
            this._taContactAdapterManager.UpdateAll(this._authDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //fill the local data set which caches the db data locally
            //in memory with data from the db
            _taContact.Fill(_authDBDataSet.Contacts);

        }
       

        private void contactIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void _bndNavContactList_RefreshItems(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

        }

        private void onClose(object sender, EventArgs e)
        {
            //close the form. since this is the main form of the application the app eill now close ass well.
            Close();
        }
    }
}
