// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TA_PROPERTY_FLAG.xml' path='doc/member[@name="TA_PROPERTY_FLAG"]/*' />
public enum TA_PROPERTY_FLAG
{
    /// <include file='TA_PROPERTY_FLAG.xml' path='doc/member[@name="TA_PROPERTY_FLAG.TAPF_NONE"]/*' />
    TAPF_NONE = 0x0,

    /// <include file='TA_PROPERTY_FLAG.xml' path='doc/member[@name="TA_PROPERTY_FLAG.TAPF_HASSTAGGER"]/*' />
    TAPF_HASSTAGGER = 0x1,

    /// <include file='TA_PROPERTY_FLAG.xml' path='doc/member[@name="TA_PROPERTY_FLAG.TAPF_ISRTLAWARE"]/*' />
    TAPF_ISRTLAWARE = 0x2,

    /// <include file='TA_PROPERTY_FLAG.xml' path='doc/member[@name="TA_PROPERTY_FLAG.TAPF_ALLOWCOLLECTION"]/*' />
    TAPF_ALLOWCOLLECTION = 0x4,

    /// <include file='TA_PROPERTY_FLAG.xml' path='doc/member[@name="TA_PROPERTY_FLAG.TAPF_HASBACKGROUND"]/*' />
    TAPF_HASBACKGROUND = 0x8,

    /// <include file='TA_PROPERTY_FLAG.xml' path='doc/member[@name="TA_PROPERTY_FLAG.TAPF_HASPERSPECTIVE"]/*' />
    TAPF_HASPERSPECTIVE = 0x10,
}
