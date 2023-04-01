// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite
{
    [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM")]
    public enum PanoseScriptForm : int
    {
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_ANY")]
        Any = 0x0,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_NO_FIT")]
        NoFit = 0x1,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_UPRIGHT_NO_WRAPPING")]
        UprightNoWrapping = 0x2,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_UPRIGHT_SOME_WRAPPING")]
        UprightSomeWrapping = 0x3,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_UPRIGHT_MORE_WRAPPING")]
        UprightMoreWrapping = 0x4,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_UPRIGHT_EXTREME_WRAPPING")]
        UprightExtremeWrapping = 0x5,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_OBLIQUE_NO_WRAPPING")]
        ObliqueNoWrapping = 0x6,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_OBLIQUE_SOME_WRAPPING")]
        ObliqueSomeWrapping = 0x7,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_OBLIQUE_MORE_WRAPPING")]
        ObliqueMoreWrapping = 0x8,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_OBLIQUE_EXTREME_WRAPPING")]
        ObliqueExtremeWrapping = 0x9,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_EXAGGERATED_NO_WRAPPING")]
        ExaggeratedNoWrapping = 0xA,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_EXAGGERATED_SOME_WRAPPING")]
        ExaggeratedSomeWrapping = 0xB,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_EXAGGERATED_MORE_WRAPPING")]
        ExaggeratedMoreWrapping = 0xC,
        [NativeName("Name", "DWRITE_PANOSE_SCRIPT_FORM_EXAGGERATED_EXTREME_WRAPPING")]
        ExaggeratedExtremeWrapping = 0xD,
    }
}
