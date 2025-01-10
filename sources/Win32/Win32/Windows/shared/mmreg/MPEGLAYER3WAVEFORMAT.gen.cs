// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/mmreg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct MPEGLAYER3WAVEFORMAT
{
    public WAVEFORMATEX wfx;

    [NativeTypeName("WORD")]
    public ushort wID;

    [NativeTypeName("DWORD")]
    public uint fdwFlags;

    [NativeTypeName("WORD")]
    public ushort nBlockSize;

    [NativeTypeName("WORD")]
    public ushort nFramesPerBlock;

    [NativeTypeName("WORD")]
    public ushort nCodecDelay;
}
