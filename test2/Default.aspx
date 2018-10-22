<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" MasterPageFile="~/MasterPage.master"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="js/jquery-1.7.1.min.js"></script>
    <script type="text/javascript" src="js/jquery-ui-1.8.17.custom.min.js"></script>
    <link type="text/css" href="css/jquery-ui-1.8.17.custom.css" rel="stylesheet" />
    
    

    <script type="text/javascript" src="js/dateValidation.js"></script>
    <script type="text/javascript" language="javascript" >
    
    
    // loads jquery calendar
    $(function () {
   
        var dates = $("#ctl00_body_txtDate").datepicker({
                    dateFormat: "dd/mm/yy",
                    changeMonth: true,
                    numberOfMonths: 2,    
                    showCurrentAtPos: 1,              
                    onSelect: function (selectedDate) {
                        var option = this.id == "ctl00_body_txtDate" ? "minDate" : "maxDate",
        					instance = $(this).data("datepicker"),
        					date = $.datepicker.parseDate(
        						instance.settings.dateFormat ||
        						$.datepicker._defaults.dateFormat,
        						selectedDate, instance.settings);
                        dates.not(this).datepicker("option", option, date);
                    }
                });
                });                

  </script>  

    
</asp:Content>


<asp:Content ID="content2" ContentPlaceHolderID="body" Runat="Server">
    <div id = "main">
        <%-- <asp:textbox runat ="server" ID = "txtDate" Text = "Enter Date"></asp:textbox> 
         <asp:Button runat ="server" ID ="btnGo" Text ="Go" OnClick="btnGo_Click"  /> --%>
        <br />
        <br />
        
        <%-- <asp:textbox runat ="server" ID = "Textbox2" Text = "Random Number"></asp:textbox>
         <asp:Button runat ="server" ID ="Button1" Text ="Go" OnClick="Button1_Click" /> --%>
    
    </div>
    
    
    <div id ="bottom">
    <asp:Label ID ="lblMessage" runat ="server" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button runat ="server" ID ="btnLottoNumbers" Text ="Lotto" OnClick="btnLottoNumbers_Click" /><br />
        <br />
        
        <asp:Label ID ="lblMsg2" runat ="server" />
        
    </div>
</asp:Content>