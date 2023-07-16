// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.MFPCreateMediaPlayer"]/*'/>
    [DllImport("mfplay", ExactSpelling = true)]
    public static extern HRESULT MFPCreateMediaPlayer([NativeTypeName("LPCWSTR")] ushort* pwszURL, BOOL fStartPlayback, [NativeTypeName("MFP_CREATION_OPTIONS")] uint creationOptions, IMFPMediaPlayerCallback* pCallback, HWND hWnd, IMFPMediaPlayer** ppMediaPlayer);
    [NativeTypeName("const IID")]
    public static ref readonly Guid MFP_POSITIONTYPE_100NS
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
            return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFP_PKEY_StreamIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0x97,
                0xCF,
                0xA7,
                0xD9,
                0xE8,
                0x87,
                0x4A,
                0xBD,
                0x8E,
                0x29,
                0x67,
                0x00,
                0x1F,
                0xD3,
                0xAD,
                0x00,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const PROPERTYKEY")]
    public static ref readonly PROPERTYKEY MFP_PKEY_StreamRenderingResults
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x40,
                0x97,
                0xCF,
                0xA7,
                0xD9,
                0xE8,
                0x87,
                0x4A,
                0xBD,
                0x8E,
                0x29,
                0x67,
                0x00,
                0x1F,
                0xD3,
                0xAD,
                0x01,
                0x00,
                0x00,
                0x00
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<PROPERTYKEY>());
            return ref Unsafe.As<byte, PROPERTYKEY>(ref MemoryMarshal.GetReference(data));
        }
    }
}