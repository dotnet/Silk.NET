// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDCompositionCompositeEffect.xml' path='doc/member[@name="IDCompositionCompositeEffect"]/*'/>
[Guid("576616C0-A231-494D-A38D-00FD5EC4DB46")]
[NativeTypeName("struct IDCompositionCompositeEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionCompositeEffect : IDCompositionCompositeEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionCompositeEffect));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionCompositeEffect*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionCompositeEffect*, uint> )(lpVtbl[1]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionCompositeEffect*, uint> )(lpVtbl[2]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDCompositionFilterEffect.SetInput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown* input, uint flags)
    {
        return ((delegate* unmanaged<IDCompositionCompositeEffect*, uint, IUnknown*, uint, int> )(lpVtbl[3]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this), index, input, flags);
    }

    /// <include file='IDCompositionCompositeEffect.xml' path='doc/member[@name="IDCompositionCompositeEffect.SetMode"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetMode(D2D1_COMPOSITE_MODE mode)
    {
        return ((delegate* unmanaged<IDCompositionCompositeEffect*, D2D1_COMPOSITE_MODE, int> )(lpVtbl[4]))((IDCompositionCompositeEffect*)Unsafe.AsPointer(ref this), mode);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetMode(D2D1_COMPOSITE_MODE mode);
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
        [NativeTypeName("HRESULT (UINT, IUnknown *, UINT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IUnknown*, uint, int> SetInput;
        [NativeTypeName("HRESULT (D2D1_COMPOSITE_MODE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_COMPOSITE_MODE, int> SetMode;
    }
}