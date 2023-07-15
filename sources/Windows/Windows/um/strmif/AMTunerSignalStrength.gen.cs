// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='AMTunerSignalStrength.xml' path='doc/member[@name="AMTunerSignalStrength"]/*'/>
public enum AMTunerSignalStrength
{
    /// <include file='AMTunerSignalStrength.xml' path='doc/member[@name="AMTunerSignalStrength.AMTUNER_HASNOSIGNALSTRENGTH"]/*'/>
    AMTUNER_HASNOSIGNALSTRENGTH = -1,
    /// <include file='AMTunerSignalStrength.xml' path='doc/member[@name="AMTunerSignalStrength.AMTUNER_NOSIGNAL"]/*'/>
    AMTUNER_NOSIGNAL = 0,
    /// <include file='AMTunerSignalStrength.xml' path='doc/member[@name="AMTunerSignalStrength.AMTUNER_SIGNALPRESENT"]/*'/>
    AMTUNER_SIGNALPRESENT = 1,
}