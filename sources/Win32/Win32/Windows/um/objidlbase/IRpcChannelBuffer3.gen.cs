// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("25B15600-0115-11D0-BF0D-00AA00B8DFD2")]
[NativeTypeName("struct IRpcChannelBuffer3 : IRpcChannelBuffer2")]
[NativeInheritance("IRpcChannelBuffer2")]
public unsafe partial struct IRpcChannelBuffer3 : IRpcChannelBuffer3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRpcChannelBuffer3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRpcChannelBuffer3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRpcChannelBuffer3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRpcChannelBuffer3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
    {
        return (
            (delegate* unmanaged<IRpcChannelBuffer3, RPCOLEMESSAGE*, Guid*, int>)((*lpVtbl)[3])
        )(this, pMessage, riid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
    {
        return (
            (delegate* unmanaged<IRpcChannelBuffer3, RPCOLEMESSAGE*, uint*, int>)((*lpVtbl)[4])
        )(this, pMessage, pStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FreeBuffer(RPCOLEMESSAGE* pMessage)
    {
        return ((delegate* unmanaged<IRpcChannelBuffer3, RPCOLEMESSAGE*, int>)((*lpVtbl)[5]))(
            this,
            pMessage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDestCtx(
        [NativeTypeName("DWORD *")] uint* pdwDestContext,
        void** ppvDestContext
    )
    {
        return ((delegate* unmanaged<IRpcChannelBuffer3, uint*, void**, int>)((*lpVtbl)[6]))(
            this,
            pdwDestContext,
            ppvDestContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsConnected()
    {
        return ((delegate* unmanaged<IRpcChannelBuffer3, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
    {
        return ((delegate* unmanaged<IRpcChannelBuffer3, uint*, int>)((*lpVtbl)[8]))(
            this,
            pdwVersion
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Send(RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus)
    {
        return (
            (delegate* unmanaged<IRpcChannelBuffer3, RPCOLEMESSAGE*, uint*, int>)((*lpVtbl)[9])
        )(this, pMsg, pulStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Receive(
        RPCOLEMESSAGE* pMsg,
        [NativeTypeName("ULONG")] uint ulSize,
        [NativeTypeName("ULONG *")] uint* pulStatus
    )
    {
        return (
            (delegate* unmanaged<IRpcChannelBuffer3, RPCOLEMESSAGE*, uint, uint*, int>)(
                (*lpVtbl)[10]
            )
        )(this, pMsg, ulSize, pulStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Cancel(RPCOLEMESSAGE* pMsg)
    {
        return ((delegate* unmanaged<IRpcChannelBuffer3, RPCOLEMESSAGE*, int>)((*lpVtbl)[11]))(
            this,
            pMsg
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCallContext(
        RPCOLEMESSAGE* pMsg,
        [NativeTypeName("const IID &")] Guid* riid,
        void** pInterface
    )
    {
        return (
            (delegate* unmanaged<IRpcChannelBuffer3, RPCOLEMESSAGE*, Guid*, void**, int>)(
                (*lpVtbl)[12]
            )
        )(this, pMsg, riid, pInterface);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetDestCtxEx(
        RPCOLEMESSAGE* pMsg,
        [NativeTypeName("DWORD *")] uint* pdwDestContext,
        void** ppvDestContext
    )
    {
        return (
            (delegate* unmanaged<IRpcChannelBuffer3, RPCOLEMESSAGE*, uint*, void**, int>)(
                (*lpVtbl)[13]
            )
        )(this, pMsg, pdwDestContext, ppvDestContext);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetState(RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pState)
    {
        return (
            (delegate* unmanaged<IRpcChannelBuffer3, RPCOLEMESSAGE*, uint*, int>)((*lpVtbl)[14])
        )(this, pMsg, pState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT RegisterAsync(RPCOLEMESSAGE* pMsg, IAsyncManager pAsyncMgr)
    {
        return (
            (delegate* unmanaged<IRpcChannelBuffer3, RPCOLEMESSAGE*, IAsyncManager, int>)(
                (*lpVtbl)[15]
            )
        )(this, pMsg, pAsyncMgr);
    }

    public interface Interface : IRpcChannelBuffer2.Interface
    {
        [VtblIndex(9)]
        HRESULT Send(RPCOLEMESSAGE* pMsg, [NativeTypeName("ULONG *")] uint* pulStatus);

        [VtblIndex(10)]
        HRESULT Receive(
            RPCOLEMESSAGE* pMsg,
            [NativeTypeName("ULONG")] uint ulSize,
            [NativeTypeName("ULONG *")] uint* pulStatus
        );

        [VtblIndex(11)]
        HRESULT Cancel(RPCOLEMESSAGE* pMsg);

        [VtblIndex(12)]
        HRESULT GetCallContext(
            RPCOLEMESSAGE* pMsg,
            [NativeTypeName("const IID &")] Guid* riid,
            void** pInterface
        );

        [VtblIndex(13)]
        HRESULT GetDestCtxEx(
            RPCOLEMESSAGE* pMsg,
            [NativeTypeName("DWORD *")] uint* pdwDestContext,
            void** ppvDestContext
        );

        [VtblIndex(14)]
        HRESULT GetState(RPCOLEMESSAGE* pMsg, [NativeTypeName("DWORD *")] uint* pState);

        [VtblIndex(15)]
        HRESULT RegisterAsync(RPCOLEMESSAGE* pMsg, IAsyncManager pAsyncMgr);
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

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, Guid*, int> GetBuffer;

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, uint*, int> SendReceive;

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, int> FreeBuffer;

        [NativeTypeName("HRESULT (DWORD *, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, void**, int> GetDestCtx;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsConnected;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetProtocolVersion;

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, uint*, int> Send;

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, uint, uint*, int> Receive;

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, int> Cancel;

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, Guid*, void**, int> GetCallContext;

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, DWORD *, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, uint*, void**, int> GetDestCtxEx;

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, uint*, int> GetState;

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, IAsyncManager *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RPCOLEMESSAGE*, IAsyncManager, int> RegisterAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRpcChannelBuffer3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRpcChannelBuffer3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IRpcChannelBuffer2"/> to <see cref = "IRpcChannelBuffer3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IRpcChannelBuffer2"/> instance to be converted </param>
    public static explicit operator IRpcChannelBuffer3(Silk.NET.Windows.IRpcChannelBuffer2 value)
    {
        return new IRpcChannelBuffer3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRpcChannelBuffer3"/> to <see cref = "Silk.NET.Windows.IRpcChannelBuffer2"/>.</summary>
    /// <param name = "value">The <see cref = "IRpcChannelBuffer3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IRpcChannelBuffer2(IRpcChannelBuffer3 value)
    {
        return new Silk.NET.Windows.IRpcChannelBuffer2(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IRpcChannelBuffer"/> to <see cref = "IRpcChannelBuffer3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IRpcChannelBuffer"/> instance to be converted </param>
    public static explicit operator IRpcChannelBuffer3(Silk.NET.Windows.IRpcChannelBuffer value)
    {
        return new IRpcChannelBuffer3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRpcChannelBuffer3"/> to <see cref = "Silk.NET.Windows.IRpcChannelBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "IRpcChannelBuffer3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IRpcChannelBuffer(IRpcChannelBuffer3 value)
    {
        return new Silk.NET.Windows.IRpcChannelBuffer(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRpcChannelBuffer3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRpcChannelBuffer3(Silk.NET.Windows.IUnknown value)
    {
        return new IRpcChannelBuffer3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRpcChannelBuffer3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRpcChannelBuffer3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRpcChannelBuffer3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
