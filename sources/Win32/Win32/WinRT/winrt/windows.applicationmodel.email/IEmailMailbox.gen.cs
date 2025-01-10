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

[Guid("A8790649-CF5B-411B-80B1-4A6A1484CE25")]
[NativeTypeName("struct IEmailMailbox : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailbox : IEmailMailbox.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailbox));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEmailMailbox, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEmailMailbox, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailMailbox, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IEmailMailbox, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailMailbox, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Capabilities(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxCapabilities **")]
            IEmailMailboxCapabilities* value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, IEmailMailboxCapabilities*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ChangeTracker(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeTracker **")]
            IEmailMailboxChangeTracker* value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, IEmailMailboxChangeTracker*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_DisplayName(HSTRING value)
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_IsOwnedByCurrentApp([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IEmailMailbox, byte*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsDataEncryptedUnderLock([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IEmailMailbox, byte*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MailAddress(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_MailAddress(HSTRING value)
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_MailAddressAliases(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IEmailMailbox, IVector<HSTRING>**, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_OtherAppReadAccess(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess *")]
            EmailMailboxOtherAppReadAccess* value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, EmailMailboxOtherAppReadAccess*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_OtherAppReadAccess(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess")]
            EmailMailboxOtherAppReadAccess value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, EmailMailboxOtherAppReadAccess, int>)((*lpVtbl)[17])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_OtherAppWriteAccess(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess *")]
            EmailMailboxOtherAppWriteAccess* value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, EmailMailboxOtherAppWriteAccess*, int>)(
                (*lpVtbl)[18]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_OtherAppWriteAccess(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess")]
            EmailMailboxOtherAppWriteAccess value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, EmailMailboxOtherAppWriteAccess, int>)(
                (*lpVtbl)[19]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Policies(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxPolicies **")]
            IEmailMailboxPolicies* value
    )
    {
        return ((delegate* unmanaged<IEmailMailbox, IEmailMailboxPolicies*, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_SourceDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING*, int>)((*lpVtbl)[21]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_SyncManager(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxSyncManager **")]
            IEmailMailboxSyncManager* value
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, IEmailMailboxSyncManager*, int>)((*lpVtbl)[22])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_UserDataAccountId(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING*, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT GetConversationReader(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
            IEmailConversationReader* result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, IEmailConversationReader*, int>)((*lpVtbl)[24])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT GetConversationReaderWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
            IEmailQueryOptions options,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
            IEmailConversationReader* result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox,
                IEmailQueryOptions,
                IEmailConversationReader*,
                int>)((*lpVtbl)[25])
        )(this, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT GetMessageReader(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
            IEmailMessageReader* result
    )
    {
        return ((delegate* unmanaged<IEmailMailbox, IEmailMessageReader*, int>)((*lpVtbl)[26]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT GetMessageReaderWithOptions(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
            IEmailQueryOptions options,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
            IEmailMessageReader* result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, IEmailQueryOptions, IEmailMessageReader*, int>)(
                (*lpVtbl)[27]
            )
        )(this, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT DeleteAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IEmailMailbox, IAsyncAction*, int>)((*lpVtbl)[28]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT GetConversationAsync(
        HSTRING id,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[29]
            )
        )(this, id, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT GetFolderAsync(
        HSTRING id,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[30]
            )
        )(this, id, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetMessageAsync(
        HSTRING id,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, HSTRING, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[31]
            )
        )(this, id, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT GetSpecialFolderAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind")]
            EmailSpecialFolderKind folderType,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox,
                EmailSpecialFolderKind,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[32])
        )(this, folderType, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT SaveAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IEmailMailbox, IAsyncAction*, int>)((*lpVtbl)[33]))(
            this,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(34)]
    public HRESULT MarkMessageAsSeenAsync(
        HSTRING messageId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING, IAsyncAction*, int>)((*lpVtbl)[34]))(
            this,
            messageId,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(35)]
    public HRESULT MarkFolderAsSeenAsync(
        HSTRING folderId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING, IAsyncAction*, int>)((*lpVtbl)[35]))(
            this,
            folderId,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(36)]
    public HRESULT MarkMessageReadAsync(
        HSTRING messageId,
        [NativeTypeName("boolean")] byte isRead,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, HSTRING, byte, IAsyncAction*, int>)((*lpVtbl)[36])
        )(this, messageId, isRead, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(37)]
    public HRESULT ChangeMessageFlagStateAsync(
        HSTRING messageId,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState")]
            EmailFlagState flagState,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, HSTRING, EmailFlagState, IAsyncAction*, int>)(
                (*lpVtbl)[37]
            )
        )(this, messageId, flagState, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(38)]
    public HRESULT TryMoveMessageAsync(
        HSTRING messageId,
        HSTRING newParentFolderId,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, HSTRING, HSTRING, IAsyncOperation<byte>**, int>)(
                (*lpVtbl)[38]
            )
        )(this, messageId, newParentFolderId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(39)]
    public HRESULT TryMoveFolderAsync(
        HSTRING folderId,
        HSTRING newParentFolderId,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, HSTRING, HSTRING, IAsyncOperation<byte>**, int>)(
                (*lpVtbl)[39]
            )
        )(this, folderId, newParentFolderId, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(40)]
    public HRESULT TryMoveFolderWithNewNameAsync(
        HSTRING folderId,
        HSTRING newParentFolderId,
        HSTRING newFolderName,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox,
                HSTRING,
                HSTRING,
                HSTRING,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[40])
        )(this, folderId, newParentFolderId, newFolderName, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(41)]
    public HRESULT DeleteMessageAsync(
        HSTRING messageId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING, IAsyncAction*, int>)((*lpVtbl)[41]))(
            this,
            messageId,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(42)]
    public HRESULT MarkFolderSyncEnabledAsync(
        HSTRING folderId,
        [NativeTypeName("boolean")] byte isSyncEnabled,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, HSTRING, byte, IAsyncAction*, int>)((*lpVtbl)[42])
        )(this, folderId, isSyncEnabled, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(43)]
    public HRESULT SendMessageAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
            IEmailMessage message,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, IEmailMessage, IAsyncAction*, int>)((*lpVtbl)[43])
        )(this, message, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(44)]
    public HRESULT SaveDraftAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
            IEmailMessage message,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, IEmailMessage, IAsyncAction*, int>)((*lpVtbl)[44])
        )(this, message, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(45)]
    public HRESULT DownloadMessageAsync(
        HSTRING messageId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING, IAsyncAction*, int>)((*lpVtbl)[45]))(
            this,
            messageId,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(46)]
    public HRESULT DownloadAttachmentAsync(
        HSTRING attachmentId,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return ((delegate* unmanaged<IEmailMailbox, HSTRING, IAsyncAction*, int>)((*lpVtbl)[46]))(
            this,
            attachmentId,
            result
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(47)]
    public HRESULT CreateResponseMessageAsync(
        HSTRING messageId,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind")]
            EmailMessageResponseKind responseType,
        HSTRING subject,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")]
            EmailMessageBodyKind responseHeaderType,
        HSTRING responseHeader,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox,
                HSTRING,
                EmailMessageResponseKind,
                HSTRING,
                EmailMessageBodyKind,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[47])
        )(this, messageId, responseType, subject, responseHeaderType, responseHeader, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(48)]
    public HRESULT TryUpdateMeetingResponseAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
            IEmailMessage meeting,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMeetingResponseType")]
            EmailMeetingResponseType response,
        HSTRING subject,
        HSTRING comment,
        [NativeTypeName("boolean")] byte sendUpdate,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox,
                IEmailMessage,
                EmailMeetingResponseType,
                HSTRING,
                HSTRING,
                byte,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[48])
        )(this, meeting, response, subject, comment, sendUpdate, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(49)]
    public HRESULT TryForwardMeetingAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
            IEmailMessage meeting,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t *"
        )]
            IIterable<IntPtr>* recipients,
        HSTRING subject,
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")]
            EmailMessageBodyKind forwardHeaderType,
        HSTRING forwardHeader,
        HSTRING comment,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox,
                IEmailMessage,
                IIterable<IntPtr>*,
                HSTRING,
                EmailMessageBodyKind,
                HSTRING,
                HSTRING,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[49])
        )(this, meeting, recipients, subject, forwardHeaderType, forwardHeader, comment, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(50)]
    public HRESULT TryProposeNewTimeForMeetingAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
            IEmailMessage meeting,
        [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime newStartTime,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan newDuration,
        HSTRING subject,
        HSTRING comment,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox,
                IEmailMessage,
                WinRTDateTime,
                TimeSpan,
                HSTRING,
                HSTRING,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[50])
        )(this, meeting, newStartTime, newDuration, subject, comment, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(51)]
    public HRESULT add_MailboxChanged(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CEmail__CEmailMailbox_Windows__CApplicationModel__CEmail__CEmailMailboxChangedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* pHandler,
        EventRegistrationToken* pToken
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[51])
        )(this, pHandler, pToken);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(52)]
    public HRESULT remove_MailboxChanged(EventRegistrationToken token)
    {
        return ((delegate* unmanaged<IEmailMailbox, EventRegistrationToken, int>)((*lpVtbl)[52]))(
            this,
            token
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(53)]
    public HRESULT SmartSendMessageAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
            IEmailMessage message,
        [NativeTypeName("boolean")] byte smartSend,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
    )
    {
        return (
            (delegate* unmanaged<IEmailMailbox, IEmailMessage, byte, IAsyncAction*, int>)(
                (*lpVtbl)[53]
            )
        )(this, message, smartSend, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(54)]
    public HRESULT TrySetAutoReplySettingsAsync(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReplySettings *")]
            IEmailMailboxAutoReplySettings autoReplySettings,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** result
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox,
                IEmailMailboxAutoReplySettings,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[54])
        )(this, autoReplySettings, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(55)]
    public HRESULT TryGetAutoReplySettingsAsync(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind"
        )]
            EmailMailboxAutoReplyMessageResponseKind requestedFormat,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxAutoReplySettings_t **"
        )]
            IAsyncOperation<IntPtr>** autoReplySettings
    )
    {
        return (
            (delegate* unmanaged<
                IEmailMailbox,
                EmailMailboxAutoReplyMessageResponseKind,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[55])
        )(this, requestedFormat, autoReplySettings);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Capabilities(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxCapabilities **")]
                IEmailMailboxCapabilities* value
        );

        [VtblIndex(7)]
        HRESULT get_ChangeTracker(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeTracker **")]
                IEmailMailboxChangeTracker* value
        );

        [VtblIndex(8)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_DisplayName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_IsOwnedByCurrentApp([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_IsDataEncryptedUnderLock([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT get_MailAddress(HSTRING* value);

        [VtblIndex(14)]
        HRESULT put_MailAddress(HSTRING value);

        [VtblIndex(15)]
        HRESULT get_MailAddressAliases(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(16)]
        HRESULT get_OtherAppReadAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess *"
            )]
                EmailMailboxOtherAppReadAccess* value
        );

        [VtblIndex(17)]
        HRESULT put_OtherAppReadAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess"
            )]
                EmailMailboxOtherAppReadAccess value
        );

        [VtblIndex(18)]
        HRESULT get_OtherAppWriteAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess *"
            )]
                EmailMailboxOtherAppWriteAccess* value
        );

        [VtblIndex(19)]
        HRESULT put_OtherAppWriteAccess(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess"
            )]
                EmailMailboxOtherAppWriteAccess value
        );

        [VtblIndex(20)]
        HRESULT get_Policies(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxPolicies **")]
                IEmailMailboxPolicies* value
        );

        [VtblIndex(21)]
        HRESULT get_SourceDisplayName(HSTRING* value);

        [VtblIndex(22)]
        HRESULT get_SyncManager(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMailboxSyncManager **")]
                IEmailMailboxSyncManager* value
        );

        [VtblIndex(23)]
        HRESULT get_UserDataAccountId(HSTRING* value);

        [VtblIndex(24)]
        HRESULT GetConversationReader(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
                IEmailConversationReader* result
        );

        [VtblIndex(25)]
        HRESULT GetConversationReaderWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
                IEmailQueryOptions options,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailConversationReader **")]
                IEmailConversationReader* result
        );

        [VtblIndex(26)]
        HRESULT GetMessageReader(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
                IEmailMessageReader* result
        );

        [VtblIndex(27)]
        HRESULT GetMessageReaderWithOptions(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailQueryOptions *")]
                IEmailQueryOptions options,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessageReader **")]
                IEmailMessageReader* result
        );

        [VtblIndex(28)]
        HRESULT DeleteAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(29)]
        HRESULT GetConversationAsync(
            HSTRING id,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailConversation_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(30)]
        HRESULT GetFolderAsync(
            HSTRING id,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(31)]
        HRESULT GetMessageAsync(
            HSTRING id,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(32)]
        HRESULT GetSpecialFolderAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind")]
                EmailSpecialFolderKind folderType,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(33)]
        HRESULT SaveAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(34)]
        HRESULT MarkMessageAsSeenAsync(
            HSTRING messageId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(35)]
        HRESULT MarkFolderAsSeenAsync(
            HSTRING folderId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(36)]
        HRESULT MarkMessageReadAsync(
            HSTRING messageId,
            [NativeTypeName("boolean")] byte isRead,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(37)]
        HRESULT ChangeMessageFlagStateAsync(
            HSTRING messageId,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState")]
                EmailFlagState flagState,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(38)]
        HRESULT TryMoveMessageAsync(
            HSTRING messageId,
            HSTRING newParentFolderId,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(39)]
        HRESULT TryMoveFolderAsync(
            HSTRING folderId,
            HSTRING newParentFolderId,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(40)]
        HRESULT TryMoveFolderWithNewNameAsync(
            HSTRING folderId,
            HSTRING newParentFolderId,
            HSTRING newFolderName,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(41)]
        HRESULT DeleteMessageAsync(
            HSTRING messageId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(42)]
        HRESULT MarkFolderSyncEnabledAsync(
            HSTRING folderId,
            [NativeTypeName("boolean")] byte isSyncEnabled,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(43)]
        HRESULT SendMessageAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
                IEmailMessage message,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(44)]
        HRESULT SaveDraftAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
                IEmailMessage message,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(45)]
        HRESULT DownloadMessageAsync(
            HSTRING messageId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(46)]
        HRESULT DownloadAttachmentAsync(
            HSTRING attachmentId,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(47)]
        HRESULT CreateResponseMessageAsync(
            HSTRING messageId,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind")]
                EmailMessageResponseKind responseType,
            HSTRING subject,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")]
                EmailMessageBodyKind responseHeaderType,
            HSTRING responseHeader,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(48)]
        HRESULT TryUpdateMeetingResponseAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
                IEmailMessage meeting,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMeetingResponseType")]
                EmailMeetingResponseType response,
            HSTRING subject,
            HSTRING comment,
            [NativeTypeName("boolean")] byte sendUpdate,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(49)]
        HRESULT TryForwardMeetingAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
                IEmailMessage meeting,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t *"
            )]
                IIterable<IntPtr>* recipients,
            HSTRING subject,
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind")]
                EmailMessageBodyKind forwardHeaderType,
            HSTRING forwardHeader,
            HSTRING comment,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(50)]
        HRESULT TryProposeNewTimeForMeetingAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
                IEmailMessage meeting,
            [NativeTypeName("ABI::Windows::Foundation::DateTime")] WinRTDateTime newStartTime,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan newDuration,
            HSTRING subject,
            HSTRING comment,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(51)]
        HRESULT add_MailboxChanged(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CEmail__CEmailMailbox_Windows__CApplicationModel__CEmail__CEmailMailboxChangedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* pHandler,
            EventRegistrationToken* pToken
        );

        [VtblIndex(52)]
        HRESULT remove_MailboxChanged(EventRegistrationToken token);

        [VtblIndex(53)]
        HRESULT SmartSendMessageAsync(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailMessage *")]
                IEmailMessage message,
            [NativeTypeName("boolean")] byte smartSend,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* result
        );

        [VtblIndex(54)]
        HRESULT TrySetAutoReplySettingsAsync(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReplySettings *"
            )]
                IEmailMailboxAutoReplySettings autoReplySettings,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** result
        );

        [VtblIndex(55)]
        HRESULT TryGetAutoReplySettingsAsync(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind"
            )]
                EmailMailboxAutoReplyMessageResponseKind requestedFormat,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxAutoReplySettings_t **"
            )]
                IAsyncOperation<IntPtr>** autoReplySettings
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
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxCapabilities **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMailboxCapabilities*, int> get_Capabilities;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxChangeTracker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMailboxChangeTracker*, int> get_ChangeTracker;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsOwnedByCurrentApp;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsDataEncryptedUnderLock;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MailAddress;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_MailAddress;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_MailAddressAliases;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EmailMailboxOtherAppReadAccess*,
            int> get_OtherAppReadAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppReadAccess) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EmailMailboxOtherAppReadAccess,
            int> put_OtherAppReadAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EmailMailboxOtherAppWriteAccess*,
            int> get_OtherAppWriteAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxOtherAppWriteAccess) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EmailMailboxOtherAppWriteAccess,
            int> put_OtherAppWriteAccess;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxPolicies **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMailboxPolicies*, int> get_Policies;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SourceDisplayName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxSyncManager **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMailboxSyncManager*, int> get_SyncManager;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserDataAccountId;

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
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> DeleteAsync;

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
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailSpecialFolderKind, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailFolder_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EmailSpecialFolderKind,
            IAsyncOperation<IntPtr>**,
            int> GetSpecialFolderAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> SaveAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> MarkMessageAsSeenAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> MarkFolderAsSeenAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, boolean, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, byte, IAsyncAction*, int> MarkMessageReadAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Email::EmailFlagState, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            EmailFlagState,
            IAsyncAction*,
            int> ChangeMessageFlagStateAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IAsyncOperation<byte>**,
            int> TryMoveMessageAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            IAsyncOperation<byte>**,
            int> TryMoveFolderAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            HSTRING,
            HSTRING,
            IAsyncOperation<byte>**,
            int> TryMoveFolderWithNewNameAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> DeleteMessageAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, boolean, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            byte,
            IAsyncAction*,
            int> MarkFolderSyncEnabledAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMessage, IAsyncAction*, int> SendMessageAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailMessage, IAsyncAction*, int> SaveDraftAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> DownloadMessageAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> DownloadAttachmentAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind, HSTRING, ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            EmailMessageResponseKind,
            HSTRING,
            EmailMessageBodyKind,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> CreateResponseMessageAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::ApplicationModel::Email::EmailMeetingResponseType, HSTRING, HSTRING, boolean, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEmailMessage,
            EmailMeetingResponseType,
            HSTRING,
            HSTRING,
            byte,
            IAsyncOperation<byte>**,
            int> TryUpdateMeetingResponseAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CApplicationModel__CEmail__CEmailRecipient_t *, HSTRING, ABI::Windows::ApplicationModel::Email::EmailMessageBodyKind, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEmailMessage,
            IIterable<IntPtr>*,
            HSTRING,
            EmailMessageBodyKind,
            HSTRING,
            HSTRING,
            IAsyncOperation<byte>**,
            int> TryForwardMeetingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, ABI::Windows::Foundation::DateTime, ABI::Windows::Foundation::TimeSpan, HSTRING, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEmailMessage,
            WinRTDateTime,
            TimeSpan,
            HSTRING,
            HSTRING,
            IAsyncOperation<byte>**,
            int> TryProposeNewTimeForMeetingAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CApplicationModel__CEmail__CEmailMailbox_Windows__CApplicationModel__CEmail__CEmailMailboxChangedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_MailboxChanged;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_MailboxChanged;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMessage *, boolean, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEmailMessage,
            byte,
            IAsyncAction*,
            int> SmartSendMessageAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailMailboxAutoReplySettings *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEmailMailboxAutoReplySettings,
            IAsyncOperation<byte>**,
            int> TrySetAutoReplySettingsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailMailboxAutoReplyMessageResponseKind, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CEmail__CEmailMailboxAutoReplySettings_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EmailMailboxAutoReplyMessageResponseKind,
            IAsyncOperation<IntPtr>**,
            int> TryGetAutoReplySettingsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailMailbox"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailMailbox(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailMailbox"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailMailbox(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailMailbox(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailbox"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailbox"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailMailbox value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailMailbox"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailMailbox(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailMailbox(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailbox"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailbox"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailMailbox value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
