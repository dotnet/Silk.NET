// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/nldef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='NL_NETWORK_CONNECTIVITY_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_HINT"]/*'/>
[SupportedOSPlatform("windows10.0.19041.0")]
public partial struct NL_NETWORK_CONNECTIVITY_HINT
{
    /// <include file='NL_NETWORK_CONNECTIVITY_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_HINT.ConnectivityLevel"]/*'/>
    public NL_NETWORK_CONNECTIVITY_LEVEL_HINT ConnectivityLevel;
    /// <include file='NL_NETWORK_CONNECTIVITY_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_HINT.ConnectivityCost"]/*'/>
    public NL_NETWORK_CONNECTIVITY_COST_HINT ConnectivityCost;
    /// <include file='NL_NETWORK_CONNECTIVITY_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_HINT.ApproachingDataLimit"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte ApproachingDataLimit;
    /// <include file='NL_NETWORK_CONNECTIVITY_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_HINT.OverDataLimit"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte OverDataLimit;
    /// <include file='NL_NETWORK_CONNECTIVITY_HINT.xml' path='doc/member[@name="NL_NETWORK_CONNECTIVITY_HINT.Roaming"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte Roaming;
}