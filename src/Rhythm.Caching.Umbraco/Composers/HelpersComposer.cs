namespace Rhythm.Caching.Umbraco.Composers
{
    // Namespaces.
    using global::Umbraco.Core;
    using global::Umbraco.Core.Composing;

    /// <summary>
    /// An Umbraco IUserComposer for registering Helper classes to the Umbraco IoC container
    /// </summary>
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public sealed class HelpersComposer : IUserComposer
    {
        /// <inheritdoc />
        public void Compose(Composition composition)
        {
            composition.Register<ICacheHelper, CacheHelper>();
        }
    }
}
