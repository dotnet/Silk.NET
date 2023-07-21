// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_DVDCOPY_SET_COPY_STATE.xml' path='doc/member[@name="AM_DVDCOPY_SET_COPY_STATE"]/*' />
public partial struct AM_DVDCOPY_SET_COPY_STATE
{
    /// <include file='AM_DVDCOPY_SET_COPY_STATE.xml' path='doc/member[@name="AM_DVDCOPY_SET_COPY_STATE.DVDCopyState"]/*' />
    [NativeTypeName("ULONG")]
    public uint DVDCopyState;
}
