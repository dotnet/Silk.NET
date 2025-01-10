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

[Guid("F690E944-56F2-45AA-872C-0CE9F3DB0B5C")]
[NativeTypeName("struct IEmailMailboxCapabilities3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IEmailMailboxCapabilities3
    : IEmailMailboxCapabilities3.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IEmailMailboxCapabilities3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IEmailMailboxCapabilities3, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IEmailMailboxCapabilities3, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT put_CanForwardMeetings([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_CanGetAndSetExternalAutoReplies([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_CanGetAndSetInternalAutoReplies([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_CanUpdateMeetingResponses([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_CanServerSearchFolders([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_CanServerSearchMailbox([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_CanProposeNewTimeForMeetings([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_CanSmartSend([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_CanResolveRecipients([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_CanValidateCertificates([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_CanEmptyFolder([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_CanCreateFolder([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_CanDeleteFolder([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_CanMoveFolder([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IEmailMailboxCapabilities3, byte, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT put_CanForwardMeetings([NativeTypeName("boolean")] byte value);

        [VtblIndex(7)]
        HRESULT put_CanGetAndSetExternalAutoReplies([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT put_CanGetAndSetInternalAutoReplies([NativeTypeName("boolean")] byte value);

        [VtblIndex(9)]
        HRESULT put_CanUpdateMeetingResponses([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT put_CanServerSearchFolders([NativeTypeName("boolean")] byte value);

        [VtblIndex(11)]
        HRESULT put_CanServerSearchMailbox([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT put_CanProposeNewTimeForMeetings([NativeTypeName("boolean")] byte value);

        [VtblIndex(13)]
        HRESULT put_CanSmartSend([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT put_CanResolveRecipients([NativeTypeName("boolean")] byte value);

        [VtblIndex(15)]
        HRESULT put_CanValidateCertificates([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT put_CanEmptyFolder([NativeTypeName("boolean")] byte value);

        [VtblIndex(17)]
        HRESULT put_CanCreateFolder([NativeTypeName("boolean")] byte value);

        [VtblIndex(18)]
        HRESULT put_CanDeleteFolder([NativeTypeName("boolean")] byte value);

        [VtblIndex(19)]
        HRESULT put_CanMoveFolder([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanForwardMeetings;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanGetAndSetExternalAutoReplies;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanGetAndSetInternalAutoReplies;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanUpdateMeetingResponses;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanServerSearchFolders;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanServerSearchMailbox;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanProposeNewTimeForMeetings;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanSmartSend;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanResolveRecipients;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanValidateCertificates;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanEmptyFolder;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanCreateFolder;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanDeleteFolder;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_CanMoveFolder;
    }

    /// <summary>Initializes a new instance of the <see cref = "IEmailMailboxCapabilities3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IEmailMailboxCapabilities3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IEmailMailboxCapabilities3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IEmailMailboxCapabilities3(Silk.NET.WinRT.IInspectable value)
    {
        return new IEmailMailboxCapabilities3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailboxCapabilities3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailboxCapabilities3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IEmailMailboxCapabilities3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IEmailMailboxCapabilities3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IEmailMailboxCapabilities3(Silk.NET.Windows.IUnknown value)
    {
        return new IEmailMailboxCapabilities3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IEmailMailboxCapabilities3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IEmailMailboxCapabilities3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IEmailMailboxCapabilities3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
