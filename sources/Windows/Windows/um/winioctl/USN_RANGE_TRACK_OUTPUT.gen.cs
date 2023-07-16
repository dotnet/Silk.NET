// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='USN_RANGE_TRACK_OUTPUT.xml' path='doc/member[@name="USN_RANGE_TRACK_OUTPUT"]/*'/>
[SupportedOSPlatform("windows6.3")]
public partial struct USN_RANGE_TRACK_OUTPUT
{
    /// <include file='USN_RANGE_TRACK_OUTPUT.xml' path='doc/member[@name="USN_RANGE_TRACK_OUTPUT.Usn"]/*'/>
    [NativeTypeName("USN")]
    public long Usn;
}