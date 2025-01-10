// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum TimedTextRubyAlign
{
    TimedTextRubyAlign_Center = 0,
    TimedTextRubyAlign_Start = 1,
    TimedTextRubyAlign_End = 2,
    TimedTextRubyAlign_SpaceAround = 3,
    TimedTextRubyAlign_SpaceBetween = 4,
    TimedTextRubyAlign_WithBase = 5,
}
