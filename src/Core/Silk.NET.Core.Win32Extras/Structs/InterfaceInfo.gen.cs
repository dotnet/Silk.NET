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
    [NativeName("Name", "tagINTERFACEINFO")]
    public unsafe partial struct InterfaceInfo
    {
        public InterfaceInfo
        (
            Silk.NET.Core.Native.IUnknown* pUnk = null,
            Guid? iid = null,
            ushort? wMethod = null
        ) : this()
        {
            if (pUnk is not null)
            {
                PUnk = pUnk;
            }

            if (iid is not null)
            {
                Iid = iid.Value;
            }

            if (wMethod is not null)
            {
                WMethod = wMethod.Value;
            }
        }


        [NativeName("Type", "IUnknown *")]
        [NativeName("Type.Name", "IUnknown *")]
        [NativeName("Name", "pUnk")]
        public Silk.NET.Core.Native.IUnknown* PUnk;

        [NativeName("Type", "IID")]
        [NativeName("Type.Name", "IID")]
        [NativeName("Name", "iid")]
        public Guid Iid;

        [NativeName("Type", "WORD")]
        [NativeName("Type.Name", "WORD")]
        [NativeName("Name", "wMethod")]
        public ushort WMethod;
    }
}
