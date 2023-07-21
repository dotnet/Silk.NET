// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='VMRPresentationFlags.xml' path='doc/member[@name="VMRPresentationFlags"]/*' />
public enum VMRPresentationFlags
{
    /// <include file='VMRPresentationFlags.xml' path='doc/member[@name="VMRPresentationFlags.VMRSample_SyncPoint"]/*' />
    VMRSample_SyncPoint = 0x1,

    /// <include file='VMRPresentationFlags.xml' path='doc/member[@name="VMRPresentationFlags.VMRSample_Preroll"]/*' />
    VMRSample_Preroll = 0x2,

    /// <include file='VMRPresentationFlags.xml' path='doc/member[@name="VMRPresentationFlags.VMRSample_Discontinuity"]/*' />
    VMRSample_Discontinuity = 0x4,

    /// <include file='VMRPresentationFlags.xml' path='doc/member[@name="VMRPresentationFlags.VMRSample_TimeValid"]/*' />
    VMRSample_TimeValid = 0x8,

    /// <include file='VMRPresentationFlags.xml' path='doc/member[@name="VMRPresentationFlags.VMRSample_SrcDstRectsValid"]/*' />
    VMRSample_SrcDstRectsValid = 0x10,
}
