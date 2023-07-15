// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='NETCONNECTINFOSTRUCT.xml' path='doc/member[@name="NETCONNECTINFOSTRUCT"]/*'/>
public partial struct NETCONNECTINFOSTRUCT
{
    /// <include file='NETCONNECTINFOSTRUCT.xml' path='doc/member[@name="NETCONNECTINFOSTRUCT.cbStructure"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStructure;
    /// <include file='NETCONNECTINFOSTRUCT.xml' path='doc/member[@name="NETCONNECTINFOSTRUCT.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='NETCONNECTINFOSTRUCT.xml' path='doc/member[@name="NETCONNECTINFOSTRUCT.dwSpeed"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSpeed;
    /// <include file='NETCONNECTINFOSTRUCT.xml' path='doc/member[@name="NETCONNECTINFOSTRUCT.dwDelay"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDelay;
    /// <include file='NETCONNECTINFOSTRUCT.xml' path='doc/member[@name="NETCONNECTINFOSTRUCT.dwOptDataSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwOptDataSize;
}