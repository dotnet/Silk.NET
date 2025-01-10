// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AHTYPE
{
    AHTYPE_UNDEFINED = 0,
    AHTYPE_USER_APPLICATION = 0x8,
    AHTYPE_ANY_APPLICATION = 0x10,
    AHTYPE_MACHINEDEFAULT = 0x20,
    AHTYPE_PROGID = 0x40,
    AHTYPE_APPLICATION = 0x80,
    AHTYPE_CLASS_APPLICATION = 0x100,
    AHTYPE_ANY_PROGID = 0x200,
}
