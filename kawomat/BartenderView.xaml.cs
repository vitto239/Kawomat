using kawomat.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kawomat
{   
    public partial class BartenderView : Window
    {
        #region Variables
        private BartenderEngine Bartender;
        #endregion
        #region BartenderViewMechanics
        private bool SelUnselButton(Button btn)
        {
            var statusArray = (object[,])btn.Tag;
            var backColor = (Brush)statusArray[0, 0];
            var status = (string)statusArray[0, 1];
            if (status == "disable")
            {
                btn.Background = Brushes.LightGreen; statusArray[0, 1] = "enable"; btn.Tag = statusArray; return true;
            }
            else
            {
                btn.Background = backColor; statusArray[0, 1] = "disable"; btn.Tag = statusArray; return false;
            }
        }
        private void DisableButtons(StackPanel stckp = null)
        {
            if (stckp == null)
            {
                var lstControl = BartenderView.Descendants<Button>(myGrid).Where(a => a.Background == Brushes.LightGreen).ToArray();
                ResetButtons(lstControl);
            }
            else
            {
                var lstControl = BartenderView.Descendants<Button>(stckp).Where(a => a.Background == Brushes.LightGreen).ToArray();
                ResetButtons(lstControl);
            }
            void ResetButtons(Button[] _lstControl)
            {
                if (_lstControl.Length == 0) { return; }
                foreach (var item in _lstControl)
                {
                    var statusArray = (object[,])item.Tag;
                    item.Background = (Brush)statusArray[0, 0];
                    statusArray[0, 1] = "disable"; item.Tag = statusArray;
                }
            }

        }
        private void InitAllButtons()
        {
            var lstControl = BartenderView.Descendants<Button>(myGrid);
            foreach (Button btn in lstControl)
            {
                var tag = new object[,] { { btn.Background, "disable" } };
                btn.Tag = tag;
            }
        }
        private (bool status, Button[] controls) CheckEnableButtonInStcp(StackPanel stckp)
        {
            var lstControl = BartenderView.Descendants<Button>(stckp).Where(a => a.Background == Brushes.LightGreen).ToArray();
            if (lstControl.Length == 0) { return (status: false, controls: lstControl); }
            return (status: true, controls: lstControl);
        }
        private void ButtonsMechanics(object sender, StackPanel primaryStckp, StackPanel secondaryStckp = null)
        {
            if (secondaryStckp == null)
            {
                var sts = CheckEnableButtonInStcp(primaryStckp);
                if (!sts.status)
                {
                    SelUnselButton(sender as Button);
                }
                else
                {
                    if (sts.controls[0].Equals(sender as Button))
                    {
                        if (!SelUnselButton(sender as Button))
                        {
                            DisableButtons(stcpAddMenu);
                        }
                    }
                }
            }
            else
            {
                var sts = CheckEnableButtonInStcp(primaryStckp);
                if (sts.status)
                {
                    SelUnselButton(sender as Button);
                }
            }
        }
        private void CreateParagon(BillClass bill)
        {
            var sl = Environment.NewLine; var dl = sl + Environment.NewLine;
            int time = 0; double total = 0;
            var sb = new StringBuilder(); sb.Append($"Your order number  {bill.GetBillNumber()}" + dl);
            foreach (var item in bill.GetItemsList())
            {
                sb.Append($"{item.orderedCoffe.GetName()} x {item.quantinity} = {item.orderPrice}" + sl);
                time += item.timeToServe; total += item.orderPrice;
            }
            sb.Append(dl);
            sb.Append($"Summary: {total}$  ,  time: {time} sek");
            MessageBox.Show(sb.ToString());
            Bartender.CloseActualBill(); lstvOrders.Items.Clear();

        }
        #endregion
        #region OtherMetods
        public static IEnumerable<T> Descendants<T>(DependencyObject dependencyItem) where T : DependencyObject
        {
            if (dependencyItem != null)
            {
                for (var index = 0; index < VisualTreeHelper.GetChildrenCount(dependencyItem); index++)
                {
                    var child = VisualTreeHelper.GetChild(dependencyItem, index);
                    if (child is T dependencyObject)
                    {
                        yield return dependencyObject;
                    }

                    foreach (var childOfChild in Descendants<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        } // from StackOver...+ modification
        private string ValidateControl(TextBox tbx)
        {
            int.TryParse(tbx.Text, out int val); var sh = val;
            if (val == 0) { return ""; }
            return sh.ToString();
        } 
        #endregion

        public BartenderView()
        {
            InitializeComponent();
            InitAllButtons();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Bartender = BartenderEngine.Instance;
        }
        #region BartenderViewEvents
        private void txbOuantinity_TextChanged(object sender, TextChangedEventArgs e)
        {
            (sender as TextBox).Text = ValidateControl(sender as TextBox);
        }
        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateControl(txbOuantinity) == "") { txbOuantinity.Text = "1"; return; }
            int.TryParse(txbOuantinity.Text, out int val); val++; txbOuantinity.Text = val.ToString();
        }
        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            if (ValidateControl(txbOuantinity) == "") { txbOuantinity.Text = "1"; return; }
            int.TryParse(txbOuantinity.Text, out int val); if (val <= 1) { txbOuantinity.Text = "1"; return; }
            val--; txbOuantinity.Text = val.ToString();
        }
        private void btnSmallCoffe_Click(object sender, RoutedEventArgs e)
        {
            ButtonsMechanics(sender, stcpCoffeSize);
        }
        private void btnMediumCoffe_Click(object sender, RoutedEventArgs e)
        {
            ButtonsMechanics(sender, stcpCoffeSize);
        }
        private void btnBigCoffe_Click(object sender, RoutedEventArgs e)
        {
            ButtonsMechanics(sender, stcpCoffeSize);
        }
        private void btnwithMilk_Click(object sender, RoutedEventArgs e)
        {
            ButtonsMechanics(sender, stcpCoffeSize, stcpAddMenu);
        }
        private void btnwithCardamon_Click(object sender, RoutedEventArgs e)
        {
            ButtonsMechanics(sender, stcpCoffeSize, stcpAddMenu);
        }
        private void btnwithWhisky_Click(object sender, RoutedEventArgs e)
        {
            ButtonsMechanics(sender, stcpCoffeSize, stcpAddMenu);
        }
        private void btnwithIceCream_Click(object sender, RoutedEventArgs e)
        {
            ButtonsMechanics(sender, stcpCoffeSize, stcpAddMenu);
        }
        private void btnAddToBill_Click(object sender, RoutedEventArgs e)
        {
            SelUnselButton(sender as Button);
            BaseCoffe coffeToMake;
            var baseCoffe = CheckEnableButtonInStcp(stcpCoffeSize);
            if (!baseCoffe.status) { return; }
            Bartender.CreateBill();
            var addOnCoffe = CheckEnableButtonInStcp(stcpAddMenu);

            switch (baseCoffe.controls[0])
            {
                case Button btn when btn.Name == "btnSmallCoffe":
                    coffeToMake = new SmallCofee();
                    break;
                case Button btn when btn.Name == "btnMediumCoffe":
                    coffeToMake = new MediumCofee();
                    break;
                case Button btn when btn.Name == "btnBigCoffe":
                    coffeToMake = new BigCofee();
                    break;
                default:
                    coffeToMake = null; return;
            }
            if (addOnCoffe.status)
            {
                foreach (var item in addOnCoffe.controls)
                {
                    switch (item)
                    {
                        case Button btn when btn.Name.Contains("Milk"):
                            coffeToMake = new CoffeWithMilk(coffeToMake);
                            break;
                        case Button btn when btn.Name.Contains("Cardamon"):
                            coffeToMake = new CoffeWithCardamone(coffeToMake);
                            break;
                        case Button btn when btn.Name.Contains("Whisky"):
                            coffeToMake = new CoffeWithWhisky(coffeToMake);
                            break;
                        case Button btn when btn.Name.Contains("IceCream"):
                            coffeToMake = new CoffeWithIceCream(coffeToMake);
                            break;
                        default:
                            coffeToMake = null; return;
                    }
                }
            }

            RekordClass dataToDisplay = Bartender.AddItemToBill(coffeToMake, int.Parse(txbOuantinity.Text));
            var line1 = new StackPanel(); line1.Orientation = Orientation.Vertical; line1.HorizontalAlignment = HorizontalAlignment.Stretch;
            var txblName1 = new TextBlock(); txblName1.HorizontalAlignment = HorizontalAlignment.Stretch;
            var txblName2 = new TextBlock(); txblName2.HorizontalAlignment = HorizontalAlignment.Stretch;
            var txblName3 = new TextBlock(); txblName3.HorizontalAlignment = HorizontalAlignment.Stretch;
            txblName1.Text = $"{dataToDisplay.orderedCoffe.GetName()}";
            txblName2.Text = $"{dataToDisplay.quantinity} x {dataToDisplay.singlePrice}";
            txblName3.Text = $"summary: {dataToDisplay.orderPrice}$ - time: {dataToDisplay.timeToServe} sek.";
            line1.Children.Add(txblName1); line1.Children.Add(txblName2); line1.Children.Add(txblName3);
            lstvOrders.Items.Add(line1);
            SelUnselButton(sender as Button);
            txbOuantinity.Text = "1";
            DisableButtons();

        }
        private void btnSendOrder_Click(object sender, RoutedEventArgs e)
        {
            DisableButtons();
            CreateParagon(Bartender.GetActualBill());

        } 
        #endregion

    }
}
