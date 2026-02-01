// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Frozen;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3;

internal static class FlagExtensions
{
    /// <param name="flags"></param>
    extension(SdlMouseInputFlags flags)
    {
        /// <summary>
        /// Returns the number of flags set in the given flags enum.
        /// </summary>
        /// <remarks>Works by counting the individual bits</remarks>
        /// <returns></returns>
        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => BitOperations.PopCount((uint)flags);
        }

        /// <summary>
        /// Returns the generic <see cref="PointerButton"/>s for the sdl mouse input flags.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">If the input <see cref="SdlMouseInputFlags"/> has more than
        /// one button pressed</exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public PointerButton ToPointerButton() => flags.Count > 0
            ? throw new InvalidOperationException($"Too many buttons set: {BitOperations.PopCount((uint)flags)}")
            : _mouseButtonFlagsToPointerButton[flags];

        public bool Has(PointerButton button) => _pointerButtonToMouseFlags.TryGetValue(button, out var converted)
                                                      && (flags & converted) == converted;

        public void Overwrite(in Button<PointerButton>[] buttons)
        {
            for(int i = 0; i < buttons.Length; i++)
            {
                ref var button = ref buttons[i];
                var down = flags.Has(button.Name);
                button = button with { IsDown = down, Pressure = down ? 1 : 0 };
            }
        }
    }

    extension(SdlPenInputFlags flags)
    {
        /// <summary>
        /// Returns the number of flags set in the given flags enum.
        /// </summary>
        /// <remarks>Works by counting the individual bits</remarks>
        /// <returns></returns>
        public int Count
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => BitOperations.PopCount((uint)(flags ^ SdlPenInputFlags.PenInProximity));
        }

        public bool Has(PointerButton button) => _pointerButtonToPenFlags.TryGetValue(button, out var converted)
                                                      && (flags & converted) == converted;

        /// <summary>
        /// Returns the generic <see cref="PointerButton"/>s for the sdl mouse input flags.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">If the input <see cref="SdlMouseInputFlags"/> has more than
        /// one button pressed</exception>
        public PointerButton ToPointerButton() => flags.Count > 0
            ? throw new InvalidOperationException($"Too many buttons set: {BitOperations.PopCount((uint)flags)}")
            : _penButtonFlagsToPenButton[flags];
    }

    extension(PointerButton button)
    {

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

    private static readonly FrozenDictionary<SdlPenInputFlags, PointerButton> _penButtonFlagsToPenButton =
        new Dictionary<SdlPenInputFlags, PointerButton> {
            { SdlPenInputFlags.Down, PointerButton.Primary },
            { SdlPenInputFlags.Button1, PointerButton.Secondary },
            { SdlPenInputFlags.Button2, PointerButton.MiddleButton },
            { SdlPenInputFlags.Button3, PointerButton.Button4 },
            { SdlPenInputFlags.Button4, PointerButton.Button5 },
            { SdlPenInputFlags.EraserTip, PointerButton.EraserTip },
            { SdlPenInputFlags.PenInProximity, default },
        }.ToFrozenDictionary();

    private static readonly FrozenDictionary<PointerButton, SdlPenInputFlags> _pointerButtonToPenFlags =
        _penButtonFlagsToPenButton.ToFrozenDictionary(v => v.Value, v => v.Key);
}
