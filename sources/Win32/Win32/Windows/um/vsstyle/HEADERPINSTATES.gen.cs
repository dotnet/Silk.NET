// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum HEADERPINSTATES
{
    EBHP_NORMAL = 1,
    EBHP_HOT = 2,
    EBHP_PRESSED = 3,
    EBHP_SELECTEDNORMAL = 4,
    EBHP_SELECTEDHOT = 5,
    EBHP_SELECTEDPRESSED = 6,
}
