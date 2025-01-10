// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("329788BA-E513-4F06-889D-1BE30ECF43E6")]
[NativeTypeName("struct ISpatialEntityStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialEntityStore : ISpatialEntityStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialEntityStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialEntityStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpatialEntityStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialEntityStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpatialEntityStore, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpatialEntityStore, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpatialEntityStore, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SaveAsync(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity *")]
            ISpatialEntity entity,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* action
    )
    {
        return (
            (delegate* unmanaged<ISpatialEntityStore, ISpatialEntity, IAsyncAction*, int>)(
                (*lpVtbl)[6]
            )
        )(this, entity, action);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RemoveAsync(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity *")]
            ISpatialEntity entity,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* action
    )
    {
        return (
            (delegate* unmanaged<ISpatialEntityStore, ISpatialEntity, IAsyncAction*, int>)(
                (*lpVtbl)[7]
            )
        )(this, entity, action);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateEntityWatcher(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntityWatcher **")]
            ISpatialEntityWatcher* value
    )
    {
        return (
            (delegate* unmanaged<ISpatialEntityStore, ISpatialEntityWatcher*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT SaveAsync(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity *")]
                ISpatialEntity entity,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* action
        );

        [VtblIndex(7)]
        HRESULT RemoveAsync(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity *")]
                ISpatialEntity entity,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* action
        );

        [VtblIndex(8)]
        HRESULT CreateEntityWatcher(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntityWatcher **")]
                ISpatialEntityWatcher* value
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialEntity *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpatialEntity, IAsyncAction*, int> SaveAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialEntity *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpatialEntity, IAsyncAction*, int> RemoveAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialEntityWatcher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISpatialEntityWatcher*, int> CreateEntityWatcher;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialEntityStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialEntityStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpatialEntityStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpatialEntityStore(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpatialEntityStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialEntityStore"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialEntityStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpatialEntityStore value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialEntityStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialEntityStore(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialEntityStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialEntityStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialEntityStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialEntityStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
