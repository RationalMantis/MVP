using System;

namespace API.Views
{
    public interface IView
    {
        /// <summary>
        /// Request presenter for content
        /// </summary>
        void OnRequest();

        /// <summary>
        /// process new content from presenter
        /// </summary>
        void Update(Object response);
    }
}
