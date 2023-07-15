// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MF_TIMED_TEXT_DISPLAY_ALIGNMENT.xml' path='doc/member[@name="MF_TIMED_TEXT_DISPLAY_ALIGNMENT"]/*'/>
[SupportedOSPlatform("windows10.0")]
public enum MF_TIMED_TEXT_DISPLAY_ALIGNMENT
{
    /// <include file='MF_TIMED_TEXT_DISPLAY_ALIGNMENT.xml' path='doc/member[@name="MF_TIMED_TEXT_DISPLAY_ALIGNMENT.MF_TIMED_TEXT_DISPLAY_ALIGNMENT_BEFORE"]/*'/>
    MF_TIMED_TEXT_DISPLAY_ALIGNMENT_BEFORE = 0,
    /// <include file='MF_TIMED_TEXT_DISPLAY_ALIGNMENT.xml' path='doc/member[@name="MF_TIMED_TEXT_DISPLAY_ALIGNMENT.MF_TIMED_TEXT_DISPLAY_ALIGNMENT_AFTER"]/*'/>
    MF_TIMED_TEXT_DISPLAY_ALIGNMENT_AFTER = 1,
    /// <include file='MF_TIMED_TEXT_DISPLAY_ALIGNMENT.xml' path='doc/member[@name="MF_TIMED_TEXT_DISPLAY_ALIGNMENT.MF_TIMED_TEXT_DISPLAY_ALIGNMENT_CENTER"]/*'/>
    MF_TIMED_TEXT_DISPLAY_ALIGNMENT_CENTER = 2,
}