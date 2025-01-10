// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum _MFT_OUTPUT_STREAM_INFO_FLAGS
{
    MFT_OUTPUT_STREAM_WHOLE_SAMPLES = 0x1,
    MFT_OUTPUT_STREAM_SINGLE_SAMPLE_PER_BUFFER = 0x2,
    MFT_OUTPUT_STREAM_FIXED_SAMPLE_SIZE = 0x4,
    MFT_OUTPUT_STREAM_DISCARDABLE = 0x8,
    MFT_OUTPUT_STREAM_OPTIONAL = 0x10,
    MFT_OUTPUT_STREAM_PROVIDES_SAMPLES = 0x100,
    MFT_OUTPUT_STREAM_CAN_PROVIDE_SAMPLES = 0x200,
    MFT_OUTPUT_STREAM_LAZY_READ = 0x400,
    MFT_OUTPUT_STREAM_REMOVABLE = 0x800,
}
