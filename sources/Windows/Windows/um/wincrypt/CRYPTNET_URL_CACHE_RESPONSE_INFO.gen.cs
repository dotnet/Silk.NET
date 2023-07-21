// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPTNET_URL_CACHE_RESPONSE_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_RESPONSE_INFO"]/*' />
public unsafe partial struct CRYPTNET_URL_CACHE_RESPONSE_INFO
{
    /// <include file='CRYPTNET_URL_CACHE_RESPONSE_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_RESPONSE_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CRYPTNET_URL_CACHE_RESPONSE_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_RESPONSE_INFO.wResponseType"]/*' />
    [NativeTypeName("WORD")]
    public ushort wResponseType;

    /// <include file='CRYPTNET_URL_CACHE_RESPONSE_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_RESPONSE_INFO.wResponseFlags"]/*' />
    [NativeTypeName("WORD")]
    public ushort wResponseFlags;

    /// <include file='CRYPTNET_URL_CACHE_RESPONSE_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_RESPONSE_INFO.LastModifiedTime"]/*' />
    public FILETIME LastModifiedTime;

    /// <include file='CRYPTNET_URL_CACHE_RESPONSE_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_RESPONSE_INFO.dwMaxAge"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxAge;

    /// <include file='CRYPTNET_URL_CACHE_RESPONSE_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_RESPONSE_INFO.pwszETag"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pwszETag;

    /// <include file='CRYPTNET_URL_CACHE_RESPONSE_INFO.xml' path='doc/member[@name="CRYPTNET_URL_CACHE_RESPONSE_INFO.dwProxyId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProxyId;
}
