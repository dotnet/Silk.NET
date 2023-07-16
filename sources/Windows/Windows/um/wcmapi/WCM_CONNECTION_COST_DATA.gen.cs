// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='WCM_CONNECTION_COST_DATA.xml' path='doc/member[@name="WCM_CONNECTION_COST_DATA"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct WCM_CONNECTION_COST_DATA
{
    /// <include file='WCM_CONNECTION_COST_DATA.xml' path='doc/member[@name="WCM_CONNECTION_COST_DATA.ConnectionCost"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ConnectionCost;
    /// <include file='WCM_CONNECTION_COST_DATA.xml' path='doc/member[@name="WCM_CONNECTION_COST_DATA.CostSource"]/*'/>
    public WCM_CONNECTION_COST_SOURCE CostSource;
}