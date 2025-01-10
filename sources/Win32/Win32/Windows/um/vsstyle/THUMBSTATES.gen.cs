// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum THUMBSTATES
{
    TUS_NORMAL = 1,
    TUS_HOT = 2,
    TUS_PRESSED = 3,
    TUS_FOCUSED = 4,
    TUS_DISABLED = 5,
}
