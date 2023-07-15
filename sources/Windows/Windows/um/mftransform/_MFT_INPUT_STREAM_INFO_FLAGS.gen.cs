// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='_MFT_INPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_INPUT_STREAM_INFO_FLAGS"]/*'/>
public enum _MFT_INPUT_STREAM_INFO_FLAGS
{
    /// <include file='_MFT_INPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_INPUT_STREAM_INFO_FLAGS.MFT_INPUT_STREAM_WHOLE_SAMPLES"]/*'/>
    MFT_INPUT_STREAM_WHOLE_SAMPLES = 0x1,
    /// <include file='_MFT_INPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_INPUT_STREAM_INFO_FLAGS.MFT_INPUT_STREAM_SINGLE_SAMPLE_PER_BUFFER"]/*'/>
    MFT_INPUT_STREAM_SINGLE_SAMPLE_PER_BUFFER = 0x2,
    /// <include file='_MFT_INPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_INPUT_STREAM_INFO_FLAGS.MFT_INPUT_STREAM_FIXED_SAMPLE_SIZE"]/*'/>
    MFT_INPUT_STREAM_FIXED_SAMPLE_SIZE = 0x4,
    /// <include file='_MFT_INPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_INPUT_STREAM_INFO_FLAGS.MFT_INPUT_STREAM_HOLDS_BUFFERS"]/*'/>
    MFT_INPUT_STREAM_HOLDS_BUFFERS = 0x8,
    /// <include file='_MFT_INPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_INPUT_STREAM_INFO_FLAGS.MFT_INPUT_STREAM_DOES_NOT_ADDREF"]/*'/>
    MFT_INPUT_STREAM_DOES_NOT_ADDREF = 0x100,
    /// <include file='_MFT_INPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_INPUT_STREAM_INFO_FLAGS.MFT_INPUT_STREAM_REMOVABLE"]/*'/>
    MFT_INPUT_STREAM_REMOVABLE = 0x200,
    /// <include file='_MFT_INPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_INPUT_STREAM_INFO_FLAGS.MFT_INPUT_STREAM_OPTIONAL"]/*'/>
    MFT_INPUT_STREAM_OPTIONAL = 0x400,
    /// <include file='_MFT_INPUT_STREAM_INFO_FLAGS.xml' path='doc/member[@name="_MFT_INPUT_STREAM_INFO_FLAGS.MFT_INPUT_STREAM_PROCESSES_IN_PLACE"]/*'/>
    MFT_INPUT_STREAM_PROCESSES_IN_PLACE = 0x800,
}