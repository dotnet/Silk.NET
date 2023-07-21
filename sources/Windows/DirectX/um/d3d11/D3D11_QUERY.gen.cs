// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY"]/*' />
public enum D3D11_QUERY
{
    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_EVENT"]/*' />
    D3D11_QUERY_EVENT = 0,

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_OCCLUSION"]/*' />
    D3D11_QUERY_OCCLUSION = (D3D11_QUERY_EVENT + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_TIMESTAMP"]/*' />
    D3D11_QUERY_TIMESTAMP = (D3D11_QUERY_OCCLUSION + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_TIMESTAMP_DISJOINT"]/*' />
    D3D11_QUERY_TIMESTAMP_DISJOINT = (D3D11_QUERY_TIMESTAMP + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_PIPELINE_STATISTICS"]/*' />
    D3D11_QUERY_PIPELINE_STATISTICS = (D3D11_QUERY_TIMESTAMP_DISJOINT + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_OCCLUSION_PREDICATE"]/*' />
    D3D11_QUERY_OCCLUSION_PREDICATE = (D3D11_QUERY_PIPELINE_STATISTICS + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_SO_STATISTICS"]/*' />
    D3D11_QUERY_SO_STATISTICS = (D3D11_QUERY_OCCLUSION_PREDICATE + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_SO_OVERFLOW_PREDICATE"]/*' />
    D3D11_QUERY_SO_OVERFLOW_PREDICATE = (D3D11_QUERY_SO_STATISTICS + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_SO_STATISTICS_STREAM0"]/*' />
    D3D11_QUERY_SO_STATISTICS_STREAM0 = (D3D11_QUERY_SO_OVERFLOW_PREDICATE + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM0"]/*' />
    D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM0 = (D3D11_QUERY_SO_STATISTICS_STREAM0 + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_SO_STATISTICS_STREAM1"]/*' />
    D3D11_QUERY_SO_STATISTICS_STREAM1 = (D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM0 + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM1"]/*' />
    D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM1 = (D3D11_QUERY_SO_STATISTICS_STREAM1 + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_SO_STATISTICS_STREAM2"]/*' />
    D3D11_QUERY_SO_STATISTICS_STREAM2 = (D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM1 + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM2"]/*' />
    D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM2 = (D3D11_QUERY_SO_STATISTICS_STREAM2 + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_SO_STATISTICS_STREAM3"]/*' />
    D3D11_QUERY_SO_STATISTICS_STREAM3 = (D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM2 + 1),

    /// <include file='D3D11_QUERY.xml' path='doc/member[@name="D3D11_QUERY.D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM3"]/*' />
    D3D11_QUERY_SO_OVERFLOW_PREDICATE_STREAM3 = (D3D11_QUERY_SO_STATISTICS_STREAM3 + 1),
}
