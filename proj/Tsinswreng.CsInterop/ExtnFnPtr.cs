using System.Runtime.InteropServices;
namespace Tsinswreng.CsInterop;
public static class ExtnFnPtr{
	public static TDelegate AsFn<TDelegate>(this nint z){
		if(z == nint.Zero){
			return default!;
		}
		return Marshal.GetDelegateForFunctionPointer<TDelegate>(z);
	}
}