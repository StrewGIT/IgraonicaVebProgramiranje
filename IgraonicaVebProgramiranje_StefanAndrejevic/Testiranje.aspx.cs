using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IgraonicaVebProgramiranje_StefanAndrejevic
{
    public partial class Testiranje : System.Web.UI.Page
    {
        Konekcija db = new Konekcija();

        private void RunTest(Func<int> dbMethod, string actionName)
        {
            try
            {
                int result = dbMethod();
                if (result == 0 || result == 1)
                    lblGlobalStatus.Text = $"{actionName} completed.";
                else
                    lblGlobalStatus.Text = $"SQL ERROR: {actionName} returned error code {result}.";
            }
            catch (Exception ex)
            {
                lblGlobalStatus.Text = $"CRITICAL ERROR in {actionName}: {ex.Message}";
            }
        }

        // --- TIP MESTA ---
        protected void btnTipInsert_Click(object sender, EventArgs e) =>
            RunTest(() => db.UnosTipaMesta(txtTipNaziv.Text, int.Parse(txtTipCena.Text)), "Tip Mesta Insert");

        protected void btnTipUpdate_Click(object sender, EventArgs e) =>
            RunTest(() => db.IzmenaTipaMesta(int.Parse(txtTipId.Text), int.Parse(txtTipCena.Text)), "Tip Mesta Update");

        protected void btnTipDelete_Click(object sender, EventArgs e) =>
            RunTest(() => db.BrisanjeTipaMesta(int.Parse(txtTipId.Text)), "Tip Mesta Delete");

        // --- MESTO ---
        protected void btnMestoInsert_Click(object sender, EventArgs e) =>
            RunTest(() => db.UnosMesta(int.Parse(txtMestoTipId.Text)), "Mesto Insert");

        protected void btnMestoDelete_Click(object sender, EventArgs e) =>
            RunTest(() => db.BrisanjeMesta(int.Parse(txtMestoId.Text)), "Mesto Delete");

        // --- RADNI DAN ---
        protected void btnDanInsert_Click(object sender, EventArgs e) =>
            RunTest(() => db.UnosRadnogDana(DateTime.Parse(txtDanDatum.Text), TimeSpan.Parse(txtDanPocetak.Text), TimeSpan.Parse(txtDanKraj.Text), TimeSpan.Parse(txtDanInterval.Text)), "Radni Dan Insert");

        protected void btnDanUpdate_Click(object sender, EventArgs e) =>
            RunTest(() => db.IzmenaRadnogDana(int.Parse(txtDanId.Text), TimeSpan.Parse(txtDanPocetak.Text), TimeSpan.Parse(txtDanKraj.Text), TimeSpan.Parse(txtDanInterval.Text)), "Radni Dan Update");

        protected void btnDanDelete_Click(object sender, EventArgs e) =>
            RunTest(() => db.BrisanjeRadnogDana(int.Parse(txtDanId.Text)), "Radni Dan Delete");

        // --- REZERVACIJA ---
        protected void btnRezInsert_Click(object sender, EventArgs e) =>
            RunTest(() => db.UnosRezervacije(int.Parse(txtRezKorId.Text), int.Parse(txtRezDanId.Text), TimeSpan.Parse(txtRezPocetak.Text), TimeSpan.Parse(txtRezKraj.Text), int.Parse(txtRezMestoId.Text)), "Rezervacija Insert");

        protected void btnRezUpdate_Click(object sender, EventArgs e) =>
            RunTest(() => db.IzmenaRezervacije(int.Parse(txtRezId.Text), int.Parse(txtRezKorId.Text), int.Parse(txtRezDanId.Text), TimeSpan.Parse(txtRezPocetak.Text), TimeSpan.Parse(txtRezKraj.Text), int.Parse(txtRezMestoId.Text)), "Rezervacija Update");

        protected void btnRezDelete_Click(object sender, EventArgs e) =>
            RunTest(() => db.BrisanjeRezervacije(int.Parse(txtRezId.Text)), "Rezervacija Delete");

        protected void btnRezGen_Click(object sender, EventArgs e) =>
            RunTest(() => db.GenerisiTermineZaMesto(int.Parse(txtRezDanId.Text), int.Parse(txtRezMestoId.Text)), "Automatic Loop Generation");
    }
}
