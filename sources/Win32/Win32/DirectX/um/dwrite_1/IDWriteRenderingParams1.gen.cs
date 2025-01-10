// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("94413CF4-A6FC-4248-8B50-6674348FCAD3")]
[NativeTypeName("struct IDWriteRenderingParams1 : IDWriteRenderingParams")]
[NativeInheritance("IDWriteRenderingParams")]
public unsafe partial struct IDWriteRenderingParams1
    : IDWriteRenderingParams1.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteRenderingParams1));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public float GetGamma()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1, float>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public float GetEnhancedContrast()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1, float>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public float GetClearTypeLevel()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1, float>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public DWRITE_PIXEL_GEOMETRY GetPixelGeometry()
    {
        return (
            (delegate* unmanaged<IDWriteRenderingParams1, DWRITE_PIXEL_GEOMETRY>)((*lpVtbl)[6])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public DWRITE_RENDERING_MODE GetRenderingMode()
    {
        return (
            (delegate* unmanaged<IDWriteRenderingParams1, DWRITE_RENDERING_MODE>)((*lpVtbl)[7])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public float GetGrayscaleEnhancedContrast()
    {
        return ((delegate* unmanaged<IDWriteRenderingParams1, float>)((*lpVtbl)[8]))(this);
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

        [NativeTypeName(
            "DWRITE_PIXEL_GEOMETRY () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_PIXEL_GEOMETRY> GetPixelGeometry;

        [NativeTypeName(
            "DWRITE_RENDERING_MODE () __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DWRITE_RENDERING_MODE> GetRenderingMode;

        [NativeTypeName("FLOAT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float> GetGrayscaleEnhancedContrast;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteRenderingParams1"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteRenderingParams1(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDWriteRenderingParams"/> to <see cref = "IDWriteRenderingParams1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDWriteRenderingParams"/> instance to be converted </param>
    public static explicit operator IDWriteRenderingParams1(
        Silk.NET.DirectX.IDWriteRenderingParams value
    )
    {
        return new IDWriteRenderingParams1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteRenderingParams1"/> to <see cref = "Silk.NET.DirectX.IDWriteRenderingParams"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteRenderingParams1"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDWriteRenderingParams(
        IDWriteRenderingParams1 value
    )
    {
        return new Silk.NET.DirectX.IDWriteRenderingParams(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteRenderingParams1"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteRenderingParams1(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteRenderingParams1(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteRenderingParams1"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteRenderingParams1"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteRenderingParams1 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
