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

[Guid("A24F7771-996C-4864-B1BA-ED1240E57D11")]
[NativeTypeName("struct IEmailFolder : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailFolder : IEmailFolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailFolder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEmailFolder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEmailFolder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailFolder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IEmailFolder, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailFolder, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailFolder, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailFolder, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RemoteId(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailFolder, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_RemoteId(HSTRING value)
    {
        return ((delegate* unmanaged<IEmailFolder, HSTRING, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MailboxId(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailFolder, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ParentFolderId(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailFolder, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailFolder, HSTRING*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged<IEmailFolder, HSTRING, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_IsSyncEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IEmailFolder, byte*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_IsSyncEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailFolder, byte, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_LastSuccessfulSyncTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IEmailFolder, WinRTDateTime*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_LastSuccessfulSyncTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
    )
    {
        return ((delegate* unmanaged<IEmailFolder, WinRTDateTime, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Kind(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind *")]
            EmailSpecialFolderKind* value
    )
    {
        return ((delegate* unmanaged<IEmailFolder, EmailSpecialFolderKind*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateFolderAsync(
        HSTRING name,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailFolder, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[18]
            )
        )(this, name, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT DeleteAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IEmailFolder, IAsyncAction*, int>)((*lpVtbl)[19]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FindChildFoldersAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IEmailFolder, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[20]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetConversationReader(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
            IEmailConversationReader* result
    )
    {
        return ((delegate* unmanaged<IEmailFolder, IEmailConversationReader*, int>)((*lpVtbl)[21]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT GetConversationReaderWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
            IEmailQueryOptions options,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
            IEmailConversationReader* result
    )
    {
        return (
            (delegate* unmanaged<IEmailFolder, IEmailQueryOptions, IEmailConversationReader*, int>)(
                (*lpVtbl)[22]
            )
        )(this, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT GetMessageAsync(
        HSTRING id,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailFolder, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[23]
            )
        )(this, id, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetMessageReader(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
            IEmailMessageReader* result
    )
    {
        return ((delegate* unmanaged<IEmailFolder, IEmailMessageReader*, int>)((*lpVtbl)[24]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetMessageReaderWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
            IEmailQueryOptions options,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
            IEmailMessageReader* result
    )
    {
        return (
            (delegate* unmanaged<IEmailFolder, IEmailQueryOptions, IEmailMessageReader*, int>)(
                (*lpVtbl)[25]
            )
        )(this, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetMessageCountsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailItemCounts_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return ((delegate* unmanaged<IEmailFolder, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[26]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT TryMoveAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder *")]
            IEmailFolder newParentFolder,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailFolder, IEmailFolder, IAsyncOperation<byte>**, int>)(
                (*lpVtbl)[27]
            )
        )(this, newParentFolder, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT TryMoveWithNewNameAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder *")]
            IEmailFolder newParentFolder,
        HSTRING newFolderName,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailFolder,
                IEmailFolder,
                HSTRING,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[28])
        )(this, newParentFolder, newFolderName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT TrySaveAsync(
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return ((delegate* unmanaged<IEmailFolder, IAsyncOperation<byte>**, int>)((*lpVtbl)[29]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SaveMessageAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
            IEmailMessage message,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IEmailFolder, IEmailMessage, IAsyncAction*, int>)((*lpVtbl)[30])
        )(this, message, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_RemoteId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_RemoteId(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_MailboxId(HSTRING* value);

        [VtblIndex(10)]
        HRESULT get_ParentFolderId(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(12)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(13)]
        HRESULT get_IsSyncEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT put_IsSyncEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT get_LastSuccessfulSyncTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(16)]
        HRESULT put_LastSuccessfulSyncTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime value
        );

        [VtblIndex(17)]
        HRESULT get_Kind(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind *")]
                EmailSpecialFolderKind* value
        );

        [VtblIndex(18)]
        HRESULT CreateFolderAsync(
            HSTRING name,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(19)]
        HRESULT DeleteAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(20)]
        HRESULT FindChildFoldersAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(21)]
        HRESULT GetConversationReader(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
                IEmailConversationReader* result
        );

        [VtblIndex(22)]
        HRESULT GetConversationReaderWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
                IEmailQueryOptions options,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
                IEmailConversationReader* result
        );

        [VtblIndex(23)]
        HRESULT GetMessageAsync(
            HSTRING id,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(24)]
        HRESULT GetMessageReader(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
                IEmailMessageReader* result
        );

        [VtblIndex(25)]
        HRESULT GetMessageReaderWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
                IEmailQueryOptions options,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
                IEmailMessageReader* result
        );

        [VtblIndex(26)]
        HRESULT GetMessageCountsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailItemCounts_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(27)]
        HRESULT TryMoveAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder *")]
                IEmailFolder newParentFolder,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(28)]
        HRESULT TryMoveWithNewNameAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailFolder *")]
                IEmailFolder newParentFolder,
            HSTRING newFolderName,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(29)]
        HRESULT TrySaveAsync(
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(30)]
        HRESULT SaveMessageAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
                IEmailMessage message,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RemoteId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_RemoteId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MailboxId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ParentFolderId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsSyncEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsSyncEnabled;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_LastSuccessfulSyncTime;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime, int> put_LastSuccessfulSyncTime;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, EmailSpecialFolderKind*, int> get_Kind;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateFolderAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> DeleteAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> FindChildFoldersAsync;

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
            "HRESULT (HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncOperation<IntPtr>**, int> GetMessageAsync;

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
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailItemCounts_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> GetMessageCountsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailFolder *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailFolder, IAsyncOperation<byte>**, int> TryMoveAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailFolder *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEmailFolder,
            HSTRING,
            IAsyncOperation<byte>**,
            int> TryMoveWithNewNameAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<byte>**, int> TrySaveAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMessage, IAsyncAction*, int> SaveMessageAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailFolder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailFolder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailFolder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailFolder(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailFolder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailFolder"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailFolder"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailFolder value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailFolder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailFolder(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailFolder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailFolder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailFolder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailFolder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
