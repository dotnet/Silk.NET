// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("36B73884-C2C8-11CF-8B46-00805F6CEF60")]
[NativeTypeName("struct IMediaSample2 : IMediaSample")]
[NativeInheritance("IMediaSample")]
public unsafe partial struct IMediaSample2 : IMediaSample2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaSample2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaSample2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaSample2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaSample2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPointer(byte** ppBuffer)
    {
        return ((delegate* unmanaged<IMediaSample2, byte**, int>)((*lpVtbl)[3]))(this, ppBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("long")]
    public int GetSize()
    {
        return ((delegate* unmanaged<IMediaSample2, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTime(
        [NativeTypeName("REFERENCE_TIME *")] long* pTimeStart,
        [NativeTypeName("REFERENCE_TIME *")] long* pTimeEnd
    )
    {
        return ((delegate* unmanaged<IMediaSample2, long*, long*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IMediaSample2, long*, long*, int>)((*lpVtbl)[6]))(
            this,
            pTimeStart,
            pTimeEnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsSyncPoint()
    {
        return ((delegate* unmanaged<IMediaSample2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSyncPoint(BOOL bIsSyncPoint)
    {
        return ((delegate* unmanaged<IMediaSample2, BOOL, int>)((*lpVtbl)[8]))(this, bIsSyncPoint);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT IsPreroll()
    {
        return ((delegate* unmanaged<IMediaSample2, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetPreroll(BOOL bIsPreroll)
    {
        return ((delegate* unmanaged<IMediaSample2, BOOL, int>)((*lpVtbl)[10]))(this, bIsPreroll);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [return: NativeTypeName("long")]
    public int GetActualDataLength()
    {
        return ((delegate* unmanaged<IMediaSample2, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetActualDataLength([NativeTypeName("long")] int __MIDL__IMediaSample0000)
    {
        return ((delegate* unmanaged<IMediaSample2, int, int>)((*lpVtbl)[12]))(
            this,
            __MIDL__IMediaSample0000
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetMediaType(AM_MEDIA_TYPE** ppMediaType)
    {
        return ((delegate* unmanaged<IMediaSample2, AM_MEDIA_TYPE**, int>)((*lpVtbl)[13]))(
            this,
            ppMediaType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetMediaType(AM_MEDIA_TYPE* pMediaType)
    {
        return ((delegate* unmanaged<IMediaSample2, AM_MEDIA_TYPE*, int>)((*lpVtbl)[14]))(
            this,
            pMediaType
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT IsDiscontinuity()
    {
        return ((delegate* unmanaged<IMediaSample2, int>)((*lpVtbl)[15]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetDiscontinuity(BOOL bDiscontinuity)
    {
        return ((delegate* unmanaged<IMediaSample2, BOOL, int>)((*lpVtbl)[16]))(
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
        return ((delegate* unmanaged<IMediaSample2, long*, long*, int>)((*lpVtbl)[17]))(
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
        return ((delegate* unmanaged<IMediaSample2, long*, long*, int>)((*lpVtbl)[18]))(
            this,
            pTimeStart,
            pTimeEnd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT GetProperties([NativeTypeName("DWORD")] uint cbProperties, byte* pbProperties)
    {
        return ((delegate* unmanaged<IMediaSample2, uint, byte*, int>)((*lpVtbl)[19]))(
            this,
            cbProperties,
            pbProperties
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetProperties(
        [NativeTypeName("DWORD")] uint cbProperties,
        [NativeTypeName("const BYTE *")] byte* pbProperties
    )
    {
        return ((delegate* unmanaged<IMediaSample2, uint, byte*, int>)((*lpVtbl)[20]))(
            this,
            cbProperties,
            pbProperties
        );
    }

    public interface Interface : IMediaSample.Interface
    {
        [VtblIndex(19)]
        HRESULT GetProperties([NativeTypeName("DWORD")] uint cbProperties, byte* pbProperties);

        [VtblIndex(20)]
        HRESULT SetProperties(
            [NativeTypeName("DWORD")] uint cbProperties,
            [NativeTypeName("const BYTE *")] byte* pbProperties
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

        [NativeTypeName("HRESULT (DWORD, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> GetProperties;

        [NativeTypeName("HRESULT (DWORD, const BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, byte*, int> SetProperties;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaSample2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaSample2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMediaSample"/> to <see cref = "IMediaSample2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMediaSample"/> instance to be converted </param>
    public static explicit operator IMediaSample2(Silk.NET.Windows.IMediaSample value)
    {
        return new IMediaSample2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaSample2"/> to <see cref = "Silk.NET.Windows.IMediaSample"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaSample2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMediaSample(IMediaSample2 value)
    {
        return new Silk.NET.Windows.IMediaSample(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaSample2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaSample2(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaSample2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaSample2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaSample2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaSample2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
