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

[Guid("F803226E-9137-4F8B-A470-279AC3058EB6")]
[NativeTypeName("struct IEmailStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailStore : IEmailStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEmailStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEmailStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IEmailStore, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailStore, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailStore, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindMailboxesAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IEmailStore, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[6]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetConversationReader(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
            IEmailConversationReader* result
    )
    {
        return ((delegate* unmanaged<IEmailStore, IEmailConversationReader*, int>)((*lpVtbl)[7]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetConversationReaderWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
            IEmailQueryOptions options,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
            IEmailConversationReader* result
    )
    {
        return (
            (delegate* unmanaged<IEmailStore, IEmailQueryOptions, IEmailConversationReader*, int>)(
                (*lpVtbl)[8]
            )
        )(this, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetMessageReader(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
            IEmailMessageReader* result
    )
    {
        return ((delegate* unmanaged<IEmailStore, IEmailMessageReader*, int>)((*lpVtbl)[9]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetMessageReaderWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
            IEmailQueryOptions options,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
            IEmailMessageReader* result
    )
    {
        return (
            (delegate* unmanaged<IEmailStore, IEmailQueryOptions, IEmailMessageReader*, int>)(
                (*lpVtbl)[10]
            )
        )(this, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetMailboxAsync(
        HSTRING id,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[11]
            )
        )(this, id, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetConversationAsync(
        HSTRING id,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[12]
            )
        )(this, id, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFolderAsync(
        HSTRING id,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[13]
            )
        )(this, id, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetMessageAsync(
        HSTRING id,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailStore, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[14]
            )
        )(this, id, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CreateMailboxAsync(
        HSTRING accountName,
        HSTRING accountAddress,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailStore, HSTRING, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[15]
            )
        )(this, accountName, accountAddress, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT CreateMailboxInAccountAsync(
        HSTRING accountName,
        HSTRING accountAddress,
        HSTRING userDataAccountId,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailStore,
                HSTRING,
                HSTRING,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[16])
        )(this, accountName, accountAddress, userDataAccountId, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindMailboxesAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT GetConversationReader(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
                IEmailConversationReader* result
        );

        [VtblIndex(8)]
        HRESULT GetConversationReaderWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
                IEmailQueryOptions options,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
                IEmailConversationReader* result
        );

        [VtblIndex(9)]
        HRESULT GetMessageReader(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
                IEmailMessageReader* result
        );

        [VtblIndex(10)]
        HRESULT GetMessageReaderWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
                IEmailQueryOptions options,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
                IEmailMessageReader* result
        );

        [VtblIndex(11)]
        HRESULT GetMailboxAsync(
            HSTRING id,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(12)]
        HRESULT GetConversationAsync(
            HSTRING id,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(13)]
        HRESULT GetFolderAsync(
            HSTRING id,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(14)]
        HRESULT GetMessageAsync(
            HSTRING id,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(15)]
        HRESULT CreateMailboxAsync(
            HSTRING accountName,
            HSTRING accountAddress,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(16)]
        HRESULT CreateMailboxInAccountAsync(
            HSTRING accountName,
            HSTRING accountAddress,
            HSTRING userDataAccountId,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **"
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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> FindMailboxesAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailConversationReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailConversationReader*, int> GetConversationReader;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *, ABI::Windows::ApplicationModel::Email::IEmailConversationReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEmailQueryOptions,
            IEmailConversationReader*,
            int> GetConversationReaderWithOptions;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessageReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMessageReader*, int> GetMessageReader;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *, ABI::Windows::ApplicationModel::Email::IEmailMessageReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEmailQueryOptions,
            IEmailMessageReader*,
            int> GetMessageReaderWithOptions;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetMailboxAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetConversationAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetFolderAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetMessageAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateMailboxAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailbox_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateMailboxInAccountAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailStore(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailStore"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailStore value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailStore(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
