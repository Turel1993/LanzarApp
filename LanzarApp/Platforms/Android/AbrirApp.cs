using Android.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace LanzarApp.Platforms.Android
namespace LanzarApp
{
    public partial class AbrirApp
    {
        public partial void AbreApp()
        {
            Intent intent = new Intent();
            intent.SetFlags(ActivityFlags.NewTask);
            intent.SetComponent(new ComponentName("com.example.averesta", "com.example.averesta.MainActivity"));
            Android.App.Application.Context.StartActivity(intent);
        }
    }
}
