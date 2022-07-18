using ETABSv1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSIAPIDEMO.Menus;

namespace CSIAPIDEMO
{
    public partial class Main : Form
    {

        ETABSv1.cOAPI myETABSObject;
        private int ret;
        private string ModelName;
        bool state;
        ETABSv1.cSapModel mySapModel;
         eForce forceUnits;
        eLength lengthUnits;
        eTemperature temperatureUnits;
        string[] ObjectName;
        // Menus
        FileMenu fileMenu;
        EditMenu editMenu;
        SlecteMenu slecteMenu;

        public Main()
        {
            InitializeComponent();
           
        }


        #region Start Etabs and Get Units of Project
        // Run Etabs
        private void StartEtabs()
        {
            try
            {
                bool AttachToInstance;
                AttachToInstance = false;
                bool SpecifyPath;
                SpecifyPath = false;

                string ProgramPath;
                ProgramPath = @"C:\Program Files\Computers and Structures\ETABS 19\ETABS.exe";
                //dimension the ETABS Object as cOAPI type
                myETABSObject = null;

                //Use ret to check if functions return successfully (ret = 0) or fail (ret = nonzero) 
                 ret = 0;

                //create API helper object
                ETABSv1.cHelper myHelper;
                try
                {
                    myHelper = new ETABSv1.Helper();
                }
                catch (Exception ex)
                {
                    state = false;
                    return;
                }

                if (AttachToInstance)
                {
                    //attach to a running instance of ETABS 
                    try
                    {
                        //get the active ETABS object
                        myETABSObject = myHelper.GetObject("CSI.ETABS.API.ETABSObject");
                        state = true;
                    }
                    catch (Exception ex)
                    {
                        state = false;
                        MessageBox.Show("No running instance of the program found or failed to attach.");
                        return;
                    }
                }
                else
                {
                    if (SpecifyPath)
                    {
                        //'create an instance of the ETABS object from the specified path
                        try
                        {
                            //create ETABS object
                            myETABSObject = myHelper.CreateObject(ProgramPath);
                            state = true;
                        }
                        catch (Exception ex)
                        {
                            state = false;
                            return;
                        }
                    }
                    else
                    {
                        //'create an instance of the ETABS object from the latest installed ETABS
                        try
                        {
                            //create ETABS object
                            myETABSObject = myHelper.CreateObjectProgID("CSI.ETABS.API.ETABSObject");
                            state = true;
                        }
                        catch (Exception ex)
                        {
                            state = false;
                            return;
                        }
                    }
                    //start ETABS application
                    ret = myETABSObject.ApplicationStart();
                }
            }
            catch
            {

            }
        }
        public void SetDataModel()
        {
            // Set Units
            GetUnitsOfProjet();
            this.Text = "CSI ETABS Demo" + ModelName + "[" + forceUnits.ToString() + " - " + lengthUnits.ToString() + " - " + temperatureUnits.ToString() + "]";
        }
        // Get Units
        private void GetUnitsOfProjet()
        {
            try
            {
                //Get a reference to cSapModel to access all API classes and functions
                mySapModel = default(ETABSv1.cSapModel);
                mySapModel = myETABSObject.SapModel;

                ret = mySapModel.GetDatabaseUnits_2(ref forceUnits, ref lengthUnits, ref temperatureUnits);
                ModelName = mySapModel.GetModelFilename(false);

                //Check ret value 
                if (ret == 0)
                {
                    state = true;
                }
                else
                {
                    state = false;
                }
            }
            catch
            {
                state = false;

            }
        }
        #endregion


        #region Form Evnet Load and Activite
        private async void Main_Load(object sender, EventArgs e)
        {
            // Start Etabs
            txt_state.Text = "Starting Etabs...";
            progresstate.Visible = true;
            await Task.Run(() => StartEtabs());
            if (state == true)
            {
                txt_state.Text = "Ready";
                progresstate.Visible = false;
                //Get a reference to cSapModel to access all API classes and functions
                mySapModel = default(ETABSv1.cSapModel);
                mySapModel = myETABSObject.SapModel;

                // Menus init
                fileMenu = new FileMenu(mySapModel);
                editMenu = new EditMenu(mySapModel);
                slecteMenu = new SlecteMenu(mySapModel);

            }
            else
            {
                MessageBox.Show("Cannot start a new instance of the program.");

            }

        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (myETABSObject != null)
            {
                mySapModel.View.RefreshWindow();

            }
        }

#endregion
        // Open New Model
        private void btn_newemptymodel_Click(object sender, EventArgs e)
        {
            AddForms.NewModel newModel = new AddForms.NewModel(mySapModel,this,myETABSObject);
            newModel.Show();
        }

        // Open Excit File
        private async void btn_openfile_Click(object sender, EventArgs e)
        {
            // Open File
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select EDB File";
            ofd.RestoreDirectory = true;
            ofd.Filter = "ETABS File(*.edb)|*.edb";
            var rs = ofd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                txt_state.Text = "Open Model...";
                progresstate.Visible = true;
               state= await Task.Run(() => fileMenu.OpenFile(ofd.FileName));
                if (state == true)
                {
                    txt_state.Text = "Ready";
                    progresstate.Visible = false;

                }
                else
                {
                    MessageBox.Show("Can not Open Model");

                }
            }
            SetDataModel();
        }


       


      

        // Save Prject 
        private async void btn_save_Click(object sender, EventArgs e)
        {
            // Open File
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save ETABS Model";
            sfd.RestoreDirectory = true;
            sfd.Filter = "ETABS File(*.edb)|*.edb";
            var rs = sfd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                txt_state.Text = "Open Model...";
                progresstate.Visible = true;
               state= await Task.Run(() => fileMenu.SaveFile(sfd.FileName));
                if (state == true)
                {
                    txt_state.Text = "Ready";
                    progresstate.Visible = false;

                }
                else
                {
                    MessageBox.Show("Can not Open Model");

                }
            }
        }

        // Close Project 
        private void btn_close_Click(object sender, EventArgs e)
        {
            try
            {
                myETABSObject.ApplicationExit(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        // Exit Appliction
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


     

        // Change Connectivity
        private void btn_ChangeConnectivity_Click(object sender, EventArgs e)
        {
            editMenu.ChangFrameCon();
        }

        // Select All Objects
        private void btn_All_Click(object sender, EventArgs e)
        {
            ret = mySapModel.SelectObj.All();

        }

        // Prev Selection
        private void btn_prevselection_Click(object sender, EventArgs e)
        {
            ret = mySapModel.SelectObj.PreviousSelection();

        }

        // clear Slection Objects
        private void btn_clearselection_Click(object sender, EventArgs e)
        {
            ret = mySapModel.SelectObj.ClearSelection();


        }

        // Invert Select
        private void btn_invertselection_Click(object sender, EventArgs e)
        {
            ret = mySapModel.SelectObj.InvertSelection();

        }

       

        private void RefreshWindow_Click(object sender, EventArgs e)
        {
            mySapModel.View.RefreshWindow();
          
        }

        private void RefreshView_Click(object sender, EventArgs e)
        {
            mySapModel.View.RefreshView();
        }

        private void btn_getobjectslected_Click(object sender, EventArgs e)
        {
            slecteMenu.GetSelctedItems();
            var slectlable=slecteMenu.SetSlectedObjectToView();
            txt_state.Text = slectlable;
            ObjectName = slecteMenu.GetObjectName();
        }
    }
}
