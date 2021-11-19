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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA2_Fixed32")]
    public unsafe partial struct DXVA2Fixed32
    {
        public DXVA2Fixed32
        (
            DXVA2Fixed32Union? anonymous = null,
            int? ll = null,
            ushort? fraction = null,
            short? value = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (ll is not null)
            {
                Ll = ll.Value;
            }

            if (fraction is not null)
            {
                Fraction = fraction.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_dxva2api_L466_C5")]
        [NativeName("Name", "anonymous1")]
        public DXVA2Fixed32Union Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int Ll
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Ll;
        }
#else
        public int Ll
        {
            get => Anonymous.Ll;
            set => Anonymous.Ll = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ushort Fraction
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Fraction;
        }
#else
        public ushort Fraction
        {
            get => Anonymous.Fraction;
            set => Anonymous.Fraction = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref short Value
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Value;
        }
#else
        public short Value
        {
            get => Anonymous.Value;
            set => Anonymous.Value = value;
        }
#endif

    }
}
