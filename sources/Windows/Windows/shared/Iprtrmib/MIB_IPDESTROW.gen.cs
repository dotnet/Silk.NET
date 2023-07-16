// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MIB_IPDESTROW.xml' path='doc/member[@name="MIB_IPDESTROW"]/*'/>
public partial struct MIB_IPDESTROW
{
    /// <include file='MIB_IPDESTROW.xml' path='doc/member[@name="MIB_IPDESTROW.ForwardRow"]/*'/>
    public MIB_IPFORWARDROW ForwardRow;
    /// <include file='MIB_IPDESTROW.xml' path='doc/member[@name="MIB_IPDESTROW.dwForwardPreference"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardPreference;
    /// <include file='MIB_IPDESTROW.xml' path='doc/member[@name="MIB_IPDESTROW.dwForwardViewSet"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwForwardViewSet;
}