namespace Rhythm.Caching.Umbraco
{

    // Namespaces.
    using global::Umbraco.Web;

    /// <inheritdoc />
    internal sealed class CacheHelper : ICacheHelper
    {
        private readonly IUmbracoContextFactory _ctx;

        public CacheHelper(IUmbracoContextFactory ctx)
        {
            _ctx = ctx;
        }

        #region Properties
        /// <inheritdoc />
        public string[] PreviewCacheKeys
        {
            get
            {
                // Variables.
                using (var ensuredUmbracoContext = _ctx.EnsureUmbracoContext())
                {
                    var context = ensuredUmbracoContext.UmbracoContext;
                    var hasContext =  context != null;

                    //// Is there an Umbraco context?
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