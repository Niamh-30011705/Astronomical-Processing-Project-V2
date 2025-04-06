// Niamh Cavanagh, Application Development Team, Sprint Two
// Date: 06 April 2025
// Version: 2.2
// Astronomical Prrocessing V2
// A forms based program to demonstrate the Binary Search and Bubble Sort. Now including the Sequential Search and some Mathematical Functions.

// Inputs
//  Random Numbers (buttonGetData_Click): Generates random integers between 10 and 90 and fills the array.
//  User Inputs:
//      TextBox (inputBinarySearch): Used to input the search term for the binary search (buttonBinarySearch_Click).
//                                   The user inputs an integer to be searched in the array.
//      TextBox (inputSequentialSearch): Used to input the search term for the sequential search (buttonSequentialSearch_Click).
//                                       The user inputs an integer to be searched in the array.
//      TextBox (inputEdit): Used to input a new value to replace an existing value in the array (buttonEdit_Click).
//                           The user edits an array element.
//      ListBox (listBoxDisplay): The user selects an entry from the list to edit or view its value (listBoxDisplay_Click).

// Processes
//  Data Initialization (buttonGetData_Click): Fills the array with random integers between 10 and 90 using rand.Next(10, 91).
//  Display Data (DisplayArray): Clears the ListBox (listBoxDisplay) and displays the current values of the array.
//  Sorting (buttonSort_Click): Implements a Bubble Sort alorithm to sort the array is ascending order. It
//                              repeatedly compares adjacent elements and swaps them if they are out of
//                              order. After each pass, the list is partially sorted.
//  Searching:
//      Binary Search Button (buttonBinarySearch_Click): Performs a binary search to find a target value (inputBinarySearch.Text). It compares
//                                                       the value with the middle of the array and keeps dividing the array into two
//                                                       halves until the target is found or the range is exhausted.
//      Sequential Search Button (buttonSequentialSearch_Click): Performs a sequential seach to find a target value (inputSequentialSearch.Text). It
//                                                               checks each element one by one from the beginning to the end until the target is
//                                                               found or reaching the end of the array.
//  Editing Data:
//      ListBox (listBoxDisplay_Click): When an item in the List Box is clicked, it displays the selected item in the
//                                      inputEdit textbox for editing.
//      Edit Button (buttonEdit_Click): Updates the selected entry in the array with a new value entered in inputEdit.
//                                      The array is then re-displayed.
//  Mathematical Functions:
//      Mid-Extreme (buttonMidExtreme_Click): The mid-extreme is defined as the sum of the smallest value and the largest value in the given data set divided by 2.
//      Mode (buttonMode_Click): The mode is defined as the number that appears most frequently in a set of data (unimodal).
//      Average (buttonAverage_Click): The average is defined as the sum of all the values divided by the total number of values in the data set.
//      Range (buttonRange_Click): The range is defined as the difference between the largest and the smallest values in the data set.
//  Closing the Program (buttonQuit_Click): Closes the application when the "Quit" button is clicked.

