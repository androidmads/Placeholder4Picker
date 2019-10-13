using System.ComponentModel;
using PickerPlaceholder;
using PickerPlaceholder.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(PLPicker), typeof(PLPickerRenderer))]
namespace PickerPlaceholder.iOS
{
    public class PLPickerRenderer: PickerRenderer
    {
        PLPicker picker = null;
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

        void UpdatePickerPlaceholder()
        {
            if (picker == null)
                picker = Element as PLPicker;
            if (picker.Placeholder != null)
                Control.Placeholder = picker.Placeholder;
        }
    }
}