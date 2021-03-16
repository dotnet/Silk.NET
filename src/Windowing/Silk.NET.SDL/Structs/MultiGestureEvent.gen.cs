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
    [NativeName("Name", "SDL_MultiGestureEvent")]
    public unsafe partial struct MultiGestureEvent
    {
        public MultiGestureEvent
        (
            uint? type = null,
            uint? timestamp = null,
            long? touchId = null,
            float? dTheta = null,
            float? dDist = null,
            float? x = null,
            float? y = null,
            ushort? numFingers = null,
            ushort? padding = null
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

            if (dTheta is not null)
            {
                DTheta = dTheta.Value;
            }

            if (dDist is not null)
            {
                DDist = dDist.Value;
            }

            if (x is not null)
            {
                X = x.Value;
            }

            if (y is not null)
            {
                Y = y.Value;
            }

            if (numFingers is not null)
            {
                NumFingers = numFingers.Value;
            }

            if (padding is not null)
            {
                Padding = padding.Value;
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

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "dTheta")]
        public float DTheta;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "dDist")]
        public float DDist;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "x")]
        public float X;

        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "y")]
        public float Y;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "numFingers")]
        public ushort NumFingers;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "padding")]
        public ushort Padding;
    }
}
