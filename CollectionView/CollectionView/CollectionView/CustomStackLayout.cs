using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CollectionView
{
    class CustomStackLayout : StackLayout
    {
        public CustomStackLayout()
        {
            StackVariable = this;
        }

        public static readonly BindableProperty StackVariableProperty =
    BindableProperty.Create(nameof(StackVariable), typeof(StackLayout), typeof(CustomStackLayout), null, BindingMode.OneWayToSource);
        public CustomStackLayout StackVariable
        {
            get
            {
                return (CustomStackLayout)GetValue(StackVariableProperty);
            }
            set
            {
                SetValue(StackVariableProperty, value);
            }
        }
    }
}
