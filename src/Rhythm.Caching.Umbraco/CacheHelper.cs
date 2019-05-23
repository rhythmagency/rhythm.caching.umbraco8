namespace Rhythm.Caching.Umbraco
{

    // Namespaces.
    using global::Umbraco.Web;

    /// <inheritdoc />
    internal sealed class CacheHelper : ICacheHelper
    {
        #region Private Properties

        private IUmbracoContextFactory UmbracoContextFactory { get; set; }

        #endregion


        #region Constructors

        public CacheHelper(IUmbracoContextFactory umbracoContextFactory)
        {
            UmbracoContextFactory = umbracoContextFactory;
        }

        #endregion

        #region Public Properties

        /// <inheritdoc />
        public string[] PreviewCacheKeys
        {
            get
            {
                using (var ensuredUmbracoContext = UmbracoContextFactory.EnsureUmbracoContext())
                {
                    // Variables.
                    var context = ensuredUmbracoContext.UmbracoContext;
                    var hasContext =  context != null;

                    // Is there an Umbraco context?
                    var key = default(string);
                    if (hasContext)
                    {
                        key = context.InPreviewMode
                            ? "Preview"
                            : "Live";
                    }
                    else
                    {
                        key = "Back Office";
                    }

                    // Return the key (wrapped in an array).
                    return new[] { key };
                }
            }
        }

        #endregion
    }
}
