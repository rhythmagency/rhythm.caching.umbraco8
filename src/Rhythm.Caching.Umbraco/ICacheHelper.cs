namespace Rhythm.Caching.Umbraco
{
    /// <summary>
    /// Assists with caching operations.
    /// </summary>
    public interface ICacheHelper
    {

        #region Public Properties

        /// <summary>
        /// Returns the keys to be used when caching, depending on if the site is currently
        /// in preview mode or not.
        /// </summary>
        /// <remarks>
        /// This allows for multiple caches to be used (one for live, one for preview mode,
        /// and one for the back office).
        /// </remarks>
        string[] PreviewCacheKeys { get; }

        #endregion

    }

}
