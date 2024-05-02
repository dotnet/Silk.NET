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
    [NativeName("Name", "tagTYPEDESC")]
    public unsafe partial struct TypeDesc
    {
        public TypeDesc
        (
            TypeDescUnion? anonymous = null,
            ushort? vt = null,
            TypeDesc* lptdesc = null,
            ArrayDesc* lpadesc = null,
            uint? hreftype = null
        ) : this()
        {
            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

            if (vt is not null)
            {
                Vt = vt.Value;
            }

            if (lptdesc is not null)
            {
                Lptdesc = lptdesc;
            }

            if (lpadesc is not null)
            {
                Lpadesc = lpadesc;
            }

            if (hreftype is not null)
            {
                Hreftype = hreftype.Value;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_oaidl_L653_C36")]
        [NativeName("Name", "anonymous1")]
        public TypeDescUnion Anonymous;

        [NativeName("Type", "VARTYPE")]
        [NativeName("Type.Name", "VARTYPE")]
        [NativeName("Name", "vt")]
        public ushort Vt;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TypeDesc* Lptdesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Lptdesc;
        }
#else
        public TypeDesc* Lptdesc
        {
            get => Anonymous.Lptdesc;
            set => Anonymous.Lptdesc = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref ArrayDesc* Lpadesc
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Lpadesc;
        }
#else
        public ArrayDesc* Lpadesc
        {
            get => Anonymous.Lpadesc;
            set => Anonymous.Lpadesc = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref uint Hreftype
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Hreftype;
        }
#else
        public uint Hreftype
        {
            get => Anonymous.Hreftype;
            set => Anonymous.Hreftype = value;
        }
#endif

    }
}
