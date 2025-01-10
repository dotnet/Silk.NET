// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WBEM_GENERIC_FLAG_TYPE
{
    WBEM_FLAG_RETURN_IMMEDIATELY = 0x10,
    WBEM_FLAG_RETURN_WBEM_COMPLETE = 0,
    WBEM_FLAG_BIDIRECTIONAL = 0,
    WBEM_FLAG_FORWARD_ONLY = 0x20,
    WBEM_FLAG_NO_ERROR_OBJECT = 0x40,
    WBEM_FLAG_RETURN_ERROR_OBJECT = 0,
    WBEM_FLAG_SEND_STATUS = 0x80,
    WBEM_FLAG_DONT_SEND_STATUS = 0,
    WBEM_FLAG_ENSURE_LOCATABLE = 0x100,
    WBEM_FLAG_DIRECT_READ = 0x200,
    WBEM_FLAG_SEND_ONLY_SELECTED = 0,
    WBEM_RETURN_WHEN_COMPLETE = 0,
    WBEM_RETURN_IMMEDIATELY = 0x10,
    WBEM_MASK_RESERVED_FLAGS = 0x1f000,
    WBEM_FLAG_USE_AMENDED_QUALIFIERS = 0x20000,
    WBEM_FLAG_STRONG_VALIDATION = 0x100000,
}
