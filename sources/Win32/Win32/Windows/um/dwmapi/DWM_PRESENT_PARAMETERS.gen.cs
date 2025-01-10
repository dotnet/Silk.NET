// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct DWM_PRESENT_PARAMETERS
{
    [NativeTypeName("UINT32")]
    public uint cbSize;
    public BOOL fQueue;

    [NativeTypeName("DWM_FRAME_COUNT")]
    public ulong cRefreshStart;
    public uint cBuffer;
    public BOOL fUseSourceRate;
    public UNSIGNED_RATIO rateSource;
    public uint cRefreshesPerFrame;
    public DWM_SOURCE_FRAME_SAMPLING eSampling;
}
