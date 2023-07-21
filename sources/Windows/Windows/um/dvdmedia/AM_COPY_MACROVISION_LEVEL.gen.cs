// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_COPY_MACROVISION_LEVEL.xml' path='doc/member[@name="AM_COPY_MACROVISION_LEVEL"]/*' />
public enum AM_COPY_MACROVISION_LEVEL
{
    /// <include file='AM_COPY_MACROVISION_LEVEL.xml' path='doc/member[@name="AM_COPY_MACROVISION_LEVEL.AM_MACROVISION_DISABLED"]/*' />
    AM_MACROVISION_DISABLED = 0,

    /// <include file='AM_COPY_MACROVISION_LEVEL.xml' path='doc/member[@name="AM_COPY_MACROVISION_LEVEL.AM_MACROVISION_LEVEL1"]/*' />
    AM_MACROVISION_LEVEL1 = 1,

    /// <include file='AM_COPY_MACROVISION_LEVEL.xml' path='doc/member[@name="AM_COPY_MACROVISION_LEVEL.AM_MACROVISION_LEVEL2"]/*' />
    AM_MACROVISION_LEVEL2 = 2,

    /// <include file='AM_COPY_MACROVISION_LEVEL.xml' path='doc/member[@name="AM_COPY_MACROVISION_LEVEL.AM_MACROVISION_LEVEL3"]/*' />
    AM_MACROVISION_LEVEL3 = 3,
}
