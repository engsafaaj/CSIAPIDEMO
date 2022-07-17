using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSIAPIDEMO.AddForms
{
    public partial class NewModel : Form
    {
          ETABSv1.cSapModel mySapModel;
        private int ret;
        ETABSv1.cOAPI myETABSObject;
        Main main;
        private bool state;

        public NewModel(ETABSv1.cSapModel _mySapModel,Main _main, ETABSv1.cOAPI _myETABSObject)
        {
            InitializeComponent();
            this.mySapModel = _mySapModel;
            this.main = _main;
            this.myETABSObject = _myETABSObject;
        }

        private async void btn_empy_Click(object sender, EventArgs e)
        {
            // Create Emtpy Model
           main. txt_state.Text = "Create Empty Model...";
            main.progresstate.Visible = true;
            await Task.Run(() => NewEmptyModel());
            if (state == true)
            {
                main.txt_state.Text = "Ready";
                main.progresstate.Visible = false;
                main.SetDataModel();
                Close();
            }
            else
            {
                MessageBox.Show("Can not Create Model");

            }
        }

        private async void btn_grids_Click(object sender, EventArgs e)
        {
            // Create Grids Model
            main.txt_state.Text = "Create Grids Model...";
            main.progresstate.Visible = true;
            
            await Task.Run(() => GridsModel(Convert.ToInt32(edt_numberofsotry.Text), Convert.ToInt32(edt_numberofgridsx.Text),
                Convert.ToInt32(edt_numberofgridsy.Text),Convert.ToDouble(edt_typicalstoryheight.Text), Convert.ToDouble(edt_bootomstoryheight.Text), Convert.ToDouble(edt_spacingx.Text), Convert.ToDouble(edt_spacingy.Text)));
            if (state == true)
            {
                main.txt_state.Text = "Ready";
                main.progresstate.Visible = false;
                main.SetDataModel();

                Close();

            }
            else
            {
                MessageBox.Show("Can not Create Model");

            }
        }

        private async void btn_steeldeck_Click(object sender, EventArgs e)
        {
            // Create Steel Deck Model
            main.txt_state.Text = "Create Steel Deck Model...";
            main.progresstate.Visible = true;

            await Task.Run(() => SteelDeckModel(Convert.ToInt32(edt_numberofsotry.Text), Convert.ToInt32(edt_numberofgridsx.Text),
             Convert.ToInt32(edt_numberofgridsy.Text), Convert.ToDouble(edt_typicalstoryheight.Text), Convert.ToDouble(edt_bootomstoryheight.Text), Convert.ToDouble(edt_spacingx.Text), Convert.ToDouble(edt_spacingy.Text)));
            if (state == true)
            {
                main.txt_state.Text = "Ready";
                main.progresstate.Visible = false;
                main.SetDataModel();

                Close();
            }              

            else
            {
                MessageBox.Show("Can not Create Model");

            }
        }


        // New Empty Model
        private void NewEmptyModel()
        {
            try
            {
                //Get a reference to cSapModel to access all API classes and functions
                mySapModel = default(ETABSv1.cSapModel);
                mySapModel = myETABSObject.SapModel;

                //Initialize model
                ret = mySapModel.InitializeNewModel();

                //Create Empty Model
                ret = mySapModel.File.NewBlank();

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
        // New Grids Model
        private void GridsModel(int NumberOfStory,int NumberOfLinesX,int NumberOfLinesY,double TypicalSroyHeight,double BootomStoryHeight,double SpacingX,double SpacingY)
        {
            try
            {
                //Get a reference to cSapModel to access all API classes and functions
                mySapModel = default(ETABSv1.cSapModel);
                mySapModel = myETABSObject.SapModel;

                //Initialize model
                ret = mySapModel.InitializeNewModel();

                //Create Empty Model
                ret = mySapModel.File.NewGridOnly(NumberOfStory,TypicalSroyHeight, BootomStoryHeight, NumberOfLinesX,NumberOfLinesY,SpacingX,SpacingY);

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
        // New Steel Deck Model
        private void SteelDeckModel(int NumberOfStory, int NumberOfLinesX, int NumberOfLinesY, double TypicalSroyHeight, double BootomStoryHeight, double SpacingX, double SpacingY)
        {
            try
            {
                //Get a reference to cSapModel to access all API classes and functions
                mySapModel = default(ETABSv1.cSapModel);
                mySapModel = myETABSObject.SapModel;

                //Initialize model
                ret = mySapModel.InitializeNewModel();

                //Create Empty Model
                ret = mySapModel.File.NewSteelDeck(NumberOfStory, TypicalSroyHeight, BootomStoryHeight, NumberOfLinesX, NumberOfLinesY, SpacingX, SpacingY);

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
    }
}
