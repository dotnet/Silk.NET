// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/http.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct HTTP_SERVICE_CONFIG_SSL_PARAM_EX
{
    public HTTP_SSL_SERVICE_CONFIG_EX_PARAM_TYPE ParamType;

    [NativeTypeName("ULONGLONG")]
    public ulong Flags;

    [NativeTypeName("__AnonymousRecord_http_L2474_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref HTTP2_WINDOW_SIZE_PARAM Http2WindowSizeParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Http2WindowSizeParam; }
    }

    [UnscopedRef]
    public ref HTTP2_SETTINGS_LIMITS_PARAM Http2SettingsLimitsParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Http2SettingsLimitsParam; }
    }

    [UnscopedRef]
    public ref HTTP_PERFORMANCE_PARAM HttpPerformanceParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.HttpPerformanceParam; }
    }

    [UnscopedRef]
    public ref HTTP_TLS_RESTRICTIONS_PARAM HttpTlsRestrictionsParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.HttpTlsRestrictionsParam; }
    }

    [UnscopedRef]
    public ref HTTP_ERROR_HEADERS_PARAM HttpErrorHeadersParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.HttpErrorHeadersParam; }
    }

    [UnscopedRef]
    public ref HTTP_TLS_SESSION_TICKET_KEYS_PARAM HttpTlsSessionTicketKeysParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.HttpTlsSessionTicketKeysParam; }
    }

    [UnscopedRef]
    public ref HTTP_CERT_CONFIG_PARAM HttpCertConfigParam
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.HttpCertConfigParam; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HTTP2_WINDOW_SIZE_PARAM Http2WindowSizeParam;

        [FieldOffset(0)]
        public HTTP2_SETTINGS_LIMITS_PARAM Http2SettingsLimitsParam;

        [FieldOffset(0)]
        public HTTP_PERFORMANCE_PARAM HttpPerformanceParam;

        [FieldOffset(0)]
        public HTTP_TLS_RESTRICTIONS_PARAM HttpTlsRestrictionsParam;

        [FieldOffset(0)]
        public HTTP_ERROR_HEADERS_PARAM HttpErrorHeadersParam;

        [FieldOffset(0)]
        public HTTP_TLS_SESSION_TICKET_KEYS_PARAM HttpTlsSessionTicketKeysParam;

        [FieldOffset(0)]
        public HTTP_CERT_CONFIG_PARAM HttpCertConfigParam;
    }
}
