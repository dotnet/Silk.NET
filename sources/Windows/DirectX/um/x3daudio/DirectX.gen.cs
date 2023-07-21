// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.DirectX;

public static unsafe partial class DirectX
{
    [NativeTypeName("const X3DAUDIO_DISTANCE_CURVE_POINT[2]")]
    public static ReadOnlySpan<X3DAUDIO_DISTANCE_CURVE_POINT> X3DAudioDefault_LinearCurvePoints
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x80, 0x3F,
                0x00, 0x00, 0x80, 0x3F,
                0x00, 0x00, 0x00, 0x00
            };

            Debug.Assert(data.Length == (Unsafe.SizeOf<X3DAUDIO_DISTANCE_CURVE_POINT>() * 2));
            return MemoryMarshal.CreateReadOnlySpan<X3DAUDIO_DISTANCE_CURVE_POINT>(ref Unsafe.As<byte, X3DAUDIO_DISTANCE_CURVE_POINT>(ref MemoryMarshal.GetReference(data)), 2);
        }
    }

    [NativeTypeName("const X3DAUDIO_CONE")]
    public static ref readonly X3DAUDIO_CONE X3DAudioDefault_DirectionalCone
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[] {
                0xDB, 0x0F, 0xC9, 0x3F,
                0xDB, 0x0F, 0x49, 0x40,
                0x00, 0x00, 0x80, 0x3F,
                0x7D, 0x3F, 0x35, 0x3F,
                0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x80, 0x3E,
                0x7D, 0x3F, 0x35, 0x3F,
                0x00, 0x00, 0x80, 0x3F
            };

            Debug.Assert(data.Length == Unsafe.SizeOf<X3DAUDIO_CONE>());
            return ref Unsafe.As<byte, X3DAUDIO_CONE>(ref MemoryMarshal.GetReference(data));
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.X3DAudioInitialize"]/*' />
    [DllImport("X3DAudio1_7", ExactSpelling = true)]
    public static extern HRESULT X3DAudioInitialize([NativeTypeName("UINT32")] uint SpeakerChannelMask, [NativeTypeName("FLOAT32")] float SpeedOfSound, [NativeTypeName("X3DAUDIO_HANDLE")] byte* Instance);

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.X3DAudioCalculate"]/*' />
    [DllImport("X3DAudio1_7", ExactSpelling = true)]
    public static extern void X3DAudioCalculate([NativeTypeName("const X3DAUDIO_HANDLE")] byte* Instance, [NativeTypeName("const X3DAUDIO_LISTENER *")] X3DAUDIO_LISTENER* pListener, [NativeTypeName("const X3DAUDIO_EMITTER *")] X3DAUDIO_EMITTER* pEmitter, [NativeTypeName("UINT32")] uint Flags, X3DAUDIO_DSP_SETTINGS* pDSPSettings);
}
