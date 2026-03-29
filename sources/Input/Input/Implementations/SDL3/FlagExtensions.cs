// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Frozen;

namespace Silk.NET.Input.SDL3;

internal static class FlagExtensions
{
    /// <param name="flags"></param>
    extension(SdlMouseInputFlags flags)
    {
        public bool Has(PointerButton button) => _pointerButtonToMouseFlags.TryGetValue(button, out var converted)
                                                      && (flags & converted) == converted;
    }

    private static readonly FrozenDictionary<SdlMouseInputFlags, PointerButton> _mouseButtonFlagsToPointerButton =
        new Dictionary<SdlMouseInputFlags, PointerButton> {
            { SdlMouseInputFlags.LeftButtonDown, PointerButton.Primary },
            { SdlMouseInputFlags.MiddleButtonDown, PointerButton.MiddleButton }, // same as PointerButton.Button3
            { SdlMouseInputFlags.RightButtonDown, PointerButton.Secondary },
            { SdlMouseInputFlags.XButton1Down, PointerButton.Button4 },
            { SdlMouseInputFlags.XButton2Down, PointerButton.Button5 },
        }.ToFrozenDictionary();

    private static readonly FrozenDictionary<PointerButton, SdlMouseInputFlags> _pointerButtonToMouseFlags =
        _mouseButtonFlagsToPointerButton.ToFrozenDictionary(v => v.Value, v => v.Key);
}
