# CaveBirdLabs.Xamarin.Essentials

This package contains some missing classes from Xamarin.Essentials.

## Installation
CaveBirdLabs.Xamarin.Essentials is available via:
* NuGet Official Releases: [CaveBirdLabs.Xamarin.Essentials](https://www.nuget.org/packages/CaveBirdLabs.Xamarin.Essentials)

## DeviceInfoExtensions

The current release of Xamarin.Essentials gives you the hardware identifier for iOS devices. With this extension method you will get a pretty model name:

```
using Xamarin.Essentials;

var model = Xamarin.Essentials.DeviceInfo.Model.ToPrettyModel();

// default, Model property will give you for example "iPhone10,6"
// ToPrettyModel will translate this to "iPhone X"

```
