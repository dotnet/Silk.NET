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
    [NativeName("Name", "SDL_TouchFingerEvent")]
    public unsafe partial struct TouchFingerEvent
    {
        public TouchFingerEvent
        (
            uint? type = null,
            uint? timestamp = null,
            long? touchId = null,
            long? fingerId = null,
            float? x = null,
            float? y = null,
            float? dx = null,
            float? dy = null,
            float? pressure = null,
            uint? windowID = null
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

            if (touchId is not null)
            {
                TouchId = touchId.Value;
            }

            if (fingerId is not null)
            {
                FingerId = fingerId.Value;
            }

            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (dx is not null)
            {
                Dx = dx.Value;
            }

            if (dy is not null)
            {
                Dy = dy.Value;
            }

            if (pressure is not null)
            {
                Pressure = pressure.Value;
            }

            if (windowID is not null)
            {
                WindowID = windowID.Value;
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

        [NativeName("Type", "SDL_TouchID")]
        [NativeName("Type.Name", "SDL_TouchID")]
        [NativeName("Name", "touchId")]
        public long TouchId;

        [NativeName("Type", "SDL_FingerID")]
        [NativeName("Type.Name", "SDL_FingerID")]
        [NativeName("Name", "fingerId")]
        public long FingerId;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "x")]
        public float X;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "y")]
        public float Y;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "dx")]
        public float Dx;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "dy")]
        public float Dy;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "pressure")]
        public float Pressure;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "windowID")]
        public uint WindowID;
    }
}
