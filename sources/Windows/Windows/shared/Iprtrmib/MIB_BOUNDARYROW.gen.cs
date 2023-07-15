// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIB_BOUNDARYROW.xml' path='doc/member[@name="MIB_BOUNDARYROW"]/*'/>
public partial struct MIB_BOUNDARYROW
{
    /// <include file='MIB_BOUNDARYROW.xml' path='doc/member[@name="MIB_BOUNDARYROW.dwGroupAddress"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwGroupAddress;
    /// <include file='MIB_BOUNDARYROW.xml' path='doc/member[@name="MIB_BOUNDARYROW.dwGroupMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwGroupMask;
}