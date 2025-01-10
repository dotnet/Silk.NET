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

[Guid("37544F09-AB92-4306-9AC1-0C381283D9C6")]
[NativeTypeName("struct IDatagramSocket3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDatagramSocket3 : IDatagramSocket3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDatagramSocket3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDatagramSocket3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDatagramSocket3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDatagramSocket3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDatagramSocket3, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDatagramSocket3, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDatagramSocket3, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CancelIOAsync(
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IDatagramSocket3, IAsyncAction*, int>)((*lpVtbl)[6]))(
            this,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnableTransferOwnership(Guid taskId)
    {
        return ((delegate* unmanaged<IDatagramSocket3, Guid, int>)((*lpVtbl)[7]))(this, taskId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT EnableTransferOwnershipWithConnectedStandbyAction(
        Guid taskId,
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketActivityConnectedStandbyAction")]
            SocketActivityConnectedStandbyAction connectedStandbyAction
    )
    {
        return (
            (delegate* unmanaged<
                IDatagramSocket3,
                Guid,
                SocketActivityConnectedStandbyAction,
                int>)((*lpVtbl)[8])
        )(this, taskId, connectedStandbyAction);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT TransferOwnership(HSTRING socketId)
    {
        return ((delegate* unmanaged<IDatagramSocket3, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            socketId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT TransferOwnershipWithContext(
        HSTRING socketId,
        [NativeTypeName("ABI::Windows::Networking::Sockets::ISocketActivityContext *")]
            ISocketActivityContext data
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocket3, HSTRING, ISocketActivityContext, int>)(
                (*lpVtbl)[10]
            )
        )(this, socketId, data);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT TransferOwnershipWithContextAndKeepAliveTime(
        HSTRING socketId,
        [NativeTypeName("ABI::Windows::Networking::Sockets::ISocketActivityContext *")]
            ISocketActivityContext data,
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan keepAliveTime
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocket3, HSTRING, ISocketActivityContext, TimeSpan, int>)(
                (*lpVtbl)[11]
            )
        )(this, socketId, data, keepAliveTime);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CancelIOAsync(
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(7)]
        HRESULT EnableTransferOwnership(Guid taskId);

        [VtblIndex(8)]
        HRESULT EnableTransferOwnershipWithConnectedStandbyAction(
            Guid taskId,
            [NativeTypeName(
                "ABI::Windows::Networking::Sockets::SocketActivityConnectedStandbyAction"
            )]
                SocketActivityConnectedStandbyAction connectedStandbyAction
        );

        [VtblIndex(9)]
        HRESULT TransferOwnership(HSTRING socketId);

        [VtblIndex(10)]
        HRESULT TransferOwnershipWithContext(
            HSTRING socketId,
            [NativeTypeName("ABI::Windows::Networking::Sockets::ISocketActivityContext *")]
                ISocketActivityContext data
        );

        [VtblIndex(11)]
        HRESULT TransferOwnershipWithContextAndKeepAliveTime(
            HSTRING socketId,
            [NativeTypeName("ABI::Windows::Networking::Sockets::ISocketActivityContext *")]
                ISocketActivityContext data,
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan keepAliveTime
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
            "HRESULT (ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAsyncAction*, int> CancelIOAsync;

        [NativeTypeName("HRESULT (GUID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid, int> EnableTransferOwnership;

        [NativeTypeName(
            "HRESULT (GUID, ABI::Windows::Networking::Sockets::SocketActivityConnectedStandbyAction) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid,
            SocketActivityConnectedStandbyAction,
            int> EnableTransferOwnershipWithConnectedStandbyAction;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> TransferOwnership;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Networking::Sockets::ISocketActivityContext *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ISocketActivityContext,
            int> TransferOwnershipWithContext;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Networking::Sockets::ISocketActivityContext *, ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            ISocketActivityContext,
            TimeSpan,
            int> TransferOwnershipWithContextAndKeepAliveTime;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDatagramSocket3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDatagramSocket3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDatagramSocket3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDatagramSocket3(Silk.NET.WinRT.IInspectable value)
    {
        return new IDatagramSocket3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDatagramSocket3"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDatagramSocket3"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDatagramSocket3 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDatagramSocket3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDatagramSocket3(Silk.NET.Windows.IUnknown value)
    {
        return new IDatagramSocket3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDatagramSocket3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDatagramSocket3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDatagramSocket3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
