// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("C5AEFD1E-F467-40BA-8566-AB640A441E1D")]
[NativeTypeName("struct IApplicationDataContainer : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IApplicationDataContainer
    : IApplicationDataContainer.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IApplicationDataContainer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IApplicationDataContainer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IApplicationDataContainer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IApplicationDataContainer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IApplicationDataContainer, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IApplicationDataContainer, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IApplicationDataContainer, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Name(HSTRING* value)
    {
        return ((delegate* unmanaged<IApplicationDataContainer, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Locality(
        [NativeTypeName("ABI::Windows::Storage::ApplicationDataLocality *")]
            ApplicationDataLocality* value
    )
    {
        return (
            (delegate* unmanaged<IApplicationDataContainer, ApplicationDataLocality*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Values(
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")]
            IPropertySet* value
    )
    {
        return ((delegate* unmanaged<IApplicationDataContainer, IPropertySet*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Containers(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CStorage__CApplicationDataContainer_t **"
        )]
            IMapView<HSTRING, IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IApplicationDataContainer, IMapView<HSTRING, IntPtr>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT CreateContainer(
        HSTRING name,
        [NativeTypeName("ABI::Windows::Storage::ApplicationDataCreateDisposition")]
            ApplicationDataCreateDisposition disposition,
        [NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")]
            IApplicationDataContainer* container
    )
    {
        return (
            (delegate* unmanaged<
                IApplicationDataContainer,
                HSTRING,
                ApplicationDataCreateDisposition,
                IApplicationDataContainer*,
                int>)((*lpVtbl)[10])
        )(this, name, disposition, container);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT DeleteContainer(HSTRING name)
    {
        return ((delegate* unmanaged<IApplicationDataContainer, HSTRING, int>)((*lpVtbl)[11]))(
            this,
            name
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Name(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_Locality(
            [NativeTypeName("ABI::Windows::Storage::ApplicationDataLocality *")]
                ApplicationDataLocality* value
        );

        [VtblIndex(8)]
        HRESULT get_Values(
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet **")]
                IPropertySet* value
        );

        [VtblIndex(9)]
        HRESULT get_Containers(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CStorage__CApplicationDataContainer_t **"
            )]
                IMapView<HSTRING, IntPtr>** value
        );

        [VtblIndex(10)]
        HRESULT CreateContainer(
            HSTRING name,
            [NativeTypeName("ABI::Windows::Storage::ApplicationDataCreateDisposition")]
                ApplicationDataCreateDisposition disposition,
            [NativeTypeName("ABI::Windows::Storage::IApplicationDataContainer **")]
                IApplicationDataContainer* container
        );

        [VtblIndex(11)]
        HRESULT DeleteContainer(HSTRING name);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Name;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::ApplicationDataLocality *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ApplicationDataLocality*, int> get_Locality;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::IPropertySet **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPropertySet*, int> get_Values;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CStorage__CApplicationDataContainer_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMapView<HSTRING, IntPtr>**, int> get_Containers;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Storage::ApplicationDataCreateDisposition, ABI::Windows::Storage::IApplicationDataContainer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ApplicationDataCreateDisposition,
            IApplicationDataContainer*,
            int> CreateContainer;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> DeleteContainer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IApplicationDataContainer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IApplicationDataContainer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IApplicationDataContainer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IApplicationDataContainer(Silk.NET.WinRT.IInspectable value)
    {
        return new IApplicationDataContainer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationDataContainer"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationDataContainer"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IApplicationDataContainer value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IApplicationDataContainer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IApplicationDataContainer(Silk.NET.Windows.IUnknown value)
    {
        return new IApplicationDataContainer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IApplicationDataContainer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IApplicationDataContainer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IApplicationDataContainer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
