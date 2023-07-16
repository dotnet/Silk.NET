// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;
public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.XAudio2CreateWithVersionInfo"]/*'/>
    [DllImport("xaudio2_9", ExactSpelling = true)]
    public static extern HRESULT XAudio2CreateWithVersionInfo(IXAudio2** ppXAudio2, [NativeTypeName("UINT32")] uint Flags = 0, [NativeTypeName("XAUDIO2_PROCESSOR")] uint XAudio2Processor = 0x00000001, [NativeTypeName("DWORD")] uint ntddiVersion = 0x0A00000C);
    [NativeTypeName("#define Processor1 0x00000001")]
    public const int Processor1 = 0x00000001;
    [NativeTypeName("#define Processor2 0x00000002")]
    public const int Processor2 = 0x00000002;
    [NativeTypeName("#define Processor3 0x00000004")]
    public const int Processor3 = 0x00000004;
    [NativeTypeName("#define Processor4 0x00000008")]
    public const int Processor4 = 0x00000008;
    [NativeTypeName("#define Processor5 0x00000010")]
    public const int Processor5 = 0x00000010;
    [NativeTypeName("#define Processor6 0x00000020")]
    public const int Processor6 = 0x00000020;
    [NativeTypeName("#define Processor7 0x00000040")]
    public const int Processor7 = 0x00000040;
    [NativeTypeName("#define Processor8 0x00000080")]
    public const int Processor8 = 0x00000080;
    [NativeTypeName("#define Processor9 0x00000100")]
    public const int Processor9 = 0x00000100;
    [NativeTypeName("#define Processor10 0x00000200")]
    public const int Processor10 = 0x00000200;
    [NativeTypeName("#define Processor11 0x00000400")]
    public const int Processor11 = 0x00000400;
    [NativeTypeName("#define Processor12 0x00000800")]
    public const int Processor12 = 0x00000800;
    [NativeTypeName("#define Processor13 0x00001000")]
    public const int Processor13 = 0x00001000;
    [NativeTypeName("#define Processor14 0x00002000")]
    public const int Processor14 = 0x00002000;
    [NativeTypeName("#define Processor15 0x00004000")]
    public const int Processor15 = 0x00004000;
    [NativeTypeName("#define Processor16 0x00008000")]
    public const int Processor16 = 0x00008000;
    [NativeTypeName("#define Processor17 0x00010000")]
    public const int Processor17 = 0x00010000;
    [NativeTypeName("#define Processor18 0x00020000")]
    public const int Processor18 = 0x00020000;
    [NativeTypeName("#define Processor19 0x00040000")]
    public const int Processor19 = 0x00040000;
    [NativeTypeName("#define Processor20 0x00080000")]
    public const int Processor20 = 0x00080000;
    [NativeTypeName("#define Processor21 0x00100000")]
    public const int Processor21 = 0x00100000;
    [NativeTypeName("#define Processor22 0x00200000")]
    public const int Processor22 = 0x00200000;
    [NativeTypeName("#define Processor23 0x00400000")]
    public const int Processor23 = 0x00400000;
    [NativeTypeName("#define Processor24 0x00800000")]
    public const int Processor24 = 0x00800000;
    [NativeTypeName("#define Processor25 0x01000000")]
    public const int Processor25 = 0x01000000;
    [NativeTypeName("#define Processor26 0x02000000")]
    public const int Processor26 = 0x02000000;
    [NativeTypeName("#define Processor27 0x04000000")]
    public const int Processor27 = 0x04000000;
    [NativeTypeName("#define Processor28 0x08000000")]
    public const int Processor28 = 0x08000000;
    [NativeTypeName("#define Processor29 0x10000000")]
    public const int Processor29 = 0x10000000;
    [NativeTypeName("#define Processor30 0x20000000")]
    public const int Processor30 = 0x20000000;
    [NativeTypeName("#define Processor31 0x40000000")]
    public const int Processor31 = 0x40000000;
    [NativeTypeName("#define Processor32 0x80000000")]
    public const uint Processor32 = 0x80000000;
}