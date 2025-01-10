// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B9EC819F-B5A5-41C6-B3B3-DD1B3178BCF2")]
[NativeTypeName("struct ILauncherStatics4 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILauncherStatics4 : ILauncherStatics4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILauncherStatics4));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILauncherStatics4, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ILauncherStatics4, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILauncherStatics4, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ILauncherStatics4, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ILauncherStatics4, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ILauncherStatics4, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT QueryAppUriSupportAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
        )]
            IAsyncOperation<LaunchQuerySupportStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics4,
                IUriRuntimeClass,
                IAsyncOperation<LaunchQuerySupportStatus>**,
                int>)((*lpVtbl)[6])
        )(this, uri, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT QueryAppUriSupportWithPackageFamilyNameAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        HSTRING packageFamilyName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
        )]
            IAsyncOperation<LaunchQuerySupportStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics4,
                IUriRuntimeClass,
                HSTRING,
                IAsyncOperation<LaunchQuerySupportStatus>**,
                int>)((*lpVtbl)[7])
        )(this, uri, packageFamilyName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindAppUriHandlersAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics4,
                IUriRuntimeClass,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[8])
        )(this, uri, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT LaunchUriForUserAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **"
        )]
            IAsyncOperation<LaunchUriStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics4,
                IUser,
                IUriRuntimeClass,
                IAsyncOperation<LaunchUriStatus>**,
                int>)((*lpVtbl)[9])
        )(this, user, uri, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT LaunchUriWithOptionsForUserAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **"
        )]
            IAsyncOperation<LaunchUriStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics4,
                IUser,
                IUriRuntimeClass,
                ILauncherOptions,
                IAsyncOperation<LaunchUriStatus>**,
                int>)((*lpVtbl)[10])
        )(this, user, uri, options, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT LaunchUriWithDataForUserAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet inputData,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **"
        )]
            IAsyncOperation<LaunchUriStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics4,
                IUser,
                IUriRuntimeClass,
                ILauncherOptions,
                IPropertySet,
                IAsyncOperation<LaunchUriStatus>**,
                int>)((*lpVtbl)[11])
        )(this, user, uri, options, inputData, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT LaunchUriForResultsForUserAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics4,
                IUser,
                IUriRuntimeClass,
                ILauncherOptions,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[12])
        )(this, user, uri, options, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT LaunchUriForResultsWithDataForUserAsync(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet inputData,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics4,
                IUser,
                IUriRuntimeClass,
                ILauncherOptions,
                IPropertySet,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[13])
        )(this, user, uri, options, inputData, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT QueryAppUriSupportAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
            )]
                IAsyncOperation<LaunchQuerySupportStatus>** operation
        );

        [VtblIndex(7)]
        HRESULT QueryAppUriSupportWithPackageFamilyNameAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            HSTRING packageFamilyName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
            )]
                IAsyncOperation<LaunchQuerySupportStatus>** operation
        );

        [VtblIndex(8)]
        HRESULT FindAppUriHandlersAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(9)]
        HRESULT LaunchUriForUserAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **"
            )]
                IAsyncOperation<LaunchUriStatus>** operation
        );

        [VtblIndex(10)]
        HRESULT LaunchUriWithOptionsForUserAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **"
            )]
                IAsyncOperation<LaunchUriStatus>** operation
        );

        [VtblIndex(11)]
        HRESULT LaunchUriWithDataForUserAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet inputData,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **"
            )]
                IAsyncOperation<LaunchUriStatus>** operation
        );

        [VtblIndex(12)]
        HRESULT LaunchUriForResultsForUserAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(13)]
        HRESULT LaunchUriForResultsWithDataForUserAsync(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet inputData,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IAsyncOperation<LaunchQuerySupportStatus>**,
            int> QueryAppUriSupportAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            HSTRING,
            IAsyncOperation<LaunchQuerySupportStatus>**,
            int> QueryAppUriSupportWithPackageFamilyNameAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            IAsyncOperation<IntPtr>**,
            int> FindAppUriHandlersAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            IUriRuntimeClass,
            IAsyncOperation<LaunchUriStatus>**,
            int> LaunchUriForUserAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            IUriRuntimeClass,
            ILauncherOptions,
            IAsyncOperation<LaunchUriStatus>**,
            int> LaunchUriWithOptionsForUserAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            IUriRuntimeClass,
            ILauncherOptions,
            IPropertySet,
            IAsyncOperation<LaunchUriStatus>**,
            int> LaunchUriWithDataForUserAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            IUriRuntimeClass,
            ILauncherOptions,
            IAsyncOperation<IntPtr>**,
            int> LaunchUriForResultsForUserAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            IUriRuntimeClass,
            ILauncherOptions,
            IPropertySet,
            IAsyncOperation<IntPtr>**,
            int> LaunchUriForResultsWithDataForUserAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILauncherStatics4"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILauncherStatics4(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ILauncherStatics4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ILauncherStatics4(Silk.NET.WinRT.IInspectable value)
    {
        return new ILauncherStatics4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILauncherStatics4"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ILauncherStatics4"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ILauncherStatics4 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILauncherStatics4"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILauncherStatics4(Silk.NET.Windows.IUnknown value)
    {
        return new ILauncherStatics4(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILauncherStatics4"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILauncherStatics4"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ILauncherStatics4 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
