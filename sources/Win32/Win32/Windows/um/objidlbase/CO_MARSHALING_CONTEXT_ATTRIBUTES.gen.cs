// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public enum CO_MARSHALING_CONTEXT_ATTRIBUTES
{
    CO_MARSHALING_SOURCE_IS_APP_CONTAINER = 0,
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_1 = unchecked((int)(0x80000000)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_2 = unchecked((int)(0x80000001)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_3 = unchecked((int)(0x80000002)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_4 = unchecked((int)(0x80000003)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_5 = unchecked((int)(0x80000004)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_6 = unchecked((int)(0x80000005)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_7 = unchecked((int)(0x80000006)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_8 = unchecked((int)(0x80000007)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_9 = unchecked((int)(0x80000008)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_10 = unchecked((int)(0x80000009)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_11 = unchecked((int)(0x8000000a)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_12 = unchecked((int)(0x8000000b)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_13 = unchecked((int)(0x8000000c)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_14 = unchecked((int)(0x8000000d)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_15 = unchecked((int)(0x8000000e)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_16 = unchecked((int)(0x8000000f)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_17 = unchecked((int)(0x80000010)),
    CO_MARSHALING_CONTEXT_ATTRIBUTE_RESERVED_18 = unchecked((int)(0x80000011)),
}
