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

[Guid("98A5D3F6-5A25-5B6C-9192-D77A43DFEDC4")]
[NativeTypeName("struct IBackgroundExecutionManagerStatics3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IBackgroundExecutionManagerStatics3
    : IBackgroundExecutionManagerStatics3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundExecutionManagerStatics3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBackgroundExecutionManagerStatics3, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBackgroundExecutionManagerStatics3, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundExecutionManagerStatics3, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IBackgroundExecutionManagerStatics3, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBackgroundExecutionManagerStatics3, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBackgroundExecutionManagerStatics3, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RequestAccessKindForModernStandbyAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessRequestKind")]
            BackgroundAccessRequestKind requestedAccess,
        HSTRING reason,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundExecutionManagerStatics3,
                BackgroundAccessRequestKind,
                HSTRING,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[6])
        )(this, requestedAccess, reason, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAccessStatusForModernStandby(
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")]
            BackgroundAccessStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundExecutionManagerStatics3,
                BackgroundAccessStatus*,
                int>)((*lpVtbl)[7])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetAccessStatusForModernStandbyForApplication(
        HSTRING applicationId,
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")]
            BackgroundAccessStatus* result
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundExecutionManagerStatics3,
                HSTRING,
                BackgroundAccessStatus*,
                int>)((*lpVtbl)[8])
        )(this, applicationId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT RequestAccessKindForModernStandbyAsync(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Background::BackgroundAccessRequestKind"
            )]
                BackgroundAccessRequestKind requestedAccess,
            HSTRING reason,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(7)]
        HRESULT GetAccessStatusForModernStandby(
            [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")]
                BackgroundAccessStatus* result
        );

        [VtblIndex(8)]
        HRESULT GetAccessStatusForModernStandbyForApplication(
            HSTRING applicationId,
            [NativeTypeName("ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *")]
                BackgroundAccessStatus* result
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
            "HRESULT (ABI::Windows::ApplicationModel::Background::BackgroundAccessRequestKind, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BackgroundAccessRequestKind,
            HSTRING,
            IAsyncOperation<byte>**,
            int> RequestAccessKindForModernStandbyAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            BackgroundAccessStatus*,
            int> GetAccessStatusForModernStandby;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Background::BackgroundAccessStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            BackgroundAccessStatus*,
            int> GetAccessStatusForModernStandbyForApplication;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundExecutionManagerStatics3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundExecutionManagerStatics3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundExecutionManagerStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundExecutionManagerStatics3(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBackgroundExecutionManagerStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundExecutionManagerStatics3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundExecutionManagerStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBackgroundExecutionManagerStatics3 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundExecutionManagerStatics3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundExecutionManagerStatics3(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBackgroundExecutionManagerStatics3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundExecutionManagerStatics3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundExecutionManagerStatics3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBackgroundExecutionManagerStatics3 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
