// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct CRYPT_RETRIEVE_AUX_INFO
{
    [NativeTypeName("DWORD")]
    public uint cbSize;
    public FILETIME* pLastSyncTime;

    [NativeTypeName("DWORD")]
    public uint dwMaxUrlRetrievalByteCount;

    [NativeTypeName("PCRYPTNET_URL_CACHE_PRE_FETCH_INFO")]
    public CRYPTNET_URL_CACHE_PRE_FETCH_INFO* pPreFetchInfo;

    [NativeTypeName("PCRYPTNET_URL_CACHE_FLUSH_INFO")]
    public CRYPTNET_URL_CACHE_FLUSH_INFO* pFlushInfo;

    [NativeTypeName("PCRYPTNET_URL_CACHE_RESPONSE_INFO *")]
    public CRYPTNET_URL_CACHE_RESPONSE_INFO** ppResponseInfo;

    [NativeTypeName("LPWSTR")]
    public ushort* pwszCacheFileNamePrefix;

    [NativeTypeName("LPFILETIME")]
    public FILETIME* pftCacheResync;
    public BOOL fProxyCacheRetrieval;

    [NativeTypeName("DWORD")]
    public uint dwHttpStatusCode;

    [NativeTypeName("LPWSTR *")]
    public ushort** ppwszErrorResponseHeaders;

    [NativeTypeName("PCRYPT_DATA_BLOB *")]
    public CRYPT_DATA_BLOB** ppErrorContentBlob;
}
