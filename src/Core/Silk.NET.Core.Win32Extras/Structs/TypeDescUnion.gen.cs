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
    [NativeName("Name", "__AnonymousRecord_oaidl_L653_C36")]
    public unsafe partial struct TypeDescUnion
    {
        public TypeDescUnion
        (
            TypeDesc* lptdesc = null,
            ArrayDesc* lpadesc = null,
            uint? hreftype = null
        ) : this()
        {
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


        [FieldOffset(0)]
        [NativeName("Type", "struct tagTYPEDESC *")]
        [NativeName("Type.Name", "struct tagTYPEDESC *")]
        [NativeName("Name", "lptdesc")]
        public TypeDesc* Lptdesc;

        [FieldOffset(0)]
        [NativeName("Type", "struct tagARRAYDESC *")]
        [NativeName("Type.Name", "struct tagARRAYDESC *")]
        [NativeName("Name", "lpadesc")]
        public ArrayDesc* Lpadesc;

        [FieldOffset(0)]
        [NativeName("Type", "HREFTYPE")]
        [NativeName("Type.Name", "HREFTYPE")]
        [NativeName("Name", "hreftype")]
        public uint Hreftype;
    }
}
