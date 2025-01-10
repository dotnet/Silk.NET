// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/httptrace.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class HTTP
{
    [NativeTypeName("#define HTTP_TRACE_EVENT_FLAG_STATIC_DESCRIPTIVE_FIELDS 0x01")]
    public const int HTTP_TRACE_EVENT_FLAG_STATIC_DESCRIPTIVE_FIELDS = 0x01;

    [NativeTypeName("#define HTTP_TRACE_LEVEL_START 6")]
    public const int HTTP_TRACE_LEVEL_START = 6;

    [NativeTypeName("#define HTTP_TRACE_LEVEL_END 7")]
    public const int HTTP_TRACE_LEVEL_END = 7;
}
