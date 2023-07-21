// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;

namespace Silk.NET.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS"]/*' />
[Flags]
public enum D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS
{
    /// <include file='D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS.D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_NONE"]/*' />
    D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS.D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_BOB"]/*' />
    D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_BOB = 0x1,

    /// <include file='D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS.D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_CUSTOM"]/*' />
    D3D12_VIDEO_PROCESS_DEINTERLACE_FLAG_CUSTOM = unchecked((int)(0x80000000)),
}
