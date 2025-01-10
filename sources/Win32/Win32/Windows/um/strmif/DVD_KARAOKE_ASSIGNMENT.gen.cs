// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DVD_KARAOKE_ASSIGNMENT
{
    DVD_Assignment_reserved0 = 0,
    DVD_Assignment_reserved1 = 1,
    DVD_Assignment_LR = 2,
    DVD_Assignment_LRM = 3,
    DVD_Assignment_LR1 = 4,
    DVD_Assignment_LRM1 = 5,
    DVD_Assignment_LR12 = 6,
    DVD_Assignment_LRM12 = 7,
}
