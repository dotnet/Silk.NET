// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("E9CD0384-A268-4BB4-82DE-658D53574D41")]
[NativeTypeName("struct IMFNetProxyLocatorFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFNetProxyLocatorFactory
    : IMFNetProxyLocatorFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFNetProxyLocatorFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFNetProxyLocatorFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFNetProxyLocatorFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFNetProxyLocatorFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateProxyLocator(
        [NativeTypeName("LPCWSTR")] ushort* pszProtocol,
        IMFNetProxyLocator* ppProxyLocator
    )
    {
        return (
            (delegate* unmanaged<IMFNetProxyLocatorFactory, ushort*, IMFNetProxyLocator*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pszProtocol, ppProxyLocator);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateProxyLocator(
            [NativeTypeName("LPCWSTR")] ushort* pszProtocol,
            IMFNetProxyLocator* ppProxyLocator
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

        [NativeTypeName("HRESULT (LPCWSTR, IMFNetProxyLocator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IMFNetProxyLocator*, int> CreateProxyLocator;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFNetProxyLocatorFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFNetProxyLocatorFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFNetProxyLocatorFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFNetProxyLocatorFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IMFNetProxyLocatorFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFNetProxyLocatorFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFNetProxyLocatorFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFNetProxyLocatorFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
