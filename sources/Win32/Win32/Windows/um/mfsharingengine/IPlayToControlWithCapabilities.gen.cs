// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AA9DD80F-C50A-4220-91C1-332287F82A34")]
[NativeTypeName("struct IPlayToControlWithCapabilities : IPlayToControl")]
[NativeInheritance("IPlayToControl")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IPlayToControlWithCapabilities
    : IPlayToControlWithCapabilities.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPlayToControlWithCapabilities));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPlayToControlWithCapabilities, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Connect(IMFSharingEngineClassFactory pFactory)
    {
        return (
            (delegate* unmanaged<
                IPlayToControlWithCapabilities,
                IMFSharingEngineClassFactory,
                int>)((*lpVtbl)[3])
        )(this, pFactory);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Disconnect()
    {
        return ((delegate* unmanaged<IPlayToControlWithCapabilities, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCapabilities(PLAYTO_SOURCE_CREATEFLAGS* pCapabilities)
    {
        return (
            (delegate* unmanaged<IPlayToControlWithCapabilities, PLAYTO_SOURCE_CREATEFLAGS*, int>)(
                (*lpVtbl)[5]
            )
        )(this, pCapabilities);
    }

    public interface Interface : IPlayToControl.Interface
    {
        [VtblIndex(5)]
        HRESULT GetCapabilities(PLAYTO_SOURCE_CREATEFLAGS* pCapabilities);
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

        [NativeTypeName("HRESULT (IMFSharingEngineClassFactory *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMFSharingEngineClassFactory, int> Connect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Disconnect;

        [NativeTypeName("HRESULT (PLAYTO_SOURCE_CREATEFLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PLAYTO_SOURCE_CREATEFLAGS*, int> GetCapabilities;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPlayToControlWithCapabilities"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPlayToControlWithCapabilities(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPlayToControl"/> to <see cref = "IPlayToControlWithCapabilities"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPlayToControl"/> instance to be converted </param>
    public static explicit operator IPlayToControlWithCapabilities(
        Silk.NET.Windows.IPlayToControl value
    )
    {
        return new IPlayToControlWithCapabilities(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPlayToControlWithCapabilities"/> to <see cref = "Silk.NET.Windows.IPlayToControl"/>.</summary>
    /// <param name = "value">The <see cref = "IPlayToControlWithCapabilities"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPlayToControl(
        IPlayToControlWithCapabilities value
    )
    {
        return new Silk.NET.Windows.IPlayToControl(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPlayToControlWithCapabilities"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPlayToControlWithCapabilities(Silk.NET.Windows.IUnknown value)
    {
        return new IPlayToControlWithCapabilities(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPlayToControlWithCapabilities"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPlayToControlWithCapabilities"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPlayToControlWithCapabilities value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
