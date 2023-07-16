// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ICategoryProvider.xml' path='doc/member[@name="ICategoryProvider"]/*'/>
[Guid("9AF64809-5864-4C26-A720-C1F78C086EE3")]
[NativeTypeName("struct ICategoryProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICategoryProvider : ICategoryProvider.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICategoryProvider));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICategoryProvider*, Guid*, void**, int> )(lpVtbl[0]))((ICategoryProvider*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICategoryProvider*, uint> )(lpVtbl[1]))((ICategoryProvider*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICategoryProvider*, uint> )(lpVtbl[2]))((ICategoryProvider*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICategoryProvider.xml' path='doc/member[@name="ICategoryProvider.CanCategorizeOnSCID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CanCategorizeOnSCID([NativeTypeName("const SHCOLUMNID *")] PROPERTYKEY* pscid)
    {
        return ((delegate* unmanaged<ICategoryProvider*, PROPERTYKEY*, int> )(lpVtbl[3]))((ICategoryProvider*)Unsafe.AsPointer(ref this), pscid);
    }

    /// <include file='ICategoryProvider.xml' path='doc/member[@name="ICategoryProvider.GetDefaultCategory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDefaultCategory(Guid* pguid, [NativeTypeName("SHCOLUMNID *")] PROPERTYKEY* pscid)
    {
        return ((delegate* unmanaged<ICategoryProvider*, Guid*, PROPERTYKEY*, int> )(lpVtbl[4]))((ICategoryProvider*)Unsafe.AsPointer(ref this), pguid, pscid);
    }

    /// <include file='ICategoryProvider.xml' path='doc/member[@name="ICategoryProvider.GetCategoryForSCID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCategoryForSCID([NativeTypeName("const SHCOLUMNID *")] PROPERTYKEY* pscid, Guid* pguid)
    {
        return ((delegate* unmanaged<ICategoryProvider*, PROPERTYKEY*, Guid*, int> )(lpVtbl[5]))((ICategoryProvider*)Unsafe.AsPointer(ref this), pscid, pguid);
    }

    /// <include file='ICategoryProvider.xml' path='doc/member[@name="ICategoryProvider.EnumCategories"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumCategories(IEnumGUID** penum)
    {
        return ((delegate* unmanaged<ICategoryProvider*, IEnumGUID**, int> )(lpVtbl[6]))((ICategoryProvider*)Unsafe.AsPointer(ref this), penum);
    }

    /// <include file='ICategoryProvider.xml' path='doc/member[@name="ICategoryProvider.GetCategoryName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCategoryName([NativeTypeName("const GUID *")] Guid* pguid, [NativeTypeName("LPWSTR")] ushort* pszName, uint cch)
    {
        return ((delegate* unmanaged<ICategoryProvider*, Guid*, ushort*, uint, int> )(lpVtbl[7]))((ICategoryProvider*)Unsafe.AsPointer(ref this), pguid, pszName, cch);
    }

    /// <include file='ICategoryProvider.xml' path='doc/member[@name="ICategoryProvider.CreateCategory"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateCategory([NativeTypeName("const GUID *")] Guid* pguid, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<ICategoryProvider*, Guid*, Guid*, void**, int> )(lpVtbl[8]))((ICategoryProvider*)Unsafe.AsPointer(ref this), pguid, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CanCategorizeOnSCID([NativeTypeName("const SHCOLUMNID *")] PROPERTYKEY* pscid);
        [VtblIndex(4)]
        HRESULT GetDefaultCategory(Guid* pguid, [NativeTypeName("SHCOLUMNID *")] PROPERTYKEY* pscid);
        [VtblIndex(5)]
        HRESULT GetCategoryForSCID([NativeTypeName("const SHCOLUMNID *")] PROPERTYKEY* pscid, Guid* pguid);
        [VtblIndex(6)]
        HRESULT EnumCategories(IEnumGUID** penum);
        [VtblIndex(7)]
        HRESULT GetCategoryName([NativeTypeName("const GUID *")] Guid* pguid, [NativeTypeName("LPWSTR")] ushort* pszName, uint cch);
        [VtblIndex(8)]
        HRESULT CreateCategory([NativeTypeName("const GUID *")] Guid* pguid, [NativeTypeName("const IID &")] Guid* riid, void** ppv);
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
        [NativeTypeName("HRESULT (const SHCOLUMNID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> CanCategorizeOnSCID;
        [NativeTypeName("HRESULT (GUID *, SHCOLUMNID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, PROPERTYKEY*, int> GetDefaultCategory;
        [NativeTypeName("HRESULT (const SHCOLUMNID *, GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, Guid*, int> GetCategoryForSCID;
        [NativeTypeName("HRESULT (IEnumGUID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumGUID**, int> EnumCategories;
        [NativeTypeName("HRESULT (const GUID *, LPWSTR, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, uint, int> GetCategoryName;
        [NativeTypeName("HRESULT (const GUID *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, int> CreateCategory;
    }
}