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
    [NativeName("Name", "__AnonymousRecord_wtypes_L713_C5")]
    public unsafe partial struct TagDecimalUnion2
    {
        public TagDecimalUnion2
        (
            TagDecimalUnion2Union? anonymous = null,
            ulong? lo64 = null,
            uint? lo32 = null,
            uint? mid32 = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (lo64 is not null)
            {
                Lo64 = lo64.Value;
            }

            if (lo32 is not null)
            {
                Lo32 = lo32.Value;
            }

            if (mid32 is not null)
            {
                Mid32 = mid32.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_wtypes_L714_C9")]
        [NativeName("Name", "anonymous1")]
        public TagDecimalUnion2Union Anonymous;

        [FieldOffset(0)]
        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "Lo64")]
        public ulong Lo64;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Lo32
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Lo32;
        }
#else
        public uint Lo32
        {
            get => Anonymous.Lo32;
            set => Anonymous.Lo32 = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Mid32
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Mid32;
        }
#else
        public uint Mid32
        {
            get => Anonymous.Mid32;
            set => Anonymous.Mid32 = value;
        }
#endif

    }
}
