<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TicketViewer.WebForm1"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="errorMessageLabel" runat="server"></asp:Label>
        </div>
    <div>
        <asp:GridView ID="ticketGridView" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" autogeneratecolumns="false" AllowPaging="true" AutoGenerateSelectButton="True">
            <Columns>
                <asp:BoundField DataField="id"  HeaderText="Ticket ID"/>
                <asp:BoundField DataField="subject" HeaderText="Subject"/>
                <asp:BoundField DataField="requester_id" HeaderText="Requester ID"/>
                <asp:BoundField DataField="status" HeaderText="Status"/>
                <asp:BoundField DataField="priority" HeaderText="Priority" />

            </Columns>
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <table style="width:100%;" id="singleTicketView" runat="server">
            <tr>
                <td class="auto-style1" id="subjectLabel" runat="server" style="font-weight:bold;width:10%"></td>
                <td class="auto-style1" id="ticketSubject" runat="server" style="font-weight:bold;font-size:large"></td>
            </tr>
            <tr>
                <td id="requestorIdLabel" runat="server" style="font-weight:bold;">&nbsp;</td>
                <td id="requestorId" runat="server">&nbsp;</td>
            </tr>
            <tr>
                <td runat="server" id="ticketDescriptionLabel" style="font-weight:bold;">&nbsp;</td>
                <td rowspan="2" id="ticketDescription" runat="server" width="63%">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>                
            </tr>
            <tr>
                <td runat="server" id="statusLabel"></td>
                <td runat="server" id="statusStatus"></td>
            </tr>
            <tr>
                <td runat="server" id="priorityLabal"></td>
                <td runat="server" id="priorityStatus"></td>
            </tr>
        </table>
        
    </div>       
    </form>

</body>
</html>
