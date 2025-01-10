// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httptrace.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum HTTP_TRACE_TYPE
{
    HTTP_TRACE_TYPE_BYTE = 17,
    HTTP_TRACE_TYPE_USHORT = 18,
    HTTP_TRACE_TYPE_ULONG = 19,
    HTTP_TRACE_TYPE_ULONGLONG = 21,
    HTTP_TRACE_TYPE_CHAR = 16,
    HTTP_TRACE_TYPE_SHORT = 2,
    HTTP_TRACE_TYPE_LONG = 3,
    HTTP_TRACE_TYPE_LONGLONG = 20,
    HTTP_TRACE_TYPE_LPCWSTR = 31,
    HTTP_TRACE_TYPE_LPCSTR = 30,
    HTTP_TRACE_TYPE_LPCGUID = 72,
    HTTP_TRACE_TYPE_BOOL = 11,
}
