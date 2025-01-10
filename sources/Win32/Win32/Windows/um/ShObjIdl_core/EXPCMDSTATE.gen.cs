// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum EXPCMDSTATE
{
    ECS_ENABLED = 0,
    ECS_DISABLED = 0x1,
    ECS_HIDDEN = 0x2,
    ECS_CHECKBOX = 0x4,
    ECS_CHECKED = 0x8,
    ECS_RADIOCHECK = 0x10,
}
