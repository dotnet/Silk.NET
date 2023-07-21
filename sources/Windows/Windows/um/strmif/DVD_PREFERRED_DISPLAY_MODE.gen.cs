// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DVD_PREFERRED_DISPLAY_MODE.xml' path='doc/member[@name="DVD_PREFERRED_DISPLAY_MODE"]/*' />
public enum DVD_PREFERRED_DISPLAY_MODE
{
    /// <include file='DVD_PREFERRED_DISPLAY_MODE.xml' path='doc/member[@name="DVD_PREFERRED_DISPLAY_MODE.DISPLAY_CONTENT_DEFAULT"]/*' />
    DISPLAY_CONTENT_DEFAULT = 0,

    /// <include file='DVD_PREFERRED_DISPLAY_MODE.xml' path='doc/member[@name="DVD_PREFERRED_DISPLAY_MODE.DISPLAY_16x9"]/*' />
    DISPLAY_16x9 = 1,

    /// <include file='DVD_PREFERRED_DISPLAY_MODE.xml' path='doc/member[@name="DVD_PREFERRED_DISPLAY_MODE.DISPLAY_4x3_PANSCAN_PREFERRED"]/*' />
    DISPLAY_4x3_PANSCAN_PREFERRED = 2,

    /// <include file='DVD_PREFERRED_DISPLAY_MODE.xml' path='doc/member[@name="DVD_PREFERRED_DISPLAY_MODE.DISPLAY_4x3_LETTERBOX_PREFERRED"]/*' />
    DISPLAY_4x3_LETTERBOX_PREFERRED = 3,
}
