// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWinInetHttpTimeouts.xml' path='doc/member[@name="IWinInetHttpTimeouts"]/*'/>
[Guid("F286FA56-C1FD-4270-8E67-B3EB790A81E8")]
[NativeTypeName("struct IWinInetHttpTimeouts : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWinInetHttpTimeouts : IWinInetHttpTimeouts.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWinInetHttpTimeouts));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWinInetHttpTimeouts*, Guid*, void**, int> )(lpVtbl[0]))((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWinInetHttpTimeouts*, uint> )(lpVtbl[1]))((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWinInetHttpTimeouts*, uint> )(lpVtbl[2]))((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWinInetHttpTimeouts.xml' path='doc/member[@name="IWinInetHttpTimeouts.GetRequestTimeouts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRequestTimeouts([NativeTypeName("DWORD *")] uint* pdwConnectTimeout, [NativeTypeName("DWORD *")] uint* pdwSendTimeout, [NativeTypeName("DWORD *")] uint* pdwReceiveTimeout)
    {
        return ((delegate* unmanaged<IWinInetHttpTimeouts*, uint*, uint*, uint*, int> )(lpVtbl[3]))((IWinInetHttpTimeouts*)Unsafe.AsPointer(ref this), pdwConnectTimeout, pdwSendTimeout, pdwReceiveTimeout);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRequestTimeouts([NativeTypeName("DWORD *")] uint* pdwConnectTimeout, [NativeTypeName("DWORD *")] uint* pdwSendTimeout, [NativeTypeName("DWORD *")] uint* pdwReceiveTimeout);
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
        [NativeTypeName("HRESULT (DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, uint*, int> GetRequestTimeouts;
    }
}