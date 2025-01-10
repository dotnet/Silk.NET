// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum htmlFrame
{
    htmlFrameNotSet = 0,
    htmlFramevoid = 1,
    htmlFrameabove = 2,
    htmlFramebelow = 3,
    htmlFramehsides = 4,
    htmlFramelhs = 5,
    htmlFramerhs = 6,
    htmlFramevsides = 7,
    htmlFramebox = 8,
    htmlFrameborder = 9,
    htmlFrame_Max = 2147483647,
}
