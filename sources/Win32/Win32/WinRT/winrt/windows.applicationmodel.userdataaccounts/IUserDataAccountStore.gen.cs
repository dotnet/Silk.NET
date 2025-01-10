// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdataaccounts.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("2073B0AD-7D0A-4E76-BF45-2368F978A59A")]
[NativeTypeName("struct IUserDataAccountStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataAccountStore : IUserDataAccountStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataAccountStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserDataAccountStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUserDataAccountStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserDataAccountStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUserDataAccountStore, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUserDataAccountStore, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUserDataAccountStore, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindAccountsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IUserDataAccountStore, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetAccountAsync(
        HSTRING id,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IUserDataAccountStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[7]
            )
        )(this, id, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateAccountAsync(
        HSTRING userDisplayName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IUserDataAccountStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[8]
            )
        )(this, userDisplayName, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindAccountsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT GetAccountAsync(
            HSTRING id,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(8)]
        HRESULT CreateAccountAsync(
            HSTRING userDisplayName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **"
            )]
                IAsyncOperation<IntPtr>** result
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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> FindAccountsAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetAccountAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CUserDataAccounts__CUserDataAccount_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateAccountAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUserDataAccountStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUserDataAccountStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUserDataAccountStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUserDataAccountStore(Silk.NET.WinRT.IInspectable value)
    {
        return new IUserDataAccountStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataAccountStore"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataAccountStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUserDataAccountStore value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUserDataAccountStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUserDataAccountStore(Silk.NET.Windows.IUnknown value)
    {
        return new IUserDataAccountStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataAccountStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataAccountStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUserDataAccountStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
