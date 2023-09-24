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

namespace Silk.NET.WindowsCodecs
{
    [NativeName("Name", "WICBitmapPattern")]
    public unsafe partial struct BitmapPattern
    {
        public BitmapPattern
        (
            ulong? position = null,
            uint? length = null,
            byte* pattern = null,
            byte* mask = null,
            Silk.NET.Core.Bool32? endOfStream = null
        ) : this()
        {
            if (position is not null)
            {
                Position = position.Value;
            }

            if (length is not null)
            {
                Length = length.Value;
            }

            if (pattern is not null)
            {
                Pattern = pattern;
            }

            if (mask is not null)
            {
                Mask = mask;
            }

            if (endOfStream is not null)
            {
                EndOfStream = endOfStream.Value;
            }
        }


        [NativeName("Type", "ULARGE_INTEGER")]
        [NativeName("Type.Name", "ULARGE_INTEGER")]
        [NativeName("Name", "Position")]
        public ulong Position;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Length")]
        public uint Length;

        [NativeName("Type", "BYTE *")]
        [NativeName("Type.Name", "BYTE *")]
        [NativeName("Name", "Pattern")]
        public byte* Pattern;

        [NativeName("Type", "BYTE *")]
        [NativeName("Type.Name", "BYTE *")]
        [NativeName("Name", "Mask")]
        public byte* Mask;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "EndOfStream")]
        public Silk.NET.Core.Bool32 EndOfStream;
    }
}
