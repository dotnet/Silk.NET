// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIB_OPAQUE_QUERY.xml' path='doc/member[@name="MIB_OPAQUE_QUERY"]/*'/>
public unsafe partial struct MIB_OPAQUE_QUERY
{
    /// <include file='MIB_OPAQUE_QUERY.xml' path='doc/member[@name="MIB_OPAQUE_QUERY.dwVarId"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVarId;
    /// <include file='MIB_OPAQUE_QUERY.xml' path='doc/member[@name="MIB_OPAQUE_QUERY.rgdwVarIndex"]/*'/>
    [NativeTypeName("DWORD[1]")]
    public fixed uint rgdwVarIndex[1];
}