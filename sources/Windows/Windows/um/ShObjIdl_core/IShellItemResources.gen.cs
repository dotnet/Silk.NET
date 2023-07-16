// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IShellItemResources.xml' path='doc/member[@name="IShellItemResources"]/*'/>
[Guid("FF5693BE-2CE0-4D48-B5C5-40817D1ACDB9")]
[NativeTypeName("struct IShellItemResources : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellItemResources : IShellItemResources.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellItemResources));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellItemResources*, Guid*, void**, int> )(lpVtbl[0]))((IShellItemResources*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellItemResources*, uint> )(lpVtbl[1]))((IShellItemResources*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellItemResources*, uint> )(lpVtbl[2]))((IShellItemResources*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellItemResources.xml' path='doc/member[@name="IShellItemResources.GetAttributes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetAttributes([NativeTypeName("DWORD *")] uint* pdwAttributes)
    {
        return ((delegate* unmanaged<IShellItemResources*, uint*, int> )(lpVtbl[3]))((IShellItemResources*)Unsafe.AsPointer(ref this), pdwAttributes);
    }

    /// <include file='IShellItemResources.xml' path='doc/member[@name="IShellItemResources.GetSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetSize([NativeTypeName("ULONGLONG *")] ulong* pullSize)
    {
        return ((delegate* unmanaged<IShellItemResources*, ulong*, int> )(lpVtbl[4]))((IShellItemResources*)Unsafe.AsPointer(ref this), pullSize);
    }

    /// <include file='IShellItemResources.xml' path='doc/member[@name="IShellItemResources.GetTimes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTimes(FILETIME* pftCreation, FILETIME* pftWrite, FILETIME* pftAccess)
    {
        return ((delegate* unmanaged<IShellItemResources*, FILETIME*, FILETIME*, FILETIME*, int> )(lpVtbl[5]))((IShellItemResources*)Unsafe.AsPointer(ref this), pftCreation, pftWrite, pftAccess);
    }

    /// <include file='IShellItemResources.xml' path='doc/member[@name="IShellItemResources.SetTimes"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetTimes([NativeTypeName("const FILETIME *")] FILETIME* pftCreation, [NativeTypeName("const FILETIME *")] FILETIME* pftWrite, [NativeTypeName("const FILETIME *")] FILETIME* pftAccess)
    {
        return ((delegate* unmanaged<IShellItemResources*, FILETIME*, FILETIME*, FILETIME*, int> )(lpVtbl[6]))((IShellItemResources*)Unsafe.AsPointer(ref this), pftCreation, pftWrite, pftAccess);
    }

    /// <include file='IShellItemResources.xml' path='doc/member[@name="IShellItemResources.GetResourceDescription"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResourceDescription([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir, [NativeTypeName("LPWSTR *")] ushort** ppszDescription)
    {
        return ((delegate* unmanaged<IShellItemResources*, SHELL_ITEM_RESOURCE*, ushort**, int> )(lpVtbl[7]))((IShellItemResources*)Unsafe.AsPointer(ref this), pcsir, ppszDescription);
    }

    /// <include file='IShellItemResources.xml' path='doc/member[@name="IShellItemResources.EnumResources"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnumResources(IEnumResources** ppenumr)
    {
        return ((delegate* unmanaged<IShellItemResources*, IEnumResources**, int> )(lpVtbl[8]))((IShellItemResources*)Unsafe.AsPointer(ref this), ppenumr);
    }

    /// <include file='IShellItemResources.xml' path='doc/member[@name="IShellItemResources.SupportsResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SupportsResource([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir)
    {
        return ((delegate* unmanaged<IShellItemResources*, SHELL_ITEM_RESOURCE*, int> )(lpVtbl[9]))((IShellItemResources*)Unsafe.AsPointer(ref this), pcsir);
    }

    /// <include file='IShellItemResources.xml' path='doc/member[@name="IShellItemResources.OpenResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OpenResource([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellItemResources*, SHELL_ITEM_RESOURCE*, Guid*, void**, int> )(lpVtbl[10]))((IShellItemResources*)Unsafe.AsPointer(ref this), pcsir, riid, ppv);
    }

    /// <include file='IShellItemResources.xml' path='doc/member[@name="IShellItemResources.CreateResource"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateResource([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IShellItemResources*, SHELL_ITEM_RESOURCE*, Guid*, void**, int> )(lpVtbl[11]))((IShellItemResources*)Unsafe.AsPointer(ref this), pcsir, riid, ppv);
    }

    /// <include file='IShellItemResources.xml' path='doc/member[@name="IShellItemResources.MarkForDelete"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT MarkForDelete()
    {
        return ((delegate* unmanaged<IShellItemResources*, int> )(lpVtbl[12]))((IShellItemResources*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetAttributes([NativeTypeName("DWORD *")] uint* pdwAttributes);
        [VtblIndex(4)]
        HRESULT GetSize([NativeTypeName("ULONGLONG *")] ulong* pullSize);
        [VtblIndex(5)]
        HRESULT GetTimes(FILETIME* pftCreation, FILETIME* pftWrite, FILETIME* pftAccess);
        [VtblIndex(6)]
        HRESULT SetTimes([NativeTypeName("const FILETIME *")] FILETIME* pftCreation, [NativeTypeName("const FILETIME *")] FILETIME* pftWrite, [NativeTypeName("const FILETIME *")] FILETIME* pftAccess);
        [VtblIndex(7)]
        HRESULT GetResourceDescription([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir, [NativeTypeName("LPWSTR *")] ushort** ppszDescription);
        [VtblIndex(8)]
        HRESULT EnumResources(IEnumResources** ppenumr);
        [VtblIndex(9)]
        HRESULT SupportsResource([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir);
        [VtblIndex(10)]
        HRESULT OpenResource([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(11)]
        HRESULT CreateResource([NativeTypeName("const SHELL_ITEM_RESOURCE *")] SHELL_ITEM_RESOURCE* pcsir, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
        [VtblIndex(12)]
        HRESULT MarkForDelete();
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
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetAttributes;
        [NativeTypeName("HRESULT (ULONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> GetSize;
        [NativeTypeName("HRESULT (FILETIME *, FILETIME *, FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILETIME*, FILETIME*, FILETIME*, int> GetTimes;
        [NativeTypeName("HRESULT (const FILETIME *, const FILETIME *, const FILETIME *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FILETIME*, FILETIME*, FILETIME*, int> SetTimes;
        [NativeTypeName("HRESULT (const SHELL_ITEM_RESOURCE *, LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SHELL_ITEM_RESOURCE*, ushort**, int> GetResourceDescription;
        [NativeTypeName("HRESULT (IEnumResources **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumResources**, int> EnumResources;
        [NativeTypeName("HRESULT (const SHELL_ITEM_RESOURCE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SHELL_ITEM_RESOURCE*, int> SupportsResource;
        [NativeTypeName("HRESULT (const SHELL_ITEM_RESOURCE *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SHELL_ITEM_RESOURCE*, Guid*, void**, int> OpenResource;
        [NativeTypeName("HRESULT (const SHELL_ITEM_RESOURCE *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SHELL_ITEM_RESOURCE*, Guid*, void**, int> CreateResource;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> MarkForDelete;
    }
}