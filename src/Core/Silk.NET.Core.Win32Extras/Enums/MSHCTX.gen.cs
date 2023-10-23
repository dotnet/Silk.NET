// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagMSHCTX")]
    public enum MSHCTX : int
    {
        [Obsolete("Deprecated in favour of \"Local\"")]
        [NativeName("Name", "MSHCTX_LOCAL")]
        MshctxLocal = 0x0,
        [Obsolete("Deprecated in favour of \"Nosharedmem\"")]
        [NativeName("Name", "MSHCTX_NOSHAREDMEM")]
        MshctxNosharedmem = 0x1,
        [Obsolete("Deprecated in favour of \"Differentmachine\"")]
        [NativeName("Name", "MSHCTX_DIFFERENTMACHINE")]
        MshctxDifferentmachine = 0x2,
        [Obsolete("Deprecated in favour of \"Inproc\"")]
        [NativeName("Name", "MSHCTX_INPROC")]
        MshctxInproc = 0x3,
        [Obsolete("Deprecated in favour of \"Crossctx\"")]
        [NativeName("Name", "MSHCTX_CROSSCTX")]
        MshctxCrossctx = 0x4,
        [Obsolete("Deprecated in favour of \"Container\"")]
        [NativeName("Name", "MSHCTX_CONTAINER")]
        MshctxContainer = 0x5,
        [NativeName("Name", "MSHCTX_LOCAL")]
        Local = 0x0,
        [NativeName("Name", "MSHCTX_NOSHAREDMEM")]
        Nosharedmem = 0x1,
        [NativeName("Name", "MSHCTX_DIFFERENTMACHINE")]
        Differentmachine = 0x2,
        [NativeName("Name", "MSHCTX_INPROC")]
        Inproc = 0x3,
        [NativeName("Name", "MSHCTX_CROSSCTX")]
        Crossctx = 0x4,
        [NativeName("Name", "MSHCTX_CONTAINER")]
        Container = 0x5,
    }
}
