// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum FILE_WRITE_FLAGS
{
    FILE_WRITE_FLAGS_NONE = 0,
    FILE_WRITE_FLAGS_WRITE_THROUGH = 0x000000001,
}
