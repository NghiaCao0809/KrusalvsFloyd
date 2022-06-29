using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanLTDT
{
    class NodeK
    {
        #region Members
        int nName;
        public int nRank;
        public NodeK vRoot;
        public System.Drawing.Point pPosition;
        #endregion

        #region Properties
        public int Name
        {
            get
            {
                return nName;
            }
        }
        #endregion

        public NodeK(int nName, System.Drawing.Point pPosition)
        {
            this.nName = nName;
            nRank = 0;
            this.vRoot = this;
            this.pPosition = pPosition;
        }

        #region Methods
        internal NodeK GetRoot()
        {
            if (this.vRoot != this)// Xét đỉnh đang chọn có phải là gốc 
            {
                this.vRoot = this.vRoot.GetRoot();// Nếu không thì xét đỉnh parent
            }
            return this.vRoot;
        }

        internal static void Join(NodeK vRoot1, NodeK vRoot2)
        {

            if (vRoot2.nRank < vRoot1.nRank)//i Xét giá trị của Root2 có nhỏ hơn Root1
            {
                vRoot2.vRoot = vRoot1;//có thì root1 là đỉnh cha của root2
            }
            else //nếu giá trị root 2 lớn hoặc bằng root1
            {
                vRoot1.vRoot = vRoot2;// biến Root2 thành dỉnh cha
                if (vRoot1.nRank == vRoot2.nRank)//xét giá trị của = nhau ko 
                {
                    vRoot1.nRank++;
                }
            }
        }
        #endregion
    }
}
