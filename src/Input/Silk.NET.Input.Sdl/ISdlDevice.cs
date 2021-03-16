// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Silk.NET.SDL;

namespace Silk.NET.Input.Sdl
{
    internal interface ISdlDevice
    {
        void DoEvent(Event @event);
    }
}
