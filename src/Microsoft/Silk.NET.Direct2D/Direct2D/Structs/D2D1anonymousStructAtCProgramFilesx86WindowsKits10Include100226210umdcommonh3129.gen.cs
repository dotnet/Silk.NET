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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "(anonymous struct at C:\Program Files (x86)\Windows Kits\10\Include\10.0.22621.0\um\dcommon.h:312:9)")]
    public unsafe partial struct D2D1anonymousStructAtCProgramFilesx86WindowsKits10Include100226210umdcommonh3129
    {
        public D2D1anonymousStructAtCProgramFilesx86WindowsKits10Include100226210umdcommonh3129
        (
            float? d2D111 = null,
            float? d2D112 = null,
            float? d2D121 = null,
            float? d2D122 = null,
            float? d2D131 = null,
            float? d2D132 = null
        ) : this()
        {
            if (d2D111 is not null)
            {
                D2D111 = d2D111.Value;
            }

            if (d2D112 is not null)
            {
                D2D112 = d2D112.Value;
            }

            if (d2D121 is not null)
            {
                D2D121 = d2D121.Value;
            }

            if (d2D122 is not null)
            {
                D2D122 = d2D122.Value;
            }

            if (d2D131 is not null)
            {
                D2D131 = d2D131.Value;
            }

            if (d2D132 is not null)
            {
                D2D132 = d2D132.Value;
            }
        }


        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_11")]
        public float D2D111;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_12")]
        public float D2D112;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_21")]
        public float D2D121;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_22")]
        public float D2D122;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_31")]
        public float D2D131;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "_32")]
        public float D2D132;
    }
}
