// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpInitialize(
        HTTPAPI_VERSION Version,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("PVOID")] void* pReserved
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpTerminate(
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("PVOID")] void* pReserved
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCreateHttpHandle(
        [NativeTypeName("PHANDLE")] HANDLE* RequestQueueHandle,
        [NativeTypeName("ULONG")] uint Reserved
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCreateRequestQueue(
        HTTPAPI_VERSION Version,
        [NativeTypeName("PCWSTR")] ushort* Name,
        [NativeTypeName("PSECURITY_ATTRIBUTES")] SECURITY_ATTRIBUTES* SecurityAttributes,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("PHANDLE")] HANDLE* RequestQueueHandle
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCloseRequestQueue(HANDLE RequestQueueHandle);

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSetRequestQueueProperty(
        HANDLE RequestQueueHandle,
        HTTP_SERVER_PROPERTY Property,
        [NativeTypeName("PVOID")] void* PropertyInformation,
        [NativeTypeName("ULONG")] uint PropertyInformationLength,
        [NativeTypeName("ULONG")] uint Reserved1,
        [NativeTypeName("PVOID")] void* Reserved2
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpQueryRequestQueueProperty(
        HANDLE RequestQueueHandle,
        HTTP_SERVER_PROPERTY Property,
        [NativeTypeName("PVOID")] void* PropertyInformation,
        [NativeTypeName("ULONG")] uint PropertyInformationLength,
        [NativeTypeName("ULONG")] uint Reserved1,
        [NativeTypeName("PULONG")] uint* ReturnLength,
        [NativeTypeName("PVOID")] void* Reserved2
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSetRequestProperty(
        HANDLE RequestQueueHandle,
        [NativeTypeName("HTTP_OPAQUE_ID")] ulong Id,
        HTTP_REQUEST_PROPERTY PropertyId,
        [NativeTypeName("PVOID")] void* Input,
        [NativeTypeName("ULONG")] uint InputPropertySize,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpShutdownRequestQueue(HANDLE RequestQueueHandle);

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpReceiveClientCertificate(
        HANDLE RequestQueueHandle,
        [NativeTypeName("HTTP_CONNECTION_ID")] ulong ConnectionId,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("PHTTP_SSL_CLIENT_CERT_INFO")] HTTP_SSL_CLIENT_CERT_INFO* SslClientCertInfo,
        [NativeTypeName("ULONG")] uint SslClientCertInfoSize,
        [NativeTypeName("PULONG")] uint* BytesReceived,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCreateServerSession(
        HTTPAPI_VERSION Version,
        [NativeTypeName("PHTTP_SERVER_SESSION_ID")] ulong* ServerSessionId,
        [NativeTypeName("ULONG")] uint Reserved
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCloseServerSession(
        [NativeTypeName("HTTP_SERVER_SESSION_ID")] ulong ServerSessionId
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpQueryServerSessionProperty(
        [NativeTypeName("HTTP_SERVER_SESSION_ID")] ulong ServerSessionId,
        HTTP_SERVER_PROPERTY Property,
        [NativeTypeName("PVOID")] void* PropertyInformation,
        [NativeTypeName("ULONG")] uint PropertyInformationLength,
        [NativeTypeName("PULONG")] uint* ReturnLength
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSetServerSessionProperty(
        [NativeTypeName("HTTP_SERVER_SESSION_ID")] ulong ServerSessionId,
        HTTP_SERVER_PROPERTY Property,
        [NativeTypeName("PVOID")] void* PropertyInformation,
        [NativeTypeName("ULONG")] uint PropertyInformationLength
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpAddUrl(
        HANDLE RequestQueueHandle,
        [NativeTypeName("PCWSTR")] ushort* FullyQualifiedUrl,
        [NativeTypeName("PVOID")] void* Reserved
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpRemoveUrl(
        HANDLE RequestQueueHandle,
        [NativeTypeName("PCWSTR")] ushort* FullyQualifiedUrl
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCreateUrlGroup(
        [NativeTypeName("HTTP_SERVER_SESSION_ID")] ulong ServerSessionId,
        [NativeTypeName("PHTTP_URL_GROUP_ID")] ulong* pUrlGroupId,
        [NativeTypeName("ULONG")] uint Reserved
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCloseUrlGroup(
        [NativeTypeName("HTTP_URL_GROUP_ID")] ulong UrlGroupId
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpAddUrlToUrlGroup(
        [NativeTypeName("HTTP_URL_GROUP_ID")] ulong UrlGroupId,
        [NativeTypeName("PCWSTR")] ushort* pFullyQualifiedUrl,
        [NativeTypeName("HTTP_URL_CONTEXT")] ulong UrlContext,
        [NativeTypeName("ULONG")] uint Reserved
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpRemoveUrlFromUrlGroup(
        [NativeTypeName("HTTP_URL_GROUP_ID")] ulong UrlGroupId,
        [NativeTypeName("PCWSTR")] ushort* pFullyQualifiedUrl,
        [NativeTypeName("ULONG")] uint Flags
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSetUrlGroupProperty(
        [NativeTypeName("HTTP_URL_GROUP_ID")] ulong UrlGroupId,
        HTTP_SERVER_PROPERTY Property,
        [NativeTypeName("PVOID")] void* PropertyInformation,
        [NativeTypeName("ULONG")] uint PropertyInformationLength
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpQueryUrlGroupProperty(
        [NativeTypeName("HTTP_URL_GROUP_ID")] ulong UrlGroupId,
        HTTP_SERVER_PROPERTY Property,
        [NativeTypeName("PVOID")] void* PropertyInformation,
        [NativeTypeName("ULONG")] uint PropertyInformationLength,
        [NativeTypeName("PULONG")] uint* ReturnLength
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint HttpPrepareUrl(
        [NativeTypeName("PVOID")] void* Reserved,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("PCWSTR")] ushort* Url,
        [NativeTypeName("PWSTR *")] ushort** PreparedUrl
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpReceiveHttpRequest(
        HANDLE RequestQueueHandle,
        [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("PHTTP_REQUEST")] HTTP_REQUEST_V2* RequestBuffer,
        [NativeTypeName("ULONG")] uint RequestBufferLength,
        [NativeTypeName("PULONG")] uint* BytesReturned,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpReceiveRequestEntityBody(
        HANDLE RequestQueueHandle,
        [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("PVOID")] void* EntityBuffer,
        [NativeTypeName("ULONG")] uint EntityBufferLength,
        [NativeTypeName("PULONG")] uint* BytesReturned,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSendHttpResponse(
        HANDLE RequestQueueHandle,
        [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("PHTTP_RESPONSE")] HTTP_RESPONSE_V2* HttpResponse,
        [NativeTypeName("PHTTP_CACHE_POLICY")] HTTP_CACHE_POLICY* CachePolicy,
        [NativeTypeName("PULONG")] uint* BytesSent,
        [NativeTypeName("PVOID")] void* Reserved1,
        [NativeTypeName("ULONG")] uint Reserved2,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped,
        [NativeTypeName("PHTTP_LOG_DATA")] HTTP_LOG_DATA* LogData
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSendResponseEntityBody(
        HANDLE RequestQueueHandle,
        [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId,
        [NativeTypeName("ULONG")] uint Flags,
        ushort EntityChunkCount,
        [NativeTypeName("PHTTP_DATA_CHUNK")] HTTP_DATA_CHUNK* EntityChunks,
        [NativeTypeName("PULONG")] uint* BytesSent,
        [NativeTypeName("PVOID")] void* Reserved1,
        [NativeTypeName("ULONG")] uint Reserved2,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped,
        [NativeTypeName("PHTTP_LOG_DATA")] HTTP_LOG_DATA* LogData
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0")]
    public static extern uint HttpDeclarePush(
        HANDLE RequestQueueHandle,
        [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId,
        HTTP_VERB Verb,
        [NativeTypeName("PCWSTR")] ushort* Path,
        [NativeTypeName("PCSTR")] sbyte* Query,
        [NativeTypeName("PHTTP_REQUEST_HEADERS")] HTTP_REQUEST_HEADERS* Headers
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpWaitForDisconnect(
        HANDLE RequestQueueHandle,
        [NativeTypeName("HTTP_CONNECTION_ID")] ulong ConnectionId,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpWaitForDisconnectEx(
        HANDLE RequestQueueHandle,
        [NativeTypeName("HTTP_CONNECTION_ID")] ulong ConnectionId,
        [NativeTypeName("ULONG")] uint Reserved,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpCancelHttpRequest(
        HANDLE RequestQueueHandle,
        [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpWaitForDemandStart(
        HANDLE RequestQueueHandle,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern BOOL HttpIsFeatureSupported(HTTP_FEATURE_ID FeatureId);

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint HttpDelegateRequestEx(
        HANDLE RequestQueueHandle,
        HANDLE DelegateQueueHandle,
        [NativeTypeName("HTTP_REQUEST_ID")] ulong RequestId,
        [NativeTypeName("HTTP_URL_GROUP_ID")] ulong DelegateUrlGroupId,
        [NativeTypeName("ULONG")] uint PropertyInfoSetSize,
        [NativeTypeName("PHTTP_DELEGATE_REQUEST_PROPERTY_INFO")]
            HTTP_DELEGATE_REQUEST_PROPERTY_INFO* PropertyInfoSet
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0.19043.0")]
    public static extern uint HttpFindUrlGroupId(
        [NativeTypeName("PCWSTR")] ushort* FullyQualifiedUrl,
        HANDLE RequestQueueHandle,
        [NativeTypeName("PHTTP_URL_GROUP_ID")] ulong* UrlGroupId
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpFlushResponseCache(
        HANDLE RequestQueueHandle,
        [NativeTypeName("PCWSTR")] ushort* UrlPrefix,
        [NativeTypeName("ULONG")] uint Flags,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpAddFragmentToCache(
        HANDLE RequestQueueHandle,
        [NativeTypeName("PCWSTR")] ushort* UrlPrefix,
        [NativeTypeName("PHTTP_DATA_CHUNK")] HTTP_DATA_CHUNK* DataChunk,
        [NativeTypeName("PHTTP_CACHE_POLICY")] HTTP_CACHE_POLICY* CachePolicy,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpReadFragmentFromCache(
        HANDLE RequestQueueHandle,
        [NativeTypeName("PCWSTR")] ushort* UrlPrefix,
        [NativeTypeName("PHTTP_BYTE_RANGE")] HTTP_BYTE_RANGE* ByteRange,
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("ULONG")] uint BufferLength,
        [NativeTypeName("PULONG")] uint* BytesRead,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpSetServiceConfiguration(
        HANDLE ServiceHandle,
        HTTP_SERVICE_CONFIG_ID ConfigId,
        [NativeTypeName("PVOID")] void* pConfigInformation,
        [NativeTypeName("ULONG")] uint ConfigInformationLength,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* pOverlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    [SupportedOSPlatform("windows10.0.15063.0")]
    public static extern uint HttpUpdateServiceConfiguration(
        HANDLE Handle,
        HTTP_SERVICE_CONFIG_ID ConfigId,
        [NativeTypeName("PVOID")] void* ConfigInfo,
        [NativeTypeName("ULONG")] uint ConfigInfoLength,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* Overlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpDeleteServiceConfiguration(
        HANDLE ServiceHandle,
        HTTP_SERVICE_CONFIG_ID ConfigId,
        [NativeTypeName("PVOID")] void* pConfigInformation,
        [NativeTypeName("ULONG")] uint ConfigInformationLength,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* pOverlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpQueryServiceConfiguration(
        HANDLE ServiceHandle,
        HTTP_SERVICE_CONFIG_ID ConfigId,
        [NativeTypeName("PVOID")] void* pInput,
        [NativeTypeName("ULONG")] uint InputLength,
        [NativeTypeName("PVOID")] void* pOutput,
        [NativeTypeName("ULONG")] uint OutputLength,
        [NativeTypeName("PULONG")] uint* pReturnLength,
        [NativeTypeName("LPOVERLAPPED")] OVERLAPPED* pOverlapped
    );

    [DllImport("httpapi", ExactSpelling = true)]
    [return: NativeTypeName("ULONG")]
    public static extern uint HttpGetExtension(
        HTTPAPI_VERSION Version,
        [NativeTypeName("ULONG")] uint Extension,
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("ULONG")] uint BufferSize
    );
}
