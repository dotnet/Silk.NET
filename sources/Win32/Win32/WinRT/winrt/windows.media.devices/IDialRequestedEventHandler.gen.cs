// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.devices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5ABBFFDB-C21F-4BC4-891B-257E28C1B1A4")]
[NativeTypeName("struct IDialRequestedEventHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDialRequestedEventHandler
    : IDialRequestedEventHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDialRequestedEventHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDialRequestedEventHandler, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDialRequestedEventHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDialRequestedEventHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke(
        [NativeTypeName("ABI::Windows::Media::Devices::ICallControl *")] ICallControl sender,
        [NativeTypeName("ABI::Windows::Media::Devices::IDialRequestedEventArgs *")]
            IDialRequestedEventArgs e
    )
    {
        return (
            (delegate* unmanaged<
                IDialRequestedEventHandler,
                ICallControl,
                IDialRequestedEventArgs,
                int>)((*lpVtbl)[3])
        )(this, sender, e);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke(
            [NativeTypeName("ABI::Windows::Media::Devices::ICallControl *")] ICallControl sender,
            [NativeTypeName("ABI::Windows::Media::Devices::IDialRequestedEventArgs *")]
                IDialRequestedEventArgs e
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
            "HRESULT (ABI::Windows::Media::Devices::ICallControl *, ABI::Windows::Media::Devices::IDialRequestedEventArgs *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICallControl, IDialRequestedEventArgs, int> Invoke;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDialRequestedEventHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDialRequestedEventHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDialRequestedEventHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDialRequestedEventHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IDialRequestedEventHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDialRequestedEventHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDialRequestedEventHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDialRequestedEventHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
