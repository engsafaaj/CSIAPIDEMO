using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIAPIDEMO.Menus
{
   public class FileMenu
    {
        private ETABSv1.cSapModel mySapModel;
        private int ret;
        private bool state;

        public FileMenu(ETABSv1.cSapModel cSap)
        {
            mySapModel = cSap;
        }


        public bool OpenFile(string FileName)
        {
            try
            {
                //Get a reference to cSapModel to access all API classes and functions
                mySapModel = default(ETABSv1.cSapModel);

                // Open File (EDB File)
                ret = mySapModel.File.OpenFile(FileName);
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
            return state;
        }
        // Save File
        public bool SaveFile(string FileName)
        {
            try
            {
                //Get a reference to cSapModel to access all API classes and functions
                mySapModel = default(ETABSv1.cSapModel);


                // Open File (EDB File)
                ret = mySapModel.File.Save(FileName);
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
            return state;
        }

    }
}
