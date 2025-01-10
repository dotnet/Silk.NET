// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum SHREGDEL_FLAGS
{
    SHREGDEL_DEFAULT = 0x00000000,
    SHREGDEL_HKCU = 0x00000001,
    SHREGDEL_HKLM = 0x00000010,
    SHREGDEL_BOTH = 0x00000011,
}
