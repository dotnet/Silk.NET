// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum styleRubyAlign
{
    styleRubyAlignNotSet = 0,
    styleRubyAlignAuto = 1,
    styleRubyAlignLeft = 2,
    styleRubyAlignCenter = 3,
    styleRubyAlignRight = 4,
    styleRubyAlignDistributeLetter = 5,
    styleRubyAlignDistributeSpace = 6,
    styleRubyAlignLineEdge = 7,
    styleRubyAlign_Max = 2147483647,
}
