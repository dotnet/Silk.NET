// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='_MFT_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_STREAM_INFO_FLAGS"]/*' />
public enum _MFT_OUTPUT_STREAM_INFO_FLAGS
{
    /// <include file='_MFT_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_STREAM_INFO_FLAGS.MFT_OUTPUT_STREAM_WHOLE_SAMPLES"]/*' />
    MFT_OUTPUT_STREAM_WHOLE_SAMPLES = 0x1,

    /// <include file='_MFT_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_STREAM_INFO_FLAGS.MFT_OUTPUT_STREAM_SINGLE_SAMPLE_PER_BUFFER"]/*' />
    MFT_OUTPUT_STREAM_SINGLE_SAMPLE_PER_BUFFER = 0x2,

    /// <include file='_MFT_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_STREAM_INFO_FLAGS.MFT_OUTPUT_STREAM_FIXED_SAMPLE_SIZE"]/*' />
    MFT_OUTPUT_STREAM_FIXED_SAMPLE_SIZE = 0x4,

    /// <include file='_MFT_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_STREAM_INFO_FLAGS.MFT_OUTPUT_STREAM_DISCARDABLE"]/*' />
    MFT_OUTPUT_STREAM_DISCARDABLE = 0x8,

    /// <include file='_MFT_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_STREAM_INFO_FLAGS.MFT_OUTPUT_STREAM_OPTIONAL"]/*' />
    MFT_OUTPUT_STREAM_OPTIONAL = 0x10,

    /// <include file='_MFT_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_STREAM_INFO_FLAGS.MFT_OUTPUT_STREAM_PROVIDES_SAMPLES"]/*' />
    MFT_OUTPUT_STREAM_PROVIDES_SAMPLES = 0x100,

    /// <include file='_MFT_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_STREAM_INFO_FLAGS.MFT_OUTPUT_STREAM_CAN_PROVIDE_SAMPLES"]/*' />
    MFT_OUTPUT_STREAM_CAN_PROVIDE_SAMPLES = 0x200,

    /// <include file='_MFT_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_STREAM_INFO_FLAGS.MFT_OUTPUT_STREAM_LAZY_READ"]/*' />
    MFT_OUTPUT_STREAM_LAZY_READ = 0x400,

    /// <include file='_MFT_OUTPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_STREAM_INFO_FLAGS.MFT_OUTPUT_STREAM_REMOVABLE"]/*' />
    MFT_OUTPUT_STREAM_REMOVABLE = 0x800,
}
