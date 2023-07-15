// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TCPIP_OWNER_MODULE_BASIC_INFO.xml' path='doc/member[@name="TCPIP_OWNER_MODULE_BASIC_INFO"]/*'/>
public unsafe partial struct TCPIP_OWNER_MODULE_BASIC_INFO
{
    /// <include file='TCPIP_OWNER_MODULE_BASIC_INFO.xml' path='doc/member[@name="TCPIP_OWNER_MODULE_BASIC_INFO.pModuleName"]/*'/>
    [NativeTypeName("PWCHAR")]
    public ushort* pModuleName;
    /// <include file='TCPIP_OWNER_MODULE_BASIC_INFO.xml' path='doc/member[@name="TCPIP_OWNER_MODULE_BASIC_INFO.pModulePath"]/*'/>
    [NativeTypeName("PWCHAR")]
    public ushort* pModulePath;
}