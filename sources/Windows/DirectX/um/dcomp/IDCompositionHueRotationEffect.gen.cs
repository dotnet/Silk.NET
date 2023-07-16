// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDCompositionHueRotationEffect.xml' path='doc/member[@name="IDCompositionHueRotationEffect"]/*'/>
[Guid("6DB9F920-0770-4781-B0C6-381912F9D167")]
[NativeTypeName("struct IDCompositionHueRotationEffect : IDCompositionFilterEffect")]
[NativeInheritance("IDCompositionFilterEffect")]
public unsafe partial struct IDCompositionHueRotationEffect : IDCompositionHueRotationEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionHueRotationEffect));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionHueRotationEffect*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionHueRotationEffect*, uint> )(lpVtbl[1]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionHueRotationEffect*, uint> )(lpVtbl[2]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDCompositionFilterEffect.SetInput"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown* input, uint flags)
    {
        return ((delegate* unmanaged<IDCompositionHueRotationEffect*, uint, IUnknown*, uint, int> )(lpVtbl[3]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), index, input, flags);
    }

    /// <include file='IDCompositionHueRotationEffect.xml' path='doc/member[@name="IDCompositionHueRotationEffect.SetAngle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetAngle(IDCompositionAnimation* animation)
    {
        return ((delegate* unmanaged<IDCompositionHueRotationEffect*, IDCompositionAnimation*, int> )(lpVtbl[4]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), animation);
    }

    /// <include file='IDCompositionHueRotationEffect.xml' path='doc/member[@name="IDCompositionHueRotationEffect.SetAngle"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetAngle(float amountDegrees)
    {
        return ((delegate* unmanaged<IDCompositionHueRotationEffect*, float, int> )(lpVtbl[5]))((IDCompositionHueRotationEffect*)Unsafe.AsPointer(ref this), amountDegrees);
    }

    public interface Interface : IDCompositionFilterEffect.Interface
    {
        [VtblIndex(4)]
        HRESULT SetAngle(IDCompositionAnimation* animation);
        [VtblIndex(5)]
        HRESULT SetAngle(float amountDegrees);
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
        [NativeTypeName("HRESULT (IDCompositionAnimation *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDCompositionAnimation*, int> SetAngle;
        [NativeTypeName("HRESULT (float) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, int> SetAngle1;
    }
}