// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='APPLICATION_VIEW_SIZE_PREFERENCE.xml' path='doc/member[@name="APPLICATION_VIEW_SIZE_PREFERENCE"]/*' />
public enum APPLICATION_VIEW_SIZE_PREFERENCE
{
    /// <include file='APPLICATION_VIEW_SIZE_PREFERENCE.xml' path='doc/member[@name="APPLICATION_VIEW_SIZE_PREFERENCE.AVSP_DEFAULT"]/*' />
    AVSP_DEFAULT = 0,

    /// <include file='APPLICATION_VIEW_SIZE_PREFERENCE.xml' path='doc/member[@name="APPLICATION_VIEW_SIZE_PREFERENCE.AVSP_USE_LESS"]/*' />
    AVSP_USE_LESS = 1,

    /// <include file='APPLICATION_VIEW_SIZE_PREFERENCE.xml' path='doc/member[@name="APPLICATION_VIEW_SIZE_PREFERENCE.AVSP_USE_HALF"]/*' />
    AVSP_USE_HALF = 2,

    /// <include file='APPLICATION_VIEW_SIZE_PREFERENCE.xml' path='doc/member[@name="APPLICATION_VIEW_SIZE_PREFERENCE.AVSP_USE_MORE"]/*' />
    AVSP_USE_MORE = 3,

    /// <include file='APPLICATION_VIEW_SIZE_PREFERENCE.xml' path='doc/member[@name="APPLICATION_VIEW_SIZE_PREFERENCE.AVSP_USE_MINIMUM"]/*' />
    AVSP_USE_MINIMUM = 4,

    /// <include file='APPLICATION_VIEW_SIZE_PREFERENCE.xml' path='doc/member[@name="APPLICATION_VIEW_SIZE_PREFERENCE.AVSP_USE_NONE"]/*' />
    AVSP_USE_NONE = 5,

    /// <include file='APPLICATION_VIEW_SIZE_PREFERENCE.xml' path='doc/member[@name="APPLICATION_VIEW_SIZE_PREFERENCE.AVSP_CUSTOM"]/*' />
    AVSP_CUSTOM = 6,
}
