// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum _DMO_INPUT_STREAM_INFO_FLAGS
{
    DMO_INPUT_STREAMF_WHOLE_SAMPLES = 0x1,
    DMO_INPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER = 0x2,
    DMO_INPUT_STREAMF_FIXED_SAMPLE_SIZE = 0x4,
    DMO_INPUT_STREAMF_HOLDS_BUFFERS = 0x8,
}
