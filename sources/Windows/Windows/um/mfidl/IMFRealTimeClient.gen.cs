// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFRealTimeClient.xml' path='doc/member[@name="IMFRealTimeClient"]/*' />
[Guid("2347D60B-3FB5-480C-8803-8DF3ADCD3EF0")]
[NativeTypeName("struct IMFRealTimeClient : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFRealTimeClient : IMFRealTimeClient.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFRealTimeClient));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFRealTimeClient*, Guid*, void**, int>)(lpVtbl[0]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFRealTimeClient*, uint>)(lpVtbl[1]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFRealTimeClient*, uint>)(lpVtbl[2]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFRealTimeClient.xml' path='doc/member[@name="IMFRealTimeClient.RegisterThreads"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterThreads([NativeTypeName("DWORD")] uint dwTaskIndex, [NativeTypeName("LPCWSTR")] ushort* wszClass)
    {
        return ((delegate* unmanaged<IMFRealTimeClient*, uint, ushort*, int>)(lpVtbl[3]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this), dwTaskIndex, wszClass);
    }

    /// <include file='IMFRealTimeClient.xml' path='doc/member[@name="IMFRealTimeClient.UnregisterThreads"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterThreads()
    {
        return ((delegate* unmanaged<IMFRealTimeClient*, int>)(lpVtbl[4]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFRealTimeClient.xml' path='doc/member[@name="IMFRealTimeClient.SetWorkQueue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueueId)
    {
        return ((delegate* unmanaged<IMFRealTimeClient*, uint, int>)(lpVtbl[5]))((IMFRealTimeClient*)Unsafe.AsPointer(ref this), dwWorkQueueId);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterThreads([NativeTypeName("DWORD")] uint dwTaskIndex, [NativeTypeName("LPCWSTR")] ushort* wszClass);

        [VtblIndex(4)]
        HRESULT UnregisterThreads();

        [VtblIndex(5)]
        HRESULT SetWorkQueue([NativeTypeName("DWORD")] uint dwWorkQueueId);
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

        [NativeTypeName("HRESULT (DWORD, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, int> RegisterThreads;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnregisterThreads;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetWorkQueue;
    }
}
