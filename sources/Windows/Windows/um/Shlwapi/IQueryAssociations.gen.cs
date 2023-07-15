// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IQueryAssociations.xml' path='doc/member[@name="IQueryAssociations"]/*'/>
[Guid("C46CA590-3C3F-11D2-BEE6-0000F805CA57")]
[NativeTypeName("struct IQueryAssociations : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IQueryAssociations : IQueryAssociations.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IQueryAssociations));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IQueryAssociations*, Guid*, void**, int> )(lpVtbl[0]))((IQueryAssociations*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IQueryAssociations*, uint> )(lpVtbl[1]))((IQueryAssociations*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IQueryAssociations*, uint> )(lpVtbl[2]))((IQueryAssociations*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IQueryAssociations.xml' path='doc/member[@name="IQueryAssociations.Init"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Init([NativeTypeName("ASSOCF")] uint flags, [NativeTypeName("LPCWSTR")] ushort* pszAssoc, HKEY hkProgid, HWND hwnd)
    {
        return ((delegate* unmanaged<IQueryAssociations*, uint, ushort*, HKEY, HWND, int> )(lpVtbl[3]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, pszAssoc, hkProgid, hwnd);
    }

    /// <include file='IQueryAssociations.xml' path='doc/member[@name="IQueryAssociations.GetString"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetString([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("LPWSTR")] ushort* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut)
    {
        return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCSTR, ushort*, ushort*, uint*, int> )(lpVtbl[4]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, str, pszExtra, pszOut, pcchOut);
    }

    /// <include file='IQueryAssociations.xml' path='doc/member[@name="IQueryAssociations.GetKey"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetKey([NativeTypeName("ASSOCF")] uint flags, ASSOCKEY key, [NativeTypeName("LPCWSTR")] ushort* pszExtra, HKEY* phkeyOut)
    {
        return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCKEY, ushort*, HKEY*, int> )(lpVtbl[5]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, key, pszExtra, phkeyOut);
    }

    /// <include file='IQueryAssociations.xml' path='doc/member[@name="IQueryAssociations.GetData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetData([NativeTypeName("ASSOCF")] uint flags, ASSOCDATA data, [NativeTypeName("LPCWSTR")] ushort* pszExtra, void* pvOut, [NativeTypeName("DWORD *")] uint* pcbOut)
    {
        return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCDATA, ushort*, void*, uint*, int> )(lpVtbl[6]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, data, pszExtra, pvOut, pcbOut);
    }

    /// <include file='IQueryAssociations.xml' path='doc/member[@name="IQueryAssociations.GetEnum"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetEnum([NativeTypeName("ASSOCF")] uint flags, ASSOCENUM assocenum, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("const IID &")] Guid* riid, void** ppvOut)
    {
        return ((delegate* unmanaged<IQueryAssociations*, uint, ASSOCENUM, ushort*, Guid*, void**, int> )(lpVtbl[7]))((IQueryAssociations*)Unsafe.AsPointer(ref this), flags, assocenum, pszExtra, riid, ppvOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Init([NativeTypeName("ASSOCF")] uint flags, [NativeTypeName("LPCWSTR")] ushort* pszAssoc, HKEY hkProgid, HWND hwnd);
        [VtblIndex(4)]
        HRESULT GetString([NativeTypeName("ASSOCF")] uint flags, ASSOCSTR str, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("LPWSTR")] ushort* pszOut, [NativeTypeName("DWORD *")] uint* pcchOut);
        [VtblIndex(5)]
        HRESULT GetKey([NativeTypeName("ASSOCF")] uint flags, ASSOCKEY key, [NativeTypeName("LPCWSTR")] ushort* pszExtra, HKEY* phkeyOut);
        [VtblIndex(6)]
        HRESULT GetData([NativeTypeName("ASSOCF")] uint flags, ASSOCDATA data, [NativeTypeName("LPCWSTR")] ushort* pszExtra, void* pvOut, [NativeTypeName("DWORD *")] uint* pcbOut);
        [VtblIndex(7)]
        HRESULT GetEnum([NativeTypeName("ASSOCF")] uint flags, ASSOCENUM assocenum, [NativeTypeName("LPCWSTR")] ushort* pszExtra, [NativeTypeName("const IID &")] Guid* riid, void** ppvOut);
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
        [NativeTypeName("HRESULT (ASSOCF, LPCWSTR, HKEY, HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, HKEY, HWND, int> Init;
        [NativeTypeName("HRESULT (ASSOCF, ASSOCSTR, LPCWSTR, LPWSTR, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ASSOCSTR, ushort*, ushort*, uint*, int> GetString;
        [NativeTypeName("HRESULT (ASSOCF, ASSOCKEY, LPCWSTR, HKEY *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ASSOCKEY, ushort*, HKEY*, int> GetKey;
        [NativeTypeName("HRESULT (ASSOCF, ASSOCDATA, LPCWSTR, void *, DWORD *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ASSOCDATA, ushort*, void*, uint*, int> GetData;
        [NativeTypeName("HRESULT (ASSOCF, ASSOCENUM, LPCWSTR, const IID &, void **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ASSOCENUM, ushort*, Guid*, void**, int> GetEnum;
    }
}