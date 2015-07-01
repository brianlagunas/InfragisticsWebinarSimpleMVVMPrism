using Prism.Events;
using Prism.Mvvm;
using PrismDemo.Events;

namespace PrismDemo.ViewModels
{
    public class ViewBViewModel : BindableBase
    {
        private string _message = "ViewB";
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }

        public ViewBViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<UpdatedEvent>().Subscribe(Updated);
        }

        private void Updated(string obj)
        {
            Message = obj;
        }
    }
}
