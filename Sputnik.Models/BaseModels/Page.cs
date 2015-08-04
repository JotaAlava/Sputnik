using Sputnik.Commands;
using Sputnik.Core.Commands;

namespace Sputnik.Models.BaseModels
{
    public abstract class Page
    {
        private readonly string _hostUrl;
        private string _directoryUrl = "";

        protected Page(string hostUrl)
        {
            _hostUrl = hostUrl;
        }

        protected string Url
        {
            get { return string.Format("{0}{1}", _hostUrl, _directoryUrl); }
            set { this._directoryUrl = value; }
        }

        /// <summary>
        /// Returns a new IsCommand that will interact with the page
        /// </summary>
        internal virtual IsCommand IsCommand { get { return new IsCommand(); } }

        /// <summary>
        /// Returns an IsNotCommand that will interact with the page
        /// </summary>
        internal virtual IsNotCommand IsNotCommand{ get { return new IsNotCommand(); } }

        /// <summary>
        /// Returns a SetCommand that will interact with the page
        /// </summary>
        internal virtual SetCommand SetCommand { get { return new SetCommand(); } }

        /// <summary>
        /// Returns a GotoCommand that will navigate to a page's base Url
        /// </summary>
        internal virtual GotoCommand GotoCommand { get { return new GotoCommand(); } }

        /// <summary>
        /// Returns a ClickCommand that will interact with the page
        /// </summary>
        internal virtual ClickCommand ClickCommand { get { return new ClickCommand(); } }

        /// <summary>
        /// Returns a VisibleCommand that will interact with the page
        /// </summary>
        internal virtual VisibleCommand VisibleCommand { get { return new VisibleCommand(); } }

        /// <summary>
        /// Returns a NotVisibleCommand that will interact with the page
        /// </summary>
        internal virtual NotVisibleCommand NotVisibleCommand { get { return new NotVisibleCommand(); } }

        /// <summary>
        /// Returns a LikeCommand that will interact with the page
        /// </summary>
        internal virtual LikeCommand LikeCommand { get { return new LikeCommand(); } }

        /// <summary>
        /// Returns an ExistCommand that will interact with the page
        /// </summary>
        internal virtual ExistCommand ExistCommand { get { return new ExistCommand();} }

        /// <summary>
        /// Returns an ExistCommand that will interact with the page
        /// </summary>
        internal virtual NotExistCommand NotExistCommand { get { return new NotExistCommand(); } }

        /// <summary>
        /// Returns a SubmitCommand that will interact with the page
        /// </summary>
        internal virtual SubmitCommand SubmitCommand { get { return new SubmitCommand();} }
    }
}
