// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MENUBANDSTATES
{
    MDS_NORMAL = 1,
    MDS_HOT = 2,
    MDS_PRESSED = 3,
    MDS_DISABLED = 4,
    MDS_CHECKED = 5,
    MDS_HOTCHECKED = 6,
}
