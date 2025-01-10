// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("86B88E4D-AFA4-4D7B-88E4-68A51C4A0AEC")]
[NativeTypeName("struct ID2D1SvgDocument : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1SvgDocument : ID2D1SvgDocument.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgDocument));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID2D1SvgDocument, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SvgDocument, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory* factory)
    {
        ((delegate* unmanaged<ID2D1SvgDocument, ID2D1Factory*, void>)((*lpVtbl)[3]))(this, factory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetViewportSize([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument, D2D_SIZE_F, int>)((*lpVtbl)[4]))(
            this,
            viewportSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("D2D1_SIZE_F")]
    public D2D_SIZE_F GetViewportSize()
    {
        D2D_SIZE_F result;
        return *((delegate* unmanaged<ID2D1SvgDocument, D2D_SIZE_F*, D2D_SIZE_F*>)((*lpVtbl)[5]))(
            this,
            &result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRoot(ID2D1SvgElement root)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument, ID2D1SvgElement, int>)((*lpVtbl)[6]))(
            this,
            root
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetRoot(ID2D1SvgElement* root)
    {
        ((delegate* unmanaged<ID2D1SvgDocument, ID2D1SvgElement*, void>)((*lpVtbl)[7]))(this, root);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindElementById(
        [NativeTypeName("PCWSTR")] ushort* id,
        ID2D1SvgElement* svgElement
    )
    {
        return (
            (delegate* unmanaged<ID2D1SvgDocument, ushort*, ID2D1SvgElement*, int>)((*lpVtbl)[8])
        )(this, id, svgElement);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Serialize(IStream outputXmlStream, ID2D1SvgElement subtree = default)
    {
        return (
            (delegate* unmanaged<ID2D1SvgDocument, IStream, ID2D1SvgElement, int>)((*lpVtbl)[9])
        )(this, outputXmlStream, subtree);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Deserialize(IStream inputXmlStream, ID2D1SvgElement* subtree)
    {
        return (
            (delegate* unmanaged<ID2D1SvgDocument, IStream, ID2D1SvgElement*, int>)((*lpVtbl)[10])
        )(this, inputXmlStream, subtree);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreatePaint(
        D2D1_SVG_PAINT_TYPE paintType,
        [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color,
        [NativeTypeName("PCWSTR")] ushort* id,
        ID2D1SvgPaint* paint
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1SvgDocument,
                D2D1_SVG_PAINT_TYPE,
                DXGI_RGBA*,
                ushort*,
                ID2D1SvgPaint*,
                int>)((*lpVtbl)[11])
        )(this, paintType, color, id, paint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateStrokeDashArray(
        [NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes,
        [NativeTypeName("UINT32")] uint dashesCount,
        ID2D1SvgStrokeDashArray* strokeDashArray
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1SvgDocument,
                D2D1_SVG_LENGTH*,
                uint,
                ID2D1SvgStrokeDashArray*,
                int>)((*lpVtbl)[12])
        )(this, dashes, dashesCount, strokeDashArray);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreatePointCollection(
        [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points,
        [NativeTypeName("UINT32")] uint pointsCount,
        ID2D1SvgPointCollection* pointCollection
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1SvgDocument,
                D2D_POINT_2F*,
                uint,
                ID2D1SvgPointCollection*,
                int>)((*lpVtbl)[13])
        )(this, points, pointsCount, pointCollection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreatePathData(
        [NativeTypeName("const FLOAT *")] float* segmentData,
        [NativeTypeName("UINT32")] uint segmentDataCount,
        [NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands,
        [NativeTypeName("UINT32")] uint commandsCount,
        ID2D1SvgPathData* pathData
    )
    {
        return (
            (delegate* unmanaged<
                ID2D1SvgDocument,
                float*,
                uint,
                D2D1_SVG_PATH_COMMAND*,
                uint,
                ID2D1SvgPathData*,
                int>)((*lpVtbl)[14])
        )(this, segmentData, segmentDataCount, commands, commandsCount, pathData);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        HRESULT SetViewportSize([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize);

        [VtblIndex(5)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        D2D_SIZE_F GetViewportSize();

        [VtblIndex(6)]
        HRESULT SetRoot(ID2D1SvgElement root);

        [VtblIndex(7)]
        void GetRoot(ID2D1SvgElement* root);

        [VtblIndex(8)]
        HRESULT FindElementById([NativeTypeName("PCWSTR")] ushort* id, ID2D1SvgElement* svgElement);

        [VtblIndex(9)]
        HRESULT Serialize(IStream outputXmlStream, ID2D1SvgElement subtree = default);

        [VtblIndex(10)]
        HRESULT Deserialize(IStream inputXmlStream, ID2D1SvgElement* subtree);

        [VtblIndex(11)]
        HRESULT CreatePaint(
            D2D1_SVG_PAINT_TYPE paintType,
            [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color,
            [NativeTypeName("PCWSTR")] ushort* id,
            ID2D1SvgPaint* paint
        );

        [VtblIndex(12)]
        HRESULT CreateStrokeDashArray(
            [NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes,
            [NativeTypeName("UINT32")] uint dashesCount,
            ID2D1SvgStrokeDashArray* strokeDashArray
        );

        [VtblIndex(13)]
        HRESULT CreatePointCollection(
            [NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points,
            [NativeTypeName("UINT32")] uint pointsCount,
            ID2D1SvgPointCollection* pointCollection
        );

        [VtblIndex(14)]
        HRESULT CreatePathData(
            [NativeTypeName("const FLOAT *")] float* segmentData,
            [NativeTypeName("UINT32")] uint segmentDataCount,
            [NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands,
            [NativeTypeName("UINT32")] uint commandsCount,
            ID2D1SvgPathData* pathData
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

        [NativeTypeName("HRESULT (D2D1_SIZE_F) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_SIZE_F, int> SetViewportSize;

        [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_SIZE_F*, D2D_SIZE_F*> GetViewportSize;

        [NativeTypeName(
            "HRESULT (ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement, int> SetRoot;

        [NativeTypeName(
            "void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement*, void> GetRoot;

        [NativeTypeName(
            "HRESULT (PCWSTR, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, ID2D1SvgElement*, int> FindElementById;

        [NativeTypeName(
            "HRESULT (IStream *, ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStream, ID2D1SvgElement, int> Serialize;

        [NativeTypeName(
            "HRESULT (IStream *, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStream, ID2D1SvgElement*, int> Deserialize;

        [NativeTypeName(
            "HRESULT (D2D1_SVG_PAINT_TYPE, const D2D1_COLOR_F *, PCWSTR, ID2D1SvgPaint **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_SVG_PAINT_TYPE,
            DXGI_RGBA*,
            ushort*,
            ID2D1SvgPaint*,
            int> CreatePaint;

        [NativeTypeName(
            "HRESULT (const D2D1_SVG_LENGTH *, UINT32, ID2D1SvgStrokeDashArray **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D1_SVG_LENGTH*,
            uint,
            ID2D1SvgStrokeDashArray*,
            int> CreateStrokeDashArray;

        [NativeTypeName(
            "HRESULT (const D2D1_POINT_2F *, UINT32, ID2D1SvgPointCollection **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            D2D_POINT_2F*,
            uint,
            ID2D1SvgPointCollection*,
            int> CreatePointCollection;

        [NativeTypeName(
            "HRESULT (const FLOAT *, UINT32, const D2D1_SVG_PATH_COMMAND *, UINT32, ID2D1SvgPathData **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            float*,
            uint,
            D2D1_SVG_PATH_COMMAND*,
            uint,
            ID2D1SvgPathData*,
            int> CreatePathData;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID2D1SvgDocument"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID2D1SvgDocument(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.ID2D1Resource"/> to <see cref = "ID2D1SvgDocument"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.ID2D1Resource"/> instance to be converted </param>
    public static explicit operator ID2D1SvgDocument(Silk.NET.DirectX.ID2D1Resource value)
    {
        return new ID2D1SvgDocument(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1SvgDocument"/> to <see cref = "Silk.NET.DirectX.ID2D1Resource"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1SvgDocument"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.ID2D1Resource(ID2D1SvgDocument value)
    {
        return new Silk.NET.DirectX.ID2D1Resource(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID2D1SvgDocument"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID2D1SvgDocument(Silk.NET.Windows.IUnknown value)
    {
        return new ID2D1SvgDocument(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID2D1SvgDocument"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID2D1SvgDocument"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID2D1SvgDocument value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
