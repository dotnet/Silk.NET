// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A8689C-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMemAllocator : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMemAllocator : IMemAllocator.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMemAllocator));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMemAllocator, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMemAllocator, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMemAllocator, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetProperties(ALLOCATOR_PROPERTIES* pRequest, ALLOCATOR_PROPERTIES* pActual)
    {
        return (
            (delegate* unmanaged<IMemAllocator, ALLOCATOR_PROPERTIES*, ALLOCATOR_PROPERTIES*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pRequest, pActual);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProperties(ALLOCATOR_PROPERTIES* pProps)
    {
        return ((delegate* unmanaged<IMemAllocator, ALLOCATOR_PROPERTIES*, int>)((*lpVtbl)[4]))(
            this,
            pProps
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IMemAllocator, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Decommit()
    {
        return ((delegate* unmanaged<IMemAllocator, int>)((*lpVtbl)[6]))(this);
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
            (delegate* unmanaged<IMemAllocator, IMediaSample*, long*, long*, uint, int>)(
                (*lpVtbl)[7]
            )
        )(this, ppBuffer, pStartTime, pEndTime, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ReleaseBuffer(IMediaSample pBuffer)
    {
        return ((delegate* unmanaged<IMemAllocator, IMediaSample, int>)((*lpVtbl)[8]))(
            this,
            pBuffer
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetProperties(ALLOCATOR_PROPERTIES* pRequest, ALLOCATOR_PROPERTIES* pActual);

        [VtblIndex(4)]
        HRESULT GetProperties(ALLOCATOR_PROPERTIES* pProps);

        [VtblIndex(5)]
        HRESULT Commit();

        [VtblIndex(6)]
        HRESULT Decommit();

        [VtblIndex(7)]
        HRESULT GetBuffer(
            IMediaSample* ppBuffer,
            [NativeTypeName("REFERENCE_TIME *")] long* pStartTime,
            [NativeTypeName("REFERENCE_TIME *")] long* pEndTime,
            [NativeTypeName("DWORD")] uint dwFlags
        );

        [VtblIndex(8)]
        HRESULT ReleaseBuffer(IMediaSample pBuffer);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IMemAllocator"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMemAllocator(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMemAllocator"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMemAllocator(Silk.NET.Windows.IUnknown value)
    {
        return new IMemAllocator(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMemAllocator"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMemAllocator"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMemAllocator value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
