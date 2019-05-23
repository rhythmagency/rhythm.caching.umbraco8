namespace Rhythm.Caching.Umbraco.Composers
{

    // Namespaces.
    using Components;
    using global::Umbraco.Core;
    using global::Umbraco.Core.Composing;

    /// <summary>
    /// A Umbraco ComponentComposer used to register the UmbracoCachingComponent.
    /// </summary>
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public sealed class UmbracoCachingComponentComposer : IUserComposer
    {
        #region Public Methods

        /// <summary>
        /// Compose.
        /// </summary>
        public void Compose(Composition composition)
        {
            composition.Components().Append<UmbracoCachingComponent>();
        }

        #endregion

    }
}
