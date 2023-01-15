// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_TABLETRANSFER_PROP")]
    public enum TabletransferProp : int
    {
        [Obsolete("Deprecated in favour of \"RedTable\"")]
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_RED_TABLE")]
        TabletransferPropRedTable = 0x0,
        [Obsolete("Deprecated in favour of \"RedDisable\"")]
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_RED_DISABLE")]
        TabletransferPropRedDisable = 0x1,
        [Obsolete("Deprecated in favour of \"GreenTable\"")]
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_GREEN_TABLE")]
        TabletransferPropGreenTable = 0x2,
        [Obsolete("Deprecated in favour of \"GreenDisable\"")]
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_GREEN_DISABLE")]
        TabletransferPropGreenDisable = 0x3,
        [Obsolete("Deprecated in favour of \"BlueTable\"")]
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_BLUE_TABLE")]
        TabletransferPropBlueTable = 0x4,
        [Obsolete("Deprecated in favour of \"BlueDisable\"")]
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_BLUE_DISABLE")]
        TabletransferPropBlueDisable = 0x5,
        [Obsolete("Deprecated in favour of \"AlphaTable\"")]
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_ALPHA_TABLE")]
        TabletransferPropAlphaTable = 0x6,
        [Obsolete("Deprecated in favour of \"AlphaDisable\"")]
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_ALPHA_DISABLE")]
        TabletransferPropAlphaDisable = 0x7,
        [Obsolete("Deprecated in favour of \"ClampOutput\"")]
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_CLAMP_OUTPUT")]
        TabletransferPropClampOutput = 0x8,
        [Obsolete("Deprecated in favour of \"ForceDword\"")]
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_FORCE_DWORD")]
        TabletransferPropForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_RED_TABLE")]
        RedTable = 0x0,
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_RED_DISABLE")]
        RedDisable = 0x1,
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_GREEN_TABLE")]
        GreenTable = 0x2,
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_GREEN_DISABLE")]
        GreenDisable = 0x3,
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_BLUE_TABLE")]
        BlueTable = 0x4,
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_BLUE_DISABLE")]
        BlueDisable = 0x5,
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_ALPHA_TABLE")]
        AlphaTable = 0x6,
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_ALPHA_DISABLE")]
        AlphaDisable = 0x7,
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_CLAMP_OUTPUT")]
        ClampOutput = 0x8,
        [NativeName("Name", "D2D1_TABLETRANSFER_PROP_FORCE_DWORD")]
        ForceDword = unchecked((int) 0xFFFFFFFFFFFFFFFF),
    }
}
