// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MIB_IPMCAST_GLOBAL.xml' path='doc/member[@name="MIB_IPMCAST_GLOBAL"]/*'/>
public partial struct MIB_IPMCAST_GLOBAL
{
    /// <include file='MIB_IPMCAST_GLOBAL.xml' path='doc/member[@name="MIB_IPMCAST_GLOBAL.dwEnable"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwEnable;
}