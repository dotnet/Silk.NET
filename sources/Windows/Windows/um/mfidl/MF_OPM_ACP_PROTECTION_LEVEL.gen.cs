// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MF_OPM_ACP_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_ACP_PROTECTION_LEVEL"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum MF_OPM_ACP_PROTECTION_LEVEL
{
    /// <include file='MF_OPM_ACP_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_ACP_PROTECTION_LEVEL.MF_OPM_ACP_OFF"]/*'/>
    MF_OPM_ACP_OFF = 0,
    /// <include file='MF_OPM_ACP_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_ACP_PROTECTION_LEVEL.MF_OPM_ACP_LEVEL_ONE"]/*'/>
    MF_OPM_ACP_LEVEL_ONE = 1,
    /// <include file='MF_OPM_ACP_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_ACP_PROTECTION_LEVEL.MF_OPM_ACP_LEVEL_TWO"]/*'/>
    MF_OPM_ACP_LEVEL_TWO = 2,
    /// <include file='MF_OPM_ACP_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_ACP_PROTECTION_LEVEL.MF_OPM_ACP_LEVEL_THREE"]/*'/>
    MF_OPM_ACP_LEVEL_THREE = 3,
    /// <include file='MF_OPM_ACP_PROTECTION_LEVEL.xml' path='doc/member[@name="MF_OPM_ACP_PROTECTION_LEVEL.MF_OPM_ACP_FORCE_ULONG"]/*'/>
    MF_OPM_ACP_FORCE_ULONG = 0x7fffffff,
}