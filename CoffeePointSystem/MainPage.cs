using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace CoffeePointSystem
{
    public partial class MainPage : Form
    {
        private Dictionary<string, Customer> customers = new Dictionary<string, Customer>();

        private Dictionary<string, List<(string itemName, decimal price)>> sectionItems;

        private decimal totalOriginalPrice = 0m;
        private void MainPage_Load(object sender, EventArgs e)
        {
            lstPromotions.Items.Clear();
            lblOriginal.Text = "0.00";
            lblFinal.Text = "0.00";
            cmbSection.SelectedIndexChanged += cmbSection_SelectedIndexChanged;
            cmbSection.Items.AddRange(sections.Keys.ToArray());

            // Check if today is September 23 or February 22
            DateTime currentDate = DateTime.Now;
            if ((currentDate.Month == 5 && currentDate.Day == 4) || (currentDate.Month == 2 && currentDate.Day == 22))
            {
                DisplayRandomFreeItem();
            }
        }

        private void DisplayRandomFreeItem()
        {
            // Flatten and get a list of all items with their categories
            var allItems = sections.SelectMany(section =>
                section.Value.Keys.Select(item => new { Category = section.Key, Item = item }))
                .ToList();

            // Randomly select one
            Random rand = new Random();
            var selected = allItems[rand.Next(allItems.Count)];

            // Add to lstPromotions with correct format: Category - Item
            lstPromotions.Items.Add($"{selected.Category} - {selected.Item}");
            MessageBox.Show($"🎉 Free Item Today: {selected.Item} 🎉", "Today's Special", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private Dictionary<string, Dictionary<string, decimal>> sections = new Dictionary<string, Dictionary<string, decimal>>()
        {
            ["Drinks"] = new Dictionary<string, decimal>
            {
                ["Americano"] = 8,
                ["Cappuccino"] = 12,
                ["Espresso"] = 6
            },
            ["Dessert"] = new Dictionary<string, decimal>
            {
                ["Chocolate Cake"] = 20,
                ["Vanilla Cake"] = 18,
                ["Brownies"] = 10
            },
            ["Sandwiches"] = new Dictionary<string, decimal>
            {
                ["Chicken"] = 15,
                ["Cheese"] = 12,
                ["Tuna"] = 13
            }
        };

        private decimal totalOriginal = 0;
        private void cmbSection_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItem.Items.Clear();

            if (cmbSection.SelectedItem != null)
            {
                string selectedSection = cmbSection.SelectedItem.ToString();

                if (sections.ContainsKey(selectedSection))
                {
                    foreach (var item in sections[selectedSection].Keys)
                    {
                        cmbItem.Items.Add(item);
                    }

                    // Clear any previously shown text in cmbItem
                    cmbItem.Text = "";
                }
            }
        }
        public MainPage()
        {
            InitializeComponent();
            btnNewCustomer.Click += btnNewCustomer_Click;
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOriginalPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtSignIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            string phoneNumber = txtSignIn.Text.Trim();

            if (string.IsNullOrEmpty(phoneNumber))
            {
                MessageBox.Show("Please enter a phone number to register.");
                return;
            }

            if (customers.ContainsKey(phoneNumber))
            {
                MessageBox.Show("Customer already exists.");
                return;
            }

            Customer newCustomer = new Customer(phoneNumber);
            customers[phoneNumber] = newCustomer;

            MessageBox.Show($"Customer {phoneNumber} registered successfully.");
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            // Make sure a customer is logged in
            if (currentCustomer != null)
            {
                // Strip any non-numeric characters from lblFinal (such as $ and commas)
                string priceText = lblFinal.Text.Replace("$", "").Replace(",", "").Trim();

                // Try to parse the final price
                decimal finalPrice;
                if (!decimal.TryParse(priceText, out finalPrice))
                {
                    MessageBox.Show("Final amount is not a valid number.");
                    return;
                }
                if (finalPrice <= 0)
                {
                    MessageBox.Show("Final amount must be greater than zero.");
                    return;
                }

                // Calculate the points earned: $1 = 4 points × point multiplier
                decimal basePoints = finalPrice * 4; // $1 = 4 points
                decimal pointsToAdd = basePoints * (decimal)currentCustomer.PointMultiplier;

                // Add the points to the customer's balance
                currentCustomer.Points += (int)pointsToAdd;
                currentCustomer.RegisterVisit(); // Track the visit

                // Update the UI with the new points
                lblPoints.Text = $"Points: {currentCustomer.Points}";
                MessageBox.Show($"Purchase complete! {pointsToAdd:F2} points added.\nNew balance: {currentCustomer.Points}");

                // Reset the labels to show the next purchase
                lblOriginal.Text = "0.00"; // Reset original price after purchase
                lblDiscountAmount.Text = "0.00"; // Reset discount amount
                lblFinal.Text = "0.00"; // Reset final amount
                txtPointApply.Clear(); // Clear point apply input

                // Disable customer-specific controls after purchase
                btnDiscount.Enabled = false;
                txtPointApply.Enabled = false;
                lblPointMultiplier.Enabled = false;
                lstPromotions.Enabled = false;
                lblPoints.Enabled = false;
                btnComplete.Enabled = false;

                // Optionally, log out the customer (reset fields)
                txtSignIn.Clear();
                txtSignIn.Enabled = true; // Allow new login

                // Clear the basket
                lstBasket.Items.Clear();

                // Clear the current customer object
                currentCustomer = null;
            }
            else
            {
                MessageBox.Show("No customer logged in. Please log in first.");
            }
        }

        private Customer currentCustomer = null;
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string phone = txtSignIn.Text.Trim();
            if (customers.TryGetValue(phone, out Customer customer))
            {
                customer.UpdateMonthlyStatus();
                currentCustomer = customer;
                btnDiscount.Enabled = true;
                txtPointApply.Enabled = true;
                lblPointMultiplier.Enabled = true;
                lstPromotions.Enabled = true;
                lblPoints.Enabled = true;
                btnComplete.Enabled = true;
                lblPoints.Text = customer.Points.ToString("F2");
                lblPointMultiplier.Text = $"Multiplier: x{customer.PointMultiplier:F2}";
                MessageBox.Show("Customer logged in and updated.");
            }
            else
            {
                MessageBox.Show("Customer not found. Please register first.");
            }
        }

        private void lblMultiply_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Make sure an item is selected (in this case, from both category and item)
            if (cmbSection.SelectedItem != null && cmbItem.SelectedItem != null)
            {
                string selectedCategory = cmbSection.SelectedItem.ToString();
                string selectedItem = cmbItem.SelectedItem.ToString();

                // Check if the selected item exists in the selected category
                if (sections.ContainsKey(selectedCategory) && sections[selectedCategory].ContainsKey(selectedItem))
                {
                    decimal itemPrice = sections[selectedCategory][selectedItem]; // Get the price for the selected item

                    // Add the item to the basket (with category name and price)
                    lstBasket.Items.Add($"{selectedCategory} - {selectedItem} - ${itemPrice:F2}");

                    // Recalculate the original price (total of all items in the basket)
                    decimal originalPrice = lstBasket.Items.Cast<string>()
                                                  .Sum(item =>
                                                  {
                                                      // Extract item name and category to get price
                                                      var itemParts = item.Split('-');
                                                      string itemCategory = itemParts[0].Trim();
                                                      string currentItemName = itemParts[1].Trim(); // Renamed itemName to currentItemName
                                                      return sections[itemCategory][currentItemName];
                                                  });

                    lblOriginal.Text = $"${originalPrice:F2}";

                    // Update final price (currently same as original until discounts are applied)
                    lblFinal.Text = lblOriginal.Text;
                }
                else
                {
                    MessageBox.Show("Selected item not found in the category.");
                }
            }
            else
            {
                MessageBox.Show("Please select both a category and an item to add.");
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (lstBasket.SelectedItem != null)
            {
                // Get the selected item from the list and extract category and item name
                string selectedItem = lstBasket.SelectedItem.ToString();
                var itemParts = selectedItem.Split('-');
                string category = itemParts[0].Trim();
                string itemName = itemParts[1].Trim();

                // Remove the selected item from the basket
                lstBasket.Items.Remove(lstBasket.SelectedItem);

                // Recalculate the original price (total of all items in the basket)
                decimal originalPrice = lstBasket.Items.Cast<string>()
                                                  .Sum(item =>
                                                  {
                                                      var parts = item.Split('-');
                                                      string itemCategory = parts[0].Trim();
                                                      string currentItemName = parts[1].Trim(); // Renamed itemName to currentItemName
                                                      return sections[itemCategory][currentItemName];
                                                  });

                lblOriginal.Text = $"${originalPrice:F2}";

                // Update final price (currently same as original until discounts are applied)
                lblFinal.Text = lblOriginal.Text;
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }

        }

        private void cmbSection_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            if (currentCustomer != null)
            {
                // Accessing the visitsThisMonth field directly since it's private in the Customer class
                string customerInfo = $"Phone Number: {currentCustomer.PhoneNumber}\n" +
                                      $"Points: {currentCustomer.Points}\n" +
                                      $"Point Multiplier: {currentCustomer.PointMultiplier}\n" +
                                      $"Visits This Month: {currentCustomer.VisitsThisMonth}\n" +
                                      $"Date Created: {currentCustomer.DateCreated.ToShortDateString()}";

                MessageBox.Show(customerInfo, "Customer Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No customer selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (currentCustomer == null)
            {
                MessageBox.Show("No customer logged in.");
                return;
            }

            // Ensure we are working with the correct format by stripping non-numeric characters (like '$')
            string originalPriceText = lblOriginal.Text.Replace("$", "").Replace(",", "").Trim();
            if (!decimal.TryParse(originalPriceText, out decimal originalPrice))
            {
                MessageBox.Show("Invalid original price.");
                return;
            }

            if (!int.TryParse(txtPointApply.Text.Trim(), out int requestedPoints))
            {
                MessageBox.Show("Please enter a valid number of points.");
                return;
            }

            if (requestedPoints <= 0)
            {
                MessageBox.Show("Points must be greater than zero.");
                return;
            }

            if (currentCustomer.Points < requestedPoints)
            {
                MessageBox.Show("You do not have enough points.");
                return;
            }

            // Each $1 discount costs 40 points
            decimal maxDiscount = requestedPoints / 40m;

            // Ensure discount doesn't exceed original price
            decimal discountToApply = Math.Min(maxDiscount, originalPrice);

            // Calculate how many points will actually be used
            int pointsUsed = (int)(discountToApply * 40);

            // Deduct points and update UI
            currentCustomer.RemovePoints(pointsUsed);
            lblPoints.Text = $"Points: {currentCustomer.Points:F2}";
            lblDiscountAmount.Text = discountToApply.ToString("F2");
            lblFinal.Text = (originalPrice - discountToApply).ToString("F2");

        }
        private void AddFreeItemToBasket()
        {
            // Ensure there is a selected promotion item
            if (lstPromotions.SelectedItem == null)
            {
                MessageBox.Show("Please select a promotion item.");
                return;
            }

            string freeItem = lstPromotions.SelectedItem.ToString();  // Get the free item from promotions list

            // Debugging output to see the exact value
            Console.WriteLine($"Selected Promotion: {freeItem}");

            // Split the string to extract the item category and name
            var itemParts = freeItem.Split('-');

            // Ensure there are at least two parts (category and item name) in the split string
            if (itemParts.Length < 2)
            {
                MessageBox.Show($"The selected promotion item is not formatted correctly. It was: {freeItem}");
                return;
            }

            string currentCategory = itemParts[0].Trim();  // Rename 'itemCategory' to 'currentCategory'
            string currentItemName = itemParts[1].Trim();

            // Check if the category exists in sections and if the item exists in that category
            if (sections.ContainsKey(currentCategory) && sections[currentCategory].ContainsKey(currentItemName))
            {
                decimal itemPrice = sections[currentCategory][currentItemName];  // Get the price for the item

                // Add the item to the basket (with category name and price)
                lstBasket.Items.Add($"{currentCategory} - {currentItemName} - ${itemPrice:F2}");

                // Recalculate the original price (total of all items in the basket)
                decimal originalPrice = lstBasket.Items.Cast<string>()
                                                      .Sum(item =>
                                                      {
                                                          var parts = item.Split('-');
                                                          if (parts.Length < 2) return 0; // Skip invalid items
                                                          string itemCategory = parts[0].Trim();
                                                          string itemName = parts[1].Trim();
                                                          return sections[itemCategory][itemName];
                                                      });

                lblOriginal.Text = $"${originalPrice:F2}";
                lblFinal.Text = lblOriginal.Text;
            }
            else
            {
                MessageBox.Show("The selected item does not exist in the menu.");
            }
        }
    }
}
