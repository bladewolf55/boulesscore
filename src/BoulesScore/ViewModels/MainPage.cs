using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoulesScore.ViewModels
{
    public partial class MainPage: ObservableObject
    {
        public string Title => "Score";

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotMaxLeft))]
        [AlsoNotifyChangeFor(nameof(IsNotMinLeft))]
        int counterLeft = 0;

        [ObservableProperty]
        [AlsoNotifyChangeFor(nameof(IsNotMaxRight))]
        [AlsoNotifyChangeFor(nameof(IsNotMinRight))]
        int counterRight = 0;
       
        public bool IsNotMaxLeft => CounterLeft < 13;
        public bool IsNotMinLeft => CounterLeft > 0;
        public bool IsNotMaxRight => CounterRight < 13;
        public bool IsNotMinRight => CounterRight > 0;

        [ICommand]
        public void UpdateCounterLeft(string amount)
        {
            CounterLeft += int.Parse(amount);

            //SemanticScreenReader.Announce(CounterBtnLeft.Text);
        }

        [ICommand]
        public void UpdateCounterRight(string amount)
        {
            CounterRight += int.Parse(amount);
            
            //SemanticScreenReader.Announce(CounterBtnRight.Text);
        }

        [ICommand]
        public void ResetCounters()
        {
            CounterLeft = 0;
            CounterRight = 0;
        }
    }
}
