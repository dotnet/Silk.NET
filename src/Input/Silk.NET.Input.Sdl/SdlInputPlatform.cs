// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Silk.NET.Input;
using Silk.NET.Input.Sdl;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl;

[assembly: InputPlatform(typeof(SdlInputPlatform))]

namespace Silk.NET.Input.Sdl
{
    internal class SdlInputPlatform : IInputPlatform
    {
        public bool IsApplicable(IView view) => view is SdlView;

        public IInputContext CreateInput(IView view) => new SdlInputContext
        (
            view as SdlView ?? throw new InvalidOperationException
            (
                "Attempted to create SDL input context for a " +
                "non-SDL view."
            )
        );
    }
}
