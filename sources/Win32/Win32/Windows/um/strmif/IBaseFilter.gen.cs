// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A86895-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IBaseFilter : IMediaFilter")]
[NativeInheritance("IMediaFilter")]
public unsafe partial struct IBaseFilter : IBaseFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBaseFilter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBaseFilter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IBaseFilter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBaseFilter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IBaseFilter, Guid*, int>)((*lpVtbl)[3]))(this, pClassID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IBaseFilter, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IBaseFilter, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Run([NativeTypeName("REFERENCE_TIME")] long tStart)
    {
        return ((delegate* unmanaged<IBaseFilter, long, int>)((*lpVtbl)[6]))(this, tStart);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetState([NativeTypeName("DWORD")] uint dwMilliSecsTimeout, FILTER_STATE* State)
    {
        return ((delegate* unmanaged<IBaseFilter, uint, FILTER_STATE*, int>)((*lpVtbl)[7]))(
            this,
            dwMilliSecsTimeout,
            State
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSyncSource(IReferenceClock pClock)
    {
        return ((delegate* unmanaged<IBaseFilter, IReferenceClock, int>)((*lpVtbl)[8]))(
            this,
            pClock
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSyncSource(IReferenceClock* pClock)
    {
        return ((delegate* unmanaged<IBaseFilter, IReferenceClock*, int>)((*lpVtbl)[9]))(
            this,
            pClock
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT EnumPins(IEnumPins* ppEnum)
    {
        return ((delegate* unmanaged<IBaseFilter, IEnumPins*, int>)((*lpVtbl)[10]))(this, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT FindPin([NativeTypeName("LPCWSTR")] ushort* Id, IPin* ppPin)
    {
        return ((delegate* unmanaged<IBaseFilter, ushort*, IPin*, int>)((*lpVtbl)[11]))(
            this,
            Id,
            ppPin
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT QueryFilterInfo(FILTER_INFO* pInfo)
    {
        return ((delegate* unmanaged<IBaseFilter, FILTER_INFO*, int>)((*lpVtbl)[12]))(this, pInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT JoinFilterGraph(IFilterGraph pGraph, [NativeTypeName("LPCWSTR")] ushort* pName)
    {
        return ((delegate* unmanaged<IBaseFilter, IFilterGraph, ushort*, int>)((*lpVtbl)[13]))(
            this,
            pGraph,
            pName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT QueryVendorInfo([NativeTypeName("LPWSTR *")] ushort** pVendorInfo)
    {
        return ((delegate* unmanaged<IBaseFilter, ushort**, int>)((*lpVtbl)[14]))(
            this,
            pVendorInfo
        );
    }

    public interface Interface : IMediaFilter.Interface
    {
        [VtblIndex(10)]
        HRESULT EnumPins(IEnumPins* ppEnum);

        [VtblIndex(11)]
        HRESULT FindPin([NativeTypeName("LPCWSTR")] ushort* Id, IPin* ppPin);

        [VtblIndex(12)]
        HRESULT QueryFilterInfo(FILTER_INFO* pInfo);

        [VtblIndex(13)]
        HRESULT JoinFilterGraph(IFilterGraph pGraph, [NativeTypeName("LPCWSTR")] ushort* pName);

        [VtblIndex(14)]
        HRESULT QueryVendorInfo([NativeTypeName("LPWSTR *")] ushort** pVendorInfo);
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

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClassID;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;

        [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> Run;

        [NativeTypeName("HRESULT (DWORD, FILTER_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, FILTER_STATE*, int> GetState;

        [NativeTypeName("HRESULT (IReferenceClock *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IReferenceClock, int> SetSyncSource;

        [NativeTypeName("HRESULT (IReferenceClock **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IReferenceClock*, int> GetSyncSource;

        [NativeTypeName("HRESULT (IEnumPins **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumPins*, int> EnumPins;

        [NativeTypeName("HRESULT (LPCWSTR, IPin **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IPin*, int> FindPin;

        [NativeTypeName("HRESULT (FILTER_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILTER_INFO*, int> QueryFilterInfo;

        [NativeTypeName("HRESULT (IFilterGraph *, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFilterGraph, ushort*, int> JoinFilterGraph;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> QueryVendorInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBaseFilter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBaseFilter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IMediaFilter"/> to <see cref = "IBaseFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IMediaFilter"/> instance to be converted </param>
    public static explicit operator IBaseFilter(Silk.NET.Windows.IMediaFilter value)
    {
        return new IBaseFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBaseFilter"/> to <see cref = "Silk.NET.Windows.IMediaFilter"/>.</summary>
    /// <param name = "value">The <see cref = "IBaseFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IMediaFilter(IBaseFilter value)
    {
        return new Silk.NET.Windows.IMediaFilter(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersist"/> to <see cref = "IBaseFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersist"/> instance to be converted </param>
    public static explicit operator IBaseFilter(Silk.NET.Windows.IPersist value)
    {
        return new IBaseFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBaseFilter"/> to <see cref = "Silk.NET.Windows.IPersist"/>.</summary>
    /// <param name = "value">The <see cref = "IBaseFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersist(IBaseFilter value)
    {
        return new Silk.NET.Windows.IPersist(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBaseFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBaseFilter(Silk.NET.Windows.IUnknown value)
    {
        return new IBaseFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBaseFilter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBaseFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBaseFilter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
