using System;
using System.Drawing;
using System.Windows.Forms;

class xToggleButton : Panel
{
    protected Label _button1;
    protected Label _button2;
    protected bool _state = true;

    public event EventHandler<ToggleEventArgs> ToggleClick;

    public xToggleButton()
    {
        _button1 = new Label();
        _button1.Text = "On";
        _button1.BackColor = Color.LimeGreen;
        _button1.Height = this.Height;
        _button1.Width = this.Width / 2;
        _button1.TextAlign = ContentAlignment.MiddleCenter;
        _button1.Click += new EventHandler(_button_Click);
        _button1.Tag = "On";

        _button2 = new Label();
        _button2.Text = "";
        _button2.BackColor = Color.Gray;
        _button2.Left = _button1.Width;
        _button2.Height = this.Height;
        _button2.Width = this.Width / 2;
        _button2.TextAlign = ContentAlignment.MiddleCenter;
        _button2.Click += new EventHandler(_button_Click);
        _button2.Tag = "Off";
        _button2.Enabled = false;

        this.Font = new Font("Segoe UI", 8);
        this.ForeColor = Color.White;
        this.Controls.Add(_button1);
        this.Controls.Add(_button2);
    }

    void _button_Click(object sender, EventArgs e)
    {
        Label button = (Label)sender;
        string state = button.Tag.ToString();

        ToggleEventArgs toggleEvent = new ToggleEventArgs();

        if (state == "On")
        {
            this.OffState();
            toggleEvent.IsOn = false;
            _state = false;
        }
        else
        {
            this.OnState();
            toggleEvent.IsOn = true;
            _state = true;
        }
        if (this.ToggleClick != null)
        {
            this.ToggleClick(this, toggleEvent);
        }
    }

    public bool SetButtonState
    {
        set
        {
            if (value)
            {
                this.OnState();
            }
            else
            {
                this.OffState();
            }
            _state = value;
        }
    }

    public bool ButtonState
    {
        get
        {
            return _state;
        }
    }

    protected void OffState()
    {
        _button1.BackColor = Color.LightGray;
        _button1.Text = "";
        _button1.Enabled = false;
        _button2.BackColor = Color.Gray;
        _button2.Text = "Off";
        _button2.Enabled = true;
    }

    protected void OnState()
    {
        _button1.BackColor = Color.LimeGreen;
        _button1.Text = "On";
        _button1.Enabled = true;
        _button2.BackColor = Color.Gray;
        _button2.Text = "";
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
        public bool IsOn
        {
            set;
            get;
        }
    }
}
