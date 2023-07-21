// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IBandHost.xml' path='doc/member[@name="IBandHost"]/*' />
[Guid("B9075C7C-D48E-403F-AB99-D6C77A1084AC")]
[NativeTypeName("struct IBandHost : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBandHost : IBandHost.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBandHost));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBandHost*, Guid*, void**, int>)(lpVtbl[0]))((IBandHost*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBandHost*, uint>)(lpVtbl[1]))((IBandHost*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBandHost*, uint>)(lpVtbl[2]))((IBandHost*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBandHost.xml' path='doc/member[@name="IBandHost.CreateBand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateBand([NativeTypeName("const IID &")] Guid* rclsidBand, BOOL fAvailable, BOOL fVisible, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IBandHost*, Guid*, BOOL, BOOL, Guid*, void**, int>)(lpVtbl[3]))((IBandHost*)Unsafe.AsPointer(ref this), rclsidBand, fAvailable, fVisible, riid, ppv);
    }

    /// <include file='IBandHost.xml' path='doc/member[@name="IBandHost.SetBandAvailability"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetBandAvailability([NativeTypeName("const IID &")] Guid* rclsidBand, BOOL fAvailable)
    {
        return ((delegate* unmanaged<IBandHost*, Guid*, BOOL, int>)(lpVtbl[4]))((IBandHost*)Unsafe.AsPointer(ref this), rclsidBand, fAvailable);
    }

    /// <include file='IBandHost.xml' path='doc/member[@name="IBandHost.DestroyBand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DestroyBand([NativeTypeName("const IID &")] Guid* rclsidBand)
    {
        return ((delegate* unmanaged<IBandHost*, Guid*, int>)(lpVtbl[5]))((IBandHost*)Unsafe.AsPointer(ref this), rclsidBand);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateBand([NativeTypeName("const IID &")] Guid* rclsidBand, BOOL fAvailable, BOOL fVisible, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(4)]
        HRESULT SetBandAvailability([NativeTypeName("const IID &")] Guid* rclsidBand, BOOL fAvailable);

        [VtblIndex(5)]
        HRESULT DestroyBand([NativeTypeName("const IID &")] Guid* rclsidBand);
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

        [NativeTypeName("HRESULT (const IID &, BOOL, BOOL, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, BOOL, BOOL, Guid*, void**, int> CreateBand;

        [NativeTypeName("HRESULT (const IID &, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, BOOL, int> SetBandAvailability;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> DestroyBand;
    }
}
