// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_COPP_ConnectorType")]
    public enum COPPConnectorType : int
    {
        [NativeName("Name", "COPP_ConnectorType_Unknown")]
        CoppConnectorTypeUnknown = unchecked((int) 0xFFFFFFFFFFFFFFFF),
        [NativeName("Name", "COPP_ConnectorType_VGA")]
        CoppConnectorTypeVga = 0x0,
        [NativeName("Name", "COPP_ConnectorType_SVideo")]
        CoppConnectorTypeSVideo = 0x1,
        [NativeName("Name", "COPP_ConnectorType_CompositeVideo")]
        CoppConnectorTypeCompositeVideo = 0x2,
        [NativeName("Name", "COPP_ConnectorType_ComponentVideo")]
        CoppConnectorTypeComponentVideo = 0x3,
        [NativeName("Name", "COPP_ConnectorType_DVI")]
        CoppConnectorTypeDvi = 0x4,
        [NativeName("Name", "COPP_ConnectorType_HDMI")]
        CoppConnectorTypeHdmi = 0x5,
        [NativeName("Name", "COPP_ConnectorType_LVDS")]
        CoppConnectorTypeLvds = 0x6,
        [NativeName("Name", "COPP_ConnectorType_TMDS")]
        CoppConnectorTypeTmds = 0x7,
        [NativeName("Name", "COPP_ConnectorType_D_JPN")]
        CoppConnectorTypeDJpn = 0x8,
        [NativeName("Name", "COPP_ConnectorType_Internal")]
        CoppConnectorTypeInternal = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "COPP_ConnectorType_ForceDWORD")]
        CoppConnectorTypeForceDword = 0x7FFFFFFF,
    }
}
