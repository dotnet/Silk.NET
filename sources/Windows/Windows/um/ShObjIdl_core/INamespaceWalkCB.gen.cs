// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='INamespaceWalkCB.xml' path='doc/member[@name="INamespaceWalkCB"]/*'/>
[Guid("D92995F8-CF5E-4A76-BF59-EAD39EA2B97E")]
[NativeTypeName("struct INamespaceWalkCB : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INamespaceWalkCB : INamespaceWalkCB.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INamespaceWalkCB));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INamespaceWalkCB*, Guid*, void**, int> )(lpVtbl[0]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INamespaceWalkCB*, uint> )(lpVtbl[1]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INamespaceWalkCB*, uint> )(lpVtbl[2]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INamespaceWalkCB.xml' path='doc/member[@name="INamespaceWalkCB.FoundItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FoundItem(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<INamespaceWalkCB*, IShellFolder*, ITEMIDLIST*, int> )(lpVtbl[3]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this), psf, pidl);
    }

    /// <include file='INamespaceWalkCB.xml' path='doc/member[@name="INamespaceWalkCB.EnterFolder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnterFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<INamespaceWalkCB*, IShellFolder*, ITEMIDLIST*, int> )(lpVtbl[4]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this), psf, pidl);
    }

    /// <include file='INamespaceWalkCB.xml' path='doc/member[@name="INamespaceWalkCB.LeaveFolder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LeaveFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<INamespaceWalkCB*, IShellFolder*, ITEMIDLIST*, int> )(lpVtbl[5]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this), psf, pidl);
    }

    /// <include file='INamespaceWalkCB.xml' path='doc/member[@name="INamespaceWalkCB.InitializeProgressDialog"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InitializeProgressDialog([NativeTypeName("LPWSTR *")] ushort** ppszTitle, [NativeTypeName("LPWSTR *")] ushort** ppszCancel)
    {
        return ((delegate* unmanaged<INamespaceWalkCB*, ushort**, ushort**, int> )(lpVtbl[6]))((INamespaceWalkCB*)Unsafe.AsPointer(ref this), ppszTitle, ppszCancel);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FoundItem(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
        [VtblIndex(4)]
        HRESULT EnterFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
        [VtblIndex(5)]
        HRESULT LeaveFolder(IShellFolder* psf, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
        [VtblIndex(6)]
        HRESULT InitializeProgressDialog([NativeTypeName("LPWSTR *")] ushort** ppszTitle, [NativeTypeName("LPWSTR *")] ushort** ppszCancel);
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
    }
}