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

[Guid("0B7AD409-EC2D-47CE-A253-732BEEEBCACD")]
[NativeTypeName("struct ISmsMessageReceivedEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
[Obsolete(
    "SmsMessageReceivedEventHandler may be altered or unavailable for releases after Windows 10."
)]
public unsafe partial struct ISmsMessageReceivedEventHandler
    : ISmsMessageReceivedEventHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISmsMessageReceivedEventHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISmsMessageReceivedEventHandler, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISmsMessageReceivedEventHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISmsMessageReceivedEventHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [Obsolete(
        "SmsMessageReceivedEventHandler may be altered or unavailable for releases after Windows 10."
    )]
    public HRESULT Invoke(
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice *")] ISmsDevice sender,
        [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageReceivedEventArgs *")]
            ISmsMessageReceivedEventArgs e
    )
    {
        return (
            (delegate* unmanaged<
                ISmsMessageReceivedEventHandler,
                ISmsDevice,
                ISmsMessageReceivedEventArgs,
                int>)((*lpVtbl)[3])
        )(this, sender, e);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [Obsolete(
            "SmsMessageReceivedEventHandler may be altered or unavailable for releases after Windows 10."
        )]
        HRESULT Invoke(
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsDevice *")] ISmsDevice sender,
            [NativeTypeName("ABI::Windows::Devices::Sms::ISmsMessageReceivedEventArgs *")]
                ISmsMessageReceivedEventArgs e
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

        [NativeTypeName(
            "HRESULT (ABI::Windows::Devices::Sms::ISmsDevice *, ABI::Windows::Devices::Sms::ISmsMessageReceivedEventArgs *) __attribute__((stdcall))"
        )]
        [Obsolete(
            "SmsMessageReceivedEventHandler may be altered or unavailable for releases after Windows 10."
        )]
        public delegate* unmanaged<TSelf*, ISmsDevice, ISmsMessageReceivedEventArgs, int> Invoke;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISmsMessageReceivedEventHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISmsMessageReceivedEventHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISmsMessageReceivedEventHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISmsMessageReceivedEventHandler(Silk.NET.Windows.IUnknown value)
    {
        return new ISmsMessageReceivedEventHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISmsMessageReceivedEventHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISmsMessageReceivedEventHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISmsMessageReceivedEventHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
