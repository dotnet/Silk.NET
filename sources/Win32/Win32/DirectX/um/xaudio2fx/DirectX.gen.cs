// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [DllImport("xaudio2_9", ExactSpelling = true)]
    public static extern HRESULT CreateAudioVolumeMeter(IUnknown* ppApo);

    [DllImport("xaudio2_9", ExactSpelling = true)]
    public static extern HRESULT CreateAudioReverb(IUnknown* ppApo);
}
