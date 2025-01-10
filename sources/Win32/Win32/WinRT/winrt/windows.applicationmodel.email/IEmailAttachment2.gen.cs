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

[Guid("225F1070-B0FF-4571-9D54-A706C48D55C6")]
[NativeTypeName("struct IEmailAttachment2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailAttachment2 : IEmailAttachment2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailAttachment2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IEmailAttachment2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IEmailAttachment2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailAttachment2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IEmailAttachment2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailAttachment2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailAttachment2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ContentId(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_ContentId(HSTRING value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, HSTRING, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ContentLocation(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, HSTRING*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ContentLocation(HSTRING value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, HSTRING, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_DownloadState(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState *")]
            EmailAttachmentDownloadState* value
    )
    {
        return (
            (delegate* unmanaged<IEmailAttachment2, EmailAttachmentDownloadState*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_DownloadState(
        [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState")]
            EmailAttachmentDownloadState value
    )
    {
        return (
            (delegate* unmanaged<IEmailAttachment2, EmailAttachmentDownloadState, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_EstimatedDownloadSizeInBytes([NativeTypeName("UINT64 *")] ulong* value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, ulong*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_EstimatedDownloadSizeInBytes([NativeTypeName("UINT64")] ulong value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, ulong, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsFromBaseMessage([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, byte*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsInline([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, byte*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_IsInline([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, byte, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_MimeType(HSTRING* value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, HSTRING*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_MimeType(HSTRING value)
    {
        return ((delegate* unmanaged<IEmailAttachment2, HSTRING, int>)((*lpVtbl)[19]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_ContentId(HSTRING* value);

        [VtblIndex(8)]
        HRESULT put_ContentId(HSTRING value);

        [VtblIndex(9)]
        HRESULT get_ContentLocation(HSTRING* value);

        [VtblIndex(10)]
        HRESULT put_ContentLocation(HSTRING value);

        [VtblIndex(11)]
        HRESULT get_DownloadState(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState *"
            )]
                EmailAttachmentDownloadState* value
        );

        [VtblIndex(12)]
        HRESULT put_DownloadState(
            [NativeTypeName("ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState")]
                EmailAttachmentDownloadState value
        );

        [VtblIndex(13)]
        HRESULT get_EstimatedDownloadSizeInBytes([NativeTypeName("UINT64 *")] ulong* value);

        [VtblIndex(14)]
        HRESULT put_EstimatedDownloadSizeInBytes([NativeTypeName("UINT64")] ulong value);

        [VtblIndex(15)]
        HRESULT get_IsFromBaseMessage([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT get_IsInline([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT put_IsInline([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT get_MimeType(HSTRING* value);

        [VtblIndex(19)]
        HRESULT put_MimeType(HSTRING value);
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
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ContentId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ContentId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ContentLocation;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ContentLocation;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, EmailAttachmentDownloadState*, int> get_DownloadState;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::Email::EmailAttachmentDownloadState) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, EmailAttachmentDownloadState, int> put_DownloadState;

        [NativeTypeName("HRESULT (UINT64 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong*, int> get_EstimatedDownloadSizeInBytes;

        [NativeTypeName("HRESULT (UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ulong, int> put_EstimatedDownloadSizeInBytes;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsFromBaseMessage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsInline;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsInline;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_MimeType;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_MimeType;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailAttachment2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailAttachment2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailAttachment2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailAttachment2(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailAttachment2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailAttachment2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailAttachment2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailAttachment2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailAttachment2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailAttachment2(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailAttachment2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailAttachment2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailAttachment2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailAttachment2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
