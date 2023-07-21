// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile"]/*' />
public enum eAVEncH264VProfile
{
    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_unknown"]/*' />
    eAVEncH264VProfile_unknown = 0,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_Simple"]/*' />
    eAVEncH264VProfile_Simple = 66,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_Base"]/*' />
    eAVEncH264VProfile_Base = 66,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_Main"]/*' />
    eAVEncH264VProfile_Main = 77,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_High"]/*' />
    eAVEncH264VProfile_High = 100,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_422"]/*' />
    eAVEncH264VProfile_422 = 122,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_High10"]/*' />
    eAVEncH264VProfile_High10 = 110,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_444"]/*' />
    eAVEncH264VProfile_444 = 244,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_Extended"]/*' />
    eAVEncH264VProfile_Extended = 88,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_ScalableBase"]/*' />
    eAVEncH264VProfile_ScalableBase = 83,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_ScalableHigh"]/*' />
    eAVEncH264VProfile_ScalableHigh = 86,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_MultiviewHigh"]/*' />
    eAVEncH264VProfile_MultiviewHigh = 118,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_StereoHigh"]/*' />
    eAVEncH264VProfile_StereoHigh = 128,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_ConstrainedBase"]/*' />
    eAVEncH264VProfile_ConstrainedBase = 256,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_UCConstrainedHigh"]/*' />
    eAVEncH264VProfile_UCConstrainedHigh = 257,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_UCScalableConstrainedBase"]/*' />
    eAVEncH264VProfile_UCScalableConstrainedBase = 258,

    /// <include file='eAVEncH264VProfile.xml' path='doc/member[@name="eAVEncH264VProfile.eAVEncH264VProfile_UCScalableConstrainedHigh"]/*' />
    eAVEncH264VProfile_UCScalableConstrainedHigh = 259,
}
