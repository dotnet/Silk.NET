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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "tagPROPSPEC")]
    public unsafe partial struct PropSpec
    {
        public PropSpec
        (
            uint? ulKind = null,
            PropSpecUnion? anonymous = null,
            uint? propid = null,
            char* lpwstr = null
        ) : this()
        {
            if (ulKind is not null)
            {
                UlKind = ulKind.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (propid is not null)
            {
                Propid = propid.Value;
            }

            if (lpwstr is not null)
            {
                Lpwstr = lpwstr;
            }
        }


        [NativeName("Type", "ULONG")]
        [NativeName("Type.Name", "ULONG")]
        [NativeName("Name", "ulKind")]
        public uint UlKind;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_propidlbase_L452_C43")]
        [NativeName("Name", "anonymous1")]
        public PropSpecUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Propid
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Propid;
        }
#else
        public uint Propid
        {
            get => Anonymous.Propid;
            set => Anonymous.Propid = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref char* Lpwstr
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Lpwstr;
        }
#else
        public char* Lpwstr
        {
            get => Anonymous.Lpwstr;
            set => Anonymous.Lpwstr = value;
        }
#endif

    }
}
