using Umbraco.Core;
using Umbraco.Core.Composing;

namespace Rhythm.Caching.Umbraco.Composers
{
    /// <summary>
    /// An Umbraco IUserComposer for registering Helper classes to the Umbraco IoC container
    /// </summary>
    [RuntimeLevel(MinLevel = RuntimeLevel.Run)]
    public sealed class HelpersComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Register<ICacheHelper, CacheHelper>();
        }
    }
}
