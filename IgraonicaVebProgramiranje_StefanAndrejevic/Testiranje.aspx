<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Testiranje.aspx.cs" Inherits="IgraonicaVebProgramiranje_StefanAndrejevic.Testiranje" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Igraonica Full Logic Test</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="status-box">
                <asp:Label ID="lblGlobalStatus" runat="server"></asp:Label>
            </div>

            <div class="section">
                <h3>Tip Mesta:</h3>
                <div class="grid-row">
                    <label>ID:</label> <asp:TextBox ID="txtTipId" runat="server" Width="40"></asp:TextBox>
                    <label>Naziv:</label> <asp:TextBox ID="txtTipNaziv" runat="server"></asp:TextBox>
                    <label>Cena:</label> <asp:TextBox ID="txtTipCena" runat="server"></asp:TextBox>
                </div>
                <div class="grid-row">
                    <asp:Button ID="btnTipInsert" runat="server" Text="Unos" CssClass="btn" OnClick="btnTipInsert_Click" />
                    <asp:Button ID="btnTipUpdate" runat="server" Text="Izmena" CssClass="btn btn-update" OnClick="btnTipUpdate_Click" />
                    <asp:Button ID="btnTipDelete" runat="server" Text="Brisanje" CssClass="btn btn-delete" OnClick="btnTipDelete_Click" />
                </div>
            </div>

            <div class="section">
                <h3>Mesto: </h3>
                <div class="grid-row">
                    <label>ID:</label> <asp:TextBox ID="txtMestoId" runat="server" Width="40"></asp:TextBox>
                    <label>Tip ID:</label> <asp:TextBox ID="txtMestoTipId" runat="server" Width="40"></asp:TextBox>
                    <asp:Button ID="btnMestoInsert" runat="server" Text="Unos" CssClass="btn" OnClick="btnMestoInsert_Click" />
                    <asp:Button ID="btnMestoDelete" runat="server" Text="Brisanje" CssClass="btn btn-delete" OnClick="btnMestoDelete_Click" />
                </div>
            </div>

            <div class="section">
                <h3>Radni Dan: </h3>
                <div class="grid-row">
                    <label>ID:</label> <asp:TextBox ID="txtDanId" runat="server" Width="40"></asp:TextBox>
                    <label>Datum:</label> <asp:TextBox ID="txtDanDatum" runat="server" TextMode="Date"></asp:TextBox>
                    <label>Start:</label> <asp:TextBox ID="txtDanPocetak" runat="server" Width="60">08:00</asp:TextBox>
                    <label>End:</label> <asp:TextBox ID="txtDanKraj" runat="server" Width="60">16:00</asp:TextBox>
                    <label>Interval:</label> <asp:TextBox ID="txtDanInterval" runat="server" Width="60">01:00</asp:TextBox>
                </div>
                <div class="grid-row">
                    <asp:Button ID="btnDanInsert" runat="server" Text="Unos" CssClass="btn" OnClick="btnDanInsert_Click" />
                    <asp:Button ID="btnDanUpdate" runat="server" Text="Izmena" CssClass="btn btn-update" OnClick="btnDanUpdate_Click" />
                    <asp:Button ID="btnDanDelete" runat="server" Text="Brisanje" CssClass="btn btn-delete" OnClick="btnDanDelete_Click" />
                </div>
            </div>

            <div class="section">
                <h3>Rezervacija: </h3>
                <div class="grid-row">
                    <label>ID Rezervacije:</label> <asp:TextBox ID="txtRezId" runat="server" Width="40"></asp:TextBox>
                    <label>Korisnik ID:</label> <asp:TextBox ID="txtRezKorId" runat="server" Width="40"></asp:TextBox>
                </div>
                <div class="grid-row">
                    <label>Radni Dan ID:</label> <asp:TextBox ID="txtRezDanId" runat="server" Width="40"></asp:TextBox>
                    <label>Mesto ID:</label> <asp:TextBox ID="txtRezMestoId" runat="server" Width="40"></asp:TextBox>
                </div>
                <div class="grid-row">
                    <label>Vreme:</label> <asp:TextBox ID="txtRezPocetak" runat="server" Width="70">10:00</asp:TextBox> 
                    to <asp:TextBox ID="txtRezKraj" runat="server" Width="70">11:00</asp:TextBox>
                </div>
                <div class="grid-row">
                    <asp:Button ID="btnRezInsert" runat="server" Text="Unos" CssClass="btn" OnClick="btnRezInsert_Click" />
                    <asp:Button ID="btnRezUpdate" runat="server" Text="Izmena" CssClass="btn btn-update" OnClick="btnRezUpdate_Click" />
                    <asp:Button ID="btnRezDelete" runat="server" Text="Brisanje" CssClass="btn btn-delete" OnClick="btnRezDelete_Click" />
                    <asp:Button ID="btnRezGen" runat="server" Text="GENERISI SVE TERMINE ZA DATI RADNI DAN I MESTO" CssClass="btn" Style="background:#28a745;" OnClick="btnRezGen_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>