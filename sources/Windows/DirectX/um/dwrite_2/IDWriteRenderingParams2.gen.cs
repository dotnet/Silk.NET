// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDWriteRenderingParams2.xml' path='doc/member[@name="IDWriteRenderingParams2"]/*' />
[Guid("F9D711C3-9777-40AE-87E8-3E5AF9BF0948")]
[NativeTypeName("struct IDWriteRenderingParams2 : IDWriteRenderingParams1")]
[NativeInheritance("IDWriteRenderingParams1")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IDWriteRenderingParams2 : IDWriteRenderingParams2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRenderingParams2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteRenderingParams2*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams2*, uint>)(lpVtbl[1]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams2*, uint>)(lpVtbl[2]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteRenderingParams.GetGamma" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public float GetGamma()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams2*, float>)(lpVtbl[3]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteRenderingParams.GetEnhancedContrast" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public float GetEnhancedContrast()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams2*, float>)(lpVtbl[4]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteRenderingParams.GetClearTypeLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public float GetClearTypeLevel()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams2*, float>)(lpVtbl[5]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteRenderingParams.GetPixelGeometry" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams2*, DWRITE_PIXEL_GEOMETRY>)(lpVtbl[6]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteRenderingParams.GetRenderingMode" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public DWRITE_RENDERING_MODE GetRenderingMode()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams2*, DWRITE_RENDERING_MODE>)(lpVtbl[7]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDWriteRenderingParams1.GetGrayscaleEnhancedContrast" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public float GetGrayscaleEnhancedContrast()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams2*, float>)(lpVtbl[8]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteRenderingParams2.xml' path='doc/member[@name="IDWriteRenderingParams2.GetGridFitMode"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public DWRITE_GRID_FIT_MODE GetGridFitMode()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams2*, DWRITE_GRID_FIT_MODE>)(lpVtbl[9]))((IDWriteRenderingParams2*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDWriteRenderingParams1.Interface
    {
        [VtblIndex(9)]
        DWRITE_GRID_FIT_MODE GetGridFitMode();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetGamma;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetEnhancedContrast;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetClearTypeLevel;

        [NativeTypeName("DWRITE_PIXEL_GEOMETRY () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_PIXEL_GEOMETRY> GetPixelGeometry;

        [NativeTypeName("DWRITE_RENDERING_MODE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_RENDERING_MODE> GetRenderingMode;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetGrayscaleEnhancedContrast;

        [NativeTypeName("DWRITE_GRID_FIT_MODE () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DWRITE_GRID_FIT_MODE> GetGridFitMode;
    }
}
