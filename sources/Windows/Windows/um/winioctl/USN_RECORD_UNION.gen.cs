// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='USN_RECORD_UNION.xml' path='doc/member[@name="USN_RECORD_UNION"]/*' />
[StructLayout(LayoutKind.Explicit)]
public partial struct USN_RECORD_UNION
{
    /// <include file='USN_RECORD_UNION.xml' path='doc/member[@name="USN_RECORD_UNION.Header"]/*' />
    [FieldOffset(0)]
    public USN_RECORD_COMMON_HEADER Header;

    /// <include file='USN_RECORD_UNION.xml' path='doc/member[@name="USN_RECORD_UNION.V2"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("USN_RECORD_V2")]
    public USN_RECORD V2;

    /// <include file='USN_RECORD_UNION.xml' path='doc/member[@name="USN_RECORD_UNION.V3"]/*' />
    [FieldOffset(0)]
    public USN_RECORD_V3 V3;

    /// <include file='USN_RECORD_UNION.xml' path='doc/member[@name="USN_RECORD_UNION.V4"]/*' />
    [FieldOffset(0)]
    public USN_RECORD_V4 V4;
}
