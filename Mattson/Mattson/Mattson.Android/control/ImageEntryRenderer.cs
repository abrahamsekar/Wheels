using System;
using Android.Content.Res;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Support.V4.Content;
using Android.Support.V4.Content.Res;
using UISampleApp.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using static Android.Resource;
using Android.Content;
using Mattson.Controls;

[assembly: ExportRenderer(typeof(ImageEntry), typeof(ImageEntryRenderer))]

namespace UISampleApp.Droid.Renderers

{

    public class ImageEntryRenderer : EntryRenderer

    {

        ImageEntry element;

        public ImageEntryRenderer(Context context) : base(context)

        {



        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)

        {

            base.OnElementChanged(e);



            if (e.OldElement != null || e.NewElement == null)

                return;



            element = (ImageEntry)this.Element;





            var editText = this.Control;

            if (!string.IsNullOrEmpty(element.Image))

            {

                switch (element.ImageAlignment)

                {

                    case ImageAlignment.Left:

                        editText.SetCompoundDrawablesWithIntrinsicBounds(GetDrawable(element.Image), null, null, null);

                        break;

                    case ImageAlignment.Right:

                        editText.SetCompoundDrawablesWithIntrinsicBounds(null, null, GetDrawable(element.Image), null);

                        break;

                }

            }

            editText.CompoundDrawablePadding = 25;

            Control.Background.SetColorFilter(element.LineColor.ToAndroid(), PorterDuff.Mode.SrcAtop);

        }



        private BitmapDrawable GetDrawable(string imageEntryImage)

        {

            int resID = Resources.GetIdentifier(imageEntryImage, "drawable", this.Context.PackageName);

            var drawable = ContextCompat.GetDrawable(this.Context, resID);

            var bitmap = ((BitmapDrawable)drawable).Bitmap;



            return new BitmapDrawable(Resources, Bitmap.CreateScaledBitmap(bitmap, element.ImageWidth * 2, element.ImageHeight * 2, true));

        }



    }

}
//using Android.Content.Res;
//using Android.Graphics;
//using Android.Graphics.Drawables;
//using Android.MyRenderers;
//using Android.Text;
//using Mattson.Controls;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.Android;

//[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRenderer))]
//namespace Android.MyRenderers
//{
//    public class MyEntryRenderer : EntryRenderer
//    {
//        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
//        {
//            base.OnElementChanged(e);

//            if (Control != null)
//            {
//                GradientDrawable gd = new GradientDrawable();
//                gd.SetColor(global::Android.Graphics.Color.Transparent);
//                this.Control.SetBackgroundDrawable(gd);
//                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
//                Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.Blue));

//            }
//        }
//    }
//}