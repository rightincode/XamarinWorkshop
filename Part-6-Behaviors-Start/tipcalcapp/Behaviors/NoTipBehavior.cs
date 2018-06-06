using Xamarin.Forms;

namespace tipcalcapp.Behaviors
{
    //public class NoTipBehavior : Behavior<Entry>
    //{
    //    protected override void OnAttachedTo(Entry entry)
    //    {
    //        entry.TextChanged += OnEntryTextChanged;
    //        base.OnAttachedTo(entry);
    //    }

    //    protected override void OnDetachingFrom(Entry entry)
    //    {
    //        entry.TextChanged -= OnEntryTextChanged;
    //        base.OnDetachingFrom(entry);
    //    }

    //    void OnEntryTextChanged(object sender, TextChangedEventArgs args)
    //    {
    //        bool isValid = double.TryParse(args.NewTextValue, out double result);

    //        if ((isValid) && (result <= 0))
    //        {
    //            ((Entry)sender).TextColor = Color.Red;
    //        }
    //        else
    //        {
    //            ((Entry)sender).TextColor = Color.Default;
    //        }
    //    }
    //}
}
