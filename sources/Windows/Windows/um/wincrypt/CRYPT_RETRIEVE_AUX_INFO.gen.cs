// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO"]/*' />
public unsafe partial struct CRYPT_RETRIEVE_AUX_INFO
{
    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.pLastSyncTime"]/*' />
    public FILETIME* pLastSyncTime;

    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.dwMaxUrlRetrievalByteCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMaxUrlRetrievalByteCount;

    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.pPreFetchInfo"]/*' />
    [NativeTypeName("PCRYPTNET_URL_CACHE_PRE_FETCH_INFO")]
    public CRYPTNET_URL_CACHE_PRE_FETCH_INFO* pPreFetchInfo;

    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.pFlushInfo"]/*' />
    [NativeTypeName("PCRYPTNET_URL_CACHE_FLUSH_INFO")]
    public CRYPTNET_URL_CACHE_FLUSH_INFO* pFlushInfo;

    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.ppResponseInfo"]/*' />
    [NativeTypeName("PCRYPTNET_URL_CACHE_RESPONSE_INFO *")]
    public CRYPTNET_URL_CACHE_RESPONSE_INFO** ppResponseInfo;

    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.pwszCacheFileNamePrefix"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwszCacheFileNamePrefix;

    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.pftCacheResync"]/*' />
    [NativeTypeName("LPFILETIME")]
    public FILETIME* pftCacheResync;

    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.fProxyCacheRetrieval"]/*' />
    public BOOL fProxyCacheRetrieval;

    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.dwHttpStatusCode"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHttpStatusCode;

    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.ppwszErrorResponseHeaders"]/*' />
    [NativeTypeName("LPWSTR *")]
    public ushort** ppwszErrorResponseHeaders;

    /// <include file='CRYPT_RETRIEVE_AUX_INFO.xml' path='doc/member[@name="CRYPT_RETRIEVE_AUX_INFO.ppErrorContentBlob"]/*' />
    [NativeTypeName("PCRYPT_DATA_BLOB *")]
    public CRYPT_DATA_BLOB** ppErrorContentBlob;
}
