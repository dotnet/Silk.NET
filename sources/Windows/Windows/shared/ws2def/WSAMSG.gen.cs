// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/ws2def.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WSAMSG.xml' path='doc/member[@name="WSAMSG"]/*'/>
public unsafe partial struct WSAMSG
{
    /// <include file='WSAMSG.xml' path='doc/member[@name="WSAMSG.name"]/*'/>
    [NativeTypeName("LPSOCKADDR")]
    public SOCKADDR* name;
    /// <include file='WSAMSG.xml' path='doc/member[@name="WSAMSG.namelen"]/*'/>
    public int namelen;
    /// <include file='WSAMSG.xml' path='doc/member[@name="WSAMSG.lpBuffers"]/*'/>
    [NativeTypeName("LPWSABUF")]
    public WSABUF* lpBuffers;
    /// <include file='WSAMSG.xml' path='doc/member[@name="WSAMSG.dwBufferCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwBufferCount;
    /// <include file='WSAMSG.xml' path='doc/member[@name="WSAMSG.Control"]/*'/>
    public WSABUF Control;
    /// <include file='WSAMSG.xml' path='doc/member[@name="WSAMSG.dwFlags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint dwFlags;
}