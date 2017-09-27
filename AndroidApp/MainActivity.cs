using Android.App;
using Android.Widget;
using Android.OS;

namespace AndroidApp
{
    [Activity(Label = "AndroidApp", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            /* Creamos la instancia del código compartido
             * y le inyectamos la dependencia. */
            var Validator = new PCLProject.AppValidator(new AndroidDialog(this));

            /* Aquí podríamos esteablecer los valroes de las propiedades
             * Email, Password y Device.*/

            //Realizamos la validación.
            Validator.Validate();

            // Set our view from the "main" layout resource
            // SetContentView(Resource.Layout.Main);
        }
    }
}

