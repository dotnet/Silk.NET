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

[Guid("7DB165E6-6264-56F4-5E03-C86385395EB1")]
[NativeTypeName("struct ISmartCardAppletIdGroup : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISmartCardAppletIdGroup
    : ISmartCardAppletIdGroup.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmartCardAppletIdGroup));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroup, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISmartCardAppletIdGroup, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroup, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroup, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroup, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroup, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroup, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroup, HSTRING, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AppletIds(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **"
        )]
            IVector<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroup, IVector<IntPtr>**, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_SmartCardEmulationCategory(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory *")]
            SmartCardEmulationCategory* value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroup, SmartCardEmulationCategory*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_SmartCardEmulationCategory(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory")]
            SmartCardEmulationCategory value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroup, SmartCardEmulationCategory, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_SmartCardEmulationType(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType *")]
            SmartCardEmulationType* value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroup, SmartCardEmulationType*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_SmartCardEmulationType(
        [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType")]
            SmartCardEmulationType value
    )
    {
        return (
            (delegate* unmanaged<ISmartCardAppletIdGroup, SmartCardEmulationType, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_AutomaticEnablement([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroup, byte*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_AutomaticEnablement([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ISmartCardAppletIdGroup, byte, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_AppletIds(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **"
            )]
                IVector<IntPtr>** value
        );

        [VtblIndex(9)]
        HRESULT get_SmartCardEmulationCategory(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory *")]
                SmartCardEmulationCategory* value
        );

        [VtblIndex(10)]
        HRESULT put_SmartCardEmulationCategory(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory")]
                SmartCardEmulationCategory value
        );

        [VtblIndex(11)]
        HRESULT get_SmartCardEmulationType(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType *")]
                SmartCardEmulationType* value
        );

        [VtblIndex(12)]
        HRESULT put_SmartCardEmulationType(
            [NativeTypeName("ABI::Windows::Devices::SmartCards::SmartCardEmulationType")]
                SmartCardEmulationType value
        );

        [VtblIndex(13)]
        HRESULT get_AutomaticEnablement([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_AutomaticEnablement([NativeTypeName("boolean")] byte value);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CStorage__CStreams__CIBuffer_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<IntPtr>**, int> get_AppletIds;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardEmulationCategory*,
            int> get_SmartCardEmulationCategory;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardEmulationCategory) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SmartCardEmulationCategory,
            int> put_SmartCardEmulationCategory;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardEmulationType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmartCardEmulationType*, int> get_SmartCardEmulationType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::SmartCards::SmartCardEmulationType) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SmartCardEmulationType, int> put_SmartCardEmulationType;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AutomaticEnablement;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_AutomaticEnablement;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmartCardAppletIdGroup"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmartCardAppletIdGroup(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmartCardAppletIdGroup"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmartCardAppletIdGroup(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmartCardAppletIdGroup(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardAppletIdGroup"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardAppletIdGroup"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmartCardAppletIdGroup value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmartCardAppletIdGroup"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmartCardAppletIdGroup(Silk.NET.Windows.IUnknown value)
    {
        return new ISmartCardAppletIdGroup(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmartCardAppletIdGroup"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmartCardAppletIdGroup"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmartCardAppletIdGroup value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
