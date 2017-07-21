using System;
using API.Models;
using API.Presenters;
using API.Views;

namespace API.Test
{


    class TestPresenter : Presenter
    {
        public TestPresenter(IView view, IModel model)
            : base(view, model)
        {
        }
    }

    class TestView : IView
    {
        private int _requestsMade;
        private int _updatesMade;
        private object _response;

        public TestView()
        {
            _requestsMade = 0;
            _updatesMade = 0;
            _response = null;
        }

        public void OnRequest()
        {
            _requestsMade++;
        }

        public void Update(object response)
        {
            _response = response;
            _updatesMade++;
        }

        public int RequestsMade()
        {
            return _requestsMade;
        }

        public int UpdatesMade()
        {
            return _updatesMade;
        }

        public object GetResponse()
        {
            return _response;
        }
    }

    class TestModel : IModel
    {
        private int _timesLoaded;
        private int _timesSaved;
        private readonly Object _value;

        public TestModel(Object value)
        {
            _timesLoaded = 0;
            _timesSaved = 0;
            _value = value;
        }

        public object Load()
        {
            _timesLoaded++;

            return _value;
        }

        public void Save(object data)
        {
            _timesSaved++;
        }

        public int TimesLoaded()
        {
            return _timesLoaded;
        }

        public int TimesSaved()
        {
            return _timesSaved;
        }
    }
}
