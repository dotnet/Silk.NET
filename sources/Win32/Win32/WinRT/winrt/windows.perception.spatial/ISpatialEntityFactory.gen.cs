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

[Guid("E1F1E325-349F-4225-A2F3-4B01C15FE056")]
[NativeTypeName("struct ISpatialEntityFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialEntityFactory : ISpatialEntityFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialEntityFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialEntityFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpatialEntityFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialEntityFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpatialEntityFactory, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpatialEntityFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpatialEntityFactory, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateWithSpatialAnchor(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")]
            ISpatialAnchor spatialAnchor,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity **")]
            ISpatialEntity* value
    )
    {
        return (
            (delegate* unmanaged<ISpatialEntityFactory, ISpatialAnchor, ISpatialEntity*, int>)(
                (*lpVtbl)[6]
            )
        )(this, spatialAnchor, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithSpatialAnchorAndProperties(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")]
            ISpatialAnchor spatialAnchor,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet propertySet,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity **")]
            ISpatialEntity* value
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialEntityFactory,
                ISpatialAnchor,
                IPropertySet,
                ISpatialEntity*,
                int>)((*lpVtbl)[7])
        )(this, spatialAnchor, propertySet, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateWithSpatialAnchor(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")]
                ISpatialAnchor spatialAnchor,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity **")]
                ISpatialEntity* value
        );

        [VtblIndex(7)]
        HRESULT CreateWithSpatialAnchorAndProperties(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")]
                ISpatialAnchor spatialAnchor,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet propertySet,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialEntity **")]
                ISpatialEntity* value
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
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialAnchor *, ABI::Windows::Perception::Spatial::ISpatialEntity **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialAnchor,
            ISpatialEntity*,
            int> CreateWithSpatialAnchor;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialAnchor *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Perception::Spatial::ISpatialEntity **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialAnchor,
            IPropertySet,
            ISpatialEntity*,
            int> CreateWithSpatialAnchorAndProperties;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialEntityFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialEntityFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpatialEntityFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpatialEntityFactory(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpatialEntityFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialEntityFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialEntityFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpatialEntityFactory value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialEntityFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialEntityFactory(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialEntityFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialEntityFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialEntityFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialEntityFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
