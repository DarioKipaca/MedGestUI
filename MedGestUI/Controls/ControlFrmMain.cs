using Guna.UI2.WinForms;
using MedGestUI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedGestUI.Controls
{
    internal class ControlFrmMain
    {
        private frmMain _frmMainview;
        private Guna2Button _ButtonStart;
        private Panel _PanelConteiner;
        public ControlFrmMain(frmMain view, Panel Conteiner)
        {
            _frmMainview = view;
            _ButtonStart = _frmMainview.BtnDashboard;
            _ButtonStart.Tag = true;

            _frmMainview.BtnDashboard.Click += Buttonchecked;
            _frmMainview.BtnAppointment.Click += Buttonchecked;
            _frmMainview.BtnPatient.Click += Buttonchecked;
            _frmMainview.BtnReports.Click += Buttonchecked;
            _frmMainview.BtnDoctors.Click += Buttonchecked;
            _frmMainview.BtnSettings.Click += Buttonchecked;

            _PanelConteiner = Conteiner;

            _frmMainview.BtnDashboard.Click += BtnDashboard_Click;
            _frmMainview.BtnAppointment.Click += BtnAppointment_Click;
            _frmMainview.BtnPatient.Click += BtnPatient_Click;
            _frmMainview.BtnReports.Click += BtnReports_Click;


            //start dashboard

            Openforminconteiner(new frmDashboard());
        }

        private void BtnReports_Click(object? sender, EventArgs e)
        {
            Openforminconteiner(new frmReports());
        }

        private void BtnPatient_Click(object? sender, EventArgs e)
        {
            Openforminconteiner(new frmPatient());
        }

        private void BtnAppointment_Click(object? sender, EventArgs e)
        {
           Openforminconteiner(new frmAppointment());
        }

        private void BtnDashboard_Click(object? sender, EventArgs e)
        {
            Openforminconteiner(new frmDashboard());
        }

        public void Buttonchecked(object? sender, EventArgs e)
        {
            Guna2Button buttonClicked = (Guna2Button)sender;

            if (buttonClicked == null || buttonClicked.Name == _ButtonStart.Name)
                return;

            _ButtonStart.Checked = false;
            _ButtonStart.Tag = false;
            buttonClicked.Checked = true;
            buttonClicked.Tag = true;
            _ButtonStart =buttonClicked;
        }



        private void Openforminconteiner(Form formforopen)
        {
            if (_PanelConteiner.Controls.Count > 0)
            {
                Form Temp = (Form)_PanelConteiner.Controls[0];
                Temp.Close();
            }

            formforopen.TopLevel = false;
            formforopen.FormBorderStyle = FormBorderStyle.None;
            formforopen.Dock = DockStyle.Fill;
            _PanelConteiner.Controls.Add(formforopen);
            formforopen.Show();
        }
    }
}
