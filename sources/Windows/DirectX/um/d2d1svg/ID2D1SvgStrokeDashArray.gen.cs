// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1SvgStrokeDashArray.xml' path='doc/member[@name="ID2D1SvgStrokeDashArray"]/*'/>
[Guid("F1C0CA52-92A3-4F00-B4CE-F35691EFD9D9")]
[NativeTypeName("struct ID2D1SvgStrokeDashArray : ID2D1SvgAttribute")]
[NativeInheritance("ID2D1SvgAttribute")]
public unsafe partial struct ID2D1SvgStrokeDashArray : ID2D1SvgStrokeDashArray.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgStrokeDashArray));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, uint> )(lpVtbl[1]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, uint> )(lpVtbl[2]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Resource.GetFactory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, ID2D1Factory**, void> )(lpVtbl[3]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), factory);
    }

    /// <inheritdoc cref = "ID2D1SvgAttribute.GetElement"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetElement(ID2D1SvgElement** element)
    {
        ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, ID2D1SvgElement**, void> )(lpVtbl[4]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), element);
    }

    /// <inheritdoc cref = "ID2D1SvgAttribute.Clone"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Clone(ID2D1SvgAttribute** attribute)
    {
        return ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, ID2D1SvgAttribute**, int> )(lpVtbl[5]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), attribute);
    }

    /// <include file='ID2D1SvgStrokeDashArray.xml' path='doc/member[@name="ID2D1SvgStrokeDashArray.RemoveDashesAtEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveDashesAtEnd([NativeTypeName("UINT32")] uint dashesCount)
    {
        return ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, uint, int> )(lpVtbl[6]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashesCount);
    }

    /// <include file='ID2D1SvgStrokeDashArray.xml' path='doc/member[@name="ID2D1SvgStrokeDashArray.UpdateDashes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdateDashes([NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
    {
        return ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, D2D1_SVG_LENGTH*, uint, uint, int> )(lpVtbl[7]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
    }

    /// <include file='ID2D1SvgStrokeDashArray.xml' path='doc/member[@name="ID2D1SvgStrokeDashArray.UpdateDashes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UpdateDashes([NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
    {
        return ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, float*, uint, uint, int> )(lpVtbl[8]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
    }

    /// <include file='ID2D1SvgStrokeDashArray.xml' path='doc/member[@name="ID2D1SvgStrokeDashArray.GetDashes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDashes(D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
    {
        return ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, D2D1_SVG_LENGTH*, uint, uint, int> )(lpVtbl[9]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
    }

    /// <include file='ID2D1SvgStrokeDashArray.xml' path='doc/member[@name="ID2D1SvgStrokeDashArray.GetDashes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDashes(float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0)
    {
        return ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, float*, uint, uint, int> )(lpVtbl[10]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this), dashes, dashesCount, startIndex);
    }

    /// <include file='ID2D1SvgStrokeDashArray.xml' path='doc/member[@name="ID2D1SvgStrokeDashArray.GetDashesCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("UINT32")]
    public uint GetDashesCount()
    {
        return ((delegate* unmanaged<ID2D1SvgStrokeDashArray*, uint> )(lpVtbl[11]))((ID2D1SvgStrokeDashArray*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ID2D1SvgAttribute.Interface
    {
        [VtblIndex(6)]
        HRESULT RemoveDashesAtEnd([NativeTypeName("UINT32")] uint dashesCount);
        [VtblIndex(7)]
        HRESULT UpdateDashes([NativeTypeName("const D2D1_SVG_LENGTH *")] D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);
        [VtblIndex(8)]
        HRESULT UpdateDashes([NativeTypeName("const FLOAT *")] float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);
        [VtblIndex(9)]
        HRESULT GetDashes(D2D1_SVG_LENGTH* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);
        [VtblIndex(10)]
        HRESULT GetDashes(float* dashes, [NativeTypeName("UINT32")] uint dashesCount, [NativeTypeName("UINT32")] uint startIndex = 0);
        [VtblIndex(11)]
        [return: NativeTypeName("UINT32")]
        uint GetDashesCount();
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
        [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement**, void> GetElement;
        [NativeTypeName("HRESULT (ID2D1SvgAttribute **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgAttribute**, int> Clone;
        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveDashesAtEnd;
        [NativeTypeName("HRESULT (const D2D1_SVG_LENGTH *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_SVG_LENGTH*, uint, uint, int> UpdateDashes;
        [NativeTypeName("HRESULT (const FLOAT *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, uint, int> UpdateDashes1;
        [NativeTypeName("HRESULT (D2D1_SVG_LENGTH *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_SVG_LENGTH*, uint, uint, int> GetDashes;
        [NativeTypeName("HRESULT (FLOAT *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, uint, int> GetDashes1;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetDashesCount;
    }
}