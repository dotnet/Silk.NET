// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IWinInetHttpInfo.xml' path='doc/member[@name="IWinInetHttpInfo"]/*'/>
[Guid("79EAC9D8-BAFA-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IWinInetHttpInfo : IWinInetInfo")]
[NativeInheritance("IWinInetInfo")]
public unsafe partial struct IWinInetHttpInfo : IWinInetHttpInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWinInetHttpInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWinInetHttpInfo*, Guid*, void**, int> )(lpVtbl[0]))((IWinInetHttpInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWinInetHttpInfo*, uint> )(lpVtbl[1]))((IWinInetHttpInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWinInetHttpInfo*, uint> )(lpVtbl[2]))((IWinInetHttpInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWinInetInfo.QueryOption"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryOption([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf)
    {
        return ((delegate* unmanaged<IWinInetHttpInfo*, uint, void*, uint*, int> )(lpVtbl[3]))((IWinInetHttpInfo*)Unsafe.AsPointer(ref this), dwOption, pBuffer, pcbBuf);
    }

    /// <include file='IWinInetHttpInfo.xml' path='doc/member[@name="IWinInetHttpInfo.QueryInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT QueryInfo([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwReserved)
    {
        return ((delegate* unmanaged<IWinInetHttpInfo*, uint, void*, uint*, uint*, uint*, int> )(lpVtbl[4]))((IWinInetHttpInfo*)Unsafe.AsPointer(ref this), dwOption, pBuffer, pcbBuf, pdwFlags, pdwReserved);
    }

    public interface Interface : IWinInetInfo.Interface
    {
        [VtblIndex(4)]
        HRESULT QueryInfo([NativeTypeName("DWORD")] uint dwOption, [NativeTypeName("LPVOID")] void* pBuffer, [NativeTypeName("DWORD *")] uint* pcbBuf, [NativeTypeName("DWORD *")] uint* pdwFlags, [NativeTypeName("DWORD *")] uint* pdwReserved);
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
        [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint*, int> QueryOption;
        [NativeTypeName("HRESULT (DWORD, LPVOID, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint*, uint*, uint*, int> QueryInfo;
    }
}