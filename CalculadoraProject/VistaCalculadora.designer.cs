// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace CalculadoraProject
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField lblResultado { get; set; }

		[Action ("mostrarResultado:")]
		partial void mostrarResultado (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (lblResultado != null) {
				lblResultado.Dispose ();
				lblResultado = null;
			}
		}
	}
}
