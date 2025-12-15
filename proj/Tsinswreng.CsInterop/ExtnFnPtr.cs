using System.Runtime.InteropServices;
namespace Tsinswreng.CsInterop;
public static partial class ExtnFnPtr{
	public static TDelegate ToManagedFn<TDelegate>(this nint z){
		if(z == nint.Zero){
			return default!;
		}
		return Marshal.GetDelegateForFunctionPointer<TDelegate>(z);
	}
}

#if false // delegate* unmanaged[Cdecl]<>尖括號中ʹ內容 並非泛型參數、緣佢可支持void, 指針 等。故斯法不通
unsafe public static partial class ExtnFnPtr{
	public static delegate* unmanaged[Cdecl]<
		TRtn
	> ToUnmanagedCdecl<
		TRtn
	>(this Func<
		TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, TRtn
	> ToUnmanagedCdecl<
		Arg0, TRtn
	>(this Func<
		Arg0, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}


	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, TRtn
	>(this Func<
		Arg0, Arg1, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, TRtn
	> z)
		// where Arg0: unmanaged
		// where Arg1: unmanaged
		// where Arg2: unmanaged
		// where TRtn: unmanaged
	{
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

	public static delegate* unmanaged[Cdecl]<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, TRtn
	> ToUnmanagedCdecl<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, TRtn
	>(this Func<
		Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, TRtn
	> z){
		return (delegate* unmanaged[Cdecl]<Arg0, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, TRtn>)Marshal.GetFunctionPointerForDelegate(z);
	}

}

#endif
