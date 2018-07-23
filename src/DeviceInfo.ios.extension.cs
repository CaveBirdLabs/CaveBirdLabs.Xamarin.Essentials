// ReSharper disable once CheckNamespace
namespace Xamarin.Essentials
{
	public static class DeviceInfoExentions
	{
		public static string ToPrettyModel(this string hardwareIdentifier)
		{
			switch (hardwareIdentifier)
			{
				case "i386": return "iPhone Simulator 32-bit";
				case "x86_64": return "iPhone Simulator 64-bit";
				case "iPhone1,1": return "iPhone";
				case "iPhone1,2": return "iPhone 3G";
				case "iPhone2,1": return "iPhone 3GS";
				case "iPhone3,1": return "iPhone 4";
				case "iPhone3,2": return "iPhone 4 (GSM Rev A)";
				case "iPhone3,3": return "iPhone 4 (CDMA)";
				case "iPhone4,1": return "iPhone 4S";
				case "iPhone5,1": return "iPhone 5 (GSM)";
				case "iPhone5,2": return "iPhone 5 (GSM+CDMA)";
				case "iPhone5,3": return "iPhone 5C (GSM)";
				case "iPhone5,4": return "iPhone 5C (Global)";
				case "iPhone6,1": return "iPhone 5S (GSM)";
				case "iPhone6,2": return "iPhone 5S (Global)";
				case "iPhone7,1": return "iPhone 6 Plus";
				case "iPhone7,2": return "iPhone 6";
				case "iPhone8,1": return "iPhone 6s";
				case "iPhone8,2": return "iPhone 6s Plus";
				case "iPhone8,3": return "iPhone SE (GSM+CDMA)";
				case "iPhone8,4": return "iPhone SE (GSM)";
				case "iPhone9,1": return "iPhone 7 (Global)";
				case "iPhone9,2": return "iPhone 7 Plus (Global)";
				case "iPhone9,3": return "iPhone 7 (GSM)";
				case "iPhone9,4": return "iPhone 7 Plus (GSM)";
				case "iPhone10,1": return "iPhone 8";
				case "iPhone10,2": return "iPhone 8 Plus";
				case "iPhone10,3": return "iPhone X";
				case "iPhone10,4": return "iPhone 8";
				case "iPhone10,5": return "iPhone 8 Plus";
				case "iPhone10,6": return "iPhone X";
				case "iPod1,1": return "1st Gen iPod";
				case "iPod2,1": return "2nd Gen iPod";
				case "iPod3,1": return "3rd Gen iPod";
				case "iPod4,1": return "4th Gen iPod";
				case "iPod5,1": return "5th Gen iPod";
				case "iPod7,1": return "6th Gen iPod";
				case "iPad1,1": return "iPad";
				case "iPad1,2": return "iPad 3G";
				case "iPad2,1": return "2nd Gen iPad (WiFi)";
				case "iPad2,2": return "2nd Gen iPad (GSM)";
				case "iPad2,3": return "2nd Gen iPad (CDMA)";
				case "iPad2,4": return "2nd Gen iPad New Revision";
				case "iPad3,1": return "3rd Gen iPad (WiFi)";
				case "iPad3,2": return "3rd Gen iPad (CDMA)";
				case "iPad3,3": return "3rd Gen iPad (GSM)";
				case "iPad2,5": return "iPad mini (WiFi)";
				case "iPad2,6": return "iPad mini (GSM+LTE)";
				case "iPad2,7": return "iPad mini (CDMA+LTE)";
				case "iPad3,4": return "4th Gen iPad (WiFi)";
				case "iPad3,5": return "4th Gen iPad (GSM+LTE)";
				case "iPad3,6": return "4th Gen iPad (CDMA+LTE)";
				case "iPad4,1": return "iPad Air (WiFi)";
				case "iPad4,2": return "iPad Air (GSM+CDMA)";
				case "iPad4,4": return "iPad mini Retina (WiFi)";
				case "iPad4,5": return "iPad mini Retina (GSM+CDMA)";
				case "iPad4,6": return "iPad mini Retina (China)";
				case "iPad4,7": return "iPad mini 3 (WiFi)";
				case "iPad4,8": return "iPad mini 3 (GSM+CDMA)";
				case "iPad4,9": return "iPad Mini 3 (China)";
				case "iPad5,1": return "iPad mini 4 (WiFi)";
				case "iPad5,2": return "iPad mini 4 (GSM+CDMA)";
				case "iPad5,3": return "iPad Air 2 (WiFi)";
				case "iPad5,4": return "iPad Air 2 (Cellular)";
				case "iPad6,3": return "iPad Pro (9.7 inch, WiFi)";
				case "iPad6,4": return "iPad Pro (9.7 inch, WiFi+LTE)";
				case "iPad6,7": return "iPad Pro (12.9 inch, WiFi)";
				case "iPad6,8": return "iPad Pro (12.9 inch, WiFi+LTE)";
				case "iPad6,11": return "5th Gen iPad (WiFi)";
				case "iPad6,12": return "5th Gen iPad (GSM+LTE)";
				case "iPad7,1": return "iPad Pro 2 (12.9 inch, WiFi)";
				case "iPad7,2": return "iPad Pro 2 (12.9 inch, WiFi+LTE)";
				case "iPad7,3": return "iPad Pro (10.5 inch, WiFi)";
				case "iPad7,4": return "iPad Pro (10.5 inch, WiFi+LTE)";
				case "Watch1,1": return "Apple Watch 38mm case";
				case "Watch1,2": return "Apple Watch 38mm case";
				case "Watch2,6": return "Apple Watch Series 1 38mm case";
				case "Watch2,7": return "Apple Watch Series 1 42mm case";
				case "Watch2,3": return "Apple Watch Series 2 38mm case";
				case "Watch2,4": return "Apple Watch Series 2 42mm case";
				default: return hardwareIdentifier;
			}
		}
	}
}