// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum AM_DVD_GRAPH_FLAGS
{
    AM_DVD_HWDEC_PREFER = 0x1,
    AM_DVD_HWDEC_ONLY = 0x2,
    AM_DVD_SWDEC_PREFER = 0x4,
    AM_DVD_SWDEC_ONLY = 0x8,
    AM_DVD_NOVPE = 0x100,
    AM_DVD_DO_NOT_CLEAR = 0x200,
    AM_DVD_VMR9_ONLY = 0x800,
    AM_DVD_EVR_ONLY = 0x1000,
    AM_DVD_EVR_QOS = 0x2000,
    AM_DVD_ADAPT_GRAPH = 0x4000,
    AM_DVD_MASK = 0xffff,
}
