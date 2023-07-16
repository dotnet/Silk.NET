// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IPersistFolder.xml' path='doc/member[@name="IPersistFolder"]/*'/>
[Guid("000214EA-0000-0000-C000-000000000046")]
[NativeTypeName("struct IPersistFolder : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistFolder : IPersistFolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistFolder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistFolder*, Guid*, void**, int> )(lpVtbl[0]))((IPersistFolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPersistFolder*, uint> )(lpVtbl[1]))((IPersistFolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistFolder*, uint> )(lpVtbl[2]))((IPersistFolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IPersist.GetClassID"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistFolder*, Guid*, int> )(lpVtbl[3]))((IPersistFolder*)Unsafe.AsPointer(ref this), pClassID);
    }

    /// <include file='IPersistFolder.xml' path='doc/member[@name="IPersistFolder.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Initialize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<IPersistFolder*, ITEMIDLIST*, int> )(lpVtbl[4]))((IPersistFolder*)Unsafe.AsPointer(ref this), pidl);
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT Initialize([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);
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
        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClassID;
        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> Initialize;
    }
}