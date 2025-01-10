// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct HTTP_REQUEST_V1
{
    [NativeTypeName("ULONG")]
    public uint Flags;

    [NativeTypeName("HTTP_CONNECTION_ID")]
    public ulong ConnectionId;

    [NativeTypeName("HTTP_REQUEST_ID")]
    public ulong RequestId;

    [NativeTypeName("HTTP_URL_CONTEXT")]
    public ulong UrlContext;
    public HTTP_VERSION Version;
    public HTTP_VERB Verb;
    public ushort UnknownVerbLength;
    public ushort RawUrlLength;

    [NativeTypeName("PCSTR")]
    public sbyte* pUnknownVerb;

    [NativeTypeName("PCSTR")]
    public sbyte* pRawUrl;
    public HTTP_COOKED_URL CookedUrl;
    public HTTP_TRANSPORT_ADDRESS Address;
    public HTTP_REQUEST_HEADERS Headers;

    [NativeTypeName("ULONGLONG")]
    public ulong BytesReceived;
    public ushort EntityChunkCount;

    [NativeTypeName("PHTTP_DATA_CHUNK")]
    public HTTP_DATA_CHUNK* pEntityChunks;

    [NativeTypeName("HTTP_RAW_CONNECTION_ID")]
    public ulong RawConnectionId;

    [NativeTypeName("PHTTP_SSL_INFO")]
    public HTTP_SSL_INFO* pSslInfo;
}
