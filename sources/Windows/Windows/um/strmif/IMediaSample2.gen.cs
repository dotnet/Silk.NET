// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMediaSample2.xml' path='doc/member[@name="IMediaSample2"]/*'/>
[Guid("36B73884-C2C8-11CF-8B46-00805F6CEF60")]
[NativeTypeName("struct IMediaSample2 : IMediaSample")]
[NativeInheritance("IMediaSample")]
public unsafe partial struct IMediaSample2 : IMediaSample2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaSample2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaSample2*, Guid*, void**, int> )(lpVtbl[0]))((IMediaSample2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaSample2*, uint> )(lpVtbl[1]))((IMediaSample2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaSample2*, uint> )(lpVtbl[2]))((IMediaSample2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMediaSample.GetPointer"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPointer(byte** ppBuffer)
    {
        return ((delegate* unmanaged<IMediaSample2*, byte**, int> )(lpVtbl[3]))((IMediaSample2*)Unsafe.AsPointer(ref this), ppBuffer);
    }

    /// <inheritdoc cref = "IMediaSample.GetSize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("long")]
    public int GetSize()
    {
        return ((delegate* unmanaged<IMediaSample2*, int> )(lpVtbl[4]))((IMediaSample2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMediaSample.GetTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
    {
        return ((delegate* unmanaged<IMediaSample2*, long*, long*, int> )(lpVtbl[5]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
    }

    /// <inheritdoc cref = "IMediaSample.SetTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTime([NativeTypeName("REFERENCE_TIME *")] long* pTimeStart, [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd)
    {
        return ((delegate* unmanaged<IMediaSample2*, long*, long*, int> )(lpVtbl[6]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
    }

    /// <inheritdoc cref = "IMediaSample.IsSyncPoint"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsSyncPoint()
    {
        return ((delegate* unmanaged<IMediaSample2*, int> )(lpVtbl[7]))((IMediaSample2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMediaSample.SetSyncPoint"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSyncPoint(BOOL bIsSyncPoint)
    {
        return ((delegate* unmanaged<IMediaSample2*, BOOL, int> )(lpVtbl[8]))((IMediaSample2*)Unsafe.AsPointer(ref this), bIsSyncPoint);
    }

    /// <inheritdoc cref = "IMediaSample.IsPreroll"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsPreroll()
    {
        return ((delegate* unmanaged<IMediaSample2*, int> )(lpVtbl[9]))((IMediaSample2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMediaSample.SetPreroll"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPreroll(BOOL bIsPreroll)
    {
        return ((delegate* unmanaged<IMediaSample2*, BOOL, int> )(lpVtbl[10]))((IMediaSample2*)Unsafe.AsPointer(ref this), bIsPreroll);
    }

    /// <inheritdoc cref = "IMediaSample.GetActualDataLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("long")]
    public int GetActualDataLength()
    {
        return ((delegate* unmanaged<IMediaSample2*, int> )(lpVtbl[11]))((IMediaSample2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMediaSample.SetActualDataLength"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetActualDataLength([NativeTypeName("long")] int __MIDL__IMediaSample0000)
    {
        return ((delegate* unmanaged<IMediaSample2*, int, int> )(lpVtbl[12]))((IMediaSample2*)Unsafe.AsPointer(ref this), __MIDL__IMediaSample0000);
    }

    /// <inheritdoc cref = "IMediaSample.GetMediaType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMediaType(AM_MEDIA_TYPE** ppMediaType)
    {
        return ((delegate* unmanaged<IMediaSample2*, AM_MEDIA_TYPE**, int> )(lpVtbl[13]))((IMediaSample2*)Unsafe.AsPointer(ref this), ppMediaType);
    }

    /// <inheritdoc cref = "IMediaSample.SetMediaType"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetMediaType(AM_MEDIA_TYPE* pMediaType)
    {
        return ((delegate* unmanaged<IMediaSample2*, AM_MEDIA_TYPE*, int> )(lpVtbl[14]))((IMediaSample2*)Unsafe.AsPointer(ref this), pMediaType);
    }

    /// <inheritdoc cref = "IMediaSample.IsDiscontinuity"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsDiscontinuity()
    {
        return ((delegate* unmanaged<IMediaSample2*, int> )(lpVtbl[15]))((IMediaSample2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IMediaSample.SetDiscontinuity"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetDiscontinuity(BOOL bDiscontinuity)
    {
        return ((delegate* unmanaged<IMediaSample2*, BOOL, int> )(lpVtbl[16]))((IMediaSample2*)Unsafe.AsPointer(ref this), bDiscontinuity);
    }

    /// <inheritdoc cref = "IMediaSample.GetMediaTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT GetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
    {
        return ((delegate* unmanaged<IMediaSample2*, long*, long*, int> )(lpVtbl[17]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
    }

    /// <inheritdoc cref = "IMediaSample.SetMediaTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetMediaTime([NativeTypeName("LONGLONG *")] long* pTimeStart, [NativeTypeName("LONGLONG *")] long* pTimeEnd)
    {
        return ((delegate* unmanaged<IMediaSample2*, long*, long*, int> )(lpVtbl[18]))((IMediaSample2*)Unsafe.AsPointer(ref this), pTimeStart, pTimeEnd);
    }

    /// <include file='IMediaSample2.xml' path='doc/member[@name="IMediaSample2.GetProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetProperties([NativeTypeName("DWORD")] uint cbProperties, byte* pbProperties)
    {
        return ((delegate* unmanaged<IMediaSample2*, uint, byte*, int> )(lpVtbl[19]))((IMediaSample2*)Unsafe.AsPointer(ref this), cbProperties, pbProperties);
    }

    /// <include file='IMediaSample2.xml' path='doc/member[@name="IMediaSample2.SetProperties"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetProperties([NativeTypeName("DWORD")] uint cbProperties, [NativeTypeName("const BYTE *")] byte* pbProperties)
    {
        return ((delegate* unmanaged<IMediaSample2*, uint, byte*, int> )(lpVtbl[20]))((IMediaSample2*)Unsafe.AsPointer(ref this), cbProperties, pbProperties);
    }

    public interface Interface : IMediaSample.Interface
    {
        [VtblIndex(19)]
        HRESULT GetProperties([NativeTypeName("DWORD")] uint cbProperties, byte* pbProperties);
        [VtblIndex(20)]
        HRESULT SetProperties([NativeTypeName("DWORD")] uint cbProperties, [NativeTypeName("const BYTE *")] byte* pbProperties);
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
        [NativeTypeName("HRESULT (DWORD, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> GetProperties;
        [NativeTypeName("HRESULT (DWORD, const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> SetProperties;
    }
}