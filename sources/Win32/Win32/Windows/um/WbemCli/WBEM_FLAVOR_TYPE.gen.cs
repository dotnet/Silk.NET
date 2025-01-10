// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WBEM_FLAVOR_TYPE
{
    WBEM_FLAVOR_DONT_PROPAGATE = 0,
    WBEM_FLAVOR_FLAG_PROPAGATE_TO_INSTANCE = 0x1,
    WBEM_FLAVOR_FLAG_PROPAGATE_TO_DERIVED_CLASS = 0x2,
    WBEM_FLAVOR_MASK_PROPAGATION = 0xf,
    WBEM_FLAVOR_OVERRIDABLE = 0,
    WBEM_FLAVOR_NOT_OVERRIDABLE = 0x10,
    WBEM_FLAVOR_MASK_PERMISSIONS = 0x10,
    WBEM_FLAVOR_ORIGIN_LOCAL = 0,
    WBEM_FLAVOR_ORIGIN_PROPAGATED = 0x20,
    WBEM_FLAVOR_ORIGIN_SYSTEM = 0x40,
    WBEM_FLAVOR_MASK_ORIGIN = 0x60,
    WBEM_FLAVOR_NOT_AMENDED = 0,
    WBEM_FLAVOR_AMENDED = 0x80,
    WBEM_FLAVOR_MASK_AMENDED = 0x80,
}
