// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Sdl
{
    public static class InputExtensions
    {
        public static void AddSdl()
        {
            InputWindowExtensions.Add(new SdlInputPlatform());
        }
    }
}
