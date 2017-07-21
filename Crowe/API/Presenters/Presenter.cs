using API.Models;
using API.Views;

namespace API.Presenters
{
    public abstract class Presenter : IPresenter
    {
        private readonly IView _view;
        private readonly IModel _model;

        protected Presenter(IView view, IModel model)
        {
            _view = view;
            _model = model;
        }

        public void OnRequest()
        {
            _view.Update(_model.Load());
        }

        public void OnResponse(object data)
        {
            return;
        }
    }
}
