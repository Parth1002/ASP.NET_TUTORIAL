﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs"
Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
   <title>Using Partioning Operators</title>
	</head>
<body>
	<form id="form1" runat="server">
		<div id="header">
			<h1>
				C# 2010 Black Book
			</h1>
		</div>
				<div id="content">
			<div class ="itemContent">
			Displays data in Listbox by using partioning operators
			<asp:ListBox ID="ListBox1" runat="server" Height="211px" 
		style="margin-left: 199px; margin-top: 91px" Width="209px"></asp:ListBox>
			<br />
			<asp:Button ID="Button1" runat="server" style="margin-left: 211px" 
			Text="Display" Width="108px" onclick="Button1_Click" />
			</div>
					</div>
	</div>
	</form>
</body>
</html>
