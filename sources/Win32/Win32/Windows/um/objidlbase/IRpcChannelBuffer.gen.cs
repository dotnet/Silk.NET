// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D5F56B60-593B-101A-B569-08002B2DBF7A")]
[NativeTypeName("struct IRpcChannelBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRpcChannelBuffer : IRpcChannelBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRpcChannelBuffer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRpcChannelBuffer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRpcChannelBuffer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRpcChannelBuffer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
    {
        return ((delegate* unmanaged<IRpcChannelBuffer, RPCOLEMESSAGE*, Guid*, int>)((*lpVtbl)[3]))(
            this,
            pMessage,
            riid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
    {
        return ((delegate* unmanaged<IRpcChannelBuffer, RPCOLEMESSAGE*, uint*, int>)((*lpVtbl)[4]))(
            this,
            pMessage,
            pStatus
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FreeBuffer(RPCOLEMESSAGE* pMessage)
    {
        return ((delegate* unmanaged<IRpcChannelBuffer, RPCOLEMESSAGE*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IRpcChannelBuffer, uint*, void**, int>)((*lpVtbl)[6]))(
            this,
            pdwDestContext,
            ppvDestContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsConnected()
    {
        return ((delegate* unmanaged<IRpcChannelBuffer, int>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid);

        [VtblIndex(4)]
        HRESULT SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus);

        [VtblIndex(5)]
        HRESULT FreeBuffer(RPCOLEMESSAGE* pMessage);

        [VtblIndex(6)]
        HRESULT GetDestCtx([NativeTypeName("DWORD *")] uint* pdwDestContext, void** ppvDestContext);

        [VtblIndex(7)]
        HRESULT IsConnected();
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IRpcChannelBuffer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRpcChannelBuffer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRpcChannelBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRpcChannelBuffer(Silk.NET.Windows.IUnknown value)
    {
        return new IRpcChannelBuffer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRpcChannelBuffer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRpcChannelBuffer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRpcChannelBuffer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
