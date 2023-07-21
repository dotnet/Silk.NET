// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample"]/*' />
[Guid("56A8689A-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMediaSample : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMediaSample : IMediaSample.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaSample));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaSample*, Guid*, void**, int>)(lpVtbl[0]))((IMediaSample*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaSample*, uint>)(lpVtbl[1]))((IMediaSample*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaSample*, uint>)(lpVtbl[2]))((IMediaSample*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.GetPointer"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPointer(byte** ppBuffer)
    {
        return ((delegate* unmanaged<IMediaSample*, byte**, int>)(lpVtbl[3]))((IMediaSample*)Unsafe.AsPointer(ref this), ppBuffer);
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.GetSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("long")]
    public int GetSize()
    {
        return ((delegate* unmanaged<IMediaSample*, int>)(lpVtbl[4]))((IMediaSample*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.GetTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
    {
        return ((delegate* unmanaged<IMediaSample*, long*, long*, int>)(lpVtbl[5]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.SetTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
    {
        return ((delegate* unmanaged<IMediaSample*, long*, long*, int>)(lpVtbl[6]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.IsSyncPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsSyncPoint()
    {
        return ((delegate* unmanaged<IMediaSample*, int>)(lpVtbl[7]))((IMediaSample*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.SetSyncPoint"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSyncPoint(BOOL bIsSyncPoint)
    {
        return ((delegate* unmanaged<IMediaSample*, BOOL, int>)(lpVtbl[8]))((IMediaSample*)Unsafe.AsPointer(ref this), bIsSyncPoint);
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.IsPreroll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsPreroll()
    {
        return ((delegate* unmanaged<IMediaSample*, int>)(lpVtbl[9]))((IMediaSample*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.SetPreroll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPreroll(BOOL bIsPreroll)
    {
        return ((delegate* unmanaged<IMediaSample*, BOOL, int>)(lpVtbl[10]))((IMediaSample*)Unsafe.AsPointer(ref this), bIsPreroll);
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.GetActualDataLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("long")]
    public int GetActualDataLength()
    {
        return ((delegate* unmanaged<IMediaSample*, int>)(lpVtbl[11]))((IMediaSample*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.SetActualDataLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetActualDataLength([NativeTypeName("long")] int __MIDL__IMediaSample0000)
    {
        return ((delegate* unmanaged<IMediaSample*, int, int>)(lpVtbl[12]))((IMediaSample*)Unsafe.AsPointer(ref this), __MIDL__IMediaSample0000);
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.GetMediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMediaType(AM_MEDIA_TYPE** ppMediaType)
    {
        return ((delegate* unmanaged<IMediaSample*, AM_MEDIA_TYPE**, int>)(lpVtbl[13]))((IMediaSample*)Unsafe.AsPointer(ref this), ppMediaType);
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.SetMediaType"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetMediaType(AM_MEDIA_TYPE* pMediaType)
    {
        return ((delegate* unmanaged<IMediaSample*, AM_MEDIA_TYPE*, int>)(lpVtbl[14]))((IMediaSample*)Unsafe.AsPointer(ref this), pMediaType);
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.IsDiscontinuity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsDiscontinuity()
    {
        return ((delegate* unmanaged<IMediaSample*, int>)(lpVtbl[15]))((IMediaSample*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.SetDiscontinuity"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetDiscontinuity(BOOL bDiscontinuity)
    {
        return ((delegate* unmanaged<IMediaSample*, BOOL, int>)(lpVtbl[16]))((IMediaSample*)Unsafe.AsPointer(ref this), bDiscontinuity);
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.GetMediaTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
    {
        return ((delegate* unmanaged<IMediaSample*, long*, long*, int>)(lpVtbl[17]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
    }

    /// <include file='IMediaSample.xml' path='doc/member[@name="IMediaSample.SetMediaTime"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
    {
        return ((delegate* unmanaged<IMediaSample*, long*, long*, int>)(lpVtbl[18]))((IMediaSample*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPointer(byte** ppBuffer);

        [VtblIndex(4)]
        [return: NativeTypeName("long")]
        int GetSize();

        [VtblIndex(5)]
        HRESULT GetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd);

        [VtblIndex(6)]
        HRESULT SetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd);

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
        HRESULT GetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd);

        [VtblIndex(18)]
        HRESULT SetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd);
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
}
