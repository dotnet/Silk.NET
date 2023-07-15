// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MF_OPM_CGMSA_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_CGMSA_PROTECTION_LEVEL"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MF_OPM_CGMSA_PROTECTION_LEVEL
{
    /// <include file='MF_OPM_CGMSA_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_CGMSA_PROTECTION_LEVEL.MF_OPM_CGMSA_OFF"]/*'/>
    MF_OPM_CGMSA_OFF = 0,
    /// <include file='MF_OPM_CGMSA_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_CGMSA_PROTECTION_LEVEL.MF_OPM_CGMSA_COPY_FREELY"]/*'/>
    MF_OPM_CGMSA_COPY_FREELY = 0x1,
    /// <include file='MF_OPM_CGMSA_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_CGMSA_PROTECTION_LEVEL.MF_OPM_CGMSA_COPY_NO_MORE"]/*'/>
    MF_OPM_CGMSA_COPY_NO_MORE = 0x2,
    /// <include file='MF_OPM_CGMSA_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_CGMSA_PROTECTION_LEVEL.MF_OPM_CGMSA_COPY_ONE_GENERATION"]/*'/>
    MF_OPM_CGMSA_COPY_ONE_GENERATION = 0x3,
    /// <include file='MF_OPM_CGMSA_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_CGMSA_PROTECTION_LEVEL.MF_OPM_CGMSA_COPY_NEVER"]/*'/>
    MF_OPM_CGMSA_COPY_NEVER = 0x4,
    /// <include file='MF_OPM_CGMSA_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_CGMSA_PROTECTION_LEVEL.MF_OPM_CGMSA_REDISTRIBUTION_CONTROL_REQUIRED"]/*'/>
    MF_OPM_CGMSA_REDISTRIBUTION_CONTROL_REQUIRED = 0x8,
}