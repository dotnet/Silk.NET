// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sms.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("08E80A98-B8E5-41C1-A3D8-D3ABFAE22675")]
[NativeTypeName("struct ISmsMessageReceivedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10."
)]
public unsafe partial struct ISmsMessageReceivedEventArgs
    : ISmsMessageReceivedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsMessageReceivedEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedEventArgs, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISmsMessageReceivedEventArgs, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsMessageReceivedEventArgs, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedEventArgs, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISmsMessageReceivedEventArgs, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedEventArgs, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10."
    )]
    public HRESULT get_TextMessage(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage **")] ISmsTextMessage* value
    )
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedEventArgs, ISmsTextMessage*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10."
    )]
    public HRESULT get_BinaryMessage(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsBinaryMessage **")]
            ISmsBinaryMessage* value
    )
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedEventArgs, ISmsBinaryMessage*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT get_TextMessage(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsTextMessage **")]
                ISmsTextMessage* value
        );

        [VtblIndex(7)]
        [Obsolete(
            "SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT get_BinaryMessage(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsBinaryMessage **")]
                ISmsBinaryMessage* value
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
            "HRESULT (ABI::Windows::Devices::Sms::ISmsTextMessage **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<TSelf*, ISmsTextMessage*, int> get_TextMessage;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsBinaryMessage **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsMessageReceivedEventArgs may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<TSelf*, ISmsBinaryMessage*, int> get_BinaryMessage;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsMessageReceivedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsMessageReceivedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISmsMessageReceivedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISmsMessageReceivedEventArgs(Silk.NET.WinRT.IInspectable value)
    {
        return new ISmsMessageReceivedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsMessageReceivedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsMessageReceivedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISmsMessageReceivedEventArgs value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsMessageReceivedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsMessageReceivedEventArgs(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsMessageReceivedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsMessageReceivedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsMessageReceivedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsMessageReceivedEventArgs value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
