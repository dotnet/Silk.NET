// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct XAUDIO2_DEBUG_CONFIGURATION
{
    [NativeTypeName("UINT32")]
    public uint TraceMask;

    [NativeTypeName("UINT32")]
    public uint BreakMask;
    public BOOL LogThreadID;
    public BOOL LogFileline;
    public BOOL LogFunctionName;
    public BOOL LogTiming;
}