// Outputs
//  Display of Array (DisplayArray): Updates the ListBox (listBoxDisplay) to show the current contents of the array
//                                   whenever it is called.
//  Messages: Success or error messages are shown in the message box
//            (e.g., "Bubble Sort Complete", "Binary Search Successful", "Data updated successfully", etc.).
//  ListBox Selection: When an item in the ListBox is clicked (listBoxDisplay_Click), the corresponding value is displayed
//                     in the inputEdit TextBox.
//  Binary Search Results: The binary search results are shown in the messageBox. If the target is found, the message says
//                         "Binary Search Successful" along with the index. If not found, it displays "Binary Search item not found".
//  Sequential Search Results: The sequential search results are shown in the messageBox. If the target is found, the message
//                             says "Sequential Search Successful" along with the index. If not found, it displays "Sequential
//                             Search item not found".
//  Edit Results: When the data is successfully edited, the ListBox is refreshed with the updated value, and the message
//                "Data updated successfully!" is shown.
//  Mid-Extreme Results: The Mid-Extreme results are shown in the applicable read only textbox (resultMidExtreme.Text).
//  Mode Results: The Mode results are shown in the applicable read only textbox (resultMode.Text).
//  Average Results: The Average results are shown in the applicable read only textbox (resultAverage.Text).
//  Range Results: The Range results are shown in the applicable read only textbox (resultRange.Text).
//  Application Termination: The program closes when buttonQuit_Click is triggered.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astronomical_Processing_V2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Global Variables
        // Delcare number of data entries to be created
        static int arraySize = 24;
        // Array of random integers
        int[] myArray = new int[arraySize];
        // Create a random number
        Random rand = new Random();
        
        // Method to display array (called in multiple other methods)
        private void DisplayArray()
        {
            // Display array in ListBox
            // Clear ListBox for new data
            listBoxDisplay.Items.Clear();
            for (int i = 0; i < arraySize; i++)
            {
                listBoxDisplay.Items.Add(myArray[i]);
            }
        }

        // Method for Get Data on button click
        private void buttonGetData_Click(object sender, EventArgs e)
        {
            // Fill array with random numbers
            for (int i = 0; i < arraySize; i++)
            {
                // Random number from 10 to 90
                myArray[i] = rand.Next(10, 91); // 91 is exclusive, so this gives a range from 10 to 90
            }
            DisplayArray();
            // Clear messageBox
            messageBox.Clear();
        }

        // Method to perform Bubble Sort on button click
        private void buttonSort_Click(object sender, EventArgs e)
        {
            int numLength = arraySize;
            bool flag = true;
            for (int i = 1; (i <= (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    Application.DoEvents();
                    Thread.Sleep(10);
                    DisplayArray();
                    if (myArray[j + 1] < myArray[j])
                    {
                        int temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                        flag = true;
                    }
                }
            }
            // Display success message to user
            messageBox.Text = "Bubble Sort Complete";
        }

        // Method to perform Binary Search on button click
        private void buttonBinarySearch_Click(object sender, EventArgs e)
        {
            // Check if the array is sorted
            bool isSorted = true;
            for (int i = 0; i < arraySize - 1; i++)
            {
                if (myArray[i] > myArray[i + 1])
                {
                    isSorted = false;
                    break;
                }
            }
            // If the array is not sorted, display message to user
            if (!isSorted)
            {
                messageBox.Text = "The data is not sorted. Binary Search relies on the data being sorted. Please click Sort Data and try again.";
                return;
            }
            
            int min = 0;
            int max = arraySize - 1;
            // Catch error for non integer input
            if (!(Int32.TryParse(inputBinarySearch.Text, out int target)))
            {
                // Display error message to user
                messageBox.Text = "Input is invalid or textbox is empty. Please enter an integer before searching.";
                return;
            }
            // Binary Search
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (target == myArray[mid])
                {
                    // Display success message to user
                    messageBox.Text = "Binary Search Successful: " + target + " Found at index " + mid;
                    inputBinarySearch.Clear();
                    inputBinarySearch.Focus();
                    return;
                }
                else if (myArray[mid] >= target)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            // Display error message to user
            messageBox.Text = "Binary Search item not found, please try again.";
            inputBinarySearch.Clear();
            inputBinarySearch.Focus();
        }

        // Method to perform Sequential Search on button click
        private void buttonSequentialSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            // Catch error for non integer input
            if (!(Int32.TryParse(inputSequentialSearch.Text, out int target)))
            {
                // Display error message to user
                messageBox.Text = "Input is invalid or textbox is empty. Please enter an integer before searching.";
                return;
            }
            // Sequential Search
            for (int i = 0; i < arraySize; i++)
            {
                if (target == myArray[i])
                {
                    // Display success message to user
                    messageBox.Text = "Sequential Search Successful: " + target + " Found at index " + i;
                    found = true;
                    break;
                }
                else
                {
                    // Display error message to user
                    messageBox.Text = "Sequential Search item not found, please try again.";
                    inputSequentialSearch.Clear();
                    inputSequentialSearch.Focus();
                }
            }
            if (!found)
            {
                // Display error message to user
                messageBox.Text = "Sequential Search item not found, please try again.";
                inputSequentialSearch.Clear();
                inputSequentialSearch.Focus();
            }
        }

        // Method to select an entry for editing in the listbox
        private void listBoxDisplay_Click(object sender, EventArgs e)
        {
            // Check if the user has selected an item from the listbox
            if (listBoxDisplay.SelectedIndex != -1)
            {
                // Select a record in the listbox
                string curItem = listBoxDisplay.SelectedItem.ToString();
                // Directly use the selected index to display the item in the textbox
                inputEdit.Text = myArray[listBoxDisplay.SelectedIndex].ToString();
            }
            else
            {
                // Display error message to user
                messageBox.Text = "Please select a record from the List Box";
            }
        }
        
        // Method to edit selected data in listbox on button click
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Check if the user has selected an item from the listbox
            if (listBoxDisplay.SelectedIndex != - 1)
            {
                // Try to parse the input from the textbox to an integer
                if (Int32.TryParse(inputEdit.Text, out int newValue))
                {
                    // Get the index of the selected item
                    int selectedIndex = listBoxDisplay.SelectedIndex;
                    // Update the array with the new value at the selected index
                    myArray[selectedIndex] = newValue;
                    // Refresh the listbox to reflect the changes
                    DisplayArray();
                    // Display success message to user
                    messageBox.Text = "Data updated successfully!";
                }
                else
                {
                    // Display error message to user if the input is not a valid integer
                    messageBox.Text = "Please enter a valid integer.";
                }
                // Clear edit textbox for new data
                inputEdit.Clear();
                inputEdit.Focus();
            }
            else
            {
                // Display error message to user if no item is selected
                messageBox.Text = "Please slect a record from the List Box to edit.";
            }
            // Clear edit textbox for new data
            inputEdit.Clear();
            inputEdit.Focus();
        }

        // Method to calculate the Mid-Extreme of the data on button click
        private void buttonMidExtreme_Click(object sender, EventArgs e)
        {
            // Check if the list box is empty
            if (myArray.Length == 0 || listBoxDisplay.Items.Count == 0)
            {
                resultMidExtreme.Text = " ";
                messageBox.Text = "ListBox is empty. Please click Get Data before performing a calculation.";
                return;
            }
            // Find the minimum and maximum values in the array
            int min = myArray[0];
            int max = myArray[0];
            for (int i = 1; i < arraySize; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }
            // Calculate the Mid-Extreme
            double midEx = (min + max) / 2.0; // Use 2.0 to ensure the result is a floating-point number
            // Display result formatted to 2 decimal places or less as applicable to result
            resultMidExtreme.Text = "Mid-Extreme: " + midEx.ToString("0.##");
        }

        // Method to calculate the Mode of the data on button click
        private void buttonMode_Click(object sender, EventArgs e)
        {
            // Check if the list box is empty
            if (myArray.Length == 0 || listBoxDisplay.Items.Count == 0)
            {
                resultMode.Text = " ";
                messageBox.Text = "ListBox is empty. Please click Get Data before performing a calculation.";
                return;
            }
            // Track the frequency of the most frequent element
            int frequency = 1;
            // Create a list to store all modes
            List<int> modes = new List<int>();
            int counter;

            // Variable to check if all elements occur only once
            bool allElementsOnce = true;

            for (int i = 0; i < arraySize; i++)
            {
                counter = 0;
                int element = myArray[i];
                // Count occurrences of the current element
                for (int j = 0; j < arraySize; j++)
                {
                    if (element == myArray[j])
                    {
                        counter++;
                    }
                }
                // If any element appears more than once, we can say there's a mode
                if (counter > 1)
                {
                    allElementsOnce = false;
                }
                // If the counter exceeds the current frequency, update the frequency and clear the modes list
                if (counter > frequency)
                {
                    frequency = counter;
                    modes.Clear(); // Clear previous modes
                    modes.Add(element); // Add the new mode
                }
                // If the counter equals the current frequency, add it to the modes list (if not already there)
                else if (counter == frequency && !modes.Contains(element))
                {
                    modes.Add(element);
                }
            }
            // Check if all elements occurred only once
            if (allElementsOnce)
            {
                resultMode.Text = "No mode (All elements occur only once)";
            }
            else
            {
                // Display result
                if (modes.Count == 1)
                {
                    resultMode.Text = $"{modes[0]}\r\nOccurs: {frequency}";
                }
                else
                {
                    resultMode.Text = $"{string.Join(", ", modes)}\r\nOccurs: {frequency}";
                }
            }
        }

        // Method to calculate the Average of the data on button click
        private void buttonAverage_Click(object sender, EventArgs e)
        {
            // Check if the list box is empty
            if (myArray.Length == 0 || listBoxDisplay.Items.Count == 0)
            {
                resultAverage.Text = " ";
                messageBox.Text = "ListBox is empty. Please click Get Data before performing a calculation.";
                return;
            }
            // Calculate the sum of all elements
            int sum = 0;
            foreach (int num in myArray)
            {
                sum += num;
            }
            // Calculate the average
            double average = (double)sum / arraySize;
            // Display result formatted to 2 decimal places or less as applicable to result
            resultAverage.Text = "Average: " + average.ToString("0.##");
        }

        // Method to calculate the Range of the data on button click
        private void buttonRange_Click(object sender, EventArgs e)
        {
            // Check if the list box is empty
            if (myArray.Length == 0 || listBoxDisplay.Items.Count == 0)
            {
                resultRange.Text = " ";
                messageBox.Text = "ListBox is empty. Please click Get Data before performing a calculation.";
                return;
            }
            // Find the minimum and maximum values in the array
            int min = myArray[0];
            int max = myArray[0];
            for (int i = 1; i < arraySize; i++)
            {
                if (myArray[i] < min)
                {
                    min = myArray[i];
                }
                if (myArray[i] > max)
                {
                    max = myArray[i];
                }
            }
            // Calculate the range
            int range = max - min;
            // Display result
            resultRange.Text = "Range: " + range;
        }

        // Method to quit and close the program on button click
        private void buttonQuit_Click(object sender, EventArgs e)
        {
            // This closes the current form
            this.Close();
        }
    } // end Form1
} // end namespace
