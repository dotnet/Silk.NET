// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWinInetCacheHints.xml' path='doc/member[@name="IWinInetCacheHints"]/*'/>
[Guid("DD1EC3B3-8391-4FDB-A9E6-347C3CAAA7DD")]
[NativeTypeName("struct IWinInetCacheHints : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWinInetCacheHints : IWinInetCacheHints.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWinInetCacheHints));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWinInetCacheHints*, Guid*, void**, int> )(lpVtbl[0]))((IWinInetCacheHints*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWinInetCacheHints*, uint> )(lpVtbl[1]))((IWinInetCacheHints*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWinInetCacheHints*, uint> )(lpVtbl[2]))((IWinInetCacheHints*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWinInetCacheHints.xml' path='doc/member[@name="IWinInetCacheHints.SetCacheExtension"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetCacheExtension([NativeTypeName("LPCWSTR")] ushort* pwzExt, [NativeTypeName("LPVOID")] void* pszCacheFile, [NativeTypeName("DWORD *")] uint* pcbCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved)
    {
        return ((delegate* unmanaged<IWinInetCacheHints*, ushort*, void*, uint*, uint*, uint*, int> )(lpVtbl[3]))((IWinInetCacheHints*)Unsafe.AsPointer(ref this), pwzExt, pszCacheFile, pcbCacheFile, pdwWinInetError, pdwReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetCacheExtension([NativeTypeName("LPCWSTR")] ushort* pwzExt, [NativeTypeName("LPVOID")] void* pszCacheFile, [NativeTypeName("DWORD *")] uint* pcbCacheFile, [NativeTypeName("DWORD *")] uint* pdwWinInetError, [NativeTypeName("DWORD *")] uint* pdwReserved);
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
        [NativeTypeName("HRESULT (LPCWSTR, LPVOID, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, void*, uint*, uint*, uint*, int> SetCacheExtension;
    }
}