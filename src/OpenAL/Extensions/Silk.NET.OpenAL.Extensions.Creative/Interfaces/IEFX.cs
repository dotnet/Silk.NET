// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using AdvancedDLSupport;

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// Defines the public API of the Effect Extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    public interface IEFX : IEFXEffectSlots, IEFXEffects, IEFXFilters, IEFXSources, IEFXListeners
    {
    }
}