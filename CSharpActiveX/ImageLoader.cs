using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Permissions;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Windows.Forms;


namespace CSharpActiveX
{
    [PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")]
    //[ClassInterface(ClassInterfaceType.AutoDual), ComSourceInterfaces(typeof(IPageExecuteJavaScriptEvents))]
    [ClassInterface(ClassInterfaceType.None)]
    [Guid("7E7A2513-1DEA-4949-BD97-B731726BF2A8")]
    [ProgId("CSharpActiveX.ImageLoader")]
    public class ImageLoader : UserControl, IObjectSafety, IPageExecuteJavaScriptEvents
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
        public void HelloWorld(string message)
        {
            ExecMethodCompleted(new object[]{message});
        }

        private void ExecMethodCompleted(object[] args)
        {

            if (CompletedCallBack == null ||
                    (!CompletedCallBack.GetType().IsCOMObject))
                {
                    return;
                }

                try
                {
                    args = args ?? new object[] { };
                    CompletedCallBack
                        .GetType()
                        .InvokeMember
                        ("",
                         BindingFlags.InvokeMethod,
                         null,
                         CompletedCallBack,
                         args);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.EventLog.WriteEntry("ImageLoader", "error:" + ex.Message + "__" + ex.Source + "__" + ex.StackTrace, System.Diagnostics.EventLogEntryType.Error);
                }
            }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ImageLoader
            // 
            this.Name = "ImageLoader";
            this.Size = new System.Drawing.Size(0, 0);
            //this.Width = 0;
            //this.Height = 0;
            this.ResumeLayout(false);

        }
        

    }
}
