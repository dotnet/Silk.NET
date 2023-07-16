// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IStartMenuPinnedList.xml' path='doc/member[@name="IStartMenuPinnedList"]/*'/>
[Guid("4CD19ADA-25A5-4A32-B3B7-347BEE5BE36B")]
[NativeTypeName("struct IStartMenuPinnedList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStartMenuPinnedList : IStartMenuPinnedList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStartMenuPinnedList));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStartMenuPinnedList*, Guid*, void**, int> )(lpVtbl[0]))((IStartMenuPinnedList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStartMenuPinnedList*, uint> )(lpVtbl[1]))((IStartMenuPinnedList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStartMenuPinnedList*, uint> )(lpVtbl[2]))((IStartMenuPinnedList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStartMenuPinnedList.xml' path='doc/member[@name="IStartMenuPinnedList.RemoveFromList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RemoveFromList(IShellItem* pitem)
    {
        return ((delegate* unmanaged<IStartMenuPinnedList*, IShellItem*, int> )(lpVtbl[3]))((IStartMenuPinnedList*)Unsafe.AsPointer(ref this), pitem);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RemoveFromList(IShellItem* pitem);
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
        public delegate* unmanaged<TSelf*, IShellItem*, int> RemoveFromList;
    }
}