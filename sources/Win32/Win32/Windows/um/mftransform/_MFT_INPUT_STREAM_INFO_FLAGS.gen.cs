// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum _MFT_INPUT_STREAM_INFO_FLAGS
{
    MFT_INPUT_STREAM_WHOLE_SAMPLES = 0x1,
    MFT_INPUT_STREAM_SINGLE_SAMPLE_PER_BUFFER = 0x2,
    MFT_INPUT_STREAM_FIXED_SAMPLE_SIZE = 0x4,
    MFT_INPUT_STREAM_HOLDS_BUFFERS = 0x8,
    MFT_INPUT_STREAM_DOES_NOT_ADDREF = 0x100,
    MFT_INPUT_STREAM_REMOVABLE = 0x200,
    MFT_INPUT_STREAM_OPTIONAL = 0x400,
    MFT_INPUT_STREAM_PROCESSES_IN_PLACE = 0x800,
}
