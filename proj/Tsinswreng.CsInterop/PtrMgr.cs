using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace Tsinswreng.CsInterop;

unsafe public class PtrMgr:IDisposable{
	protected ConcurrentBag<IntPtr> Ptrs = new ConcurrentBag<IntPtr>();
	public void AddPtr(IntPtr Ptr){
		Ptrs.Add(Ptr);
	}
	public void AddPtr(u8* Ptr){
		AddPtr((IntPtr)Ptr);
	}
	public u8* Str(str CsStr){
		var cStr = CsStr.CStr();
		AddPtr(cStr);
		return cStr;
	}
	
	~PtrMgr(){
		Dispose(false);
	}
	protected bool _Disposed = false;
	public void Dispose() {
		Dispose(true);
		GC.SuppressFinalize(this);
	}
	protected virtual void Dispose(bool Disposing) {
		if(_Disposed){
			return;
		}
		if(Disposing){
			// dispose managed resources
		}
		foreach(var ptr in Ptrs){
			Marshal.FreeHGlobal(ptr);
		}
		_Disposed = true;
	}
}