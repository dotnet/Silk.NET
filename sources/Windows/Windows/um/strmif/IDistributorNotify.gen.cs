// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDistributorNotify.xml' path='doc/member[@name="IDistributorNotify"]/*'/>
[Guid("56A868AF-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IDistributorNotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDistributorNotify : IDistributorNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDistributorNotify));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDistributorNotify*, Guid*, void**, int> )(lpVtbl[0]))((IDistributorNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDistributorNotify*, uint> )(lpVtbl[1]))((IDistributorNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDistributorNotify*, uint> )(lpVtbl[2]))((IDistributorNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDistributorNotify.xml' path='doc/member[@name="IDistributorNotify.Stop"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IDistributorNotify*, int> )(lpVtbl[3]))((IDistributorNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDistributorNotify.xml' path='doc/member[@name="IDistributorNotify.Pause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IDistributorNotify*, int> )(lpVtbl[4]))((IDistributorNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDistributorNotify.xml' path='doc/member[@name="IDistributorNotify.Run"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Run([NativeTypeName("REFERENCE_TIME")] long tStart)
    {
        return ((delegate* unmanaged<IDistributorNotify*, long, int> )(lpVtbl[5]))((IDistributorNotify*)Unsafe.AsPointer(ref this), tStart);
    }

    /// <include file='IDistributorNotify.xml' path='doc/member[@name="IDistributorNotify.SetSyncSource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetSyncSource(IReferenceClock* pClock)
    {
        return ((delegate* unmanaged<IDistributorNotify*, IReferenceClock*, int> )(lpVtbl[6]))((IDistributorNotify*)Unsafe.AsPointer(ref this), pClock);
    }

    /// <include file='IDistributorNotify.xml' path='doc/member[@name="IDistributorNotify.NotifyGraphChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT NotifyGraphChange()
    {
        return ((delegate* unmanaged<IDistributorNotify*, int> )(lpVtbl[7]))((IDistributorNotify*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Stop();
        [VtblIndex(4)]
        HRESULT Pause();
        [VtblIndex(5)]
        HRESULT Run([NativeTypeName("REFERENCE_TIME")] long tStart);
        [VtblIndex(6)]
        HRESULT SetSyncSource(IReferenceClock* pClock);
        [VtblIndex(7)]
        HRESULT NotifyGraphChange();
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;
        [NativeTypeName("HRESULT (REFERENCE_TIME) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long, int> Run;
        [NativeTypeName("HRESULT (IReferenceClock *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IReferenceClock*, int> SetSyncSource;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> NotifyGraphChange;
    }
}