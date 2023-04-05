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
    [NativeName("Name", "tagDEC")]
    public unsafe partial struct TagDecimal
    {
        public TagDecimal
        (
            ushort? wReserved = null,
            TagDecimalUnion1? anonymous1 = null,
            uint? hi32 = null,
            TagDecimalUnion2? anonymous2 = null,
            TagDecimalUnion1Union? anonymous = null,
            ushort? signscale = null,
            byte? scale = null,
            byte? sign = null,
            ulong? lo64 = null,
            uint? lo32 = null,
            uint? mid32 = null
        ) : this()
        {
            if (wReserved is not null)
            {
                WReserved = wReserved.Value;
            }

            if (anonymous1 is not null)
            {
                Anonymous1 = anonymous1.Value;
            }

            if (hi32 is not null)
            {
                Hi32 = hi32.Value;
            }

            if (anonymous2 is not null)
            {
                Anonymous2 = anonymous2.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (signscale is not null)
            {
                Signscale = signscale.Value;
            }

            if (scale is not null)
            {
                Scale = scale.Value;
            }

            if (sign is not null)
            {
                Sign = sign.Value;
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


        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "wReserved")]
        public ushort WReserved;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_wtypes_L705_C5")]
        [NativeName("Name", "anonymous1")]
        public TagDecimalUnion1 Anonymous1;

        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "Hi32")]
        public uint Hi32;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_wtypes_L713_C5")]
        [NativeName("Name", "anonymous2")]
        public TagDecimalUnion2 Anonymous2;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TagDecimalUnion1Union Anonymous
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].Anonymous;
        }
#else
        public TagDecimalUnion1Union Anonymous
        {
            get => Anonymous1.Anonymous;
            set => Anonymous1.Anonymous = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ushort Signscale
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].Signscale;
        }
#else
        public ushort Signscale
        {
            get => Anonymous1.Signscale;
            set => Anonymous1.Signscale = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte Scale
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].Scale;
        }
#else
        public byte Scale
        {
            get => Anonymous1.Scale;
            set => Anonymous1.Scale = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte Sign
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous1, 1)[0].Sign;
        }
#else
        public byte Sign
        {
            get => Anonymous1.Sign;
            set => Anonymous1.Sign = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ulong Lo64
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].Lo64;
        }
#else
        public ulong Lo64
        {
            get => Anonymous2.Lo64;
            set => Anonymous2.Lo64 = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Lo32
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].Lo32;
        }
#else
        public uint Lo32
        {
            get => Anonymous2.Lo32;
            set => Anonymous2.Lo32 = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Mid32
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous2, 1)[0].Mid32;
        }
#else
        public uint Mid32
        {
            get => Anonymous2.Mid32;
            set => Anonymous2.Mid32 = value;
        }
#endif

    }
}
