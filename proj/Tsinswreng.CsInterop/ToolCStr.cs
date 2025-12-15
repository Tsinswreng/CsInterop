using System.Runtime.InteropServices;
using System.Text;

namespace Tsinswreng.CsInterop;

/// <summary>
/// TODO test
/// </summary>
public static unsafe class ToolCStr{

	public static string? ToCsStr(byte* cStr){

		if (cStr == null){ return null;}

		// 計算字元串的長度
		int length = 0;
		while (*(cStr + length) != 0){ // 直到遇到null字符
			length++;
		}

		// 將字元串轉換為byte[]
		byte[] byteArray = new byte[length];
		Marshal.Copy((nint)cStr, byteArray, 0, length);

		// 將byte[]轉換為string，這裡預設為UTF-8編碼
		return Encoding.UTF8.GetString(byteArray);
	}


	public static byte* ToCStr(string? CsStr){
		if (CsStr == null){ return null;}
		//AI曰 斯類API須 配套ᵈ 用、StringToCoTaskMemUTF8ʃ產ˋ叵用NativeMemory㕥釋
		//return (byte*)Marshal.StringToCoTaskMemUTF8(CsStr);
		int len = Encoding.UTF8.GetByteCount(CsStr);
		var R = (byte*)NativeMemory.Alloc((nuint)(len + 1)); // +1 给 '\0'

		fixed (char* src = CsStr){
			Encoding.UTF8.GetBytes(src, CsStr.Length, R, len);
		}
		R[len] = 0; // 手动补 0 结尾
		return R;
	}

}