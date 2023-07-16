// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IParseAndCreateItem.xml' path='doc/member[@name="IParseAndCreateItem"]/*'/>
[Guid("67EFED0E-E827-4408-B493-78F3982B685C")]
[NativeTypeName("struct IParseAndCreateItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IParseAndCreateItem : IParseAndCreateItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IParseAndCreateItem));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IParseAndCreateItem*, Guid*, void**, int> )(lpVtbl[0]))((IParseAndCreateItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IParseAndCreateItem*, uint> )(lpVtbl[1]))((IParseAndCreateItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IParseAndCreateItem*, uint> )(lpVtbl[2]))((IParseAndCreateItem*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IParseAndCreateItem.xml' path='doc/member[@name="IParseAndCreateItem.SetItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetItem(IShellItem* psi)
    {
        return ((delegate* unmanaged<IParseAndCreateItem*, IShellItem*, int> )(lpVtbl[3]))((IParseAndCreateItem*)Unsafe.AsPointer(ref this), psi);
    }

    /// <include file='IParseAndCreateItem.xml' path='doc/member[@name="IParseAndCreateItem.GetItem"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetItem([NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IParseAndCreateItem*, Guid*, void**, int> )(lpVtbl[4]))((IParseAndCreateItem*)Unsafe.AsPointer(ref this), riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetItem(IShellItem* psi);
        [VtblIndex(4)]
        HRESULT GetItem([NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem*, int> SetItem;
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetItem;
    }
}