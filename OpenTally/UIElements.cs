using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenTally
{
    public class UIElements
    {
        // UI Variables
        public const int cGrip = 16;      // Grip size

        // Light Mode Colors
        public Color BackColor = Color.White;
        public Color ForeColor = Color.Black;
        public Color ButtonFillColor = Color.Gray;
        public Color TextboxFillColor = Color.FromArgb(5, 213, 217);
        public Color ComboboxFillColor = Color.FromArgb(5, 213, 217);
        public static Color WiredModeColor = Color.DarkOrchid;
        public static Color WirelessModeColor = Color.FromArgb(5, 213, 217);

        // Dark Mode Colors TODO

        #region -  UI Functions  -

        public delegate void UpdateButtonMethod(string text, SiticoneRoundedButton button, Color FillColor, Color ForeColor, string enabled);
        public static void WSUpdateButton(string text, SiticoneRoundedButton button, Color FillColor, Color ForeColor, string enabled)
        {
            if (button.InvokeRequired)
            {
                UpdateButtonMethod del = new UpdateButtonMethod(WSUpdateButton);
                button.Invoke(del, new object[] { text, button, FillColor, ForeColor, enabled });
            }
            else
            {
                button.Text = text;
                if (enabled == "disabled") //Button is disabled
                {
                    button.Enabled = false;
                    button.DisabledState.FillColor = FillColor;
                    button.DisabledState.ForeColor = ForeColor;
                }
                else //Button must be enabled
                {
                    button.Enabled = true;
                    button.FillColor = FillColor;
                    button.ForeColor = ForeColor;
                }
            }
        }

        public static Font scaleFont(Label lab)
        {
            SizeF extent = TextRenderer.MeasureText(lab.Text, lab.Font);

            float hRatio = lab.Height / extent.Height;
            float wRatio = lab.Width / extent.Width;
            float ratio = (hRatio < wRatio) ? hRatio : wRatio;

            float newSize = lab.Font.Size * ratio;

            if (newSize < System.Single.MaxValue)
            {
                lab.Font = new Font(lab.Font.FontFamily, newSize - 2, lab.Font.Style);
                return lab.Font;
            }
            else
            {
                return lab.Font;
            }
        }

        public static Font setFontSize(Label lab, double newSize)
        {
            lab.Font = new Font(lab.Font.FontFamily, (float)newSize, lab.Font.Style);
            return lab.Font;
        }


        public static void UIShowValid(SiticoneTextBox TextBox, SiticoneHtmlToolTip toolTip, bool isValid)
        {
            if (isValid == true)
            {
                TextBox.BorderColor = Color.Green;
                TextBox.BorderThickness = 1;
            }
            else
            {
                TextBox.BorderColor = Color.Red;
                TextBox.BorderThickness = 2;
            }
        }

        // Gets and returns row heights of a table layout panel, in percent
        // Call it like: 
        //      public float[] tableLayoutPanel1Heights = new float[6];
        //      tableLayoutPanel1Heights = UIElements.GetRowHeights(tableLayoutPanel1);
        public static float[] GetRowHeights(TableLayoutPanel table, string HeightType = "percent")
        {
            //Console.WriteLine(table.RowCount);
            float[] rowHeights = new float[table.RowCount]; //Store row heights
            for (int i = 0; i < table.RowCount; i++)
            {
                if (HeightType == "pixels")//Return row heights as percentages
                {
                    rowHeights[i] = table.GetRowHeights()[i];
                }
                else if (HeightType == "percent")//Return row heights as pixel values
                {
                    rowHeights[i] = table.RowStyles[i].Height;
                }
                else
                {
                    throw new ArgumentException(message: "Second argument must be literal string \"percent\" or \"pixels\".");
                }
                //Console.WriteLine("Row " + i + "=" + rowHeights[i]);
            }
            return rowHeights;
        }

        // Thanks https://stackoverflow.com/questions/4630391/get-all-controls-of-a-specific-type
        // Call it with: UIElements.GetControlsOfType<SiticoneTextBox>(this).ToList().ForEach(element => element.FillColor = UIElements.WiredModeColor);
        // OR in a foreach() loop:
        //  foreach (var element in UIElements.GetControlsOfType<Label>(this))
        //  {
        //      element.Text = "example";
        //  }
        public static IList<T> GetControlsOfType<T>(Control control) where T : Control
        {
            var rtn = new List<T>();
            foreach (Control item in control.Controls)
            {
                var ctr = item as T;
                if (ctr != null)
                {
                    rtn.Add(ctr);
                }
                else
                {
                    rtn.AddRange(GetControlsOfType<T>(item));
                }

            }
            return rtn.OrderBy(x => x.Name).ToList();
        }

        // Initialize tally labels when needed, but probably only from MainProgram form.
        // Call it like: UIElements.InitializeLabels(configObj, MainProgram, tableLayout2, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
        public static void InitializeLabels(Config configObj, Form form, TableLayoutPanel innerTable, Label Source1, Label Source2, Label Source3, Label Source4, Label Source5, Label Source6, Label Source7, Label Source8, Label InfoText)
        {
            int count = Functions.countSources(configObj); //Get source count from the configObj
            Console.WriteLine("innerTable.RowStyles[1].Height=" + innerTable.RowStyles[1].Height);
            if (count <= 4 && innerTable.RowStyles[1].Height >= 50)// Remove 2nd row of tally labels from form depending on count of sources
            {
                form.WSUpdateControl(() =>
                {
                    form.Size = form.MinimumSize = new Size(form.Width, form.Height - (int)innerTable.RowStyles[1].Height);//Resize form
                });
                innerTable.WSUpdateControl(() =>
                {
                    innerTable.RowStyles[1].Height = 0;
                });
            }
            if (count > 4 && innerTable.RowStyles[1].Height < 50)// Add 2nd row of tally labels to form
            {
                innerTable.WSUpdateControl(() =>
                {
                    innerTable.RowStyles[1].Height = 50;
                });
                form.WSUpdateControl(() =>
                {
                    form.Size = form.MinimumSize = new Size(form.Width, form.Height + (int)innerTable.RowStyles[1].Height);//Resize form
                });
            }
            Source1.WSUpdateControl(() => { Source1.Text = configObj.source1; Source1.Font = scaleFont(Source1); });
            Source2.WSUpdateControl(() => { Source2.Text = configObj.source2; Source2.Font = scaleFont(Source2); });
            Source3.WSUpdateControl(() => { Source3.Text = configObj.source3; Source3.Font = scaleFont(Source3); });
            Source4.WSUpdateControl(() => { Source4.Text = configObj.source4; Source4.Font = scaleFont(Source4); });
            Source5.WSUpdateControl(() => { Source5.Text = configObj.source5; Source5.Font = scaleFont(Source5); });
            Source6.WSUpdateControl(() => { Source6.Text = configObj.source6; Source6.Font = scaleFont(Source6); });
            Source7.WSUpdateControl(() => { Source7.Text = configObj.source7; Source7.Font = scaleFont(Source7); });
            Source8.WSUpdateControl(() => { Source8.Text = configObj.source8; Source8.Font = scaleFont(Source8); });
        }

        // Set tally label color by config
        // Call it like: UIElements.RefreshLabels(device, Color.color, configObj, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
        public static void RefreshLabels(string source, Color color, Config configObj, Label Source1, Label Source2, Label Source3, Label Source4, Label Source5, Label Source6, Label Source7, Label Source8, Label InfoText)
        {
            //Update label colors
            if (source == configObj.source1 && configObj.source1 != null) { Source1.WSUpdateControl(() => { Source1.BackColor = color; }); }
            if (source == configObj.source2) { Source2.WSUpdateControl(() => { Source2.BackColor = color; }); }
            if (source == configObj.source3) { Source3.WSUpdateControl(() => { Source3.BackColor = color; }); }
            if (source == configObj.source4) { Source4.WSUpdateControl(() => { Source4.BackColor = color; }); }
            if (source == configObj.source5) { Source5.WSUpdateControl(() => { Source5.BackColor = color; }); }
            if (source == configObj.source6) { Source6.WSUpdateControl(() => { Source6.BackColor = color; }); }
            if (source == configObj.source7) { Source7.WSUpdateControl(() => { Source7.BackColor = color; }); }
            if (source == configObj.source8) { Source8.WSUpdateControl(() => { Source8.BackColor = color; }); }

            if (source == configObj.source1 && source == configObj.source2 && source == configObj.source3 && source == configObj.source4
                && source == configObj.source5 && source == configObj.source6 && source == configObj.source7 && source == configObj.source8) //If source doesn't equal any configured sources
            {
                if (color == Color.Red) { InfoText.WSUpdateControl(() => { InfoText.Text = "A non-tallied source is live."; }); }
                if (color == Color.Green) { InfoText.WSUpdateControl(() => { InfoText.Text = "A non-tallied source is in preview."; }); }
            }
        }

        // Color all tally labels one color
        // Call it like: UIElements.ColorAllLabels(Color.color, Source1, Source2, Source3, Source4, Source5, Source6, Source7, Source8, InfoText);
        public static void ColorAllLabels(Color color, Label Source1, Label Source2, Label Source3, Label Source4, Label Source5, Label Source6, Label Source7, Label Source8, Label InfoText)
        {
            Source1.WSUpdateControl(() => { Source1.BackColor = color; });
            Source2.WSUpdateControl(() => { Source2.BackColor = color; });
            Source3.WSUpdateControl(() => { Source3.BackColor = color; });
            Source4.WSUpdateControl(() => { Source4.BackColor = color; });
            Source5.WSUpdateControl(() => { Source5.BackColor = color; });
            Source6.WSUpdateControl(() => { Source6.BackColor = color; });
            Source7.WSUpdateControl(() => { Source7.BackColor = color; });
            Source8.WSUpdateControl(() => { Source8.BackColor = color; });
            InfoText.WSUpdateControl(() =>
            {
                InfoText.BackColor = Color.Transparent;
                InfoText.Text = "";
            });
        }

        // Get label ID from config by device name
        public static Label getLabelByDeviceName(string device, Color color, Config configObj, Label Source1, Label Source2, Label Source3, Label Source4, Label Source5, Label Source6, Label Source7, Label Source8, Label InfoText)
        {
            Label label;

            if (device == configObj.source1) { label = Source1; }
            else if (device == configObj.source2) { label = Source2; }
            else if (device == configObj.source2) { label = Source3; }
            else if (device == configObj.source2) { label = Source4; }
            else if (device == configObj.source2) { label = Source5; }
            else if (device == configObj.source2) { label = Source6; }
            else if (device == configObj.source2) { label = Source7; }
            else if (device == configObj.source2) { label = Source8; }
            else
            {
                label = InfoText;
            }

            return label;

        }

        //Blinking Labels
        public static async void Blink(Label label, int numBlinks)
        {
            int blinks = 0;
            Color ogColor = label.BackColor;//Store initial color
            while (blinks <= numBlinks)
            {
                await Task.Delay(500);
                label.BackColor = label.BackColor == ogColor ? Color.Blue : ogColor;
                blinks++;
            }
            label.WSUpdateControl(() => { label.BackColor = ogColor; });//Reset initial color
        }

        #endregion

    }

    // Helper Class
    public static class ControlExtensions
    {
        // Performs thread-safe updates to controls
        // Thanks: https://stackoverflow.com/questions/6556330/threading-cross-threading-in-c-net-how-do-i-change-combobox-data-from-anothe/6556350
        // Call it with: ComboBox.WSUpdateControl(() => { ComboBox.Items.Add(device.name); });
        public static void WSUpdateControl(this Control control, Action action)
        {
            if (control != null)
            {
                if (control.InvokeRequired)
                {
                    control.Invoke(new MethodInvoker(action), null);
                }
                else
                {
                    action.Invoke();
                }
            }
        }
    }

}

