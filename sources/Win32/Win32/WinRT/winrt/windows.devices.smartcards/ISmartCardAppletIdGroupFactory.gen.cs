// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.smartcards.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("9105EB4D-4A65-4E41-8061-CBE83F3695E5")]
[NativeTypeName("struct ISmartCardAppletIdGroupFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAppletIdGroupFactory
    : ISmartCardAppletIdGroupFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardAppletIdGroupFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroupFactory, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroupFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroupFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroupFactory, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroupFactory, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroupFactory, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        HSTRING displayName,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t *"
        )]
            IVector<IntPtr>* appletIds,
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory")]
            SmartCardEmulationCategory emulationCategory,
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType")]
            SmartCardEmulationType emulationType,
        [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **")]
            ISmartCardAppletIdGroup* result
    )
    {
        return (
            (delegate* unmanaged<
                ISmartCardAppletIdGroupFactory,
                HSTRING,
                IVector<IntPtr>*,
                SmartCardEmulationCategory,
                SmartCardEmulationType,
                ISmartCardAppletIdGroup*,
                int>)((*lpVtbl)[6])
        )(this, displayName, appletIds, emulationCategory, emulationType, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            HSTRING displayName,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t *"
            )]
                IVector<IntPtr>* appletIds,
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory")]
                SmartCardEmulationCategory emulationCategory,
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType")]
                SmartCardEmulationType emulationType,
            [NativeTypeName("ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **")]
                ISmartCardAppletIdGroup* result
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
            "HRESULT (HSTRING, ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t *, ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory, ABI::Windows::Devices::SmartCards::SmartCardEmulationType, ABI::Windows::Devices::SmartCards::ISmartCardAppletIdGroup **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IVector<IntPtr>*,
            SmartCardEmulationCategory,
            SmartCardEmulationType,
            ISmartCardAppletIdGroup*,
            int> Create;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardAppletIdGroupFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardAppletIdGroupFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardAppletIdGroupFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardAppletIdGroupFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISmartCardAppletIdGroupFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardAppletIdGroupFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardAppletIdGroupFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISmartCardAppletIdGroupFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardAppletIdGroupFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardAppletIdGroupFactory(Silk.NET.Windows.IUnknown value)
    {
        return new ISmartCardAppletIdGroupFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardAppletIdGroupFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardAppletIdGroupFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmartCardAppletIdGroupFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
