// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IMediaFilter.xml' path='doc/member[@name="IMediaFilter"]/*'/>
[Guid("56A86899-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IMediaFilter : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IMediaFilter : IMediaFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFilter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaFilter*, Guid*, void**, int> )(lpVtbl[0]))((IMediaFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMediaFilter*, uint> )(lpVtbl[1]))((IMediaFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaFilter*, uint> )(lpVtbl[2]))((IMediaFilter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPersist.GetClassID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IMediaFilter*, Guid*, int> )(lpVtbl[3]))((IMediaFilter*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <include file='IMediaFilter.xml' path='doc/member[@name="IMediaFilter.Stop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IMediaFilter*, int> )(lpVtbl[4]))((IMediaFilter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaFilter.xml' path='doc/member[@name="IMediaFilter.Pause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IMediaFilter*, int> )(lpVtbl[5]))((IMediaFilter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMediaFilter.xml' path='doc/member[@name="IMediaFilter.Run"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Run([NativeTypeName("REFERENCE_TIME")] long tStart)
    {
        return ((delegate* unmanaged<IMediaFilter*, long, int> )(lpVtbl[6]))((IMediaFilter*)Unsafe.AsPointer(ref this), tStart);
    }

    /// <include file='IMediaFilter.xml' path='doc/member[@name="IMediaFilter.GetState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetState([NativeTypeName("DWORD")] uint dwMilliSecsTimeout, FILTER_STATE* State)
    {
        return ((delegate* unmanaged<IMediaFilter*, uint, FILTER_STATE*, int> )(lpVtbl[7]))((IMediaFilter*)Unsafe.AsPointer(ref this), dwMilliSecsTimeout, State);
    }

    /// <include file='IMediaFilter.xml' path='doc/member[@name="IMediaFilter.SetSyncSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetSyncSource(IReferenceClock* pClock)
    {
        return ((delegate* unmanaged<IMediaFilter*, IReferenceClock*, int> )(lpVtbl[8]))((IMediaFilter*)Unsafe.AsPointer(ref this), pClock);
    }

    /// <include file='IMediaFilter.xml' path='doc/member[@name="IMediaFilter.GetSyncSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetSyncSource(IReferenceClock** pClock)
    {
        return ((delegate* unmanaged<IMediaFilter*, IReferenceClock**, int> )(lpVtbl[9]))((IMediaFilter*)Unsafe.AsPointer(ref this), pClock);
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
        HRESULT SetSyncSource(IReferenceClock* pClock);
        [VtblIndex(9)]
        HRESULT GetSyncSource(IReferenceClock** pClock);
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
        public delegate* unmanaged<TSelf*, IReferenceClock*, int> SetSyncSource;
        [NativeTypeName("HRESULT (IReferenceClock **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IReferenceClock**, int> GetSyncSource;
    }
}