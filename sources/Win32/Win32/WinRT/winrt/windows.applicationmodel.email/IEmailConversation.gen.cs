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

[Guid("DA18C248-A0BC-4349-902D-90F66389F51B")]
[NativeTypeName("struct IEmailConversation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailConversation : IEmailConversation.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailConversation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEmailConversation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEmailConversation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailConversation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IEmailConversation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailConversation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailConversation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailConversation, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MailboxId(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailConversation, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FlagState(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState *")]
            EmailFlagState* value
    )
    {
        return ((delegate* unmanaged<IEmailConversation, EmailFlagState*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_HasAttachment([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IEmailConversation, byte*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Importance(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailImportance *")]
            EmailImportance* value
    )
    {
        return ((delegate* unmanaged<IEmailConversation, EmailImportance*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_LastEmailResponseKind(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind *")]
            EmailMessageResponseKind* value
    )
    {
        return (
            (delegate* unmanaged<IEmailConversation, EmailMessageResponseKind*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MessageCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IEmailConversation, uint*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MostRecentMessageId(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailConversation, HSTRING*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_MostRecentMessageTime(
        [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
    )
    {
        return ((delegate* unmanaged<IEmailConversation, WinRTDateTime*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_Preview(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailConversation, HSTRING*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_LatestSender(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")]
            IEmailRecipient* value
    )
    {
        return ((delegate* unmanaged<IEmailConversation, IEmailRecipient*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_Subject(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailConversation, HSTRING*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_UnreadMessageCount([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IEmailConversation, uint*, int>)((*lpVtbl)[18]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT FindMessagesAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailConversation, IAsyncOperation<IntPtr>**, int>)((*lpVtbl)[19])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT FindMessagesWithCountAsync(
        [NativeTypeName("UINT32")] uint count,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
        )]
            IAsyncOperation<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IEmailConversation, uint, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[20]
            )
        )(this, count, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_MailboxId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_FlagState(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailFlagState *")]
                EmailFlagState* value
        );

        [VtblIndex(9)]
        HRESULT get_HasAttachment([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_Importance(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailImportance *")]
                EmailImportance* value
        );

        [VtblIndex(11)]
        HRESULT get_LastEmailResponseKind(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind *")]
                EmailMessageResponseKind* value
        );

        [VtblIndex(12)]
        HRESULT get_MessageCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        HRESULT get_MostRecentMessageId(HSTRING* value);

        [VtblIndex(14)]
        HRESULT get_MostRecentMessageTime(
            [NativeTypeName("ABI::Windows::Foundation::DateTime *")] WinRTDateTime* value
        );

        [VtblIndex(15)]
        HRESULT get_Preview(HSTRING* value);

        [VtblIndex(16)]
        HRESULT get_LatestSender(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::IEmailRecipient **")]
                IEmailRecipient* value
        );

        [VtblIndex(17)]
        HRESULT get_Subject(HSTRING* value);

        [VtblIndex(18)]
        HRESULT get_UnreadMessageCount([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(19)]
        HRESULT FindMessagesAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
            )]
                IAsyncOperation<IntPtr>** result
        );

        [VtblIndex(20)]
        HRESULT FindMessagesWithCountAsync(
            [NativeTypeName("UINT32")] uint count,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **"
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MailboxId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailFlagState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, EmailFlagState*, int> get_FlagState;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_HasAttachment;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailImportance *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, EmailImportance*, int> get_Importance;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailMessageResponseKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            EmailMessageResponseKind*,
            int> get_LastEmailResponseKind;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_MessageCount;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MostRecentMessageId;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::DateTime *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WinRTDateTime*, int> get_MostRecentMessageTime;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Preview;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::IEmailRecipient **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IEmailRecipient*, int> get_LatestSender;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Subject;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_UnreadMessageCount;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncOperation<IntPtr>**, int> FindMessagesAsync;

        [NativeTypeName(
            "HRESULT (UINT32, ABI::Windows::Foundation::__FIAsyncOperation_1___FIVectorView_1_Windows__CApplicationModel__CEmail__CEmailMessage_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            IAsyncOperation<IntPtr>**,
            int> FindMessagesWithCountAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailConversation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailConversation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailConversation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailConversation(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailConversation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailConversation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailConversation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailConversation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailConversation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailConversation(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailConversation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailConversation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailConversation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailConversation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
