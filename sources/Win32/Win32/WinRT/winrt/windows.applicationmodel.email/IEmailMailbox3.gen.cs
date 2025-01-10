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

[Guid("3DA5897B-458B-408A-8E37-AC8B05D8AF56")]
[NativeTypeName("struct IEmailMailbox3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailbox3 : IEmailMailbox3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailbox3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEmailMailbox3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEmailMailbox3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailMailbox3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IEmailMailbox3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailMailbox3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailMailbox3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ResolveRecipientsAsync(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
            IIterable<HSTRING>* recipients,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailRecipientResolutionResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox3,
                IIterable<HSTRING>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, recipients, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ValidateCertificatesAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *"
        )]
            IIterable<IntPtr>* certificates,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailCertificateValidationStatus_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox3,
                IIterable<IntPtr>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[7])
        )(this, certificates, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT TryEmptyFolderAsync(
        HSTRING folderId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxEmptyFolderStatus_t **"
        )]
            IAsyncOperation<EmailMailboxEmptyFolderStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox3,
                HSTRING,
                IAsyncOperation<EmailMailboxEmptyFolderStatus>**,
                int>)((*lpVtbl)[8])
        )(this, folderId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TryCreateFolderAsync(
        HSTRING parentFolderId,
        HSTRING name,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxCreateFolderResult_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox3, HSTRING, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[9]
            )
        )(this, parentFolderId, name, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TryDeleteFolderAsync(
        HSTRING folderId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxDeleteFolderStatus_t **"
        )]
            IAsyncOperation<EmailMailboxDeleteFolderStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox3,
                HSTRING,
                IAsyncOperation<EmailMailboxDeleteFolderStatus>**,
                int>)((*lpVtbl)[10])
        )(this, folderId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT ResolveRecipientsAsync(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *")]
                IIterable<HSTRING>* recipients,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailRecipientResolutionResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT ValidateCertificatesAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *"
            )]
                IIterable<IntPtr>* certificates,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailCertificateValidationStatus_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(8)]
        HRESULT TryEmptyFolderAsync(
            HSTRING folderId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxEmptyFolderStatus_t **"
            )]
                IAsyncOperation<EmailMailboxEmptyFolderStatus>** result
        );

        [VtblIndex(9)]
        HRESULT TryCreateFolderAsync(
            HSTRING parentFolderId,
            HSTRING name,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxCreateFolderResult_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(10)]
        HRESULT TryDeleteFolderAsync(
            HSTRING folderId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxDeleteFolderStatus_t **"
            )]
                IAsyncOperation<EmailMailboxDeleteFolderStatus>** result
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_HSTRING_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailRecipientResolutionResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<HSTRING>*,
            IAsyncOperation<IntPtr>**,
            int> ResolveRecipientsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSecurity__CCryptography__CCertificates__CCertificate_t *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailCertificateValidationStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IAsyncOperation<IntPtr>**,
            int> ValidateCertificatesAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxEmptyFolderStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<EmailMailboxEmptyFolderStatus>**,
            int> TryEmptyFolderAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxCreateFolderResult_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> TryCreateFolderAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxDeleteFolderStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<EmailMailboxDeleteFolderStatus>**,
            int> TryDeleteFolderAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailMailbox3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailMailbox3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailMailbox3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailMailbox3(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailMailbox3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailbox3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailbox3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailMailbox3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailMailbox3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailMailbox3(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailMailbox3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailbox3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailbox3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailMailbox3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
