// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MFAudioConstriction.xml' path='doc/member[@name="MFAudioConstriction"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MFAudioConstriction
{
    /// <include file='MFAudioConstriction.xml' path='doc/member[@name="MFAudioConstriction.MFaudioConstrictionOff"]/*'/>
    MFaudioConstrictionOff = 0,
    /// <include file='MFAudioConstriction.xml' path='doc/member[@name="MFAudioConstriction.MFaudioConstriction48_16"]/*'/>
    MFaudioConstriction48_16 = (MFaudioConstrictionOff + 1),
    /// <include file='MFAudioConstriction.xml' path='doc/member[@name="MFAudioConstriction.MFaudioConstriction44_16"]/*'/>
    MFaudioConstriction44_16 = (MFaudioConstriction48_16 + 1),
    /// <include file='MFAudioConstriction.xml' path='doc/member[@name="MFAudioConstriction.MFaudioConstriction14_14"]/*'/>
    MFaudioConstriction14_14 = (MFaudioConstriction44_16 + 1),
    /// <include file='MFAudioConstriction.xml' path='doc/member[@name="MFAudioConstriction.MFaudioConstrictionMute"]/*'/>
    MFaudioConstrictionMute = (MFaudioConstriction14_14 + 1),
}