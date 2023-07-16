// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='CROSS_SLIDE_THRESHOLD.xml' path='doc/member[@name="CROSS_SLIDE_THRESHOLD"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum CROSS_SLIDE_THRESHOLD
{
    /// <include file='CROSS_SLIDE_THRESHOLD.xml' path='doc/member[@name="CROSS_SLIDE_THRESHOLD.CROSS_SLIDE_THRESHOLD_SELECT_START"]/*'/>
    CROSS_SLIDE_THRESHOLD_SELECT_START = 0x00000000,
    /// <include file='CROSS_SLIDE_THRESHOLD.xml' path='doc/member[@name="CROSS_SLIDE_THRESHOLD.CROSS_SLIDE_THRESHOLD_SPEED_BUMP_START"]/*'/>
    CROSS_SLIDE_THRESHOLD_SPEED_BUMP_START = 0x00000001,
    /// <include file='CROSS_SLIDE_THRESHOLD.xml' path='doc/member[@name="CROSS_SLIDE_THRESHOLD.CROSS_SLIDE_THRESHOLD_SPEED_BUMP_END"]/*'/>
    CROSS_SLIDE_THRESHOLD_SPEED_BUMP_END = 0x00000002,
    /// <include file='CROSS_SLIDE_THRESHOLD.xml' path='doc/member[@name="CROSS_SLIDE_THRESHOLD.CROSS_SLIDE_THRESHOLD_REARRANGE_START"]/*'/>
    CROSS_SLIDE_THRESHOLD_REARRANGE_START = 0x00000003,
    /// <include file='CROSS_SLIDE_THRESHOLD.xml' path='doc/member[@name="CROSS_SLIDE_THRESHOLD.CROSS_SLIDE_THRESHOLD_COUNT"]/*'/>
    CROSS_SLIDE_THRESHOLD_COUNT = 0x00000004,
    /// <include file='CROSS_SLIDE_THRESHOLD.xml' path='doc/member[@name="CROSS_SLIDE_THRESHOLD.CROSS_SLIDE_THRESHOLD_MAX"]/*'/>
    CROSS_SLIDE_THRESHOLD_MAX = unchecked((int)(0xffffffff)),
}