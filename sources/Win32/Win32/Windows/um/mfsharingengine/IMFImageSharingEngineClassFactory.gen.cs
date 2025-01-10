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

[Guid("1FC55727-A7FB-4FC8-83AE-8AF024990AF1")]
[NativeTypeName("struct IMFImageSharingEngineClassFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFImageSharingEngineClassFactory
    : IMFImageSharingEngineClassFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFImageSharingEngineClassFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFImageSharingEngineClassFactory, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFImageSharingEngineClassFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFImageSharingEngineClassFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateInstanceFromUDN(
        [NativeTypeName("BSTR")] ushort* pUniqueDeviceName,
        IMFImageSharingEngine* ppEngine
    )
    {
        return (
            (delegate* unmanaged<
                IMFImageSharingEngineClassFactory,
                ushort*,
                IMFImageSharingEngine*,
                int>)((*lpVtbl)[3])
        )(this, pUniqueDeviceName, ppEngine);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateInstanceFromUDN(
            [NativeTypeName("BSTR")] ushort* pUniqueDeviceName,
            IMFImageSharingEngine* ppEngine
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

        [NativeTypeName("HRESULT (BSTR, IMFImageSharingEngine **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IMFImageSharingEngine*,
            int> CreateInstanceFromUDN;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFImageSharingEngineClassFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFImageSharingEngineClassFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFImageSharingEngineClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFImageSharingEngineClassFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IMFImageSharingEngineClassFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFImageSharingEngineClassFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFImageSharingEngineClassFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IMFImageSharingEngineClassFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
