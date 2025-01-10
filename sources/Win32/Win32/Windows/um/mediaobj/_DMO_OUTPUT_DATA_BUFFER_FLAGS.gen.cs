// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mediaobj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum _DMO_OUTPUT_DATA_BUFFER_FLAGS
{
    DMO_OUTPUT_DATA_BUFFERF_SYNCPOINT = 0x1,
    DMO_OUTPUT_DATA_BUFFERF_TIME = 0x2,
    DMO_OUTPUT_DATA_BUFFERF_TIMELENGTH = 0x4,
    DMO_OUTPUT_DATA_BUFFERF_DISCONTINUITY = 0x8,
    DMO_OUTPUT_DATA_BUFFERF_INCOMPLETE = 0x1000000,
}
