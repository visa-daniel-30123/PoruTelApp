using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoruTelApp.ViewModels
{
    public partial class ComandaViewModel : ObservableObject
    {
        [ObservableProperty]
        private int _contorKurtos;

        [ObservableProperty]
        private int _contorLimonada;
        [ObservableProperty]
        private int _contorInghetata;
        [ObservableProperty]
        private int _contorKurtosInghetata;

        public ComandaViewModel() {
            ContorKurtos = 0;
            ContorLimonada = 0;
            ContorInghetata = 0;
            ContorKurtosInghetata = 0;
        }
    }
}
