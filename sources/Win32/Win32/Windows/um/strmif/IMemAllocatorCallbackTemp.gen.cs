// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("379A0CF0-C1DE-11D2-ABF5-00A0C905F375")]
[NativeTypeName("struct IMemAllocatorCallbackTemp : IMemAllocator")]
[NativeInheritance("IMemAllocator")]
public unsafe partial struct IMemAllocatorCallbackTemp
    : IMemAllocatorCallbackTemp.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMemAllocatorCallbackTemp));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMemAllocatorCallbackTemp, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMemAllocatorCallbackTemp, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMemAllocatorCallbackTemp, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetProperties(ALLOCATOR_PROPERTIES* pRequest, ALLOCATOR_PROPERTIES* pActual)
    {
        return (
            (delegate* unmanaged<
                IMemAllocatorCallbackTemp,
                ALLOCATOR_PROPERTIES*,
                ALLOCATOR_PROPERTIES*,
                int>)((*lpVtbl)[3])
        )(this, pRequest, pActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperties(ALLOCATOR_PROPERTIES* pProps)
    {
        return (
            (delegate* unmanaged<IMemAllocatorCallbackTemp, ALLOCATOR_PROPERTIES*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pProps);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IMemAllocatorCallbackTemp, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Decommit()
    {
        return ((delegate* unmanaged<IMemAllocatorCallbackTemp, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetBuffer(
        IMediaSample* ppBuffer,
        [NativeTypeName("REFERENCE_TIME *")] long* pStartTime,
        [NativeTypeName("REFERENCE_TIME *")] long* pEndTime,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<
                IMemAllocatorCallbackTemp,
                IMediaSample*,
                long*,
                long*,
                uint,
                int>)((*lpVtbl)[7])
        )(this, ppBuffer, pStartTime, pEndTime, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReleaseBuffer(IMediaSample pBuffer)
    {
        return ((delegate* unmanaged<IMemAllocatorCallbackTemp, IMediaSample, int>)((*lpVtbl)[8]))(
            this,
            pBuffer
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetNotify(IMemAllocatorNotifyCallbackTemp pNotify)
    {
        return (
            (delegate* unmanaged<IMemAllocatorCallbackTemp, IMemAllocatorNotifyCallbackTemp, int>)(
                (*lpVtbl)[9]
            )
        )(this, pNotify);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetFreeCount([NativeTypeName("LONG *")] int* plBuffersFree)
    {
        return ((delegate* unmanaged<IMemAllocatorCallbackTemp, int*, int>)((*lpVtbl)[10]))(
            this,
            plBuffersFree
        );
    }

    public interface Interface : IMemAllocator.Interface
    {
        [VtblIndex(9)]
        HRESULT SetNotify(IMemAllocatorNotifyCallbackTemp pNotify);

        [VtblIndex(10)]
        HRESULT GetFreeCount([NativeTypeName("LONG *")] int* plBuffersFree);
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

        [NativeTypeName(
            "HRESULT (ALLOCATOR_PROPERTIES *, ALLOCATOR_PROPERTIES *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ALLOCATOR_PROPERTIES*,
            ALLOCATOR_PROPERTIES*,
            int> SetProperties;

        [NativeTypeName("HRESULT (ALLOCATOR_PROPERTIES *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ALLOCATOR_PROPERTIES*, int> GetProperties;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Commit;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Decommit;

        [NativeTypeName(
            "HRESULT (IMediaSample **, REFERENCE_TIME *, REFERENCE_TIME *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMediaSample*, long*, long*, uint, int> GetBuffer;

        [NativeTypeName("HRESULT (IMediaSample *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMediaSample, int> ReleaseBuffer;

        [NativeTypeName("HRESULT (IMemAllocatorNotifyCallbackTemp *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMemAllocatorNotifyCallbackTemp, int> SetNotify;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetFreeCount;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMemAllocatorCallbackTemp"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMemAllocatorCallbackTemp(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMemAllocator"/> to <see cref = "IMemAllocatorCallbackTemp"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMemAllocator"/> instance to be converted </param>
    public static explicit operator IMemAllocatorCallbackTemp(Silk.NET.Windows.IMemAllocator value)
    {
        return new IMemAllocatorCallbackTemp(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMemAllocatorCallbackTemp"/> to <see cref = "Silk.NET.Windows.IMemAllocator"/>.</summary>
    /// <param name = "value">The <see cref = "IMemAllocatorCallbackTemp"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMemAllocator(IMemAllocatorCallbackTemp value)
    {
        return new Silk.NET.Windows.IMemAllocator(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMemAllocatorCallbackTemp"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMemAllocatorCallbackTemp(Silk.NET.Windows.IUnknown value)
    {
        return new IMemAllocatorCallbackTemp(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMemAllocatorCallbackTemp"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMemAllocatorCallbackTemp"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMemAllocatorCallbackTemp value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
