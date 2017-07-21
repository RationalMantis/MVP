
namespace API.Presenters
{
    public interface IPresenter
    {
        /// <summary>
        /// process request for new content
        /// </summary>
        void OnRequest();

        /// <summary>
        /// public new content to receiver
        /// </summary>
        void OnResponse(object data);
    }
}
