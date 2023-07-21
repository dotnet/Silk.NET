// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFVideoSampleAllocatorNotifyEx.xml' path='doc/member[@name="IMFVideoSampleAllocatorNotifyEx"]/*' />
[Guid("3978AA1A-6D5B-4B7F-A340-90899189AE34")]
[NativeTypeName("struct IMFVideoSampleAllocatorNotifyEx : IMFVideoSampleAllocatorNotify")]
[NativeInheritance("IMFVideoSampleAllocatorNotify")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFVideoSampleAllocatorNotifyEx : IMFVideoSampleAllocatorNotifyEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFVideoSampleAllocatorNotifyEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorNotifyEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFVideoSampleAllocatorNotifyEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorNotifyEx*, uint>)(lpVtbl[1]))((IMFVideoSampleAllocatorNotifyEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorNotifyEx*, uint>)(lpVtbl[2]))((IMFVideoSampleAllocatorNotifyEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IMFVideoSampleAllocatorNotify.NotifyRelease" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT NotifyRelease()
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorNotifyEx*, int>)(lpVtbl[3]))((IMFVideoSampleAllocatorNotifyEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFVideoSampleAllocatorNotifyEx.xml' path='doc/member[@name="IMFVideoSampleAllocatorNotifyEx.NotifyPrune"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT NotifyPrune(IMFSample* __MIDL__IMFVideoSampleAllocatorNotifyEx0000)
    {
        return ((delegate* unmanaged<IMFVideoSampleAllocatorNotifyEx*, IMFSample*, int>)(lpVtbl[4]))((IMFVideoSampleAllocatorNotifyEx*)Unsafe.AsPointer(ref this), __MIDL__IMFVideoSampleAllocatorNotifyEx0000);
    }

    public interface Interface : IMFVideoSampleAllocatorNotify.Interface
    {
        [VtblIndex(4)]
        HRESULT NotifyPrune(IMFSample* __MIDL__IMFVideoSampleAllocatorNotifyEx0000);
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyRelease;

        [NativeTypeName("HRESULT (IMFSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSample*, int> NotifyPrune;
    }
}
