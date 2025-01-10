// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A8689A-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMediaSample : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMediaSample : IMediaSample.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaSample));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaSample, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaSample, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaSample, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPointer(byte** ppBuffer)
    {
        return ((delegate* unmanaged<IMediaSample, byte**, int>)((*lpVtbl)[3]))(this, ppBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("long")]
    public int GetSize()
    {
        return ((delegate* unmanaged<IMediaSample, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTime(
        [NativeTypeName("REFERENCE_TIME *")] long* pTimeStart,
        [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd
    )
    {
        return ((delegate* unmanaged<IMediaSample, long*, long*, int>)((*lpVtbl)[5]))(
            this,
            pTimeStart,
            pTimeEnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTime(
        [NativeTypeName("REFERENCE_TIME *")] long* pTimeStart,
        [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd
    )
    {
        return ((delegate* unmanaged<IMediaSample, long*, long*, int>)((*lpVtbl)[6]))(
            this,
            pTimeStart,
            pTimeEnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsSyncPoint()
    {
        return ((delegate* unmanaged<IMediaSample, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSyncPoint(BOOL bIsSyncPoint)
    {
        return ((delegate* unmanaged<IMediaSample, BOOL, int>)((*lpVtbl)[8]))(this, bIsSyncPoint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsPreroll()
    {
        return ((delegate* unmanaged<IMediaSample, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPreroll(BOOL bIsPreroll)
    {
        return ((delegate* unmanaged<IMediaSample, BOOL, int>)((*lpVtbl)[10]))(this, bIsPreroll);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("long")]
    public int GetActualDataLength()
    {
        return ((delegate* unmanaged<IMediaSample, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetActualDataLength([NativeTypeName("long")] int __MIDL__IMediaSample0000)
    {
        return ((delegate* unmanaged<IMediaSample, int, int>)((*lpVtbl)[12]))(
            this,
            __MIDL__IMediaSample0000
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMediaType(AM_MEDIA_TYPE** ppMediaType)
    {
        return ((delegate* unmanaged<IMediaSample, AM_MEDIA_TYPE**, int>)((*lpVtbl)[13]))(
            this,
            ppMediaType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetMediaType(AM_MEDIA_TYPE* pMediaType)
    {
        return ((delegate* unmanaged<IMediaSample, AM_MEDIA_TYPE*, int>)((*lpVtbl)[14]))(
            this,
            pMediaType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsDiscontinuity()
    {
        return ((delegate* unmanaged<IMediaSample, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetDiscontinuity(BOOL bDiscontinuity)
    {
        return ((delegate* unmanaged<IMediaSample, BOOL, int>)((*lpVtbl)[16]))(
            this,
            bDiscontinuity
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetMediaTime(
        [NativeTypeName("LONGLONG *")] long* pTimeStart,
        [NativeTypeName("LONGLONG *")] long* pTimeEnd
    )
    {
        return ((delegate* unmanaged<IMediaSample, long*, long*, int>)((*lpVtbl)[17]))(
            this,
            pTimeStart,
            pTimeEnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetMediaTime(
        [NativeTypeName("LONGLONG *")] long* pTimeStart,
        [NativeTypeName("LONGLONG *")] long* pTimeEnd
    )
    {
        return ((delegate* unmanaged<IMediaSample, long*, long*, int>)((*lpVtbl)[18]))(
            this,
            pTimeStart,
            pTimeEnd
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPointer(byte** ppBuffer);

        [VtblIndex(4)]
        [return: NativeTypeName("long")]
        int GetSize();

        [VtblIndex(5)]
        HRESULT GetTime(
            [NativeTypeName("REFERENCE_TIME *")] long* pTimeStart,
            [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd
        );

        [VtblIndex(6)]
        HRESULT SetTime(
            [NativeTypeName("REFERENCE_TIME *")] long* pTimeStart,
            [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd
        );

        [VtblIndex(7)]
        HRESULT IsSyncPoint();

        [VtblIndex(8)]
        HRESULT SetSyncPoint(BOOL bIsSyncPoint);

        [VtblIndex(9)]
        HRESULT IsPreroll();

        [VtblIndex(10)]
        HRESULT SetPreroll(BOOL bIsPreroll);

        [VtblIndex(11)]
        [return: NativeTypeName("long")]
        int GetActualDataLength();

        [VtblIndex(12)]
        HRESULT SetActualDataLength([NativeTypeName("long")] int __MIDL__IMediaSample0000);

        [VtblIndex(13)]
        HRESULT GetMediaType(AM_MEDIA_TYPE** ppMediaType);

        [VtblIndex(14)]
        HRESULT SetMediaType(AM_MEDIA_TYPE* pMediaType);

        [VtblIndex(15)]
        HRESULT IsDiscontinuity();

        [VtblIndex(16)]
        HRESULT SetDiscontinuity(BOOL bDiscontinuity);

        [VtblIndex(17)]
        HRESULT GetMediaTime(
            [NativeTypeName("LONGLONG *")] long* pTimeStart,
            [NativeTypeName("LONGLONG *")] long* pTimeEnd
        );

        [VtblIndex(18)]
        HRESULT SetMediaTime(
            [NativeTypeName("LONGLONG *")] long* pTimeStart,
            [NativeTypeName("LONGLONG *")] long* pTimeEnd
        );
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

        [NativeTypeName("HRESULT (BYTE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, int> GetPointer;

        [NativeTypeName("long () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetSize;

        [NativeTypeName("HRESULT (REFERENCE_TIME *, REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, long*, int> GetTime;

        [NativeTypeName("HRESULT (REFERENCE_TIME *, REFERENCE_TIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, long*, int> SetTime;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsSyncPoint;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetSyncPoint;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsPreroll;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetPreroll;

        [NativeTypeName("long () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetActualDataLength;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetActualDataLength;

        [NativeTypeName("HRESULT (AM_MEDIA_TYPE **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AM_MEDIA_TYPE**, int> GetMediaType;

        [NativeTypeName("HRESULT (AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, AM_MEDIA_TYPE*, int> SetMediaType;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDiscontinuity;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetDiscontinuity;

        [NativeTypeName("HRESULT (LONGLONG *, LONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, long*, int> GetMediaTime;

        [NativeTypeName("HRESULT (LONGLONG *, LONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, long*, int> SetMediaTime;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaSample"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaSample(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaSample"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaSample(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaSample(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaSample"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaSample"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaSample value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
