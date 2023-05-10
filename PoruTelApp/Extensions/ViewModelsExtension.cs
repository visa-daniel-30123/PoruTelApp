using CommunityToolkit.Maui;
using PoruTelApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PoruTelApp.Extensions
{
    public static class ViewModelsExtension
    {
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppbuilder)
        {
            mauiAppbuilder
                .Services
                .AddTransient<ComandaViewModel>()
                .AddTransient<Comanda>();
            return mauiAppbuilder;
        }
    }
}
