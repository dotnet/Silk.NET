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
    [NativeName("Name", "__AnonymousRecord_wtypes_L705_C5")]
    public unsafe partial struct TagDecimalUnion1
    {
        public TagDecimalUnion1
        (
            TagDecimalUnion1Union? anonymous = null,
            ushort? signscale = null,
            byte? scale = null,
            byte? sign = null
        ) : this()
        {
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
        }


        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_wtypes_L706_C9")]
        [NativeName("Name", "anonymous1")]
        public TagDecimalUnion1Union Anonymous;

        [FieldOffset(0)]
        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "signscale")]
        public ushort Signscale;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte Scale
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Scale;
        }
#else
        public byte Scale
        {
            get => Anonymous.Scale;
            set => Anonymous.Scale = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref byte Sign
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Sign;
        }
#else
        public byte Sign
        {
            get => Anonymous.Sign;
            set => Anonymous.Sign = value;
        }
#endif

    }
}
