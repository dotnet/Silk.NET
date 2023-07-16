// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDCompositionFilterEffect.xml' path='doc/member[@name="IDCompositionFilterEffect"]/*'/>
[Guid("30C421D5-8CB2-4E9F-B133-37BE270D4AC2")]
[NativeTypeName("struct IDCompositionFilterEffect : IDCompositionEffect")]
[NativeInheritance("IDCompositionEffect")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IDCompositionFilterEffect : IDCompositionFilterEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDCompositionFilterEffect));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDCompositionFilterEffect*, Guid*, void**, int> )(lpVtbl[0]))((IDCompositionFilterEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDCompositionFilterEffect*, uint> )(lpVtbl[1]))((IDCompositionFilterEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDCompositionFilterEffect*, uint> )(lpVtbl[2]))((IDCompositionFilterEffect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDCompositionFilterEffect.xml' path='doc/member[@name="IDCompositionFilterEffect.SetInput"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetInput(uint index, IUnknown* input, uint flags)
    {
        return ((delegate* unmanaged<IDCompositionFilterEffect*, uint, IUnknown*, uint, int> )(lpVtbl[3]))((IDCompositionFilterEffect*)Unsafe.AsPointer(ref this), index, input, flags);
    }

    public interface Interface : IDCompositionEffect.Interface
    {
        [VtblIndex(3)]
        HRESULT SetInput(uint index, IUnknown* input, uint flags);
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
    }
}