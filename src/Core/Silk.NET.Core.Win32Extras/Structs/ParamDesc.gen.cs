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
    [NativeName("Name", "tagPARAMDESC")]
    public unsafe partial struct ParamDesc
    {
        public ParamDesc
        (
            ParamDescEx* pparamdescex = null,
            ushort? wParamFlags = null
        ) : this()
        {
            if (pparamdescex is not null)
            {
                Pparamdescex = pparamdescex;
            }

            if (wParamFlags is not null)
            {
                WParamFlags = wParamFlags.Value;
            }
        }


        [NativeName("Type", "LPPARAMDESCEX")]
        [NativeName("Type.Name", "LPPARAMDESCEX")]
        [NativeName("Name", "pparamdescex")]
        public ParamDescEx* Pparamdescex;

        [NativeName("Type", "USHORT")]
        [NativeName("Type.Name", "USHORT")]
        [NativeName("Name", "wParamFlags")]
        public ushort WParamFlags;
    }
}
