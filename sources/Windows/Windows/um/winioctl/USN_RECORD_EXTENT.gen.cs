// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='USN_RECORD_EXTENT.xml' path='doc/member[@name="USN_RECORD_EXTENT"]/*'/>
[SupportedOSPlatform("windows6.3")]
public partial struct USN_RECORD_EXTENT
{
    /// <include file='USN_RECORD_EXTENT.xml' path='doc/member[@name="USN_RECORD_EXTENT.Offset"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long Offset;
    /// <include file='USN_RECORD_EXTENT.xml' path='doc/member[@name="USN_RECORD_EXTENT.Length"]/*'/>
    [NativeTypeName("LONGLONG")]
    public long Length;
}