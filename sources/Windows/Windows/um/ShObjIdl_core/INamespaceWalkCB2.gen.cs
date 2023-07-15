// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='INamespaceWalkCB2.xml' path='doc/member[@name="INamespaceWalkCB2"]/*'/>
[Guid("7AC7492B-C38E-438A-87DB-68737844FF70")]
[NativeTypeName("struct INamespaceWalkCB2 : INamespaceWalkCB")]
[NativeInheritance("INamespaceWalkCB")]
public unsafe partial struct INamespaceWalkCB2 : INamespaceWalkCB2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INamespaceWalkCB2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INamespaceWalkCB2*, Guid*, void**, int> )(lpVtbl[0]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INamespaceWalkCB2*, uint> )(lpVtbl[1]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INamespaceWalkCB2*, uint> )(lpVtbl[2]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "INamespaceWalkCB.FoundItem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FoundItem(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<INamespaceWalkCB2*, IShellFolder*, ITEMIDLIST*, int> )(lpVtbl[3]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), psf, pidl);
    }

    /// <inheritdoc cref = "INamespaceWalkCB.EnterFolder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnterFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<INamespaceWalkCB2*, IShellFolder*, ITEMIDLIST*, int> )(lpVtbl[4]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), psf, pidl);
    }

    /// <inheritdoc cref = "INamespaceWalkCB.LeaveFolder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LeaveFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<INamespaceWalkCB2*, IShellFolder*, ITEMIDLIST*, int> )(lpVtbl[5]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), psf, pidl);
    }

    /// <inheritdoc cref = "INamespaceWalkCB.InitializeProgressDialog"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InitializeProgressDialog([NativeTypeName("LPWSTR *")] ushort** ppszTitle, [NativeTypeName("LPWSTR *")] ushort** ppszCancel)
    {
        return ((delegate* unmanaged<INamespaceWalkCB2*, ushort**, ushort**, int> )(lpVtbl[6]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), ppszTitle, ppszCancel);
    }

    /// <include file='INamespaceWalkCB2.xml' path='doc/member[@name="INamespaceWalkCB2.WalkComplete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT WalkComplete(HRESULT hr)
    {
        return ((delegate* unmanaged<INamespaceWalkCB2*, HRESULT, int> )(lpVtbl[7]))((INamespaceWalkCB2*)Unsafe.AsPointer(ref this), hr);
    }

    public interface Interface : INamespaceWalkCB.Interface
    {
        [VtblIndex(7)]
        HRESULT WalkComplete(HRESULT hr);
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
        [NativeTypeName("HRESULT (IShellFolder *, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellFolder*, ITEMIDLIST*, int> FoundItem;
        [NativeTypeName("HRESULT (IShellFolder *, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellFolder*, ITEMIDLIST*, int> EnterFolder;
        [NativeTypeName("HRESULT (IShellFolder *, LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellFolder*, ITEMIDLIST*, int> LeaveFolder;
        [NativeTypeName("HRESULT (LPWSTR *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, ushort**, int> InitializeProgressDialog;
        [NativeTypeName("HRESULT (HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, int> WalkComplete;
    }
}