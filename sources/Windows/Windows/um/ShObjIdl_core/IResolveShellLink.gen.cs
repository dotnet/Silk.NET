// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IResolveShellLink.xml' path='doc/member[@name="IResolveShellLink"]/*'/>
[Guid("5CD52983-9449-11D2-963A-00C04F79ADF0")]
[NativeTypeName("struct IResolveShellLink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IResolveShellLink : IResolveShellLink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IResolveShellLink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IResolveShellLink*, Guid*, void**, int> )(lpVtbl[0]))((IResolveShellLink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IResolveShellLink*, uint> )(lpVtbl[1]))((IResolveShellLink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IResolveShellLink*, uint> )(lpVtbl[2]))((IResolveShellLink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IResolveShellLink.xml' path='doc/member[@name="IResolveShellLink.ResolveShellLink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ResolveShellLink(IUnknown* punkLink, HWND hwnd, [NativeTypeName("DWORD")] uint fFlags)
    {
        return ((delegate* unmanaged<IResolveShellLink*, IUnknown*, HWND, uint, int> )(lpVtbl[3]))((IResolveShellLink*)Unsafe.AsPointer(ref this), punkLink, hwnd, fFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ResolveShellLink(IUnknown* punkLink, HWND hwnd, [NativeTypeName("DWORD")] uint fFlags);
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
        [NativeTypeName("HRESULT (IUnknown *, HWND, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, HWND, uint, int> ResolveShellLink;
    }
}