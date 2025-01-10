// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SyncMgr.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9C204249-C443-4BA4-85ED-C972681DB137")]
[NativeTypeName("struct ISyncMgrConflict : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISyncMgrConflict : ISyncMgrConflict.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISyncMgrConflict));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISyncMgrConflict, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISyncMgrConflict, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISyncMgrConflict, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetProperty(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
        PROPVARIANT* ppropvar
    )
    {
        return (
            (delegate* unmanaged<ISyncMgrConflict, PROPERTYKEY*, PROPVARIANT*, int>)((*lpVtbl)[3])
        )(this, propkey, ppropvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetConflictIdInfo(SYNCMGR_CONFLICT_ID_INFO* pConflictIdInfo)
    {
        return (
            (delegate* unmanaged<ISyncMgrConflict, SYNCMGR_CONFLICT_ID_INFO*, int>)((*lpVtbl)[4])
        )(this, pConflictIdInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetItemsArray(ISyncMgrConflictItems* ppArray)
    {
        return ((delegate* unmanaged<ISyncMgrConflict, ISyncMgrConflictItems*, int>)((*lpVtbl)[5]))(
            this,
            ppArray
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Resolve(ISyncMgrConflictResolveInfo pResolveInfo)
    {
        return (
            (delegate* unmanaged<ISyncMgrConflict, ISyncMgrConflictResolveInfo, int>)((*lpVtbl)[6])
        )(this, pResolveInfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetResolutionHandler(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppvResolutionHandler
    )
    {
        return ((delegate* unmanaged<ISyncMgrConflict, Guid*, void**, int>)((*lpVtbl)[7]))(
            this,
            riid,
            ppvResolutionHandler
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetProperty(
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
            PROPVARIANT* ppropvar
        );

        [VtblIndex(4)]
        HRESULT GetConflictIdInfo(SYNCMGR_CONFLICT_ID_INFO* pConflictIdInfo);

        [VtblIndex(5)]
        HRESULT GetItemsArray(ISyncMgrConflictItems* ppArray);

        [VtblIndex(6)]
        HRESULT Resolve(ISyncMgrConflictResolveInfo pResolveInfo);

        [VtblIndex(7)]
        HRESULT GetResolutionHandler(
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppvResolutionHandler
        );
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

        [NativeTypeName("HRESULT (const PROPERTYKEY &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, PROPVARIANT*, int> GetProperty;

        [NativeTypeName("HRESULT (SYNCMGR_CONFLICT_ID_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SYNCMGR_CONFLICT_ID_INFO*, int> GetConflictIdInfo;

        [NativeTypeName("HRESULT (ISyncMgrConflictItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISyncMgrConflictItems*, int> GetItemsArray;

        [NativeTypeName("HRESULT (ISyncMgrConflictResolveInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISyncMgrConflictResolveInfo, int> Resolve;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> GetResolutionHandler;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISyncMgrConflict"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISyncMgrConflict(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISyncMgrConflict"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISyncMgrConflict(Silk.NET.Windows.IUnknown value)
    {
        return new ISyncMgrConflict(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISyncMgrConflict"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISyncMgrConflict"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISyncMgrConflict value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
