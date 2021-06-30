using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp19.Model;

namespace WindowsFormsApp19.View
{
    public interface IMainView
    {
        EventHandler<EventArgs> IndexChanged { get; set; }
        EventHandler<EventArgs> CheckedChanged { get; set; }
        EventHandler<EventArgs> AznCheckedChanged { get; set; }
        EventHandler<EventArgs> HDCheckedChanged { get; set; }
        EventHandler<EventArgs> FPCheckedChanged { get; set; }
        EventHandler<EventArgs> CCCheckedChanged { get; set; }
        EventHandler<EventArgs> ICCheckedChanged { get; set; }
        EventHandler<EventArgs> CalculateClick { get; set; }
        EventHandler<EventArgs> LoadClick { get; set; }
        string PriceText { get; set; }
        string HDPrText { get; }
        string FPPrText { get; }
        string CCPrText { get; }
        string İCPrText { get; }
        List<Petrol> Petrols { set; }
        List<Payment> Payments { set; }
        bool isLiter { get; set; }
        bool isActiveAz { get; set; }
        bool isActiveLt { get; set; }
        bool isICActive { get; set; }
        bool isCCActive { get; set; }
        bool isFPActive { get; set; }
        bool isHDActive { get; set; }
        string MoneyText { get; set; }
        string LiterText { get; set; }
        string ICText { get; set; }
        string CCText { get; set; }
        string FPText { get; set; }
        string HDText { get; set; }
        string TotalText { get; set; }
        string Total2Text { get; set; }
    }
}
