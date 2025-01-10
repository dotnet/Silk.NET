// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wslapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum WSL_DISTRIBUTION_FLAGS
{
    WSL_DISTRIBUTION_FLAGS_NONE = 0x0,
    WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP = 0x1,
    WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH = 0x2,
    WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING = 0x4,
}
