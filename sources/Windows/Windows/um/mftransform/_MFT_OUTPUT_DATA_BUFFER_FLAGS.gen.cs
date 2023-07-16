// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='_MFT_OUTPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_DATA_BUFFER_FLAGS"]/*'/>
public enum _MFT_OUTPUT_DATA_BUFFER_FLAGS
{
    /// <include file='_MFT_OUTPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_DATA_BUFFER_FLAGS.MFT_OUTPUT_DATA_BUFFER_INCOMPLETE"]/*'/>
    MFT_OUTPUT_DATA_BUFFER_INCOMPLETE = 0x1000000,
    /// <include file='_MFT_OUTPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_DATA_BUFFER_FLAGS.MFT_OUTPUT_DATA_BUFFER_FORMAT_CHANGE"]/*'/>
    MFT_OUTPUT_DATA_BUFFER_FORMAT_CHANGE = 0x100,
    /// <include file='_MFT_OUTPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_DATA_BUFFER_FLAGS.MFT_OUTPUT_DATA_BUFFER_STREAM_END"]/*'/>
    MFT_OUTPUT_DATA_BUFFER_STREAM_END = 0x200,
    /// <include file='_MFT_OUTPUT_DATA_BUFFER_FLAGS.xml' path='doc/member[@name="_MFT_OUTPUT_DATA_BUFFER_FLAGS.MFT_OUTPUT_DATA_BUFFER_NO_SAMPLE"]/*'/>
    MFT_OUTPUT_DATA_BUFFER_NO_SAMPLE = 0x300,
}