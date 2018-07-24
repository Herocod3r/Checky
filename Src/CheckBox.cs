using System;
using Xamarin.Forms;
using NControl.Abstractions;
using NGraphics;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Checky
{
    public class CheckBox : ContentView
    {

        public CheckBox()
        {
            //Content = new Label { Text = "Hello there" };
            if (HeightRequest <= 0) HeightRequest = 30;
            WidthRequest = HeightRequest;
            GetView();
            TapGestureRecognizer tgr = new TapGestureRecognizer();
            tgr.Tapped += Tgr_Tapped;
            GestureRecognizers.Add(tgr);
        }

        void Tgr_Tapped(object sender, EventArgs e)
        {
            IsChecked = !IsChecked;
            GetView();
        }



        //public override bool TouchesEnded(IEnumerable<NGraphics.Point> points)
        //{
        //    IsChecked = !IsChecked;
        //    return true;
        //}


        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            //base.OnPropertyChanged(propertyName);

            if (HeightRequest.ToString() != "-1" && WidthRequest.ToString() != "-1")
            {
                if (HeightRequest.ToString() != WidthRequest.ToString()) HeightRequest = WidthRequest;
            }

        }


        private void GetView()
        {
            Content = new NControlView((ICanvas canvas, Rect rect) =>
            {
                if (CheckThickness <= 0) CheckThickness = WidthRequest / 10;

                canvas.DrawRectangle(rect, new NGraphics.Size(-5), pen: new Pen(BorderColor.ToNColor(), BorderThickness), brush: new SolidBrush(FillColor.ToNColor()));


                if (IsChecked)
                {
                    canvas.DrawLine(new NGraphics.Point(rect.Width.PerctPoint(20), rect.Height.PerctPoint(50d)), new NGraphics.Point(rect.Width.PerctPoint(40), rect.Height.PerctPoint(80)), new Pen(CheckColor.ToNColor(), CheckThickness));
                    canvas.DrawLine(new NGraphics.Point(rect.Width.PerctPoint(35), rect.Height.PerctPoint(80)), new NGraphics.Point(rect.Width.PerctPoint(80), rect.Height.PerctPoint(30)), new Pen(CheckColor.ToNColor(), CheckThickness));

                }
            });
        }



        //public override void Draw(ICanvas canvas, Rect rect)
        //{


        //    //canvas.DrawRectangle(rect, new NGraphics.Size(5),pen: new Pen(NGraphics.Colors.Black));
        //    if (CheckThickness <= 0) CheckThickness = WidthRequest / 10;

        //    canvas.DrawRectangle(rect, new NGraphics.Size(-5), pen: new Pen(BorderColor.ToNColor(), BorderThickness),brush: new SolidBrush(FillColor.ToNColor()));


        //    if (IsChecked)
        //    {
        //        canvas.DrawLine(new NGraphics.Point(rect.Width.PerctPoint(20), rect.Height.PerctPoint(50d)), new NGraphics.Point(rect.Width.PerctPoint(40), rect.Height.PerctPoint(80)), new Pen(CheckColor.ToNColor(), CheckThickness));
        //        canvas.DrawLine(new NGraphics.Point(rect.Width.PerctPoint(35), rect.Height.PerctPoint(80)), new NGraphics.Point(rect.Width.PerctPoint(80), rect.Height.PerctPoint(30)), new Pen(CheckColor.ToNColor(), CheckThickness));

        //    }

        //    //canvas.DrawLine(new NGraphics.Point(rect.Width / 2, rect.Height - 10), new NGraphics.Point(rect.Width - 10, 10), new Pen(NGraphics.Colors.DarkGray, 2));

        //    //canvas.DrawPath(new List<PathOp>() { 

        //    //    new MoveTo(0,0),
        //    //    new CurveTo(new NGraphics.Point(5,0),new NGraphics.Point(0,5),NGraphics.Point.Zero)

        //    //},new Pen(NGraphics.Colors.Blue,2));

        //    //new CurveTo()
        //}





        //private double CardToPerct(double slide,double total) => (slide/100d)*total;


        private static void Changed(BindableObject obj, object newValue, object oldValue)
        {
            var ct = obj as CheckBox;
            ct.GetView();
        }


        public static readonly BindableProperty FillColorProperty = BindableProperty.Create(
            "FillColor", typeof(Xamarin.Forms.Color), typeof(CheckBox), Xamarin.Forms.Color.Transparent, propertyChanged: Changed);



        public Xamarin.Forms.Color FillColor
        {
            get { return (Xamarin.Forms.Color)GetValue(FillColorProperty); }
            set { SetValue(FillColorProperty, value); }
        }


        public static readonly BindableProperty BorderColorProperty = BindableProperty.Create(
            "BorderColor", typeof(Xamarin.Forms.Color), typeof(CheckBox), Xamarin.Forms.Color.LightGray, propertyChanged: Changed);



        public Xamarin.Forms.Color BorderColor
        {
            get { return (Xamarin.Forms.Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }


        public static readonly BindableProperty CheckColorProperty = BindableProperty.Create(
            "CheckColor", typeof(Xamarin.Forms.Color), typeof(CheckBox), Xamarin.Forms.Color.LightGray, propertyChanged: Changed);



        public Xamarin.Forms.Color CheckColor
        {
            get { return (Xamarin.Forms.Color)GetValue(CheckColorProperty); }
            set { SetValue(CheckColorProperty, value); }
        }




        public static readonly BindableProperty BorderThicknessProperty = BindableProperty.Create(
            "BorderThickness", typeof(double), typeof(CheckBox), 0d, propertyChanged: Changed);



        public double BorderThickness
        {
            get { return (double)GetValue(BorderThicknessProperty); }
            set { SetValue(BorderThicknessProperty, value); }
        }



        public static readonly BindableProperty CheckThicknessProperty = BindableProperty.Create(
            "CheckThickness", typeof(double), typeof(CheckBox), 5d, propertyChanged: Changed);



        public double CheckThickness
        {
            get { return (double)GetValue(CheckThicknessProperty); }
            set { SetValue(CheckThicknessProperty, value); }
        }



        public static readonly BindableProperty IsCheckedProperty = BindableProperty.Create(
            "IsChecked", typeof(bool), typeof(CheckBox), false, propertyChanged: Changed);


        public bool IsChecked
        {
            get { return (bool)GetValue(IsCheckedProperty); }
            set { SetValue(IsCheckedProperty, value); }
        }





        public static void Init()
        {

        }


    }
}
