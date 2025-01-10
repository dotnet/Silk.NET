// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum THUMBVERTSTATES
{
    TUVS_NORMAL = 1,
    TUVS_HOT = 2,
    TUVS_PRESSED = 3,
    TUVS_FOCUSED = 4,
    TUVS_DISABLED = 5,
}
