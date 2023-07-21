// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='eAVEncDDDynamicRangeCompressionControl.xml' path='doc/member[@name="eAVEncDDDynamicRangeCompressionControl"]/*' />
public enum eAVEncDDDynamicRangeCompressionControl
{
    /// <include file='eAVEncDDDynamicRangeCompressionControl.xml' path='doc/member[@name="eAVEncDDDynamicRangeCompressionControl.eAVEncDDDynamicRangeCompressionControl_None"]/*' />
    eAVEncDDDynamicRangeCompressionControl_None = 0,

    /// <include file='eAVEncDDDynamicRangeCompressionControl.xml' path='doc/member[@name="eAVEncDDDynamicRangeCompressionControl.eAVEncDDDynamicRangeCompressionControl_FilmStandard"]/*' />
    eAVEncDDDynamicRangeCompressionControl_FilmStandard = 1,

    /// <include file='eAVEncDDDynamicRangeCompressionControl.xml' path='doc/member[@name="eAVEncDDDynamicRangeCompressionControl.eAVEncDDDynamicRangeCompressionControl_FilmLight"]/*' />
    eAVEncDDDynamicRangeCompressionControl_FilmLight = 2,

    /// <include file='eAVEncDDDynamicRangeCompressionControl.xml' path='doc/member[@name="eAVEncDDDynamicRangeCompressionControl.eAVEncDDDynamicRangeCompressionControl_MusicStandard"]/*' />
    eAVEncDDDynamicRangeCompressionControl_MusicStandard = 3,

    /// <include file='eAVEncDDDynamicRangeCompressionControl.xml' path='doc/member[@name="eAVEncDDDynamicRangeCompressionControl.eAVEncDDDynamicRangeCompressionControl_MusicLight"]/*' />
    eAVEncDDDynamicRangeCompressionControl_MusicLight = 4,

    /// <include file='eAVEncDDDynamicRangeCompressionControl.xml' path='doc/member[@name="eAVEncDDDynamicRangeCompressionControl.eAVEncDDDynamicRangeCompressionControl_Speech"]/*' />
    eAVEncDDDynamicRangeCompressionControl_Speech = 5,
}
