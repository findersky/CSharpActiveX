using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Permissions;
using System.Runtime.InteropServices;

namespace CSharpActiveX
{
    [PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")]
    [Guid("7E7A2513-1DEA-4949-BD97-B731726BF2A8")]
    [ProgId("CSharpActiveX.ImageLoader")]
    public class ImageLoader:IObjectSafety,IPageExecuteJavaScriptEvents
    {
        #region  IObjectSafety
        public void GetInterfacceSafyOptions(int riid, out int pdwSupportedOptions, out int pdwEnabledOptions)
        {
            pdwEnabledOptions = 2;
            pdwSupportedOptions = 1;
        }

        public void SetInterfaceSafetyOptions(int riid, int dwOptionsSetMask, int dwEnabledOptions)
        {
            //throw new NotImplementedException();
        }
        #endregion

        public object CompletedCallBack
        {
            get;
            set;
        }
    }
}
