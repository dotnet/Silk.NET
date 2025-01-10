// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("B571C28C-A472-48D5-88D2-8ADCAF1B8813")]
[NativeTypeName("struct IConnectionStatusHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IConnectionStatusHandler
    : IConnectionStatusHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IConnectionStatusHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IConnectionStatusHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IConnectionStatusHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IConnectionStatusHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke(
        [NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice sender,
        [NativeTypeName("ABI::Windows::Media::Streaming::ConnectionStatus")] ConnectionStatus arg
    )
    {
        return (
            (delegate* unmanaged<IConnectionStatusHandler, IBasicDevice, ConnectionStatus, int>)(
                (*lpVtbl)[3]
            )
        )(this, sender, arg);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke(
            [NativeTypeName("ABI::Windows::Media::Streaming::IBasicDevice *")] IBasicDevice sender,
            [NativeTypeName("ABI::Windows::Media::Streaming::ConnectionStatus")]
                ConnectionStatus arg
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
            "HRESULT (ABI::Windows::Media::Streaming::IBasicDevice *, ABI::Windows::Media::Streaming::ConnectionStatus) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBasicDevice, ConnectionStatus, int> Invoke;
    }

    /// <summary>Initializes a new instance of the <see cref = "IConnectionStatusHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IConnectionStatusHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IConnectionStatusHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IConnectionStatusHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IConnectionStatusHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IConnectionStatusHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IConnectionStatusHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IConnectionStatusHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
