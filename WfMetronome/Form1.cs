using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Timers;
using System.Threading;

namespace WfMetronome
{
    public partial class Form1 : Form
    {
        private int _ts;
        private double _tempo;
        private int _ppqn;

        private System.Timers.Timer _timer;
        private int _current_ppqn;
        private double _elapsed;
        private int _bar;

        private delegate void SafeCallDelegate(Label label, string text);
        private Thread thread2 = null;

        public Form1()
        {
            InitializeComponent();
            _ts = 4;
            _tempo = 60.0d;
            _ppqn = 24;

            _timer = new System.Timers.Timer();
            _timer.Interval = getInterval(4, 60.0d, 24);
            _timer.Enabled = false;
            _timer.AutoReset = true;
            _timer.Elapsed += OnTimedEvent;
            _current_ppqn = 0;
            _elapsed = 0.0d;
            _bar = 0;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ppqn = Convert.ToInt32(ppqn.SelectedItem); ;
            updateLabels(_ts, _tempo, _ppqn);

        }

        private void signature_SelectedIndexChanged(object sender, EventArgs e)
        {
            String tmp = Convert.ToString(signature.SelectedItem);
            switch (tmp)
            {
                case "4:4":
                    _ts = 4;
                    break;
                case "2:4":
                    _ts = 2;
                    break;
                case "3:4":
                    _ts = 3;
                    break;
                default:
                    _ts = 4;
                    break;
            }
            updateLabels(_ts, _tempo, _ppqn);

        }

        private void tempo_ValueChanged(object sender, EventArgs e)
        {
            _tempo = Convert.ToDouble(tempo.Value);
            updateLabels(_ts, _tempo, _ppqn);
        }

        private void updateLabels(int ts, double tempo, int ppqn)
        {
            duration.Text = Math.Round(getDuration(ts, tempo), 4).ToString() + "s";
            total.Text = getTicks(ts, ppqn).ToString();
            interval.Text = getInterval(ts, tempo, ppqn).ToString();
        }

        private double getDuration(int ts, double tempo)
        {
            return (double)((60 / _tempo) * _ts);
        }

        private int getTicks(int ts, int ppqn)
        {
            return ts * ppqn;
        }

        private double getInterval(int ts, double tempo, int ppqn)
        {
            return (double)Math.Round((getDuration(ts, tempo) / getTicks(ts, ppqn) * 1000), 4);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(! _timer.Enabled)
            {
                _elapsed = 0.0d;
                updateLabels(_ts, _tempo, _ppqn);
                _timer.Interval = getInterval(_ts, _tempo, _ppqn);
                button1.Text = "Stop";
                _timer.Enabled = true;
               
            } else
            {
                button1.Text = "Start";
                _timer.Enabled = false;
            }
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if(_current_ppqn < getTicks(_ts, _ppqn))
            {
                if (_current_ppqn % _ppqn == 0)
                {
                    _bar += 1;
                } else
                {
                }
                _current_ppqn += 1;
                _elapsed += _timer.Interval;
                
            } else
            {
                _current_ppqn = 0;
                _bar = 0;
            }
            thread2 = new Thread(new ThreadStart(setLabel));
            thread2.Start();
        }

        private void updateLabelSafe(Label label, string text)
        {
            if (label.InvokeRequired)
            {
                var d = new SafeCallDelegate(updateLabelSafe);
                label.Invoke(d, new object[] { label, text });
            }
            else
            {
                label.Text = text;
            }
        }

        private void setLabel()
        {
            updateLabelSafe(label6, _current_ppqn.ToString());
            if (_current_ppqn % _ppqn == 0)
            {
                updateLabelSafe(label8, (_elapsed / 1000).ToString());
                drawPulse(System.Drawing.Color.Green);
                System.Media.SystemSounds.Beep.Play();
            } else
            {
                drawPulse(System.Drawing.Color.YellowGreen);
            }
            if(_bar > 0) { 
               updateLabelSafe(label10, _bar.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void drawPulse(System.Drawing.Color color) {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(color);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(20, 180, 40, 40));
            myBrush.Dispose();
            formGraphics.Dispose();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            _elapsed = 0.0d;
            _ts = 4;
            _tempo = 60.0d;
            _ppqn = 24;
            updateLabels(_ts, _tempo, _ppqn);
            _current_ppqn = 0;
            _bar = 0;
            updateLabelSafe(label10, 0.ToString());
            updateLabelSafe(label6, 0.ToString());
            updateLabelSafe(label8, "");

        }
    }
}
