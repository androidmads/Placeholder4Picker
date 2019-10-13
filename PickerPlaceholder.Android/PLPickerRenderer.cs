using System.ComponentModel;
using Android.Content;
using PickerPlaceholder;
using PickerPlaceholder.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(PLPicker), typeof(PLPickerRenderer))]
namespace PickerPlaceholder.Droid
{
    public class PLPickerRenderer : Xamarin.Forms.Platform.Android.AppCompat.PickerRenderer
    {
        PLPicker picker = null;
        public PLPickerRenderer(Context context) : base(context)
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                picker = Element as PLPicker;
                UpdatePickerPlaceholder();
                if (picker.SelectedIndex <= -1)
                {
                    UpdatePickerPlaceholder();
                }
            }
        }
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (picker != null)
            {
                if (e.PropertyName.Equals(PLPicker.PlaceholderProperty.PropertyName))
                {
                    UpdatePickerPlaceholder();
                }
            }
        }

        protected override void UpdatePlaceHolderText()
        {
            UpdatePickerPlaceholder();
        }

        void UpdatePickerPlaceholder()
        {
            if (picker == null)
                picker = Element as PLPicker;
            if (picker.Placeholder != null)
                Control.Hint = picker.Placeholder;
        }
    }
}