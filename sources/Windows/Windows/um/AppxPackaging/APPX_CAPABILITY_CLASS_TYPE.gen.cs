// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='APPX_CAPABILITY_CLASS_TYPE.xml' path='doc/member[@name="APPX_CAPABILITY_CLASS_TYPE"]/*' />
public enum APPX_CAPABILITY_CLASS_TYPE
{
    /// <include file='APPX_CAPABILITY_CLASS_TYPE.xml' path='doc/member[@name="APPX_CAPABILITY_CLASS_TYPE.APPX_CAPABILITY_CLASS_DEFAULT"]/*' />
    APPX_CAPABILITY_CLASS_DEFAULT = 0,

    /// <include file='APPX_CAPABILITY_CLASS_TYPE.xml' path='doc/member[@name="APPX_CAPABILITY_CLASS_TYPE.APPX_CAPABILITY_CLASS_GENERAL"]/*' />
    APPX_CAPABILITY_CLASS_GENERAL = 0x1,

    /// <include file='APPX_CAPABILITY_CLASS_TYPE.xml' path='doc/member[@name="APPX_CAPABILITY_CLASS_TYPE.APPX_CAPABILITY_CLASS_RESTRICTED"]/*' />
    APPX_CAPABILITY_CLASS_RESTRICTED = 0x2,

    /// <include file='APPX_CAPABILITY_CLASS_TYPE.xml' path='doc/member[@name="APPX_CAPABILITY_CLASS_TYPE.APPX_CAPABILITY_CLASS_WINDOWS"]/*' />
    APPX_CAPABILITY_CLASS_WINDOWS = 0x4,

    /// <include file='APPX_CAPABILITY_CLASS_TYPE.xml' path='doc/member[@name="APPX_CAPABILITY_CLASS_TYPE.APPX_CAPABILITY_CLASS_ALL"]/*' />
    APPX_CAPABILITY_CLASS_ALL = 0x7,

    /// <include file='APPX_CAPABILITY_CLASS_TYPE.xml' path='doc/member[@name="APPX_CAPABILITY_CLASS_TYPE.APPX_CAPABILITY_CLASS_CUSTOM"]/*' />
    APPX_CAPABILITY_CLASS_CUSTOM = 0x8,
}
