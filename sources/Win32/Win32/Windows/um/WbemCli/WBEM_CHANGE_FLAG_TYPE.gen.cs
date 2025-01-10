// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum WBEM_CHANGE_FLAG_TYPE
{
    WBEM_FLAG_CREATE_OR_UPDATE = 0,
    WBEM_FLAG_UPDATE_ONLY = 0x1,
    WBEM_FLAG_CREATE_ONLY = 0x2,
    WBEM_FLAG_UPDATE_COMPATIBLE = 0,
    WBEM_FLAG_UPDATE_SAFE_MODE = 0x20,
    WBEM_FLAG_UPDATE_FORCE_MODE = 0x40,
    WBEM_MASK_UPDATE_MODE = 0x60,
    WBEM_FLAG_ADVISORY = 0x10000,
}
