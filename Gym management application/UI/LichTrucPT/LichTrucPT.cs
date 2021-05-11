using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gym_management_appication.Database.LichTrucPT;

namespace Gym_management_appication.UI.LichTrucPT
{
    public partial class LichTrucPT : Form
    {
        DataTable dataTable = new DataTable();
        public LichTrucPT()
        {
            InitializeComponent();           
            LoadLichTrucPT();
            resolveData();

        }
        public void LoadLichTrucPT() {   
            dataTable = new LichTrucPTModel().GetData("Select * from PTSchedule");
        }
        void resolveData() {
            for (int i = 0; i < dataTable.Rows.Count; i++) {
                Label lb = new Label();
                lb.Text = dataTable.Rows[i][1].ToString();
                lb.Font = new Font("Microsoft Sans Serif", 8);
                lb.AutoSize = true;
                lb.BackColor = Color.FromArgb(254, 129, 118);              
                switch (dataTable.Rows[i][2]) {
                    case 2:
                        switch (dataTable.Rows[i][3]) {
                            case 1:
                                panel21.Controls.Add(lb);
                                break;
                            case 2:
                                panel22.Controls.Add(lb);
                                break;
                            case 3:
                                panel23.Controls.Add(lb);
                                break;
                        }
                        break;
                    case 3:
                        switch (dataTable.Rows[i][3])
                        {
                            case 1:
                                panel31.Controls.Add(lb);
                                break;
                            case 2:
                                panel32.Controls.Add(lb);
                                break;
                            case 3:
                                panel33.Controls.Add(lb);
                                break;
                        }
                        break;
                    case 4:
                        switch (dataTable.Rows[i][3])
                        {
                            case 1:
                                panel41.Controls.Add(lb);
                                break;
                            case 2:
                                panel42.Controls.Add(lb);
                                break;
                            case 3:
                                panel43.Controls.Add(lb);
                                break;
                        }
                        break;
                    case 5:
                        switch (dataTable.Rows[i][3])
                        {
                            case 1:
                                panel51.Controls.Add(lb);
                                break;
                            case 2:
                                panel52.Controls.Add(lb);
                                break;
                            case 3:
                                panel53.Controls.Add(lb);
                                break;
                        }
                        break;
                    case 6:
                        switch (dataTable.Rows[i][3])
                        {
                            case 1:
                                panel61.Controls.Add(lb);
                                break;
                            case 2:
                                panel62.Controls.Add(lb);
                                break;
                            case 3:
                                panel63.Controls.Add(lb);
                                break;
                        }
                        break;
                    case 7:
                        switch (dataTable.Rows[i][3])
                        {
                            case 1:
                                panel71.Controls.Add(lb);
                                break;
                            case 2:
                                panel72.Controls.Add(lb);
                                break;
                            case 3:
                                panel73.Controls.Add(lb);
                                break;
                        }
                        break;
                   

                }
            }

        }
    }
}
