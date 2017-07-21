using API.Models;
using API.Views;

namespace API.Presenters
{
    internal class BasicPresenter : Presenter
    {
        public BasicPresenter(IView view) : base(view, new BasicModel()) {}
    }
}
