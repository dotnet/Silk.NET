// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAuthenticate.xml' path='doc/member[@name="IAuthenticate"]/*'/>
[Guid("79EAC9D0-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IAuthenticate : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAuthenticate : IAuthenticate.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAuthenticate));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAuthenticate*, Guid*, void**, int> )(lpVtbl[0]))((IAuthenticate*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAuthenticate*, uint> )(lpVtbl[1]))((IAuthenticate*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAuthenticate*, uint> )(lpVtbl[2]))((IAuthenticate*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAuthenticate.xml' path='doc/member[@name="IAuthenticate.Authenticate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Authenticate(HWND* phwnd, [NativeTypeName("LPWSTR *")] ushort** pszUsername, [NativeTypeName("LPWSTR *")] ushort** pszPassword)
    {
        return ((delegate* unmanaged<IAuthenticate*, HWND*, ushort**, ushort**, int> )(lpVtbl[3]))((IAuthenticate*)Unsafe.AsPointer(ref this), phwnd, pszUsername, pszPassword);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Authenticate(HWND* phwnd, [NativeTypeName("LPWSTR *")] ushort** pszUsername, [NativeTypeName("LPWSTR *")] ushort** pszPassword);
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
        [NativeTypeName("HRESULT (HWND *, LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, ushort**, ushort**, int> Authenticate;
    }
}