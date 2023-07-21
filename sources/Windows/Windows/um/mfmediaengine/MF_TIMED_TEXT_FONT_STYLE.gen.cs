// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_TIMED_TEXT_FONT_STYLE.xml' path='doc/member[@name="MF_TIMED_TEXT_FONT_STYLE"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum MF_TIMED_TEXT_FONT_STYLE
{
    /// <include file='MF_TIMED_TEXT_FONT_STYLE.xml' path='doc/member[@name="MF_TIMED_TEXT_FONT_STYLE.MF_TIMED_TEXT_FONT_STYLE_NORMAL"]/*' />
    MF_TIMED_TEXT_FONT_STYLE_NORMAL = 0,

    /// <include file='MF_TIMED_TEXT_FONT_STYLE.xml' path='doc/member[@name="MF_TIMED_TEXT_FONT_STYLE.MF_TIMED_TEXT_FONT_STYLE_OBLIQUE"]/*' />
    MF_TIMED_TEXT_FONT_STYLE_OBLIQUE = 1,

    /// <include file='MF_TIMED_TEXT_FONT_STYLE.xml' path='doc/member[@name="MF_TIMED_TEXT_FONT_STYLE.MF_TIMED_TEXT_FONT_STYLE_ITALIC"]/*' />
    MF_TIMED_TEXT_FONT_STYLE_ITALIC = 2,
}
