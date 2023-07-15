// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPRECOEVENTFLAGS.xml' path='doc/member[@name="SPRECOEVENTFLAGS"]/*'/>
public enum SPRECOEVENTFLAGS
{
    /// <include file='SPRECOEVENTFLAGS.xml' path='doc/member[@name="SPRECOEVENTFLAGS.SPREF_AutoPause"]/*'/>
    SPREF_AutoPause = (1 << 0),
    /// <include file='SPRECOEVENTFLAGS.xml' path='doc/member[@name="SPRECOEVENTFLAGS.SPREF_Emulated"]/*'/>
    SPREF_Emulated = (1 << 1),
    /// <include file='SPRECOEVENTFLAGS.xml' path='doc/member[@name="SPRECOEVENTFLAGS.SPREF_SMLTimeout"]/*'/>
    SPREF_SMLTimeout = (1 << 2),
    /// <include file='SPRECOEVENTFLAGS.xml' path='doc/member[@name="SPRECOEVENTFLAGS.SPREF_ExtendableParse"]/*'/>
    SPREF_ExtendableParse = (1 << 3),
    /// <include file='SPRECOEVENTFLAGS.xml' path='doc/member[@name="SPRECOEVENTFLAGS.SPREF_ReSent"]/*'/>
    SPREF_ReSent = (1 << 4),
    /// <include file='SPRECOEVENTFLAGS.xml' path='doc/member[@name="SPRECOEVENTFLAGS.SPREF_Hypothesis"]/*'/>
    SPREF_Hypothesis = (1 << 5),
    /// <include file='SPRECOEVENTFLAGS.xml' path='doc/member[@name="SPRECOEVENTFLAGS.SPREF_FalseRecognition"]/*'/>
    SPREF_FalseRecognition = (1 << 6),
}