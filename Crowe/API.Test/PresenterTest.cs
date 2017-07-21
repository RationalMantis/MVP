using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace API.Test
{
    [TestClass]
    public class PresenterTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullViewTest()
        {
            var presenter = new TestPresenter(null, new TestModel(""));

            presenter.OnRequest();
        }

        [TestMethod]
        [ExpectedException(typeof (NullReferenceException))]
        public void NullModelTest()
        {
            var presenter = new TestPresenter(new TestView(), null);

            presenter.OnRequest();
        }

        [TestMethod]
        public void BasicTest()
        {
            const string expectedValue = "TEST";

            var view = new TestView();
            var model = new TestModel(expectedValue);
            var presenter = new TestPresenter(view, model);

            presenter.OnRequest();

            Assert.AreEqual(model.TimesLoaded(), 1);
            Assert.AreEqual(view.UpdatesMade(), 1);
            Assert.AreEqual(view.GetResponse(), expectedValue);
        }
    }
}
