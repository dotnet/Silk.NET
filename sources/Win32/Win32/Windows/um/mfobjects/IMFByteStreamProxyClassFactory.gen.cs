// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A6B43F84-5C0A-42E8-A44D-B1857A76992F")]
[NativeTypeName("struct IMFByteStreamProxyClassFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFByteStreamProxyClassFactory
    : IMFByteStreamProxyClassFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFByteStreamProxyClassFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IMFByteStreamProxyClassFactory, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMFByteStreamProxyClassFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFByteStreamProxyClassFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateByteStreamProxy(
        IMFByteStream pByteStream,
        IMFAttributes pAttributes,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPVOID *")] void** ppvObject
    )
    {
        return (
            (delegate* unmanaged<
                IMFByteStreamProxyClassFactory,
                IMFByteStream,
                IMFAttributes,
                Guid*,
                void**,
                int>)((*lpVtbl)[3])
        )(this, pByteStream, pAttributes, riid, ppvObject);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateByteStreamProxy(
            IMFByteStream pByteStream,
            IMFAttributes pAttributes,
            [NativeTypeName("const IID &")] Guid* riid,
            [NativeTypeName("LPVOID *")] void** ppvObject
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

        [NativeTypeName(
            "HRESULT (IMFByteStream *, IMFAttributes *, const IID &, LPVOID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IMFByteStream,
            IMFAttributes,
            Guid*,
            void**,
            int> CreateByteStreamProxy;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFByteStreamProxyClassFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFByteStreamProxyClassFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFByteStreamProxyClassFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFByteStreamProxyClassFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IMFByteStreamProxyClassFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFByteStreamProxyClassFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFByteStreamProxyClassFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFByteStreamProxyClassFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
