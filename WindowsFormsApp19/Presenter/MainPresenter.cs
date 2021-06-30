using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp19.Data;
using WindowsFormsApp19.Model;
using WindowsFormsApp19.View;

namespace WindowsFormsApp19.Presenter
{
    public class MainPresenter
    {
        private readonly PetrolContext _db;
        private IMainView _view;
        string c;
        public MainPresenter(IMainView view)
        {
            _view = view;
            _view.IndexChanged += CombvoIndex;
            _view.CheckedChanged += LiterChecked;
            _view.AznCheckedChanged += MoneyChecked;
            _view.CalculateClick += CalculateBtn;
            _view.ICCheckedChanged += ICChecked;
            _view.CCCheckedChanged += CCChecked;
            _view.FPCheckedChanged += FPChecked;
            _view.HDCheckedChanged += HDChecked;
            _view.LoadClick += Load;
            _db = new PetrolContext();
            //_db.Petrols.Add(new Petrol { Name = "AI95", Price = 1.4 });
            //_db.Petrols.Add(new Petrol { Name = "AI92", Price = 1 });
            //_db.Petrols.Add(new Petrol { Name = "Dizel", Price = 0.8 });
            //_db.SaveChanges();
            var list = _db.Petrols.ToList();
            _view.Petrols = list;
        }
        public void CombvoIndex(object sender, EventArgs e)
        {
            var combo = (sender as ComboBox).SelectedItem;
            c = combo.ToString();
            var petrol = combo as Petrol;
            _view.PriceText = petrol.Price.ToString();
        }
        public void LiterChecked(object s, EventArgs e)
        {
            var item = s as RadioButton;
            if (item.Checked)
            {
                _view.isActiveLt = true;
            }
            else
            {
                _view.isActiveLt = false;
            }
        }
        public void MoneyChecked(object s, EventArgs e)
        {
            var item = s as RadioButton;
            if (item.Checked)
            {
                _view.isActiveAz = true;
            }
            else
            {
                _view.isActiveLt = false;

            }
        }
        public void HDChecked(object s, EventArgs e)
        {
            var item = s as CheckBox;
            if (item.Checked)
            {
                _view.isHDActive = true;
            }
            else
            {
                _view.isHDActive = false;

            }
        }
        public void FPChecked(object s, EventArgs e)
        {
            var item = s as CheckBox;
            if (item.Checked)
            {
                _view.isFPActive = true;
            }
            else
            {
                _view.isFPActive = false;

            }
        }
        public void ICChecked(object s, EventArgs e)
        {
            var item = s as CheckBox;
            if (item.Checked)
            {
                _view.isICActive = true;
            }
            else
            {
                _view.isICActive = false;

            }
        }
        public void CCChecked(object s, EventArgs e)
        {
            var item = s as CheckBox;
            if (item.Checked)
            {
                _view.isCCActive = true;
            }
            else
            {
                _view.isCCActive = false;

            }
        }
        public void CalculateBtn(object s, EventArgs e)
        {
            double totalm = 0;
            int counter = 0;
            List<Meal> nm = new List<Meal>();
            if (_view.isActiveLt)
            {
                var v = Convert.ToInt32(_view.LiterText);
                var t = Convert.ToDouble(_view.PriceText);
                var total = v * t;
                _view.TotalText = total.ToString();
            }
            else if (_view.isActiveAz)
            {
                _view.TotalText = _view.MoneyText;
                var v = Convert.ToInt32(_view.MoneyText);
                var t = Convert.ToDouble(_view.PriceText);
                var total = v / t;
                total = Convert.ToInt32(total);
                _view.LiterText = total.ToString();
            }
            if (_view.isHDActive)
            {
                var p = Convert.ToDouble( _view.HDPrText);
                var d = Convert.ToInt32(_view.HDText);
                var total = p * d;
                totalm += total;
                nm.Add(new Meal { Name = "HotDog", piece = total });
                counter++;
            }
            if (_view.isFPActive)
            {
                var p = Convert.ToDouble(_view.FPPrText);
                var d = Convert.ToInt32(_view.FPText);
                var total = p * d;
                totalm += total;
                nm.Add(new Meal { Name = "Fried Potato", piece = total });
                counter++;
            }
            if (_view.isICActive)
            {
                var p = Convert.ToDouble(_view.İCPrText);
                var d = Convert.ToInt32(_view.ICText);
                var total = p * d;
                totalm += total;
                nm.Add(new Meal { Name = "Ice Cream", piece = total });
                counter++;
            }
            if (_view.isCCActive)
            {
                var p = Convert.ToDouble(_view.CCPrText);
                var d = Convert.ToInt32(_view.CCText);
                var total = p * d;
                totalm += total;
                nm.Add(new Meal { Name = "Coca-Cola", piece = total });
                counter++;

            }
            _view.Total2Text = totalm.ToString();
            var tt = Convert.ToDouble(_view.TotalText) + totalm;
            Payment payment = new Payment
            {
                Oil = c,
                Litr = Convert.ToInt32(_view.LiterText),
                Total = Convert.ToDouble(tt),
                Meals = $"You've ordered {counter} meals",
                PaymentDate = DateTime.Now
            };
            _db.Payments.Add(payment);
            _db.SaveChanges();
        }
        public void Load(object sender, EventArgs e)
        {
            var payments = _db.Payments.ToList();
            _view.Payments = payments;
        }
    }
}
