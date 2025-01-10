// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D20F1388-8256-597C-8511-C84EC50D5E2B")]
[NativeTypeName("struct IAppInstallerInfo2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppInstallerInfo2 : IAppInstallerInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppInstallerInfo2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppInstallerInfo2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OnLaunch([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_HoursBetweenUpdateChecks([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, uint*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ShowPrompt([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_UpdateBlocksActivation([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, byte*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_AutomaticBackgroundTask([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ForceUpdateFromAnyVersion([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, byte*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsAutoRepairEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, byte*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Version(
        [NativeTypeName("ABI::Windows::ApplicationModel::PackageVersion *")] PackageVersion* value
    )
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, PackageVersion*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_LastChecked(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IAppInstallerInfo2, WinRTDateTime*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_PausedUntil(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
        )]
            IReference<DateTime>** value
    )
    {
        return (
            (delegate* unmanaged<IAppInstallerInfo2, IReference<DateTime>**, int>)((*lpVtbl)[15])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_UpdateUris(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IAppInstallerInfo2, IVectorView<IntPtr>**, int>)((*lpVtbl)[16])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_RepairUris(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IAppInstallerInfo2, IVectorView<IntPtr>**, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_DependencyPackageUris(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IAppInstallerInfo2, IVectorView<IntPtr>**, int>)((*lpVtbl)[18])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_OptionalPackageUris(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **"
        )]
            IVectorView<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IAppInstallerInfo2, IVectorView<IntPtr>**, int>)((*lpVtbl)[19])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_PolicySource(
        [NativeTypeName("ABI::Windows::ApplicationModel::AppInstallerPolicySource *")]
            AppInstallerPolicySource* value
    )
    {
        return (
            (delegate* unmanaged<IAppInstallerInfo2, AppInstallerPolicySource*, int>)((*lpVtbl)[20])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OnLaunch([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_HoursBetweenUpdateChecks([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        HRESULT get_ShowPrompt([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_UpdateBlocksActivation([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_AutomaticBackgroundTask([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_ForceUpdateFromAnyVersion([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_IsAutoRepairEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT get_Version(
            [NativeTypeName("ABI::Windows::ApplicationModel::PackageVersion *")]
                PackageVersion* value
        );

        [VtblIndex(14)]
        HRESULT get_LastChecked(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(15)]
        HRESULT get_PausedUntil(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **"
            )]
                IReference<DateTime>** value
        );

        [VtblIndex(16)]
        HRESULT get_UpdateUris(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(17)]
        HRESULT get_RepairUris(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(18)]
        HRESULT get_DependencyPackageUris(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(19)]
        HRESULT get_OptionalPackageUris(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **"
            )]
                IVectorView<IntPtr>** value
        );

        [VtblIndex(20)]
        HRESULT get_PolicySource(
            [NativeTypeName("ABI::Windows::ApplicationModel::AppInstallerPolicySource *")]
                AppInstallerPolicySource* value
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_OnLaunch;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_HoursBetweenUpdateChecks;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ShowPrompt;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_UpdateBlocksActivation;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_AutomaticBackgroundTask;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_ForceUpdateFromAnyVersion;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsAutoRepairEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::PackageVersion *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PackageVersion*, int> get_Version;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_LastChecked;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_Windows__CFoundation__CDateTime_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<DateTime>**, int> get_PausedUntil;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_UpdateUris;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_RepairUris;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_DependencyPackageUris;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CFoundation__CUri_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVectorView<IntPtr>**, int> get_OptionalPackageUris;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::AppInstallerPolicySource *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, AppInstallerPolicySource*, int> get_PolicySource;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppInstallerInfo2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppInstallerInfo2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppInstallerInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppInstallerInfo2(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppInstallerInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppInstallerInfo2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppInstallerInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppInstallerInfo2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppInstallerInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppInstallerInfo2(Silk.NET.Windows.IUnknown value)
    {
        return new IAppInstallerInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppInstallerInfo2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppInstallerInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppInstallerInfo2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
