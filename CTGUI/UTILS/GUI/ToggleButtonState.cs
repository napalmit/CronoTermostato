using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CTGUI.UTILS.GUI
{
    public partial class ToggleButtonState : UserControl
    {
        protected Label _button1;
        protected Label _button2;

        private int STATO = StatoSistema.AUTO;

        public event EventHandler<ToggleEventArgs> ToggleClick;

        public ToggleButtonState()
        {
            this.Font = new Font("Roboto", 35);

            _button1 = new Label();
            _button1.Font = this.Font;
            _button1.Text = "AUTO";
            _button1.BackColor = Color.LimeGreen;
            _button1.Height = this.Height;
            _button1.Width = this.Width / 2;
            _button1.TextAlign = ContentAlignment.MiddleCenter;
            _button1.Click += new EventHandler(_button_Click);
            _button1.Tag = "AUTO";
            _button1.Enabled = false;

            _button2 = new Label();
            _button2.Font = this.Font;
            _button2.Text = "MANUAL";
            _button2.BackColor = Color.Gray;
            _button2.Left = _button1.Width;
            _button2.Height = this.Height;
            _button2.Width = this.Width / 2;
            _button2.TextAlign = ContentAlignment.MiddleCenter;
            _button2.Click += new EventHandler(_button_Click);
            _button2.Tag = "MANUAL";
            _button2.Enabled = true;

            
            this.ForeColor = Color.White;
            this.BackColor = Color.Transparent;
            this.Controls.Add(_button1);
            this.Controls.Add(_button2);
        }

        void _button_Click(object sender, EventArgs e)
        {
            Label button = (Label)sender;
            string state = button.Tag.ToString();

            ToggleEventArgs toggleEvent = new ToggleEventArgs();

            if (STATO == StatoSistema.AUTO)
            {
                // da auto a manual
                this.ManualState();
                STATO = StatoSistema.MANUAL;
            }
            else if (STATO == StatoSistema.MANUAL)
            {
                // da manual a auto
                this.AutoState();                
                STATO = StatoSistema.AUTO;
            }

            toggleEvent.Stato = STATO;

            if (this.ToggleClick != null)
            {
                this.ToggleClick(this, toggleEvent);
            }
        }

        public void SetStatoSistema(int statoSistema)
        {
            if (statoSistema == StatoSistema.AUTO)
            {
                // da auto a manual
                this.AutoState();
                //toggleEvent.IsOn = false;
                STATO = StatoSistema.AUTO;
            }
            else if (statoSistema == StatoSistema.MANUAL)
            {
                // da manual a auto
                this.ManualState();
                //toggleEvent.IsOn = false;
                STATO = StatoSistema.MANUAL;
            }
        }

        protected void AutoState()
        {
            _button1.BackColor = Color.Gray;
            _button1.Text = "AUTO";
            _button1.Enabled = false;

            _button2.BackColor = Color.LimeGreen;
            _button2.Text = "MANUAL";
            _button2.Enabled = true;
        }

        protected void ManualState()
        {
            _button1.BackColor = Color.LimeGreen;
            _button1.Text = "AUTO";
            _button1.Enabled = true;

            _button2.BackColor = Color.Gray;
            _button2.Text = "MANUAL";
            _button2.Enabled = false;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            _button1.Height = this.Height;
            _button1.Width = this.Width / 2;

            _button2.Height = this.Height;
            _button2.Width = this.Width / 2;
            _button2.Left = _button1.Width;
        }

        public class ToggleEventArgs : EventArgs
        {
            public int Stato
            {
                set;
                get;
            }
        }
    }

}

