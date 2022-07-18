using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSIAPIDEMO.Menus
{
   public class SlecteMenu
    {
        private int NumberItems;
        private int[] ObjectType;
        private string[] ObjectName;
        private ETABSv1.cSapModel mySapModel;
        private int ret;
        private string ObjectSlectedText;
        public SlecteMenu(ETABSv1.cSapModel cSap )
        {
            mySapModel = cSap;
        }

        public void GetSelctedItems()
        {
           mySapModel.SelectObj.GetSelected(ref NumberItems, ref ObjectType, ref ObjectName);
        }
        
        public string SetSlectedObjectToView()
        {
            if (ObjectType != null)
            {
                var point = ObjectType.Where(x => x == 1).ToArray().Count().ToString();
                var frame = ObjectType.Where(x => x == 2).ToArray().Count().ToString();
                var cable = ObjectType.Where(x => x == 3).ToArray().Count().ToString();
                var tendon = ObjectType.Where(x => x == 4).ToArray().Count().ToString();
                var area = ObjectType.Where(x => x == 5).ToArray().Count().ToString();
                var soild = ObjectType.Where(x => x == 6).ToArray().Count().ToString();
                var link = ObjectType.Where(x => x == 7).ToArray().Count().ToString();
                ObjectSlectedText = "";
                if (point != "0")
                {
                    ObjectSlectedText = ObjectSlectedText+ point + " Points,";
                }
                if (frame != "0")
                {
                    ObjectSlectedText = ObjectSlectedText + frame + " Frames,";
                }
                if (cable != "0")
                {
                    ObjectSlectedText = ObjectSlectedText + cable + " Cables,";
                }
                if (tendon != "0")
                {
                    ObjectSlectedText = ObjectSlectedText + tendon + " Tendon,";
                }
                if (area != "0")
                {
                    ObjectSlectedText = ObjectSlectedText + area + " Area,";
                }
                if (soild != "0")
                {
                    ObjectSlectedText = ObjectSlectedText + soild + " Soild,";
                }
                if (link != "0")
                {
                    ObjectSlectedText = ObjectSlectedText + link + " Link";
                }
                ObjectSlectedText= ObjectSlectedText + " are Selected";
            }
            else
            {
                ObjectSlectedText = "Ready";

            }
            return ObjectSlectedText;
        }
      
        public string[] GetObjectName()
        {
            return ObjectName;
        }
    }
}
