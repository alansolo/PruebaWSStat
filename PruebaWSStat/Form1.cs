using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaWSStat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.SUtiFolioStat_PortTypeClient stat = new ServiceReference1.SUtiFolioStat_PortTypeClient();

            ServiceReference1.DBA_ConsultarStatsInput input = new ServiceReference1.DBA_ConsultarStatsInput();



            ServiceReference1.consultarFoliosStatRequest request = new ServiceReference1.consultarFoliosStatRequest();


            ServiceReference1.DBA_ConsultarStatsOutput[] resultado = stat.consultarFoliosStat(input);




            WebReference.SUtiFolioStatBindingQSService service = new WebReference.SUtiFolioStatBindingQSService();

            WebReference.DBA_ConsultarStatsInput inn = new WebReference.DBA_ConsultarStatsInput();

            WebReference.DBA_ConsultarStatsOutput[] res = service.consultarFoliosStat(inn);

            List<string> listaUsuario = res.Select(n => n.assigned_user).Distinct().ToList();

            List<AnalisisStat> listaAnalisisStat = new List<AnalisisStat>();


            listaUsuario.ForEach(n =>
            {
                AnalisisStat analisisStat = new AnalisisStat();

                analisisStat.usuario = n;
                analisisStat.contador = res.Where(m => m.assigned_user == n).Count();

                listaAnalisisStat.Add(analisisStat);

            });

            listaAnalisisStat = listaAnalisisStat.OrderByDescending(n => n.contador).ToList();

        }
    }
}
