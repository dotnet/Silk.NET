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

[Guid("E826EA58-66A9-4D41-83D4-B4C18C87B846")]
[NativeTypeName("struct IBackgroundExecutionManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundExecutionManagerStatics
    : IBackgroundExecutionManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundExecutionManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBackgroundExecutionManagerStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBackgroundExecutionManagerStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundExecutionManagerStatics, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IBackgroundExecutionManagerStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBackgroundExecutionManagerStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBackgroundExecutionManagerStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **"
        )]
            IAsyncOperation<BackgroundAccessStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundExecutionManagerStatics,
                IAsyncOperation<BackgroundAccessStatus>**,
                int>)((*lpVtbl)[6])
        )(this, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestAccessForApplicationAsync(
        HSTRING applicationId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **"
        )]
            IAsyncOperation<BackgroundAccessStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundExecutionManagerStatics,
                HSTRING,
                IAsyncOperation<BackgroundAccessStatus>**,
                int>)((*lpVtbl)[7])
        )(this, applicationId, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveAccess()
    {
        return ((delegate* unmanaged<IBackgroundExecutionManagerStatics, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RemoveAccessForApplication(HSTRING applicationId)
    {
        return (
            (delegate* unmanaged<IBackgroundExecutionManagerStatics, HSTRING, int>)((*lpVtbl)[9])
        )(this, applicationId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetAccessStatus(
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")]
            BackgroundAccessStatus* status
    )
    {
        return (
            (delegate* unmanaged<IBackgroundExecutionManagerStatics, BackgroundAccessStatus*, int>)(
                (*lpVtbl)[10]
            )
        )(this, status);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetAccessStatusForApplication(
        HSTRING applicationId,
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")]
            BackgroundAccessStatus* status
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundExecutionManagerStatics,
                HSTRING,
                BackgroundAccessStatus*,
                int>)((*lpVtbl)[11])
        )(this, applicationId, status);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **"
            )]
                IAsyncOperation<BackgroundAccessStatus>** operation
        );

        [VtblIndex(7)]
        HRESULT RequestAccessForApplicationAsync(
            HSTRING applicationId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **"
            )]
                IAsyncOperation<BackgroundAccessStatus>** operation
        );

        [VtblIndex(8)]
        HRESULT RemoveAccess();

        [VtblIndex(9)]
        HRESULT RemoveAccessForApplication(HSTRING applicationId);

        [VtblIndex(10)]
        HRESULT GetAccessStatus(
            [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")]
                BackgroundAccessStatus* status
        );

        [VtblIndex(11)]
        HRESULT GetAccessStatusForApplication(
            HSTRING applicationId,
            [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")]
                BackgroundAccessStatus* status
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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<BackgroundAccessStatus>**,
            int> RequestAccessAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CBackground__CBackgroundAccessStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<BackgroundAccessStatus>**,
            int> RequestAccessForApplicationAsync;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAccess;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> RemoveAccessForApplication;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BackgroundAccessStatus*, int> GetAccessStatus;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            BackgroundAccessStatus*,
            int> GetAccessStatusForApplication;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundExecutionManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundExecutionManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundExecutionManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundExecutionManagerStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBackgroundExecutionManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundExecutionManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundExecutionManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBackgroundExecutionManagerStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundExecutionManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundExecutionManagerStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBackgroundExecutionManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundExecutionManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundExecutionManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBackgroundExecutionManagerStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
