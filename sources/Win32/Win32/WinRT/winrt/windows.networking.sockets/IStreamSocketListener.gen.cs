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

[Guid("FF513437-DF9F-4DF0-BF82-0EC5D7B35AAE")]
[NativeTypeName("struct IStreamSocketListener : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocketListener : IStreamSocketListener.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSocketListener));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamSocketListener, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStreamSocketListener, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamSocketListener, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStreamSocketListener, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStreamSocketListener, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStreamSocketListener, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Control(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListenerControl **")]
            IStreamSocketListenerControl* value
    )
    {
        return (
            (delegate* unmanaged<IStreamSocketListener, IStreamSocketListenerControl*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Information(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListenerInformation **")]
            IStreamSocketListenerInformation* value
    )
    {
        return (
            (delegate* unmanaged<IStreamSocketListener, IStreamSocketListenerInformation*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT BindServiceNameAsync(
        HSTRING localServiceName,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IStreamSocketListener, HSTRING, IAsyncAction*, int>)((*lpVtbl)[8])
        )(this, localServiceName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT BindEndpointAsync(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName localHostName,
        HSTRING localServiceName,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IStreamSocketListener, IHostName, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[9]
            )
        )(this, localHostName, localServiceName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_ConnectionReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CStreamSocketListener_Windows__CNetworking__CSockets__CStreamSocketListenerConnectionReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                IStreamSocketListener,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[10])
        )(this, eventHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_ConnectionReceived(EventRegistrationToken eventCookie)
    {
        return (
            (delegate* unmanaged<IStreamSocketListener, EventRegistrationToken, int>)((*lpVtbl)[11])
        )(this, eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Control(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListenerControl **")]
                IStreamSocketListenerControl* value
        );

        [VtblIndex(7)]
        HRESULT get_Information(
            [NativeTypeName(
                "ABI::Windows::Networking::Sockets::IStreamSocketListenerInformation **"
            )]
                IStreamSocketListenerInformation* value
        );

        [VtblIndex(8)]
        HRESULT BindServiceNameAsync(
            HSTRING localServiceName,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(9)]
        HRESULT BindEndpointAsync(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName localHostName,
            HSTRING localServiceName,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(10)]
        HRESULT add_ConnectionReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CStreamSocketListener_Windows__CNetworking__CSockets__CStreamSocketListenerConnectionReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(11)]
        HRESULT remove_ConnectionReceived(EventRegistrationToken eventCookie);
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
            "HRESULT (ABI::Windows::Networking::Sockets::IStreamSocketListenerControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStreamSocketListenerControl*, int> get_Control;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::IStreamSocketListenerInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStreamSocketListenerInformation*, int> get_Information;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> BindServiceNameAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHostName,
            HSTRING,
            IAsyncAction*,
            int> BindEndpointAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CStreamSocketListener_Windows__CNetworking__CSockets__CStreamSocketListenerConnectionReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_ConnectionReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_ConnectionReceived;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStreamSocketListener"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStreamSocketListener(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStreamSocketListener"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStreamSocketListener(Silk.NET.WinRT.IInspectable value)
    {
        return new IStreamSocketListener(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSocketListener"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSocketListener"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStreamSocketListener value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStreamSocketListener"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStreamSocketListener(Silk.NET.Windows.IUnknown value)
    {
        return new IStreamSocketListener(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSocketListener"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSocketListener"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStreamSocketListener value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
