using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp.Views
{
    public partial class PayModeview : Form, IPayModeView
    {
        private bool isSuccessful;
        private string message;
        private bool isEdit;

        public string PayModeId
        {
            get { return TxtPayModeId.Text; }
            set { TxtPayModeId.Text = value; }
        }
        public string PayModeName
        {
            get { return TxtPayModeName.Text; }
            set { TxtPayModeName.Text = value; }

        }
        public string PayModeObservation
        {
            get { return TxtPayModeObs.Text; }
            set { TxtPayModeObs.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message
        {
            get { return message; }
            set { message = value; }

        }


        public PayModeview()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            TabControl.TabPages.Remove(tabPagePayModeDetail);

            BtnClose.Click += delegate { this.Close(); };

        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            //agregagr, llame al evento AddNewEvent cuando se haga click en el boton
            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                TabControl.TabPages.Remove(tabPagePayModeList);
                TabControl.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Add New Pay Mode";
            };

            BtnEdit.Click += delegate 
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                TabControl.TabPages.Remove(tabPagePayModeList);
                TabControl.TabPages.Add(tabPagePayModeDetail);
                tabPagePayModeDetail.Text = "Edit Pay Mode";
            };

            BtnDelete.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);
                var result = MessageBox.Show(
                    "Are you sur you want to delete the selected Pay Mode?",
                    "Warnign",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            BtnSave.Click += delegate 
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    TabControl.TabPages.Remove(tabPagePayModeDetail);
                    TabControl.TabPages.Add(tabPagePayModeList);
                }
                MessageBox.Show(Message);
            };

            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                TabControl.TabPages.Remove(tabPagePayModeDetail);
                TabControl.TabPages.Add(tabPagePayModeList);
            };




        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        private void PayModeview_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SetPayModeListBildingSource(BindingSource payModeList)
        {
            DgPayMode.DataSource = payModeList;
        }

        public void show()
        {
            throw new NotImplementedException();
        }

        private static PayModeview instance;

        public static PayModeview GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PayModeview();
                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }

    }
}
