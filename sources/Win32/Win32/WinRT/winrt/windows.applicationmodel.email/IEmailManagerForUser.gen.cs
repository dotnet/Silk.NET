// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("F773DE9F-3CA5-4B0F-90C1-156E40174CE5")]
[NativeTypeName("struct IEmailManagerForUser : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailManagerForUser : IEmailManagerForUser.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailManagerForUser));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEmailManagerForUser, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEmailManagerForUser, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailManagerForUser, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IEmailManagerForUser, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailManagerForUser, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailManagerForUser, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ShowComposeNewEmailAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
            IEmailMessage message,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IEmailManagerForUser, IEmailMessage, IAsyncAction*, int>)(
                (*lpVtbl)[6]
            )
        )(this, message, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RequestStoreAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailStoreAccessType")]
            EmailStoreAccessType accessType,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailStore_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailManagerForUser,
                EmailStoreAccessType,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, accessType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value)
    {
        return ((delegate* unmanaged<IEmailManagerForUser, IUser*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ShowComposeNewEmailAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
                IEmailMessage message,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(7)]
        HRESULT RequestStoreAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailStoreAccessType")]
                EmailStoreAccessType accessType,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailStore_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(8)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value);
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
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEmailMessage,
            IAsyncAction*,
            int> ShowComposeNewEmailAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailStoreAccessType, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailStore_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EmailStoreAccessType,
            IAsyncOperation<IntPtr>**,
            int> RequestStoreAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUser*, int> get_User;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailManagerForUser"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailManagerForUser(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailManagerForUser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailManagerForUser(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailManagerForUser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailManagerForUser"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailManagerForUser"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailManagerForUser value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailManagerForUser"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailManagerForUser(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailManagerForUser(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailManagerForUser"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailManagerForUser"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailManagerForUser value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
