using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Family_Schedule
{
    public partial class Calendar : Form
    {
        private List<string> _dayOfEvent { get; set; }
        private List<string> _description { get; set; }
        private List<int> _block { get; set; }
        private string[] _colors { get; set; }
       
        public Calendar()
        {
            InitializeComponent();
        }

        public Calendar(List<string> dayOfEvent, List<string> description, 
            List<int> block, string[] colors)
        {
            InitializeComponent();
            _dayOfEvent = dayOfEvent;
            _description = description;
            _block = block;
            _colors = colors;
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            //create 2 lists of labels
            var labelDate = new List<Label> { labelDate1, labelDate2, labelDate3,
                labelDate4, labelDate5 };
            var labelCal = new List<Label> { labelCal1, labelCal2, labelCal3,
                labelCal4, labelCal5 };

            //clearing all text out of the labels
            foreach (var l in labelDate)
            {
                l.Text = "";
            }

            foreach (var l in labelCal)
            {
                l.Text = "";
            }

            int i = 0;
            string[] d = _dayOfEvent.ToArray();           

            foreach (var l in labelDate)
            {
                //break out of loop if there are no more dates to display
                if(i >= d.Length)
                {
                    break;
                }
                l.Text = d[i];              
                i++;
            }
            
            i = 0;
            string [] title = _description.ToArray();
            int[] time = _block.ToArray();
            foreach (var l in labelCal)
            {
                //break out of loop if there are no more events to display
                if (i >= title.Length)
                {
                    break;
                }

                else if (_colors[i] == "pink")
                {
                    l.ForeColor = Color.DeepPink;
                    l.Text = title[i] + " at " + time[i].ToString();
                }

                else if (_colors[i] == "blue")
                {
                    l.ForeColor = Color.Blue;
                    l.Text = title[i] + " at " + time[i].ToString();
                }

                else if (_colors[i] == "green")
                {
                    l.ForeColor = Color.Green;
                    l.Text = title[i] + " at " + time[i].ToString();
                }

                else if (_colors[i] == "purple")
                {
                    l.ForeColor = Color.Purple;
                    l.Text = title[i] + " at " + time[i].ToString();
                }

                else if (_colors[i] == "red")
                {
                    l.ForeColor = Color.Red;
                    l.Text = title[i] + " at " + time[i].ToString();
                }

                else
                {
                    l.Text = title[i] + " at " + time[i].ToString();
                }
                
                i++;
            }

            //display the key
            labelKey.Text = "Mom   =   pink\n" + 
                "Dad    =   blue\n" + 
                "Travis =   green\n" + 
                "Amy    =   purple\n" + 
                "Ian      =   red\n" +
                "Many   =   black";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
