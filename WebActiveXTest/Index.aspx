<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebActiveXTest.Index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        var activeObject = null;
        window.onload = function () {
            activeObject = document.getElementById("ThismyCode");
            //activeObject = new ActiveXObject("ImageLoader");
            activeObject.CompletedCallBack = function (message) {
                alert(message);
            };
        };
        function CallMethod() {
            debugger;
            activeObject.HelloWorld("Hello World");
        
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="displayArea">
        <input id="btnClick" type="button" value="test" onclick="CallMethod();"/>
    </div>
    <div>
       <object id="ThismyCode" name="ThismyCode"  classid="clsid:{7E7A2513-1DEA-4949-BD97-B731726BF2A8}"></object>
    </div>
    </form>
</body>
</html>
