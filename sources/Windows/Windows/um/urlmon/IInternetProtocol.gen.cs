// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IInternetProtocol.xml' path='doc/member[@name="IInternetProtocol"]/*'/>
[Guid("79EAC9E4-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetProtocol : IInternetProtocolRoot")]
[NativeInheritance("IInternetProtocolRoot")]
public unsafe partial struct IInternetProtocol : IInternetProtocol.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocol));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IInternetProtocol*, Guid*, void**, int> )(lpVtbl[0]))((IInternetProtocol*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInternetProtocol*, uint> )(lpVtbl[1]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetProtocol*, uint> )(lpVtbl[2]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInternetProtocolRoot.Start"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Start([NativeTypeName("LPCWSTR")] ushort* szUrl, IInternetProtocolSink* pOIProtSink, IInternetBindInfo* pOIBindInfo, [NativeTypeName("DWORD")] uint grfPI, HANDLE_PTR dwReserved)
    {
        return ((delegate* unmanaged<IInternetProtocol*, ushort*, IInternetProtocolSink*, IInternetBindInfo*, uint, HANDLE_PTR, int> )(lpVtbl[3]))((IInternetProtocol*)Unsafe.AsPointer(ref this), szUrl, pOIProtSink, pOIBindInfo, grfPI, dwReserved);
    }

    /// <inheritdoc cref = "IInternetProtocolRoot.Continue"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Continue(PROTOCOLDATA* pProtocolData)
    {
        return ((delegate* unmanaged<IInternetProtocol*, PROTOCOLDATA*, int> )(lpVtbl[4]))((IInternetProtocol*)Unsafe.AsPointer(ref this), pProtocolData);
    }

    /// <inheritdoc cref = "IInternetProtocolRoot.Abort"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Abort(HRESULT hrReason, [NativeTypeName("DWORD")] uint dwOptions)
    {
        return ((delegate* unmanaged<IInternetProtocol*, HRESULT, uint, int> )(lpVtbl[5]))((IInternetProtocol*)Unsafe.AsPointer(ref this), hrReason, dwOptions);
    }

    /// <inheritdoc cref = "IInternetProtocolRoot.Terminate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Terminate([NativeTypeName("DWORD")] uint dwOptions)
    {
        return ((delegate* unmanaged<IInternetProtocol*, uint, int> )(lpVtbl[6]))((IInternetProtocol*)Unsafe.AsPointer(ref this), dwOptions);
    }

    /// <inheritdoc cref = "IInternetProtocolRoot.Suspend"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Suspend()
    {
        return ((delegate* unmanaged<IInternetProtocol*, int> )(lpVtbl[7]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IInternetProtocolRoot.Resume"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IInternetProtocol*, int> )(lpVtbl[8]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IInternetProtocol.xml' path='doc/member[@name="IInternetProtocol.Read"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead)
    {
        return ((delegate* unmanaged<IInternetProtocol*, void*, uint, uint*, int> )(lpVtbl[9]))((IInternetProtocol*)Unsafe.AsPointer(ref this), pv, cb, pcbRead);
    }

    /// <include file='IInternetProtocol.xml' path='doc/member[@name="IInternetProtocol.Seek"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition)
    {
        return ((delegate* unmanaged<IInternetProtocol*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> )(lpVtbl[10]))((IInternetProtocol*)Unsafe.AsPointer(ref this), dlibMove, dwOrigin, plibNewPosition);
    }

    /// <include file='IInternetProtocol.xml' path='doc/member[@name="IInternetProtocol.LockRequest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT LockRequest([NativeTypeName("DWORD")] uint dwOptions)
    {
        return ((delegate* unmanaged<IInternetProtocol*, uint, int> )(lpVtbl[11]))((IInternetProtocol*)Unsafe.AsPointer(ref this), dwOptions);
    }

    /// <include file='IInternetProtocol.xml' path='doc/member[@name="IInternetProtocol.UnlockRequest"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT UnlockRequest()
    {
        return ((delegate* unmanaged<IInternetProtocol*, int> )(lpVtbl[12]))((IInternetProtocol*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IInternetProtocolRoot.Interface
    {
        [VtblIndex(9)]
        HRESULT Read(void* pv, [NativeTypeName("ULONG")] uint cb, [NativeTypeName("ULONG *")] uint* pcbRead);
        [VtblIndex(10)]
        HRESULT Seek(LARGE_INTEGER dlibMove, [NativeTypeName("DWORD")] uint dwOrigin, ULARGE_INTEGER* plibNewPosition);
        [VtblIndex(11)]
        HRESULT LockRequest([NativeTypeName("DWORD")] uint dwOptions);
        [VtblIndex(12)]
        HRESULT UnlockRequest();
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
        [NativeTypeName("HRESULT (LPCWSTR, IInternetProtocolSink *, IInternetBindInfo *, DWORD, HANDLE_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IInternetProtocolSink*, IInternetBindInfo*, uint, HANDLE_PTR, int> Start;
        [NativeTypeName("HRESULT (PROTOCOLDATA *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROTOCOLDATA*, int> Continue;
        [NativeTypeName("HRESULT (HRESULT, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, uint, int> Abort;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Terminate;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Suspend;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Resume;
        [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint*, int> Read;
        [NativeTypeName("HRESULT (LARGE_INTEGER, DWORD, ULARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LARGE_INTEGER, uint, ULARGE_INTEGER*, int> Seek;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> LockRequest;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> UnlockRequest;
    }
}