// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument"]/*' />
[Guid("86B88E4D-AFA4-4D7B-88E4-68A51C4A0AEC")]
[NativeTypeName("struct ID2D1SvgDocument : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1SvgDocument : ID2D1SvgDocument.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgDocument));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, uint>)(lpVtbl[1]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, uint>)(lpVtbl[2]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Resource.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1SvgDocument*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), factory);
    }

    /// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument.SetViewportSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetViewportSize([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, D2D_SIZE_F, int>)(lpVtbl[4]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), viewportSize);
    }

    /// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument.GetViewportSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("D2D1_SIZE_F")]
    public D2D_SIZE_F GetViewportSize()
    {
        D2D_SIZE_F result;
        return *((delegate* unmanaged<ID2D1SvgDocument*, D2D_SIZE_F*, D2D_SIZE_F*>)(lpVtbl[5]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), &result);
    }

    /// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument.SetRoot"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetRoot(ID2D1SvgElement* root)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, ID2D1SvgElement*, int>)(lpVtbl[6]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
    }

    /// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument.GetRoot"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetRoot(ID2D1SvgElement** root)
    {
        ((delegate* unmanaged<ID2D1SvgDocument*, ID2D1SvgElement**, void>)(lpVtbl[7]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), root);
    }

    /// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument.FindElementById"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindElementById([NativeTypeName("PCWSTR")] ushort* id, ID2D1SvgElement** svgElement)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, ushort*, ID2D1SvgElement**, int>)(lpVtbl[8]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), id, svgElement);
    }

    /// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument.Serialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Serialize(IStream* outputXmlStream, ID2D1SvgElement* subtree = null)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, IStream*, ID2D1SvgElement*, int>)(lpVtbl[9]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), outputXmlStream, subtree);
    }

    /// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument.Deserialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Deserialize(IStream* inputXmlStream, ID2D1SvgElement** subtree)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, IStream*, ID2D1SvgElement**, int>)(lpVtbl[10]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), inputXmlStream, subtree);
    }

    /// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument.CreatePaint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreatePaint(D2D1_SVG_PAINT_TYPE paintType, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("PCWSTR")] ushort* id, ID2D1SvgPaint** paint)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, D2D1_SVG_PAINT_TYPE, DXGI_RGBA*, ushort*, ID2D1SvgPaint**, int>)(lpVtbl[11]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), paintType, color, id, paint);
    }

    /// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument.CreateStrokeDashArray"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT CreateStrokeDashArray([NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, D2D1_SVG_LENGTH*, uint, ID2D1SvgStrokeDashArray**, int>)(lpVtbl[12]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), dashes, dashesCount, strokeDashArray);
    }

    /// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument.CreatePointCollection"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreatePointCollection([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, ID2D1SvgPointCollection** pointCollection)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, D2D_POINT_2F*, uint, ID2D1SvgPointCollection**, int>)(lpVtbl[13]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), points, pointsCount, pointCollection);
    }

    /// <include file='ID2D1SvgDocument.xml' path='doc/member[@name="ID2D1SvgDocument.CreatePathData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreatePathData([NativeTypeName("const FLOAT *")] float* segmentData, [NativeTypeName("UINT32")] uint segmentDataCount, [NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, ID2D1SvgPathData** pathData)
    {
        return ((delegate* unmanaged<ID2D1SvgDocument*, float*, uint, D2D1_SVG_PATH_COMMAND*, uint, ID2D1SvgPathData**, int>)(lpVtbl[14]))((ID2D1SvgDocument*)Unsafe.AsPointer(ref this), segmentData, segmentDataCount, commands, commandsCount, pathData);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        HRESULT SetViewportSize([NativeTypeName("D2D1_SIZE_F")] D2D_SIZE_F viewportSize);

        [VtblIndex(5)]
        [return: NativeTypeName("D2D1_SIZE_F")]
        D2D_SIZE_F GetViewportSize();

        [VtblIndex(6)]
        HRESULT SetRoot(ID2D1SvgElement* root);

        [VtblIndex(7)]
        void GetRoot(ID2D1SvgElement** root);

        [VtblIndex(8)]
        HRESULT FindElementById([NativeTypeName("PCWSTR")] ushort* id, ID2D1SvgElement** svgElement);

        [VtblIndex(9)]
        HRESULT Serialize(IStream* outputXmlStream, ID2D1SvgElement* subtree = null);

        [VtblIndex(10)]
        HRESULT Deserialize(IStream* inputXmlStream, ID2D1SvgElement** subtree);

        [VtblIndex(11)]
        HRESULT CreatePaint(D2D1_SVG_PAINT_TYPE paintType, [NativeTypeName("const D2D1_COLOR_F *")] DXGI_RGBA* color, [NativeTypeName("PCWSTR")] ushort* id, ID2D1SvgPaint** paint);

        [VtblIndex(12)]
        HRESULT CreateStrokeDashArray([NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray);

        [VtblIndex(13)]
        HRESULT CreatePointCollection([NativeTypeName("const D2D1_POINT_2F *")] D2D_POINT_2F* points, [NativeTypeName("UINT32")] uint pointsCount, ID2D1SvgPointCollection** pointCollection);

        [VtblIndex(14)]
        HRESULT CreatePathData([NativeTypeName("const FLOAT *")] float* segmentData, [NativeTypeName("UINT32")] uint segmentDataCount, [NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, ID2D1SvgPathData** pathData);
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

        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Factory**, void> GetFactory;

        [NativeTypeName("HRESULT (D2D1_SIZE_F) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_SIZE_F, int> SetViewportSize;

        [NativeTypeName("D2D1_SIZE_F () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_SIZE_F*, D2D_SIZE_F*> GetViewportSize;

        [NativeTypeName("HRESULT (ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement*, int> SetRoot;

        [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement**, void> GetRoot;

        [NativeTypeName("HRESULT (PCWSTR, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ID2D1SvgElement**, int> FindElementById;

        [NativeTypeName("HRESULT (IStream *, ID2D1SvgElement *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, ID2D1SvgElement*, int> Serialize;

        [NativeTypeName("HRESULT (IStream *, ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, ID2D1SvgElement**, int> Deserialize;

        [NativeTypeName("HRESULT (D2D1_SVG_PAINT_TYPE, const D2D1_COLOR_F *, PCWSTR, ID2D1SvgPaint **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_SVG_PAINT_TYPE, DXGI_RGBA*, ushort*, ID2D1SvgPaint**, int> CreatePaint;

        [NativeTypeName("HRESULT (const D2D1_SVG_LENGTH *, UINT32, ID2D1SvgStrokeDashArray **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_SVG_LENGTH*, uint, ID2D1SvgStrokeDashArray**, int> CreateStrokeDashArray;

        [NativeTypeName("HRESULT (const D2D1_POINT_2F *, UINT32, ID2D1SvgPointCollection **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D_POINT_2F*, uint, ID2D1SvgPointCollection**, int> CreatePointCollection;

        [NativeTypeName("HRESULT (const FLOAT *, UINT32, const D2D1_SVG_PATH_COMMAND *, UINT32, ID2D1SvgPathData **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, D2D1_SVG_PATH_COMMAND*, uint, ID2D1SvgPathData**, int> CreatePathData;
    }
}
