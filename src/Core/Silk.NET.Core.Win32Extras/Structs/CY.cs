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
    [NativeName("Name", "tagCY")]
    public unsafe partial struct CY
    {
        public CY
        (
            CYUnion? anonymous = null,
            long? int64 = null,
            uint? lo = null,
            int? hi = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (int64 is not null)
            {
                Int64 = int64.Value;
            }

            if (lo is not null)
            {
                Lo = lo.Value;
            }

            if (hi is not null)
            {
                Hi = hi.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_wtypes_L679_C5")]
        [NativeName("Name", "anonymous1")]
        public CYUnion Anonymous;

        [FieldOffset(0)]
        [NativeName("Type", "LONGLONG")]
        [NativeName("Type.Name", "LONGLONG")]
        [NativeName("Name", "int64")]
        public long Int64;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Lo
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Lo;
        }
#else
        public uint Lo
        {
            get => Anonymous.Lo;
            set => Anonymous.Lo = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref int Hi
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Hi;
        }
#else
        public int Hi
        {
            get => Anonymous.Hi;
            set => Anonymous.Hi = value;
        }
#endif

    }
}
