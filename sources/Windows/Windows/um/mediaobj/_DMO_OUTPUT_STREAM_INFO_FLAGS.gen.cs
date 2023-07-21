// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='_DMO_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_STREAM_INFO_FLAGS"]/*' />
public enum _DMO_OUTPUT_STREAM_INFO_FLAGS
{
    /// <include file='_DMO_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_STREAM_INFO_FLAGS.DMO_OUTPUT_STREAMF_WHOLE_SAMPLES"]/*' />
    DMO_OUTPUT_STREAMF_WHOLE_SAMPLES = 0x1,

    /// <include file='_DMO_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_STREAM_INFO_FLAGS.DMO_OUTPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER"]/*' />
    DMO_OUTPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER = 0x2,

    /// <include file='_DMO_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_STREAM_INFO_FLAGS.DMO_OUTPUT_STREAMF_FIXED_SAMPLE_SIZE"]/*' />
    DMO_OUTPUT_STREAMF_FIXED_SAMPLE_SIZE = 0x4,

    /// <include file='_DMO_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_STREAM_INFO_FLAGS.DMO_OUTPUT_STREAMF_DISCARDABLE"]/*' />
    DMO_OUTPUT_STREAMF_DISCARDABLE = 0x8,

    /// <include file='_DMO_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_DMO_OUTPUT_STREAM_INFO_FLAGS.DMO_OUTPUT_STREAMF_OPTIONAL"]/*' />
    DMO_OUTPUT_STREAMF_OPTIONAL = 0x10,
}
