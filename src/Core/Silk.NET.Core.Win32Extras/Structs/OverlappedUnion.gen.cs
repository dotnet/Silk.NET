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

namespace Silk.NET.Core.Win32Extras
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_minwinbase_L55_C5")]
    public unsafe partial struct OverlappedUnion
    {
        public OverlappedUnion
        (
            OverlappedUnionUnion? anonymous = null,
            void* pointer = null,
            int? offset = null,
            int? offsetHigh = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (pointer is not null)
            {
                Pointer = pointer;
            }

            if (offset is not null)
            {
                Offset = offset.Value;
            }

            if (offsetHigh is not null)
            {
                OffsetHigh = offsetHigh.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_minwinbase_L56_C9")]
        [NativeName("Name", "anonymous1")]
        public OverlappedUnionUnion Anonymous;

        [FieldOffset(0)]
        [NativeName("Type", "PVOID")]
        [NativeName("Type.Name", "PVOID")]
        [NativeName("Name", "Pointer")]
        public void* Pointer;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int Offset
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Offset;
        }
#else
        public int Offset
        {
            get => Anonymous.Offset;
            set => Anonymous.Offset = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int OffsetHigh
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].OffsetHigh;
        }
#else
        public int OffsetHigh
        {
            get => Anonymous.OffsetHigh;
            set => Anonymous.OffsetHigh = value;
        }
#endif

    }
}
