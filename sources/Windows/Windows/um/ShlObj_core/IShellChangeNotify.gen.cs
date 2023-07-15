// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IShellChangeNotify.xml' path='doc/member[@name="IShellChangeNotify"]/*'/>
[Guid("D82BE2B1-5764-11D0-A96E-00C04FD705A2")]
[NativeTypeName("struct IShellChangeNotify : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellChangeNotify : IShellChangeNotify.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellChangeNotify));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellChangeNotify*, Guid*, void**, int> )(lpVtbl[0]))((IShellChangeNotify*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellChangeNotify*, uint> )(lpVtbl[1]))((IShellChangeNotify*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellChangeNotify*, uint> )(lpVtbl[2]))((IShellChangeNotify*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellChangeNotify.xml' path='doc/member[@name="IShellChangeNotify.OnChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnChange([NativeTypeName("LONG")] int lEvent, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2)
    {
        return ((delegate* unmanaged<IShellChangeNotify*, int, ITEMIDLIST*, ITEMIDLIST*, int> )(lpVtbl[3]))((IShellChangeNotify*)Unsafe.AsPointer(ref this), lEvent, pidl1, pidl2);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnChange([NativeTypeName("LONG")] int lEvent, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl1, [NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl2);
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
        [NativeTypeName("HRESULT (LONG, LPCITEMIDLIST, LPCITEMIDLIST) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ITEMIDLIST*, ITEMIDLIST*, int> OnChange;
    }
}