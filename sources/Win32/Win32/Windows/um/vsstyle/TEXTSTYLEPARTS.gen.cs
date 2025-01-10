// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum TEXTSTYLEPARTS
{
    TEXT_MAININSTRUCTION = 1,
    TEXT_INSTRUCTION = 2,
    TEXT_BODYTITLE = 3,
    TEXT_BODYTEXT = 4,
    TEXT_SECONDARYTEXT = 5,
    TEXT_HYPERLINKTEXT = 6,
    TEXT_EXPANDED = 7,
    TEXT_LABEL = 8,
    TEXT_CONTROLLABEL = 9,
}
