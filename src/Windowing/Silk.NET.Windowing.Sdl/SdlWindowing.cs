// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Windowing.Sdl
{
    public static class SdlWindowing
    {
        public static void RegisterPlatform()
        {
            Window.Add(new SdlPlatform());
        }
    }
}
