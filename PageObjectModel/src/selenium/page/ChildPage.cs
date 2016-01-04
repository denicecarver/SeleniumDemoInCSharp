namespace selenium.page

{
    public class ChildPage
    {
        /// <summary>
        /// Classes that inherit this class will belong to a WikiLoadPage
        /// </summary>
        /// TODO: Figure out how to require subclasses only exist within a WikiLoadPage
        protected LoadPage loadPage = null;

        public ChildPage(LoadPage loadPage)
        {
            this.loadPage = loadPage;
        }
    }
}