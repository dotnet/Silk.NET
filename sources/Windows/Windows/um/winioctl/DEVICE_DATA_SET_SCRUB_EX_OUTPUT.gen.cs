// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DEVICE_DATA_SET_SCRUB_EX_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_SCRUB_EX_OUTPUT"]/*' />
public partial struct DEVICE_DATA_SET_SCRUB_EX_OUTPUT
{
    /// <include file='DEVICE_DATA_SET_SCRUB_EX_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_SCRUB_EX_OUTPUT.BytesProcessed"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong BytesProcessed;

    /// <include file='DEVICE_DATA_SET_SCRUB_EX_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_SCRUB_EX_OUTPUT.BytesRepaired"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong BytesRepaired;

    /// <include file='DEVICE_DATA_SET_SCRUB_EX_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_SCRUB_EX_OUTPUT.BytesFailed"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong BytesFailed;

    /// <include file='DEVICE_DATA_SET_SCRUB_EX_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_SCRUB_EX_OUTPUT.ParityExtent"]/*' />
    [NativeTypeName("DEVICE_DSM_RANGE")]
    public DEVICE_DATA_SET_RANGE ParityExtent;

    /// <include file='DEVICE_DATA_SET_SCRUB_EX_OUTPUT.xml' path='doc/member[@name="DEVICE_DATA_SET_SCRUB_EX_OUTPUT.BytesScrubbed"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong BytesScrubbed;
}
