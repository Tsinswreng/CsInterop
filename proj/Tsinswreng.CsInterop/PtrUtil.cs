namespace Tsinswreng.CsInterop;
using static System.Runtime.InteropServices.NativeMemory;
using static System.Runtime.InteropServices.Marshal;

unsafe public static class Ptr{
	public static T* New<T>()where T:unmanaged{
		return (T*)AllocZeroed((nuint)SizeOf<T>());
	}

	public static nil FreeEtNull<T>(ref T* ptrRef)where T:unmanaged{
		if(ptrRef == null){
			return NIL;
		}
		Free(ptrRef);
		ptrRef = null;
		return NIL;
	}

	public static int SizeOf_int<T>()where T:unmanaged{
		return SizeOf<T>();
	}
}