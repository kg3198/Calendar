using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Family_Schedule
{
    public partial class CreateSchedule : Form
    {
        private static List<int> _times = new List<int>();
        private List<string> _dayOfEvent = new List<string>();
        private List<string> _description = new List<string>();
        private List<int> _block = new List<int>();

        //array for what color events should be
        private string[] _colors = new string[5];
        //an indexer for the colors array
        private int i = 0;

        public CreateSchedule()
        {
            InitializeComponent();
        }
        
        private void Family_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            //sets the ListBox to check an item on a single click verse double click
            checkedListBox1.CheckOnClick = true;

            //makes sure that the user can not select a date that has already passed
            dateTimePicker1.MinDate = DateTime.Today;

            //initialze the error messages to empty strings
            labelMsg1.Text = "";
            labelMsg2.Text = "";
            labelMsg3.Text = "";
            labelNoMore.Text = "";

            //populate start time drop-down list            
            DateStore dateStore = new DateStore();
            List<int> ListTimes = dateStore.GetListOfTimes();

            foreach (int t in ListTimes)
            {
                comboBoxTime.Items.Add(t);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteEvent deleteEvent = new DeleteEvent(_dayOfEvent, _description, 
                _block, _colors);            
            deleteEvent.StartPosition = FormStartPosition.CenterParent;
            deleteEvent.ShowDialog();
            ClearForm();

            Delete delete = new Delete();

            //updates each list so they don't contain an event that was deleted
            _dayOfEvent = delete.UpdatedDayOfEvent();
            _description = delete.UpdatedDescription();
            _block = delete.UpdatedBlock();
            _colors = delete.UpdatedColor();

            //makes sure i doesn't go outside the bounds of the colors array
            var totalDeleted = delete.TotalEventsDeleted();
            i = i - totalDeleted;

            //enable add button if there are less than 5 events
            if (_dayOfEvent.Count < 5)
            {
                buttonAdd.Enabled = true;
                labelNoMore.Text = "";
            }            
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int error = 0;
            
            //check if a time was entered
            if(comboBoxTime.SelectedIndex < 0)
            {
                labelMsg1.Text = "Please select a time";
                error++;
            }
            else
            {
                labelMsg1.Text = "";
            }

            //check if a description was entered
            if(textBox1.Text == "")
            {
                labelMsg2.Text = "Please enter a description";
                error++;
            }
            else
            {
                labelMsg2.Text = "";
            }

            //check if at least one member was selected
            if(checkedListBox1.SelectedItems.Count <= 0)
            {
                labelMsg3.Text = "Please select at least one family member";
                error++;
            }
            else
            {
                labelMsg3.Text = "";
            }
            
            //if all the information was entered then add information to the lists
            if(error == 0)
            {
                DateStore dateStore = new DateStore();
                
                //format the date to get rid of the time
                string date = dateTimePicker1.Value.ToShortDateString();

                dateStore.AddEvent(_dayOfEvent, _description, _block, date, 
                    Convert.ToInt32(comboBoxTime.Items[comboBoxTime.SelectedIndex]), 
                    textBox1.Text);
                
                _dayOfEvent = dateStore.GetDates();
                _description = dateStore.GetDesctiption();
                _block = dateStore.GetBlock();

                //keep track of what color the events should be
                FamilyMembers familyMembers = new FamilyMembers();               
                if(checkedListBox1.CheckedItems.Count == 1)
                {
                    //if one person was selected then get the color associated with them
                    _colors[i] = familyMembers.Color(checkedListBox1.SelectedItem.ToString());
                    i++;
                }
                else
                {
                    //if more than one person was selected get the appropriate color
                    string[] names = new string[5];
                    for(int k = 0; k < checkedListBox1.CheckedItems.Count; k++)
                    {
                        names[k] = checkedListBox1.CheckedItems[k].ToString();
                    }
                    _colors[i] = familyMembers.Color(names);
                    i++;
                }

                

                MessageBox.Show("Event was added to the calendar");
                ClearForm();
                
                //if there are 5 events in the list then disable add button so no more items can be added                   
                if (_dayOfEvent.Count >= 5)
                {
                    buttonAdd.Enabled = false;
                    labelNoMore.Text = "No more events can be added to caledar";
                }
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar(_dayOfEvent, _description, _block, _colors);
            calendar.StartPosition = FormStartPosition.CenterParent;
            calendar.ShowDialog();
            ClearForm();
        }    

        private void ClearForm()
        {
            comboBoxTime.SelectedIndex = -1;
            textBox1.Text = "";

            for(int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
            }
            checkedListBox1.ClearSelected();            
        }
    }
}
