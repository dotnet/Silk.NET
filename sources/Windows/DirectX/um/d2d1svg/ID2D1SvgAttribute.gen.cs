// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1SvgAttribute.xml' path='doc/member[@name="ID2D1SvgAttribute"]/*'/>
[Guid("C9CDB0DD-F8C9-4E70-B7C2-301C80292C5E")]
[NativeTypeName("struct ID2D1SvgAttribute : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1SvgAttribute : ID2D1SvgAttribute.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgAttribute));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SvgAttribute*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1SvgAttribute*, uint> )(lpVtbl[1]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SvgAttribute*, uint> )(lpVtbl[2]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Resource.GetFactory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1SvgAttribute*, ID2D1Factory**, void> )(lpVtbl[3]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this), factory);
    }

    /// <include file='ID2D1SvgAttribute.xml' path='doc/member[@name="ID2D1SvgAttribute.GetElement"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetElement(ID2D1SvgElement** element)
    {
        ((delegate* unmanaged<ID2D1SvgAttribute*, ID2D1SvgElement**, void> )(lpVtbl[4]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this), element);
    }

    /// <include file='ID2D1SvgAttribute.xml' path='doc/member[@name="ID2D1SvgAttribute.Clone"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Clone(ID2D1SvgAttribute** attribute)
    {
        return ((delegate* unmanaged<ID2D1SvgAttribute*, ID2D1SvgAttribute**, int> )(lpVtbl[5]))((ID2D1SvgAttribute*)Unsafe.AsPointer(ref this), attribute);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        void GetElement(ID2D1SvgElement** element);
        [VtblIndex(5)]
        HRESULT Clone(ID2D1SvgAttribute** attribute);
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
    }
}