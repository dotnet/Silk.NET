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
    [NativeName("Name", "_OVERLAPPED")]
    public unsafe partial struct Overlapped
    {
        public Overlapped
        (
            nuint? @internal = null,
            nuint? internalHigh = null,
            OverlappedUnion? anonymous = null,
            nint* hEvent = null,
            void* pointer = null,
            int? offset = null,
            int? offsetHigh = null
        ) : this()
        {
            if (@internal is not null)
            {
                Internal = @internal.Value;
            }

            if (internalHigh is not null)
            {
                InternalHigh = internalHigh.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (hEvent is not null)
            {
                HEvent = hEvent;
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


        [NativeName("Type", "ULONG_PTR")]
        [NativeName("Type.Name", "ULONG_PTR")]
        [NativeName("Name", "Internal")]
        public nuint Internal;

        [NativeName("Type", "ULONG_PTR")]
        [NativeName("Type.Name", "ULONG_PTR")]
        [NativeName("Name", "InternalHigh")]
        public nuint InternalHigh;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_minwinbase_L55_C5")]
        [NativeName("Name", "anonymous1")]
        public OverlappedUnion Anonymous;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "hEvent")]
        public nint* HEvent;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref void* Pointer
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Pointer;
        }
#else
        public void* Pointer
        {
            get => Anonymous.Pointer;
            set => Anonymous.Pointer = value;
        }
#endif

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
