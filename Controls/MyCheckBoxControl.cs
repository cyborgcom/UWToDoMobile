using System.Windows.Input;

namespace UWToDoMobile.Controls
{
    public class MyCheckBoxControl : CheckBox
    {
        public static readonly BindableProperty CheckedCommandProperty = BindableProperty.Create(
            propertyName: nameof(CheckedCommand),
            returnType: typeof(ICommand),
            declaringType: typeof(MyCheckBoxControl),
            defaultValue: null);

        public static readonly BindableProperty CheckedCommandParameterProperty = BindableProperty.Create(
            propertyName: nameof(CheckedCommandParameter),
            returnType: typeof(object),
            declaringType: typeof(MyCheckBoxControl),
            defaultValue: null);

        public ICommand CheckedCommand
        {
            get => (ICommand)GetValue(CheckedCommandProperty);
            set => SetValue(CheckedCommandProperty, value);
        }

        public object CheckedCommandParameter
        {
            get => GetValue(CheckedCommandParameterProperty);
            set => SetValue(CheckedCommandParameterProperty, value);
        }

        public MyCheckBoxControl()
        {
            CheckedChanged += OnCheckedChanged;
        }

        private void OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
        {
            var parameter = CheckedCommandParameter;
            if (CheckedCommand?.CanExecute(parameter) == true)
            {
                CheckedCommand.Execute(parameter);
            }
        }
    }
}
