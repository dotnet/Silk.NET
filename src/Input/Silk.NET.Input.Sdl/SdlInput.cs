// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using Silk.NET.Windowing.Sdl;

namespace Silk.NET.Input.Sdl
{
    public static class SdlInput
    {
        public static void RegisterPlatform()
        {
            SdlWindowing.RegisterPlatform(); // just in case it's not already
            if (!InputWindowExtensions._platforms.OfType<SdlInputPlatform>().Any())
            {
                InputWindowExtensions.Add(new SdlInputPlatform());
            }
        }

        public static void Use() // for consistency with windowing
        {
            InputWindowExtensions.ShouldLoadFirstPartyPlatforms(false);
            RegisterPlatform();
        }
    }
}
