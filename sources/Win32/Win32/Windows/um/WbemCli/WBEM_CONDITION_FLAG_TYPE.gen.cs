// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WBEM_CONDITION_FLAG_TYPE
{
    WBEM_FLAG_ALWAYS = 0,
    WBEM_FLAG_ONLY_IF_TRUE = 0x1,
    WBEM_FLAG_ONLY_IF_FALSE = 0x2,
    WBEM_FLAG_ONLY_IF_IDENTICAL = 0x3,
    WBEM_MASK_PRIMARY_CONDITION = 0x3,
    WBEM_FLAG_KEYS_ONLY = 0x4,
    WBEM_FLAG_REFS_ONLY = 0x8,
    WBEM_FLAG_LOCAL_ONLY = 0x10,
    WBEM_FLAG_PROPAGATED_ONLY = 0x20,
    WBEM_FLAG_SYSTEM_ONLY = 0x30,
    WBEM_FLAG_NONSYSTEM_ONLY = 0x40,
    WBEM_MASK_CONDITION_ORIGIN = 0x70,
    WBEM_FLAG_CLASS_OVERRIDES_ONLY = 0x100,
    WBEM_FLAG_CLASS_LOCAL_AND_OVERRIDES = 0x200,
    WBEM_MASK_CLASS_CONDITION = 0x300,
}
