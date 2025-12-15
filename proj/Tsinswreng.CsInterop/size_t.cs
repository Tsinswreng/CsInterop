namespace Tsinswreng.CsInterop;
using TPrimitive = System.UIntPtr;
using TStruct = size_t;
public struct size_t(TPrimitive V){
	public TPrimitive Value = V;
	public static implicit operator TPrimitive(TStruct e){
		return e.Value;
	}
	public static implicit operator TStruct(TPrimitive s){
		return new TStruct(s);
	}

}


