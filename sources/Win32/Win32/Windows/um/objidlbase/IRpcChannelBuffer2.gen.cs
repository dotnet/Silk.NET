// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("594F31D0-7F19-11D0-B194-00A0C90DC8BF")]
[NativeTypeName("struct IRpcChannelBuffer2 : IRpcChannelBuffer")]
[NativeInheritance("IRpcChannelBuffer")]
public unsafe partial struct IRpcChannelBuffer2 : IRpcChannelBuffer2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRpcChannelBuffer2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRpcChannelBuffer2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRpcChannelBuffer2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRpcChannelBuffer2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetBuffer(RPCOLEMESSAGE* pMessage, [NativeTypeName("const IID &")] Guid* riid)
    {
        return (
            (delegate* unmanaged<IRpcChannelBuffer2, RPCOLEMESSAGE*, Guid*, int>)((*lpVtbl)[3])
        )(this, pMessage, riid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SendReceive(RPCOLEMESSAGE* pMessage, [NativeTypeName("ULONG *")] uint* pStatus)
    {
        return (
            (delegate* unmanaged<IRpcChannelBuffer2, RPCOLEMESSAGE*, uint*, int>)((*lpVtbl)[4])
        )(this, pMessage, pStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT FreeBuffer(RPCOLEMESSAGE* pMessage)
    {
        return ((delegate* unmanaged<IRpcChannelBuffer2, RPCOLEMESSAGE*, int>)((*lpVtbl)[5]))(
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
        return ((delegate* unmanaged<IRpcChannelBuffer2, uint*, void**, int>)((*lpVtbl)[6]))(
            this,
            pdwDestContext,
            ppvDestContext
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsConnected()
    {
        return ((delegate* unmanaged<IRpcChannelBuffer2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion)
    {
        return ((delegate* unmanaged<IRpcChannelBuffer2, uint*, int>)((*lpVtbl)[8]))(
            this,
            pdwVersion
        );
    }

    public interface Interface : IRpcChannelBuffer.Interface
    {
        [VtblIndex(8)]
        HRESULT GetProtocolVersion([NativeTypeName("DWORD *")] uint* pdwVersion);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IRpcChannelBuffer2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRpcChannelBuffer2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IRpcChannelBuffer"/> to <see cref = "IRpcChannelBuffer2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IRpcChannelBuffer"/> instance to be converted </param>
    public static explicit operator IRpcChannelBuffer2(Silk.NET.Windows.IRpcChannelBuffer value)
    {
        return new IRpcChannelBuffer2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRpcChannelBuffer2"/> to <see cref = "Silk.NET.Windows.IRpcChannelBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "IRpcChannelBuffer2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IRpcChannelBuffer(IRpcChannelBuffer2 value)
    {
        return new Silk.NET.Windows.IRpcChannelBuffer(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRpcChannelBuffer2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRpcChannelBuffer2(Silk.NET.Windows.IUnknown value)
    {
        return new IRpcChannelBuffer2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRpcChannelBuffer2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRpcChannelBuffer2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRpcChannelBuffer2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
