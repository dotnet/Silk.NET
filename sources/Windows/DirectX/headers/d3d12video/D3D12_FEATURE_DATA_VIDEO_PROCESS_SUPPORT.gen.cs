// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputSample"]/*' />
    public D3D12_VIDEO_SAMPLE InputSample;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputFieldType"]/*' />
    public D3D12_VIDEO_FIELD_TYPE InputFieldType;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputStereoFormat"]/*' />
    public D3D12_VIDEO_FRAME_STEREO_FORMAT InputStereoFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.InputFrameRate"]/*' />
    public DXGI_RATIONAL InputFrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.OutputFormat"]/*' />
    public D3D12_VIDEO_FORMAT OutputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.OutputStereoFormat"]/*' />
    public D3D12_VIDEO_FRAME_STEREO_FORMAT OutputStereoFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.OutputFrameRate"]/*' />
    public DXGI_RATIONAL OutputFrameRate;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.SupportFlags"]/*' />
    public D3D12_VIDEO_PROCESS_SUPPORT_FLAGS SupportFlags;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.ScaleSupport"]/*' />
    public D3D12_VIDEO_SCALE_SUPPORT ScaleSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.FeatureSupport"]/*' />
    public D3D12_VIDEO_PROCESS_FEATURE_FLAGS FeatureSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.DeinterlaceSupport"]/*' />
    public D3D12_VIDEO_PROCESS_DEINTERLACE_FLAGS DeinterlaceSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.AutoProcessingSupport"]/*' />
    public D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS AutoProcessingSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.FilterSupport"]/*' />
    public D3D12_VIDEO_PROCESS_FILTER_FLAGS FilterSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_SUPPORT.FilterRangeSupport"]/*' />
    [NativeTypeName("D3D12_VIDEO_PROCESS_FILTER_RANGE[32]")]
    public _FilterRangeSupport_e__FixedBuffer FilterRangeSupport;

    /// <include file='_FilterRangeSupport_e__FixedBuffer.xml' path='doc/member[@name="_FilterRangeSupport_e__FixedBuffer"]/*' />
    public partial struct _FilterRangeSupport_e__FixedBuffer
    {
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e0;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e1;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e2;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e3;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e4;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e5;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e6;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e7;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e8;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e9;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e10;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e11;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e12;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e13;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e14;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e15;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e16;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e17;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e18;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e19;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e20;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e21;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e22;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e23;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e24;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e25;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e26;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e27;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e28;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e29;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e30;
        public D3D12_VIDEO_PROCESS_FILTER_RANGE e31;

        [UnscopedRef]
        public ref D3D12_VIDEO_PROCESS_FILTER_RANGE this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<D3D12_VIDEO_PROCESS_FILTER_RANGE> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
    }
}
