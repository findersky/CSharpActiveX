using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace CSharpActiveX
{
    [Guid("a5ee0756-0cbb-4cf1-9a9c-509407d5eed6")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface IPageExecuteJavaScriptEvents
    {
        
        [DispId(1)]
        object CompletedCallBack { get; set; }
    }
}
