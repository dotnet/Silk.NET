// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMFTrackedSample.xml' path='doc/member[@name="IMFTrackedSample"]/*'/>
[Guid("245BF8E9-0755-40F7-88A5-AE0F18D55E17")]
[NativeTypeName("struct IMFTrackedSample : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFTrackedSample : IMFTrackedSample.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTrackedSample));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFTrackedSample*, Guid*, void**, int> )(lpVtbl[0]))((IMFTrackedSample*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFTrackedSample*, uint> )(lpVtbl[1]))((IMFTrackedSample*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFTrackedSample*, uint> )(lpVtbl[2]))((IMFTrackedSample*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTrackedSample.xml' path='doc/member[@name="IMFTrackedSample.SetAllocator"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetAllocator(IMFAsyncCallback* pSampleAllocator, IUnknown* pUnkState)
    {
        return ((delegate* unmanaged<IMFTrackedSample*, IMFAsyncCallback*, IUnknown*, int> )(lpVtbl[3]))((IMFTrackedSample*)Unsafe.AsPointer(ref this), pSampleAllocator, pUnkState);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetAllocator(IMFAsyncCallback* pSampleAllocator, IUnknown* pUnkState);
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
        [NativeTypeName("HRESULT (IMFAsyncCallback *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFAsyncCallback*, IUnknown*, int> SetAllocator;
    }
}