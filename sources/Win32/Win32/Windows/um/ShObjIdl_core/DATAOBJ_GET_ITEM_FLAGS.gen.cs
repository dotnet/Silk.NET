// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum DATAOBJ_GET_ITEM_FLAGS
{
    DOGIF_DEFAULT = 0,
    DOGIF_TRAVERSE_LINK = 0x1,
    DOGIF_NO_HDROP = 0x2,
    DOGIF_NO_URL = 0x4,
    DOGIF_ONLY_IF_ONE = 0x8,
}
