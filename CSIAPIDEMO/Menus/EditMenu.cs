using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIAPIDEMO.Menus
{
   public class EditMenu
    {
        private ETABSv1.cSapModel mySapModel;
        public EditMenu(ETABSv1.cSapModel cSap )
        {
            mySapModel = cSap;
        }

        public void ChangFrameCon()
        {
            try
            {

                 mySapModel.EditFrame.ChangeConnectivity("474", "168", "176");
            }
            catch { }
        }
    }
}
