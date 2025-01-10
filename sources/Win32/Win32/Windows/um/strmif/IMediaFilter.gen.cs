// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A86899-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMediaFilter : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IMediaFilter : IMediaFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFilter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaFilter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaFilter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaFilter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IMediaFilter, Guid*, int>)((*lpVtbl)[3]))(this, pClassID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMediaFilter, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMediaFilter, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Run([NativeTypeName("REFERENCE_TIME")] long tStart)
    {
        return ((delegate* unmanaged<IMediaFilter, long, int>)((*lpVtbl)[6]))(this, tStart);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetState([NativeTypeName("DWORD")] uint dwMilliSecsTimeout, FILTER_STATE* State)
    {
        return ((delegate* unmanaged<IMediaFilter, uint, FILTER_STATE*, int>)((*lpVtbl)[7]))(
            this,
            dwMilliSecsTimeout,
            State
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSyncSource(IReferenceClock pClock)
    {
        return ((delegate* unmanaged<IMediaFilter, IReferenceClock, int>)((*lpVtbl)[8]))(
            this,
            pClock
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSyncSource(IReferenceClock* pClock)
    {
        return ((delegate* unmanaged<IMediaFilter, IReferenceClock*, int>)((*lpVtbl)[9]))(
            this,
            pClock
        );
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT Stop();

        [VtblIndex(5)]
        HRESULT Pause();

        [VtblIndex(6)]
        HRESULT Run([NativeTypeName("REFERENCE_TIME")] long tStart);

        [VtblIndex(7)]
        HRESULT GetState([NativeTypeName("DWORD")] uint dwMilliSecsTimeout, FILTER_STATE* State);

        [VtblIndex(8)]
        HRESULT SetSyncSource(IReferenceClock pClock);

        [VtblIndex(9)]
        HRESULT GetSyncSource(IReferenceClock* pClock);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaFilter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaFilter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersist"/> to <see cref = "IMediaFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersist"/> instance to be converted </param>
    public static explicit operator IMediaFilter(Silk.NET.Windows.IPersist value)
    {
        return new IMediaFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaFilter"/> to <see cref = "Silk.NET.Windows.IPersist"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersist(IMediaFilter value)
    {
        return new Silk.NET.Windows.IPersist(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaFilter(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaFilter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaFilter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
