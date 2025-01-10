// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9F0-BAF9-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IInternetProtocolSinkStackable : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IInternetProtocolSinkStackable
    : IInternetProtocolSinkStackable.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IInternetProtocolSinkStackable));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IInternetProtocolSinkStackable, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IInternetProtocolSinkStackable, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IInternetProtocolSinkStackable, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SwitchSink(IInternetProtocolSink pOIProtSink)
    {
        return (
            (delegate* unmanaged<IInternetProtocolSinkStackable, IInternetProtocolSink, int>)(
                (*lpVtbl)[3]
            )
        )(this, pOIProtSink);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CommitSwitch()
    {
        return ((delegate* unmanaged<IInternetProtocolSinkStackable, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RollbackSwitch()
    {
        return ((delegate* unmanaged<IInternetProtocolSinkStackable, int>)((*lpVtbl)[5]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SwitchSink(IInternetProtocolSink pOIProtSink);

        [VtblIndex(4)]
        HRESULT CommitSwitch();

        [VtblIndex(5)]
        HRESULT RollbackSwitch();
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

        [NativeTypeName("HRESULT (IInternetProtocolSink *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IInternetProtocolSink, int> SwitchSink;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> CommitSwitch;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RollbackSwitch;
    }

    /// <summary>Initializes a new instance of the <see cref = "IInternetProtocolSinkStackable"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IInternetProtocolSinkStackable(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IInternetProtocolSinkStackable"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IInternetProtocolSinkStackable(Silk.NET.Windows.IUnknown value)
    {
        return new IInternetProtocolSinkStackable(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IInternetProtocolSinkStackable"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IInternetProtocolSinkStackable"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IInternetProtocolSinkStackable value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
