// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM.xml' path='doc/member[@name="D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM"]/*' />
public partial struct D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM
{
    /// <include file='D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM.xml' path='doc/member[@name="D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM.DecoderDesc"]/*' />
    public D3D11_VIDEO_DECODER_DESC DecoderDesc;

    /// <include file='D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM.xml' path='doc/member[@name="D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM.Components"]/*' />
    public D3D11_VIDEO_DECODER_HISTOGRAM_COMPONENT_FLAGS Components;

    /// <include file='D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM.xml' path='doc/member[@name="D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM.BinCount"]/*' />
    public uint BinCount;

    /// <include file='D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM.xml' path='doc/member[@name="D3D11_FEATURE_DATA_VIDEO_DECODER_HISTOGRAM.CounterBitDepth"]/*' />
    public uint CounterBitDepth;
}
