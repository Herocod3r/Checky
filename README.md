# Checky
a simple checkbox for xamarin forms based on NControl

## Setup
* Available on NuGet: [Checky](https://www.nuget.org/packages/Checky/) 
* Add nuget package to your Xamarin.Forms .netStandard project and to your platform-specific projects (iOS and Android)
* Initialize the NControl renderer on your platforms 

```cs
    NControl.Droid.NControlViewRenderer.Init();
     NControl.iOS.NControlViewRenderer.Init();
```

## Samples
The sample you can find here 
https://github.com/Herocod3r/Checky/blob/master/Test/Test/Test/MainPage.xaml
![sreenshot](https://image.ibb.co/j39P3o/Simulator_Screen_Shot_i_Phone_7_2018_07_24_at_03_18_34.png)

```xml

xmlns:chk="clr-namespace:Checky;assembly=Checky"

   <chk:CheckBox CheckThickness="3" FillColor="Blue" BorderColor="Blue" IsChecked="true" CheckColor="White" BorderThickness="5" VerticalOptions="Center"  />

```
*The CheckThickness is a double for thickness of check mack
*The FillColor color is for checkbox fill color can be transparent
*IsChecked bindable property for when is active




Check source code for more info
