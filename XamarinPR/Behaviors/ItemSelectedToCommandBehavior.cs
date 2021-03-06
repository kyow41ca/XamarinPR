using System.Windows.Input;
using Prism.Behaviors;
using Xamarin.Forms;

namespace XamarinPR.Behaviors
{
	public class ItemSelectedToCommandBehavior : BehaviorBase<ListView>
	{
		public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(EventToCommandBehavior), null);

		public ICommand Command
		{
			get { return (ICommand)GetValue(CommandProperty); }
			set { SetValue(CommandProperty, value); }
		}

		protected override void OnAttachedTo(ListView bindable)
		{
			base.OnAttachedTo(bindable);
			bindable.ItemSelected += Bindable_ItemSelected;
		}

		protected override void OnDetachingFrom(ListView bindable)
		{
			base.OnDetachingFrom(bindable);
			bindable.ItemSelected -= Bindable_ItemSelected;
		}

		private void Bindable_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				if (Command.CanExecute(e.SelectedItem))
				{
					Command.Execute(e.SelectedItem);
				}
				AssociatedObject.SelectedItem = null;
			}
		}
	}
}
