// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='WINHTTP_WEB_SOCKET_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_STATUS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct WINHTTP_WEB_SOCKET_STATUS
{
    /// <include file='WINHTTP_WEB_SOCKET_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_STATUS.dwBytesTransferred"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwBytesTransferred;
    /// <include file='WINHTTP_WEB_SOCKET_STATUS.xml' path='doc/member[@name="WINHTTP_WEB_SOCKET_STATUS.eBufferType"]/*'/>
    public WINHTTP_WEB_SOCKET_BUFFER_TYPE eBufferType;
}