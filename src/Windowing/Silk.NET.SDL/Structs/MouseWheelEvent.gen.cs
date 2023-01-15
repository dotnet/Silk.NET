// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("Name", "SDL_MouseWheelEvent")]
    public unsafe partial struct MouseWheelEvent
    {
        public MouseWheelEvent
        (
            uint? type = null,
            uint? timestamp = null,
            uint? windowID = null,
            uint? which = null,
            int? x = null,
            int? y = null,
            uint? direction = null,
            float? preciseX = null,
            float? preciseY = null,
            int? mouseX = null,
            int? mouseY = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (timestamp is not null)
            {
                Timestamp = timestamp.Value;
            }

            if (windowID is not null)
            {
                WindowID = windowID.Value;
            }

            if (which is not null)
            {
                Which = which.Value;
            }

            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (direction is not null)
            {
                Direction = direction.Value;
            }

            if (preciseX is not null)
            {
                PreciseX = preciseX.Value;
            }

            if (preciseY is not null)
            {
                PreciseY = preciseY.Value;
            }

            if (mouseX is not null)
            {
                MouseX = mouseX.Value;
            }

            if (mouseY is not null)
            {
                MouseY = mouseY.Value;
            }
        }


        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "timestamp")]
        public uint Timestamp;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "windowID")]
        public uint WindowID;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "which")]
        public uint Which;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "x")]
        public int X;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "y")]
        public int Y;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "direction")]
        public uint Direction;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "preciseX")]
        public float PreciseX;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "preciseY")]
        public float PreciseY;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "mouseX")]
        public int MouseX;

        [NativeName("Type", "Sint32")]
        [NativeName("Type.Name", "Sint32")]
        [NativeName("Name", "mouseY")]
        public int MouseY;
    }
}
