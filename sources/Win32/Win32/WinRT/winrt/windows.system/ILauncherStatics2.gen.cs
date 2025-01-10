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

[Guid("59BA2FBB-24CB-4C02-A4C4-8294569D54F1")]
[NativeTypeName("struct ILauncherStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ILauncherStatics2 : ILauncherStatics2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ILauncherStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ILauncherStatics2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ILauncherStatics2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ILauncherStatics2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ILauncherStatics2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ILauncherStatics2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ILauncherStatics2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LaunchUriForResultsAsync(
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
                ILauncherStatics2,
                IUriRuntimeClass,
                ILauncherOptions,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, uri, options, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LaunchUriForResultsWithDataAsync(
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
                ILauncherStatics2,
                IUriRuntimeClass,
                ILauncherOptions,
                IPropertySet,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, uri, options, inputData, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LaunchUriWithDataAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet inputData,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics2,
                IUriRuntimeClass,
                ILauncherOptions,
                IPropertySet,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[8])
        )(this, uri, options, inputData, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT QueryUriSupportAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")]
            LaunchQuerySupportType launchQuerySupportType,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
        )]
            IAsyncOperation<LaunchQuerySupportStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics2,
                IUriRuntimeClass,
                LaunchQuerySupportType,
                IAsyncOperation<LaunchQuerySupportStatus>**,
                int>)((*lpVtbl)[9])
        )(this, uri, launchQuerySupportType, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT QueryUriSupportWithPackageFamilyNameAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")]
            LaunchQuerySupportType launchQuerySupportType,
        HSTRING packageFamilyName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
        )]
            IAsyncOperation<LaunchQuerySupportStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics2,
                IUriRuntimeClass,
                LaunchQuerySupportType,
                HSTRING,
                IAsyncOperation<LaunchQuerySupportStatus>**,
                int>)((*lpVtbl)[10])
        )(this, uri, launchQuerySupportType, packageFamilyName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT QueryFileSupportAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
        )]
            IAsyncOperation<LaunchQuerySupportStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics2,
                IStorageFile,
                IAsyncOperation<LaunchQuerySupportStatus>**,
                int>)((*lpVtbl)[11])
        )(this, file, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT QueryFileSupportWithPackageFamilyNameAsync(
        [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
        HSTRING packageFamilyName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
        )]
            IAsyncOperation<LaunchQuerySupportStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics2,
                IStorageFile,
                HSTRING,
                IAsyncOperation<LaunchQuerySupportStatus>**,
                int>)((*lpVtbl)[12])
        )(this, file, packageFamilyName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT FindUriSchemeHandlersAsync(
        HSTRING scheme,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<ILauncherStatics2, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[13]
            )
        )(this, scheme, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT FindUriSchemeHandlersWithLaunchUriTypeAsync(
        HSTRING scheme,
        [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")]
            LaunchQuerySupportType launchQuerySupportType,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ILauncherStatics2,
                HSTRING,
                LaunchQuerySupportType,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[14])
        )(this, scheme, launchQuerySupportType, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT FindFileHandlersAsync(
        HSTRING extension,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<ILauncherStatics2, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[15]
            )
        )(this, extension, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT LaunchUriForResultsAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT LaunchUriForResultsWithDataAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet inputData,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(8)]
        HRESULT LaunchUriWithDataAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::System::ILauncherOptions *")] ILauncherOptions options,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet inputData,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(9)]
        HRESULT QueryUriSupportAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")]
                LaunchQuerySupportType launchQuerySupportType,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
            )]
                IAsyncOperation<LaunchQuerySupportStatus>** operation
        );

        [VtblIndex(10)]
        HRESULT QueryUriSupportWithPackageFamilyNameAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")]
                LaunchQuerySupportType launchQuerySupportType,
            HSTRING packageFamilyName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
            )]
                IAsyncOperation<LaunchQuerySupportStatus>** operation
        );

        [VtblIndex(11)]
        HRESULT QueryFileSupportAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
            )]
                IAsyncOperation<LaunchQuerySupportStatus>** operation
        );

        [VtblIndex(12)]
        HRESULT QueryFileSupportWithPackageFamilyNameAsync(
            [NativeTypeName("ABI::Windows::Storage::IStorageFile *")] IStorageFile file,
            HSTRING packageFamilyName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **"
            )]
                IAsyncOperation<LaunchQuerySupportStatus>** operation
        );

        [VtblIndex(13)]
        HRESULT FindUriSchemeHandlersAsync(
            HSTRING scheme,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(14)]
        HRESULT FindUriSchemeHandlersWithLaunchUriTypeAsync(
            HSTRING scheme,
            [NativeTypeName("ABI::Windows::System::LaunchQuerySupportType")]
                LaunchQuerySupportType launchQuerySupportType,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(15)]
        HRESULT FindFileHandlersAsync(
            HSTRING extension,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **"
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
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            ILauncherOptions,
            IAsyncOperation<IntPtr>**,
            int> LaunchUriForResultsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchUriResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            ILauncherOptions,
            IPropertySet,
            IAsyncOperation<IntPtr>**,
            int> LaunchUriForResultsWithDataAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::ILauncherOptions *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            ILauncherOptions,
            IPropertySet,
            IAsyncOperation<byte>**,
            int> LaunchUriWithDataAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::LaunchQuerySupportType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            LaunchQuerySupportType,
            IAsyncOperation<LaunchQuerySupportStatus>**,
            int> QueryUriSupportAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::LaunchQuerySupportType, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUriRuntimeClass,
            LaunchQuerySupportType,
            HSTRING,
            IAsyncOperation<LaunchQuerySupportStatus>**,
            int> QueryUriSupportWithPackageFamilyNameAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            IAsyncOperation<LaunchQuerySupportStatus>**,
            int> QueryFileSupportAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageFile *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CLaunchQuerySupportStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageFile,
            HSTRING,
            IAsyncOperation<LaunchQuerySupportStatus>**,
            int> QueryFileSupportWithPackageFamilyNameAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> FindUriSchemeHandlersAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::System::LaunchQuerySupportType, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            LaunchQuerySupportType,
            IAsyncOperation<IntPtr>**,
            int> FindUriSchemeHandlersWithLaunchUriTypeAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CAppInfo_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> FindFileHandlersAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ILauncherStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ILauncherStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ILauncherStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ILauncherStatics2(Silk.NET.WinRT.IInspectable value)
    {
        return new ILauncherStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILauncherStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ILauncherStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ILauncherStatics2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ILauncherStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ILauncherStatics2(Silk.NET.Windows.IUnknown value)
    {
        return new ILauncherStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ILauncherStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ILauncherStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ILauncherStatics2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
