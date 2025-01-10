// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/rendezvoussession.h and um/rendezvoussession_i.c in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("9BA4B1DD-8B0C-48B7-9E7C-2F25857C8DF5")]
[NativeTypeName("struct IRendezvousSession : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRendezvousSession : IRendezvousSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRendezvousSession));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRendezvousSession, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRendezvousSession, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRendezvousSession, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT get_State(RENDEZVOUS_SESSION_STATE* pSessionState)
    {
        return (
            (delegate* unmanaged<IRendezvousSession, RENDEZVOUS_SESSION_STATE*, int>)((*lpVtbl)[3])
        )(this, pSessionState);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT get_RemoteUser([NativeTypeName("BSTR *")] ushort** bstrUserName)
    {
        return ((delegate* unmanaged<IRendezvousSession, ushort**, int>)((*lpVtbl)[4]))(
            this,
            bstrUserName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT get_Flags([NativeTypeName("LONG *")] int* pFlags)
    {
        return ((delegate* unmanaged<IRendezvousSession, int*, int>)((*lpVtbl)[5]))(this, pFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SendContextData([NativeTypeName("BSTR")] ushort* bstrData)
    {
        return ((delegate* unmanaged<IRendezvousSession, ushort*, int>)((*lpVtbl)[6]))(
            this,
            bstrData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Terminate(HRESULT hr, [NativeTypeName("BSTR")] ushort* bstrAppData)
    {
        return ((delegate* unmanaged<IRendezvousSession, HRESULT, ushort*, int>)((*lpVtbl)[7]))(
            this,
            hr,
            bstrAppData
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT get_State(RENDEZVOUS_SESSION_STATE* pSessionState);

        [VtblIndex(4)]
        HRESULT get_RemoteUser([NativeTypeName("BSTR *")] ushort** bstrUserName);

        [VtblIndex(5)]
        HRESULT get_Flags([NativeTypeName("LONG *")] int* pFlags);

        [VtblIndex(6)]
        HRESULT SendContextData([NativeTypeName("BSTR")] ushort* bstrData);

        [VtblIndex(7)]
        HRESULT Terminate(HRESULT hr, [NativeTypeName("BSTR")] ushort* bstrAppData);
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

        [NativeTypeName("HRESULT (RENDEZVOUS_SESSION_STATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RENDEZVOUS_SESSION_STATE*, int> get_State;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_RemoteUser;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Flags;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SendContextData;

        [NativeTypeName("HRESULT (HRESULT, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, ushort*, int> Terminate;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRendezvousSession"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRendezvousSession(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRendezvousSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRendezvousSession(Silk.NET.Windows.IUnknown value)
    {
        return new IRendezvousSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRendezvousSession"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRendezvousSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRendezvousSession value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
