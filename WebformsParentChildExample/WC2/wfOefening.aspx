<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wfOefening.aspx.cs" Inherits="WC2.wfOefening" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridViewGames" runat="server" AutoGenerateColumns="False" DataKeyNames="GameId" DataSourceID="SqlDataSourceGames" EmptyDataText="There are no data records to display." Caption="Games" OnSelectedIndexChanged="GridViewGames_SelectedIndexChanged" AllowPaging="True" AllowSorting="True">
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="GameId" HeaderText="GameId" InsertVisible="False" ReadOnly="True" SortExpression="GameId" />
                    <asp:BoundField DataField="Description" HeaderText="Description" SortExpression="Description" />
                    <asp:BoundField DataField="Startdate" HeaderText="Startdate" SortExpression="Startdate" />
                    <asp:BoundField DataField="Enddate" HeaderText="Enddate" SortExpression="Enddate" />
                </Columns>
            </asp:GridView>
            </div>
            <div>
            <asp:SqlDataSource ID="SqlDataSourceGames" runat="server" ConnectionString="<%$ ConnectionStrings:VoorbeelddatabaseConnectionString1 %>" DeleteCommand="DELETE FROM [Game] WHERE [GameId] = @GameId" InsertCommand="INSERT INTO [Game] ([Description], [Startdate], [Enddate]) VALUES (@Description, @Startdate, @Enddate)" ProviderName="<%$ ConnectionStrings:VoorbeelddatabaseConnectionString1.ProviderName %>" SelectCommand="SELECT [GameId], [Description], [Startdate], [Enddate] FROM [Game]" UpdateCommand="UPDATE [Game] SET [Description] = @Description, [Startdate] = @Startdate, [Enddate] = @Enddate WHERE [GameId] = @GameId">
                <DeleteParameters>
                    <asp:Parameter Name="GameId" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="Description" Type="String" />
                    <asp:Parameter DbType="Date" Name="Startdate" />
                    <asp:Parameter DbType="Date" Name="Enddate" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="Description" Type="String" />
                    <asp:Parameter DbType="Date" Name="Startdate" />
                    <asp:Parameter DbType="Date" Name="Enddate" />
                    <asp:Parameter Name="GameId" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>
              <br />
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:VoorbeelddatabaseConnectionString1 %>" 
                    DeleteCommand="DELETE FROM [GameAccount] WHERE [id] = @id" 
                    InsertCommand="INSERT INTO [GameAccount] ([gameid], [accountid]) VALUES (@gameid, @accountid)" 
                    ProviderName="<%$ ConnectionStrings:VoorbeelddatabaseConnectionString1.ProviderName %>" 
                    SelectCommand="SELECT gameaccount.id, account.accountid, account.Email, account.FriendlyName FROM [GameAccount], account where gameaccount.accountid = account.accountid and gameid = @SelectedParentId" 
                    UpdateCommand="UPDATE [GameAccount] SET [gameid] = @gameid, [accountid] = @accountid WHERE [id] = @id">
                    <SelectParameters>
                        <asp:SessionParameter Name="SelectedParentId" SessionField="SelectedParentId" Type="Int32" />
                    </SelectParameters>
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="gameid" Type="Int32" />
                        <asp:Parameter Name="accountid" Type="Int32" />
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="gameid" Type="Int32" />
                        <asp:Parameter Name="accountid" Type="Int32" />
                        <asp:Parameter Name="id" Type="Int32" />
                    </UpdateParameters>
                </asp:SqlDataSource>

                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

            </div>
        <asp:GridView ID="GridViewSpelers" runat="server" AutoGenerateColumns="False" Caption="Spelers" DataKeyNames="id" DataSourceID="SqlDataSourceSpelers" EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:BoundField DataField="gameid" HeaderText="gameid" SortExpression="gameid" />
                <asp:BoundField DataField="accountid" HeaderText="accountid" SortExpression="accountid" />
                <asp:BoundField DataField="id" HeaderText="id" ReadOnly="True" SortExpression="id" InsertVisible="False" />
                <asp:BoundField DataField="FriendlyName" HeaderText="FriendlyName" SortExpression="FriendlyName" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSourceSpelers" runat="server" 
            ConnectionString="<%$ ConnectionStrings:VoorbeelddatabaseConnectionString1 %>" 
            DeleteCommand="DELETE FROM [GameAccount] WHERE [id] = @id" 
            InsertCommand="INSERT INTO [GameAccount] ([gameid], [accountid]) VALUES (@gameid, @accountid)" 
            ProviderName="<%$ ConnectionStrings:VoorbeelddatabaseConnectionString1.ProviderName %>" 
            SelectCommand="SELECT [gameid], gameaccount.[accountid], [id], account.FriendlyName, Account.Email FROM [GameAccount] join Account on GameAccount.accountid = Account.AccountId where gameid = @SelectedParentId" 
            UpdateCommand="UPDATE [GameAccount] SET [gameid] = @gameid, [accountid] = @accountid WHERE [id] = @id">
            <SelectParameters>
                <asp:SessionParameter Name="SelectedParentId" SessionField="SelectedParentId" Type="Int32" />
            </SelectParameters>
            <DeleteParameters>
                <asp:Parameter Name="id" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="gameid" Type="Int32" />
                <asp:Parameter Name="accountid" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="gameid" Type="Int32" />
                <asp:Parameter Name="accountid" Type="Int32" />
                <asp:Parameter Name="id" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <br />
        

  <div>

  </div>
  
        <div>

  </div>
  
    </form>
</body>
</html>
