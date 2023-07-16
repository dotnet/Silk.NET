// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDWriteRenderingParams1.xml' path='doc/member[@name="IDWriteRenderingParams1"]/*'/>
[Guid("94413CF4-A6FC-4248-8B50-6674348FCAD3")]
[NativeTypeName("struct IDWriteRenderingParams1 : IDWriteRenderingParams")]
[NativeInheritance("IDWriteRenderingParams")]
public unsafe partial struct IDWriteRenderingParams1 : IDWriteRenderingParams1.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRenderingParams1));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1*, Guid*, void**, int> )(lpVtbl[0]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1*, uint> )(lpVtbl[1]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1*, uint> )(lpVtbl[2]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteRenderingParams.GetGamma"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public float GetGamma()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1*, float> )(lpVtbl[3]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteRenderingParams.GetEnhancedContrast"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public float GetEnhancedContrast()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1*, float> )(lpVtbl[4]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteRenderingParams.GetClearTypeLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public float GetClearTypeLevel()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1*, float> )(lpVtbl[5]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteRenderingParams.GetPixelGeometry"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1*, DWRITE_PIXEL_GEOMETRY> )(lpVtbl[6]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDWriteRenderingParams.GetRenderingMode"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public DWRITE_RENDERING_MODE GetRenderingMode()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1*, DWRITE_RENDERING_MODE> )(lpVtbl[7]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteRenderingParams1.xml' path='doc/member[@name="IDWriteRenderingParams1.GetGrayscaleEnhancedContrast"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public float GetGrayscaleEnhancedContrast()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1*, float> )(lpVtbl[8]))((IDWriteRenderingParams1*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IDWriteRenderingParams.Interface
    {
        [VtblIndex(8)]
        float GetGrayscaleEnhancedContrast();
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
    }
}