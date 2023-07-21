// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_MPEG2Level.xml' path='doc/member[@name="AM_MPEG2Level"]/*' />
public enum AM_MPEG2Level
{
    /// <include file='AM_MPEG2Level.xml' path='doc/member[@name="AM_MPEG2Level.AM_MPEG2Level_Low"]/*' />
    AM_MPEG2Level_Low = 1,

    /// <include file='AM_MPEG2Level.xml' path='doc/member[@name="AM_MPEG2Level.AM_MPEG2Level_Main"]/*' />
    AM_MPEG2Level_Main = 2,

    /// <include file='AM_MPEG2Level.xml' path='doc/member[@name="AM_MPEG2Level.AM_MPEG2Level_High1440"]/*' />
    AM_MPEG2Level_High1440 = 3,

    /// <include file='AM_MPEG2Level.xml' path='doc/member[@name="AM_MPEG2Level.AM_MPEG2Level_High"]/*' />
    AM_MPEG2Level_High = 4,
}
