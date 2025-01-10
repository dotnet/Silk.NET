// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum PROPERTYUI_FLAGS
{
    PUIF_DEFAULT = 0,
    PUIF_RIGHTALIGN = 0x1,
    PUIF_NOLABELININFOTIP = 0x2,
}
