// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shappmgr.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppPublisher.xml' path='doc/member[@name="IAppPublisher"]/*'/>
[Guid("07250A10-9CF9-11D1-9076-006008059382")]
[NativeTypeName("struct IAppPublisher : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppPublisher : IAppPublisher.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppPublisher));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppPublisher*, Guid*, void**, int> )(lpVtbl[0]))((IAppPublisher*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppPublisher*, uint> )(lpVtbl[1]))((IAppPublisher*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppPublisher*, uint> )(lpVtbl[2]))((IAppPublisher*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppPublisher.xml' path='doc/member[@name="IAppPublisher.GetNumberOfCategories"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetNumberOfCategories([NativeTypeName("DWORD *")] uint* pdwCat)
    {
        return ((delegate* unmanaged<IAppPublisher*, uint*, int> )(lpVtbl[3]))((IAppPublisher*)Unsafe.AsPointer(ref this), pdwCat);
    }

    /// <include file='IAppPublisher.xml' path='doc/member[@name="IAppPublisher.GetCategories"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCategories(APPCATEGORYINFOLIST* pAppCategoryList)
    {
        return ((delegate* unmanaged<IAppPublisher*, APPCATEGORYINFOLIST*, int> )(lpVtbl[4]))((IAppPublisher*)Unsafe.AsPointer(ref this), pAppCategoryList);
    }

    /// <include file='IAppPublisher.xml' path='doc/member[@name="IAppPublisher.GetNumberOfApps"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetNumberOfApps([NativeTypeName("DWORD *")] uint* pdwApps)
    {
        return ((delegate* unmanaged<IAppPublisher*, uint*, int> )(lpVtbl[5]))((IAppPublisher*)Unsafe.AsPointer(ref this), pdwApps);
    }

    /// <include file='IAppPublisher.xml' path='doc/member[@name="IAppPublisher.EnumApps"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT EnumApps(Guid* pAppCategoryId, IEnumPublishedApps** ppepa)
    {
        return ((delegate* unmanaged<IAppPublisher*, Guid*, IEnumPublishedApps**, int> )(lpVtbl[6]))((IAppPublisher*)Unsafe.AsPointer(ref this), pAppCategoryId, ppepa);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetNumberOfCategories([NativeTypeName("DWORD *")] uint* pdwCat);
        [VtblIndex(4)]
        HRESULT GetCategories(APPCATEGORYINFOLIST* pAppCategoryList);
        [VtblIndex(5)]
        HRESULT GetNumberOfApps([NativeTypeName("DWORD *")] uint* pdwApps);
        [VtblIndex(6)]
        HRESULT EnumApps(Guid* pAppCategoryId, IEnumPublishedApps** ppepa);
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
        public delegate* unmanaged<TSelf*, uint*, int> GetNumberOfCategories;
        [NativeTypeName("HRESULT (APPCATEGORYINFOLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPCATEGORYINFOLIST*, int> GetCategories;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetNumberOfApps;
        [NativeTypeName("HRESULT (GUID *, IEnumPublishedApps **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IEnumPublishedApps**, int> EnumApps;
    }
}