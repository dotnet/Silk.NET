//
// IEFX.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using AdvancedDLSupport;

namespace Silk.NET.OpenAL.Extensions.Creative.EFX
{
    /// <summary>
    /// Defines the public API of the Effect Extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IEFX : IEFXEffectSlots, IEFXEffects, IEFXFilters, IEFXSources, IEFXListeners
    {
    }
}
