// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_TIMED_TEXT_DECORATION.xml' path='doc/member[@name="MF_TIMED_TEXT_DECORATION"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum MF_TIMED_TEXT_DECORATION
{
    /// <include file='MF_TIMED_TEXT_DECORATION.xml' path='doc/member[@name="MF_TIMED_TEXT_DECORATION.MF_TIMED_TEXT_DECORATION_NONE"]/*' />
    MF_TIMED_TEXT_DECORATION_NONE = 0,

    /// <include file='MF_TIMED_TEXT_DECORATION.xml' path='doc/member[@name="MF_TIMED_TEXT_DECORATION.MF_TIMED_TEXT_DECORATION_UNDERLINE"]/*' />
    MF_TIMED_TEXT_DECORATION_UNDERLINE = 1,

    /// <include file='MF_TIMED_TEXT_DECORATION.xml' path='doc/member[@name="MF_TIMED_TEXT_DECORATION.MF_TIMED_TEXT_DECORATION_LINE_THROUGH"]/*' />
    MF_TIMED_TEXT_DECORATION_LINE_THROUGH = 2,

    /// <include file='MF_TIMED_TEXT_DECORATION.xml' path='doc/member[@name="MF_TIMED_TEXT_DECORATION.MF_TIMED_TEXT_DECORATION_OVERLINE"]/*' />
    MF_TIMED_TEXT_DECORATION_OVERLINE = 4,
}
