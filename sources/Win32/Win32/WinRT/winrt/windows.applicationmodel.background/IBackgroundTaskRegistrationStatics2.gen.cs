// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("174B671E-B20D-4FA9-AD9A-E93AD6C71E01")]
[NativeTypeName("struct IBackgroundTaskRegistrationStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundTaskRegistrationStatics2
    : IBackgroundTaskRegistrationStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundTaskRegistrationStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBackgroundTaskRegistrationStatics2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBackgroundTaskRegistrationStatics2, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundTaskRegistrationStatics2, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBackgroundTaskRegistrationStatics2, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBackgroundTaskRegistrationStatics2, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBackgroundTaskRegistrationStatics2, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_AllTaskGroups(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistrationGroup_t **"
        )]
            IMapView<HSTRING, IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundTaskRegistrationStatics2,
                IMapView<HSTRING, IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetTaskGroup(
        HSTRING groupId,
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **"
        )]
            IBackgroundTaskRegistrationGroup* value
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundTaskRegistrationStatics2,
                HSTRING,
                IBackgroundTaskRegistrationGroup*,
                int>)((*lpVtbl)[7])
        )(this, groupId, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_AllTaskGroups(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistrationGroup_t **"
            )]
                IMapView<HSTRING, IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT GetTaskGroup(
            HSTRING groupId,
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **"
            )]
                IBackgroundTaskRegistrationGroup* value
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CApplicationModel__CBackground__CBackgroundTaskRegistrationGroup_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMapView<HSTRING, IntPtr>**, int> get_AllTaskGroups;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Background::IBackgroundTaskRegistrationGroup **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IBackgroundTaskRegistrationGroup*,
            int> GetTaskGroup;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundTaskRegistrationStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundTaskRegistrationStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundTaskRegistrationStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundTaskRegistrationStatics2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBackgroundTaskRegistrationStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTaskRegistrationStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTaskRegistrationStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBackgroundTaskRegistrationStatics2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundTaskRegistrationStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundTaskRegistrationStatics2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBackgroundTaskRegistrationStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundTaskRegistrationStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundTaskRegistrationStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBackgroundTaskRegistrationStatics2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
