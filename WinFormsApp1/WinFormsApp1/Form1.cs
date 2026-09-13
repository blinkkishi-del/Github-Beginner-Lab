namespace WinFormsApp1
{


    public partial class Form1 : Form
    {
        // Declare a generic List to store duplicate string objects if necessary[cite: 2]
        private List<string> activityList;

        public Form1()
        {
            InitializeComponent();
            // Create a List<T> collection[cite: 2]
            activityList = new List<string>();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string entry = txtActname.Text + " (Organizer: " + txtOrganizer.Text + ")";

            // The Add method places the item at the end of the list[cite: 2]
            activityList.Add(entry);

            UpdateDisplay();

            txtActname.Clear();
            txtOrganizer.Clear();
        }

        public void UpdateDisplay()
        {
            listResult.Items.Clear();
            // Loop through the elements in the collection[cite: 2]
            foreach (string activity in activityList)
            {
                listResult.Items.Add(activity);
            }
        }
    }
}














/*Sample:

 
School Activity Management System
Easy Version (Basic Setup)
1.	Create a Windows Forms Application.
2.	Enter activity name and organizer; display the details.
3.	Add appropriate Labels, TextBoxes, and a Button based on the required input.
4.	Use the Button's Click event to process the entered information.
5.	Display the result using a Label, TextBox, ListBox, or MessageBox.
6.	Ensure that the application has a clear and organized user interface.

Average Version (List<T>)
7.	Extend the Easy version.
8.	Use a suitable collection from the handout to store multiple activities and display/manage them.
9.	Keep all existing Easy Version functionality.
10.	Display the collection data in a ListBox or appropriate control.
11.	Use the appropriate collection method based on the required operation.
12.	Update the displayed data whenever the collection changes.

Difficult Version (Event or Delegate)
13.	Extend the Average version.
14.	Event or Delegate: integrate a notification or processing method into the completed collection application.
15.	Keep all Easy and Average Version functionality.
16.	Declare the required delegate, event, generic delegate, or event accessor based on the assigned concept.
17.	Connect the new functionality to the existing application.
18.	Invoke the delegate or event at the appropriate part of the program.
19.	Display the resulting notification, message, or processed output.
  */
