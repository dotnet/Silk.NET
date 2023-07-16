// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shdeprecated.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITravelEntry.xml' path='doc/member[@name="ITravelEntry"]/*'/>
[Guid("F46EDB3B-BC2F-11D0-9412-00AA00A3EBD3")]
[NativeTypeName("struct ITravelEntry : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITravelEntry : ITravelEntry.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITravelEntry));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITravelEntry*, Guid*, void**, int> )(lpVtbl[0]))((ITravelEntry*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITravelEntry*, uint> )(lpVtbl[1]))((ITravelEntry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITravelEntry*, uint> )(lpVtbl[2]))((ITravelEntry*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITravelEntry.xml' path='doc/member[@name="ITravelEntry.Invoke"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke(IUnknown* punk)
    {
        return ((delegate* unmanaged<ITravelEntry*, IUnknown*, int> )(lpVtbl[3]))((ITravelEntry*)Unsafe.AsPointer(ref this), punk);
    }

    /// <include file='ITravelEntry.xml' path='doc/member[@name="ITravelEntry.Update"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Update(IUnknown* punk, BOOL fIsLocalAnchor)
    {
        return ((delegate* unmanaged<ITravelEntry*, IUnknown*, BOOL, int> )(lpVtbl[4]))((ITravelEntry*)Unsafe.AsPointer(ref this), punk, fIsLocalAnchor);
    }

    /// <include file='ITravelEntry.xml' path='doc/member[@name="ITravelEntry.GetPidl"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPidl([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<ITravelEntry*, ITEMIDLIST**, int> )(lpVtbl[5]))((ITravelEntry*)Unsafe.AsPointer(ref this), ppidl);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke(IUnknown* punk);
        [VtblIndex(4)]
        HRESULT Update(IUnknown* punk, BOOL fIsLocalAnchor);
        [VtblIndex(5)]
        HRESULT GetPidl([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);
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
        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> Invoke;
        [NativeTypeName("HRESULT (IUnknown *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, BOOL, int> Update;
        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST**, int> GetPidl;
    }
}