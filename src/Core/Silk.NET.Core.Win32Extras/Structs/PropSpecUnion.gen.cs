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
    [StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
    [NativeName("Name", "__AnonymousRecord_propidlbase_L452_C43")]
    public unsafe partial struct PropSpecUnion
    {
        public PropSpecUnion
        (
            uint? propid = null,
            char* lpwstr = null
        ) : this()
        {
            if (propid is not null)
            {
                Propid = propid.Value;
            }

            if (lpwstr is not null)
            {
                Lpwstr = lpwstr;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "PROPID")]
        [NativeName("Type.Name", "PROPID")]
        [NativeName("Name", "propid")]
        public uint Propid;

        [FieldOffset(0)]
        [NativeName("Type", "LPOLESTR")]
        [NativeName("Type.Name", "LPOLESTR")]
        [NativeName("Name", "lpwstr")]
        public char* Lpwstr;
    }
}
