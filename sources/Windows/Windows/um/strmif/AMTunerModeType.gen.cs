// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AMTunerModeType.xml' path='doc/member[@name="AMTunerModeType"]/*'/>
public enum AMTunerModeType
{
    /// <include file='AMTunerModeType.xml' path='doc/member[@name="AMTunerModeType.AMTUNER_MODE_DEFAULT"]/*'/>
    AMTUNER_MODE_DEFAULT = 0,
    /// <include file='AMTunerModeType.xml' path='doc/member[@name="AMTunerModeType.AMTUNER_MODE_TV"]/*'/>
    AMTUNER_MODE_TV = 0x1,
    /// <include file='AMTunerModeType.xml' path='doc/member[@name="AMTunerModeType.AMTUNER_MODE_FM_RADIO"]/*'/>
    AMTUNER_MODE_FM_RADIO = 0x2,
    /// <include file='AMTunerModeType.xml' path='doc/member[@name="AMTunerModeType.AMTUNER_MODE_AM_RADIO"]/*'/>
    AMTUNER_MODE_AM_RADIO = 0x4,
    /// <include file='AMTunerModeType.xml' path='doc/member[@name="AMTunerModeType.AMTUNER_MODE_DSS"]/*'/>
    AMTUNER_MODE_DSS = 0x8,
}