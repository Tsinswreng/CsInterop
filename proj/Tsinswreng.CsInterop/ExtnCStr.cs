namespace Tsinswreng.CsInterop.Extn;
unsafe public static class ExtnCStr {
	/// <summary>
	/// 會創新ʹ匪託管ʹC字串 需注意回收
	/// </summary>
	/// <param name="z"></param>
	/// <returns></returns>
	public static byte* CStr(this string? z){
		return CStrUtil.ToCStr(z);
	}
}