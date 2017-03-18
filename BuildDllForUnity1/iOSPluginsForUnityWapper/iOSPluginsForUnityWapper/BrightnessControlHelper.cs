using System.Runtime.InteropServices;

public class BrightnessControlHelper
{
#if !UNITY_EDITOR
#if (UNITY_IOS)
	[DllImport("__Internal")]
	public static extern void setBrightness(float value);
#endif
#else
	public static void setBrightness(float value) { }
#endif
}