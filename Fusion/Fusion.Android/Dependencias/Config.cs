using System;
using Fusion.Interfaces;
using System.IO;

[assembly: Xamarin.Forms.Dependency(typeof(Fusion.Droid.Dependecias.Config))]
namespace Fusion.Droid.Dependecias
{
    public class Config : IConfig
    {
        private string diretorio;
        public string Diretorio
        {
            get
            {
                if (string.IsNullOrEmpty(diretorio)) diretorio = "file:///android_asset/";

                return diretorio;
            }
        }
    }
}