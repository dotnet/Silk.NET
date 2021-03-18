// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl;

namespace Silk.NET.Input.Sdl
{
    public static class SdlInput
    {
        public static void RegisterPlatform()
        {
            Window.Add(new SdlPlatform());
            InputWindowExtensions.Add(new SdlInputPlatform());
        }
    }
}
