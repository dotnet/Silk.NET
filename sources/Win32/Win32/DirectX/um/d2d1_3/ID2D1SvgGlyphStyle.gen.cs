// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("AF671749-D241-4DB8-8E41-DCC2E5C1A438")]
[NativeTypeName("struct ID2D1SvgGlyphStyle : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1SvgGlyphStyle : ID2D1SvgGlyphStyle.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgGlyphStyle));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SvgGlyphStyle, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1SvgGlyphStyle, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SvgGlyphStyle, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1SvgGlyphStyle, ID2D1Factory*, void>)((*lpVtbl)[3]))(
            this,
            factory
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFill(ID2D1Brush brush)
    {
        return ((delegate* unmanaged<ID2D1SvgGlyphStyle, ID2D1Brush, int>)((*lpVtbl)[4]))(
            this,
            brush
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void GetFill(ID2D1Brush* brush)
    {
        ((delegate* unmanaged<ID2D1SvgGlyphStyle, ID2D1Brush*, void>)((*lpVtbl)[5]))(this, brush);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetStroke(
        ID2D1Brush brush,
        float strokeWidth = 1.0f,
        [NativeTypeName("const FLOAT *")] float* dashes = null,
        [NativeTypeName("UINT32")] uint dashesCount = 0,
        float dashOffset = 1.0f
    )
    {
        return (
            (delegate* unmanaged<ID2D1SvgGlyphStyle, ID2D1Brush, float, float*, uint, float, int>)(
                (*lpVtbl)[6]
            )
        )(this, brush, strokeWidth, dashes, dashesCount, dashOffset);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [return: NativeTypeName("UINT32")]
    public uint GetStrokeDashesCount()
    {
        return ((delegate* unmanaged<ID2D1SvgGlyphStyle, uint>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetStroke(
        ID2D1Brush* brush,
        float* strokeWidth = null,
        float* dashes = null,
        [NativeTypeName("UINT32")] uint dashesCount = 0,
        float* dashOffset = null
    )
    {
        (
            (delegate* unmanaged<
                ID2D1SvgGlyphStyle,
                ID2D1Brush*,
                float*,
                float*,
                uint,
                float*,
                void>)((*lpVtbl)[8])
        )(this, brush, strokeWidth, dashes, dashesCount, dashOffset);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        HRESULT SetFill(ID2D1Brush brush);

        [VtblIndex(5)]
        void GetFill(ID2D1Brush* brush);

        [VtblIndex(6)]
        HRESULT SetStroke(
            ID2D1Brush brush,
            float strokeWidth = 1.0f,
            [NativeTypeName("const FLOAT *")] float* dashes = null,
            [NativeTypeName("UINT32")] uint dashesCount = 0,
            float dashOffset = 1.0f
        );

        [VtblIndex(7)]
        [return: NativeTypeName("UINT32")]
        uint GetStrokeDashesCount();

        [VtblIndex(8)]
        void GetStroke(
            ID2D1Brush* brush,
            float* strokeWidth = null,
            float* dashes = null,
            [NativeTypeName("UINT32")] uint dashesCount = 0,
            float* dashOffset = null
        );
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

        [NativeTypeName(
            "void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Factory*, void> GetFactory;

        [NativeTypeName("HRESULT (ID2D1Brush *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Brush, int> SetFill;

        [NativeTypeName("void (ID2D1Brush **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Brush*, void> GetFill;

        [NativeTypeName(
            "HRESULT (ID2D1Brush *, FLOAT, const FLOAT *, UINT32, FLOAT) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1Brush, float, float*, uint, float, int> SetStroke;

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetStrokeDashesCount;

        [NativeTypeName(
            "void (ID2D1Brush **, FLOAT *, FLOAT *, UINT32, FLOAT *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ID2D1Brush*,
            float*,
            float*,
            uint,
            float*,
            void> GetStroke;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1SvgGlyphStyle"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1SvgGlyphStyle(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1SvgGlyphStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1SvgGlyphStyle(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1SvgGlyphStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1SvgGlyphStyle"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1SvgGlyphStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1SvgGlyphStyle value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1SvgGlyphStyle"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1SvgGlyphStyle(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1SvgGlyphStyle(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1SvgGlyphStyle"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1SvgGlyphStyle"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1SvgGlyphStyle value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
