// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='UI_ANIMATION_SCHEDULING_RESULT.xml' path='doc/member[@name="UI_ANIMATION_SCHEDULING_RESULT"]/*' />
public enum UI_ANIMATION_SCHEDULING_RESULT
{
    /// <include file='UI_ANIMATION_SCHEDULING_RESULT.xml' path='doc/member[@name="UI_ANIMATION_SCHEDULING_RESULT.UI_ANIMATION_SCHEDULING_UNEXPECTED_FAILURE"]/*' />
    UI_ANIMATION_SCHEDULING_UNEXPECTED_FAILURE = 0,

    /// <include file='UI_ANIMATION_SCHEDULING_RESULT.xml' path='doc/member[@name="UI_ANIMATION_SCHEDULING_RESULT.UI_ANIMATION_SCHEDULING_INSUFFICIENT_PRIORITY"]/*' />
    UI_ANIMATION_SCHEDULING_INSUFFICIENT_PRIORITY = 1,

    /// <include file='UI_ANIMATION_SCHEDULING_RESULT.xml' path='doc/member[@name="UI_ANIMATION_SCHEDULING_RESULT.UI_ANIMATION_SCHEDULING_ALREADY_SCHEDULED"]/*' />
    UI_ANIMATION_SCHEDULING_ALREADY_SCHEDULED = 2,

    /// <include file='UI_ANIMATION_SCHEDULING_RESULT.xml' path='doc/member[@name="UI_ANIMATION_SCHEDULING_RESULT.UI_ANIMATION_SCHEDULING_SUCCEEDED"]/*' />
    UI_ANIMATION_SCHEDULING_SUCCEEDED = 3,

    /// <include file='UI_ANIMATION_SCHEDULING_RESULT.xml' path='doc/member[@name="UI_ANIMATION_SCHEDULING_RESULT.UI_ANIMATION_SCHEDULING_DEFERRED"]/*' />
    UI_ANIMATION_SCHEDULING_DEFERRED = 4,
}
