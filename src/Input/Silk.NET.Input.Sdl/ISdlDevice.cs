// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.SDL;

namespace Silk.NET.Input.Sdl
{
    internal interface ISdlDevice
    {
        void DoEvent(Event @event);
    }
}
