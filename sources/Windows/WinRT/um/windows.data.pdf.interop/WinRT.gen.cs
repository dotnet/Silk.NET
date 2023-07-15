// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/windows.data.pdf.interop.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.DirectX;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.WinRT;
public static unsafe partial class WinRT
{
    /// <include file='WinRT.xml' path='doc/member[@name="WinRT.PdfCreateRenderer"]/*'/>
    [DllImport("windows.data.pdf.dll", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.3")]
    public static extern HRESULT PdfCreateRenderer(IDXGIDevice* pDevice, IPdfRendererNative** ppRenderer);
    [NativeTypeName("const D2D_RECT_F")]
    public static ref readonly D2D_RECT_F sc_PdfRenderParamsDefaultSrcRect
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
            Debug.Assert(data.Length == Unsafe.SizeOf<D2D_RECT_F>());
            return ref Unsafe.As<byte, D2D_RECT_F>(ref MemoryMarshal.GetReference(data));
        }
    }

    [NativeTypeName("const D2D_COLOR_F")]
    public static ref readonly DXGI_RGBA sc_PdfRenderParamsDefaultBkColor
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            ReadOnlySpan<byte> data = new byte[]
            {
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x80,
                0x3F,
                0x00,
                0x00,
                0x80,
                0x3F
            };
            Debug.Assert(data.Length == Unsafe.SizeOf<DXGI_RGBA>());
            return ref Unsafe.As<byte, DXGI_RGBA>(ref MemoryMarshal.GetReference(data));
        }
    }
}