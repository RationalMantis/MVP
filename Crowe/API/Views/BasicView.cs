using System;
using API.Presenters;

namespace API.Views
{
    public class BasicView : IView
    {
        private readonly IPresenter _presenter;

        public BasicView()
        {
            _presenter = new BasicPresenter(this);
        }

        public void OnRequest()
        {
            _presenter.OnRequest();
        }

        public void Update(object response)
        {
            Console.WriteLine(response.ToString());
        }
    }
}
