// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum MF_TIMED_TEXT_RUBY_ALIGN
{
    MF_TIMED_TEXT_RUBY_ALIGN_CENTER = 0,
    MF_TIMED_TEXT_RUBY_ALIGN_START = 1,
    MF_TIMED_TEXT_RUBY_ALIGN_END = 2,
    MF_TIMED_TEXT_RUBY_ALIGN_SPACEAROUND = 3,
    MF_TIMED_TEXT_RUBY_ALIGN_SPACEBETWEEN = 4,
    MF_TIMED_TEXT_RUBY_ALIGN_WITHBASE = 5,
}
