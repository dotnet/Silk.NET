// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS"]/*' />
public unsafe partial struct URL_COMPONENTS
{
    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.dwStructSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStructSize;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.lpszScheme"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpszScheme;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.dwSchemeLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSchemeLength;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.nScheme"]/*' />
    [NativeTypeName("INTERNET_SCHEME")]
    public int nScheme;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.lpszHostName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpszHostName;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.dwHostNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHostNameLength;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.nPort"]/*' />
    [NativeTypeName("INTERNET_PORT")]
    public ushort nPort;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.lpszUserName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpszUserName;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.dwUserNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwUserNameLength;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.lpszPassword"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpszPassword;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.dwPasswordLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPasswordLength;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.lpszUrlPath"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpszUrlPath;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.dwUrlPathLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwUrlPathLength;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.lpszExtraInfo"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpszExtraInfo;

    /// <include file='URL_COMPONENTS.xml' path='doc/member[@name="URL_COMPONENTS.dwExtraInfoLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwExtraInfoLength;
}
