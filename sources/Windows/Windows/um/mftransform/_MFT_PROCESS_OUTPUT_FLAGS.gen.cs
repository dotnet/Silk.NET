// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='_MFT_PROCESS_OUTPUT_FLAGS.xml' path='doc/member[@name="_MFT_PROCESS_OUTPUT_FLAGS"]/*'/>
public enum _MFT_PROCESS_OUTPUT_FLAGS
{
    /// <include file='_MFT_PROCESS_OUTPUT_FLAGS.xml' path='doc/member[@name="_MFT_PROCESS_OUTPUT_FLAGS.MFT_PROCESS_OUTPUT_DISCARD_WHEN_NO_BUFFER"]/*'/>
    MFT_PROCESS_OUTPUT_DISCARD_WHEN_NO_BUFFER = 0x1,
    /// <include file='_MFT_PROCESS_OUTPUT_FLAGS.xml' path='doc/member[@name="_MFT_PROCESS_OUTPUT_FLAGS.MFT_PROCESS_OUTPUT_REGENERATE_LAST_OUTPUT"]/*'/>
    MFT_PROCESS_OUTPUT_REGENERATE_LAST_OUTPUT = 0x2,
}