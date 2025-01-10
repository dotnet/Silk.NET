// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("BD4A49D8-B289-45BB-97EB-C7525205A843")]
[NativeTypeName("struct IStreamWebSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamWebSocket : IStreamWebSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamWebSocket));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamWebSocket, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStreamWebSocket, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamWebSocket, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStreamWebSocket, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStreamWebSocket, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStreamWebSocket, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Control(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamWebSocketControl **")]
            IStreamWebSocketControl* value
    )
    {
        return (
            (delegate* unmanaged<IStreamWebSocket, IStreamWebSocketControl*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Information(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IWebSocketInformation **")]
            IWebSocketInformation* value
    )
    {
        return ((delegate* unmanaged<IStreamWebSocket, IWebSocketInformation*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InputStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* value
    )
    {
        return ((delegate* unmanaged<IStreamWebSocket, IInputStream*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Control(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamWebSocketControl **")]
                IStreamWebSocketControl* value
        );

        [VtblIndex(7)]
        HRESULT get_Information(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IWebSocketInformation **")]
                IWebSocketInformation* value
        );

        [VtblIndex(8)]
        HRESULT get_InputStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* value
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
            "HRESULT (ABI::Windows::Networking::Sockets::IStreamWebSocketControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStreamWebSocketControl*, int> get_Control;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::IWebSocketInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWebSocketInformation*, int> get_Information;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IInputStream*, int> get_InputStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStreamWebSocket"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStreamWebSocket(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStreamWebSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStreamWebSocket(Silk.NET.WinRT.IInspectable value)
    {
        return new IStreamWebSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamWebSocket"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamWebSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStreamWebSocket value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStreamWebSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStreamWebSocket(Silk.NET.Windows.IUnknown value)
    {
        return new IStreamWebSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamWebSocket"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamWebSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStreamWebSocket value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
