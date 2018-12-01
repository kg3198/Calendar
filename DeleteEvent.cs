using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Family_Schedule
{
    public partial class DeleteEvent : Form
    {
        public static List<string> DayOfEvent = new List<string>();
        public static List<string> Description = new List<string>();
        public static List<int> Block = new List<int>();
        public static string[] Colors = new string[5];        

        //variable for the number of items deleted
        public static int count;

        public DeleteEvent()
        {
            InitializeComponent();
        }

        public DeleteEvent(List<string> dayOfEvent, List<string> description, 
            List<int> block, string[] colors)
        {
            DayOfEvent = dayOfEvent;
            Description = description;
            Block = block;
            Colors = colors;
            count = 0;
            InitializeComponent();
        }        

        private void DeleteEvent_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void loadForm()
        {
            CenterToScreen();

            comboBoxDates.Items.Clear();

            labelEvent.Text = "";
            labelMsg.Text = "";

            buttonDelete.Enabled = false;

            //load the available dates into the combo box
            foreach (string d in DayOfEvent)
            {
                comboBoxDates.Items.Add(d);
            }

            if (DayOfEvent.Count == 0)
            {
                labelMsg.Text = "There are no events to delete";
            }
        }

        private void comboBoxDates_SelectedIndexChanged(object sender, EventArgs e)
        {
            //displays the description that is linked to the date selected
            string[] arrDescription = Description.ToArray();
            labelEvent.Text = arrDescription[comboBoxDates.SelectedIndex];
            buttonDelete.Enabled = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();

            delete.UpdatedDayOfEvent(comboBoxDates.SelectedIndex);
            delete.UpdatedDescription(comboBoxDates.SelectedIndex);
            delete.UpdatedBlock(comboBoxDates.SelectedIndex);
            delete.UpdatedColor(comboBoxDates.SelectedIndex);

            MessageBox.Show("Event was deleted");
            
            count++;
            loadForm();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
