// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='USN_TRACK_MODIFIED_RANGES.xml' path='doc/member[@name="USN_TRACK_MODIFIED_RANGES"]/*'/>
[SupportedOSPlatform("windows6.3")]
public partial struct USN_TRACK_MODIFIED_RANGES
{
    /// <include file='USN_TRACK_MODIFIED_RANGES.xml' path='doc/member[@name="USN_TRACK_MODIFIED_RANGES.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='USN_TRACK_MODIFIED_RANGES.xml' path='doc/member[@name="USN_TRACK_MODIFIED_RANGES.Unused"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Unused;
    /// <include file='USN_TRACK_MODIFIED_RANGES.xml' path='doc/member[@name="USN_TRACK_MODIFIED_RANGES.ChunkSize"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong ChunkSize;
    /// <include file='USN_TRACK_MODIFIED_RANGES.xml' path='doc/member[@name="USN_TRACK_MODIFIED_RANGES.FileSizeThreshold"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long FileSizeThreshold;
}