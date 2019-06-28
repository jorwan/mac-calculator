using System;

using AppKit;
using CoreGraphics;
using Foundation;

namespace CalculadoraProject
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Aplica cambios para el cuadro de la ventana
            prepararCuadro();
        }

        // Aplica cambios para el cuadro de la ventana
        private void prepararCuadro()
        {
            // Define un nuevo cuadro para el tamano de la ventana
            CGRect nuevoCuadro = new CGRect(
                View.Frame.X
                , View.Frame.Y
                , 232
                , 300
            );
            View.Frame = nuevoCuadro;
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void mostrarResultado(NSObject sender)
        {
            lblResultado.StringValue = "0.00";
        }

    }
}
