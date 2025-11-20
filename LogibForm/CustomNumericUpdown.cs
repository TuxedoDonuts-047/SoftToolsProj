using System;
using System.Windows.Forms;

namespace LogibForm
{
    public partial class CustomNumericUpdown : UserControl
    {
        private decimal _value = 0;
        private decimal _minimum = 0;
        private decimal _maximum = 100;
        private decimal _increment = 1;

        public CustomNumericUpdown()
        {
            InitializeComponent();
            UpdateTextBox();
        }
        // Public property to access the current value from your main form
        public decimal Value
        {
            get { return _value; }
            set
            {
                // Ensure value stays within bounds
                if (value >= _minimum && value <= _maximum)
                {
                    _value = value;
                    UpdateTextBox();
                    OnValueChanged(EventArgs.Empty); // Raise a custom event
                }
            }
        }
        // Add properties for Min, Max, and Increment if needed, similar to the Value property

        // Event for when the value changes
        public event EventHandler ValueChanged;

        protected virtual void OnValueChanged(EventArgs e)
        {
            ValueChanged?.Invoke(this, e);
        }

        private void UpdateTextBox()
        {
            txtValue.Text = Value.ToString();
        }

        // Event handler for the Plus button
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Value += _increment; // Increment the value
        }

        // Event handler for the Minus button
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Value -= _increment; // Decrement the value
        }
    }
}
