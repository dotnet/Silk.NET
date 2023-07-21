// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMFRealTimeClientEx.xml' path='doc/member[@name="IMFRealTimeClientEx"]/*' />
[Guid("03910848-AB16-4611-B100-17B88AE2F248")]
[NativeTypeName("struct IMFRealTimeClientEx : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFRealTimeClientEx : IMFRealTimeClientEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFRealTimeClientEx));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFRealTimeClientEx*, Guid*, void**, int>)(lpVtbl[0]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFRealTimeClientEx*, uint>)(lpVtbl[1]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFRealTimeClientEx*, uint>)(lpVtbl[2]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFRealTimeClientEx.xml' path='doc/member[@name="IMFRealTimeClientEx.RegisterThreadsEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterThreadsEx([NativeTypeName("DWORD *")] uint* pdwTaskIndex, [NativeTypeName("LPCWSTR")] ushort* wszClassName, [NativeTypeName("LONG")] int lBasePriority)
    {
        return ((delegate* unmanaged<IMFRealTimeClientEx*, uint*, ushort*, int, int>)(lpVtbl[3]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this), pdwTaskIndex, wszClassName, lBasePriority);
    }

    /// <include file='IMFRealTimeClientEx.xml' path='doc/member[@name="IMFRealTimeClientEx.UnregisterThreads"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnregisterThreads()
    {
        return ((delegate* unmanaged<IMFRealTimeClientEx*, int>)(lpVtbl[4]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFRealTimeClientEx.xml' path='doc/member[@name="IMFRealTimeClientEx.SetWorkQueueEx"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetWorkQueueEx([NativeTypeName("DWORD")] uint dwMultithreadedWorkQueueId, [NativeTypeName("LONG")] int lWorkItemBasePriority)
    {
        return ((delegate* unmanaged<IMFRealTimeClientEx*, uint, int, int>)(lpVtbl[5]))((IMFRealTimeClientEx*)Unsafe.AsPointer(ref this), dwMultithreadedWorkQueueId, lWorkItemBasePriority);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterThreadsEx([NativeTypeName("DWORD *")] uint* pdwTaskIndex, [NativeTypeName("LPCWSTR")] ushort* wszClassName, [NativeTypeName("LONG")] int lBasePriority);

        [VtblIndex(4)]
        HRESULT UnregisterThreads();

        [VtblIndex(5)]
        HRESULT SetWorkQueueEx([NativeTypeName("DWORD")] uint dwMultithreadedWorkQueueId, [NativeTypeName("LONG")] int lWorkItemBasePriority);
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

        [NativeTypeName("HRESULT (DWORD *, LPCWSTR, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort*, int, int> RegisterThreadsEx;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnregisterThreads;

        [NativeTypeName("HRESULT (DWORD, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, int> SetWorkQueueEx;
    }
}
