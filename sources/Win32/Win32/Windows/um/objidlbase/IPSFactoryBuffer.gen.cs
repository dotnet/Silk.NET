// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D5F569D0-593B-101A-B569-08002B2DBF7A")]
[NativeTypeName("struct IPSFactoryBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPSFactoryBuffer : IPSFactoryBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPSFactoryBuffer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPSFactoryBuffer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPSFactoryBuffer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPSFactoryBuffer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateProxy(
        IUnknown pUnkOuter,
        [NativeTypeName("const IID &")] Guid* riid,
        IRpcProxyBuffer* ppProxy,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IPSFactoryBuffer, IUnknown, Guid*, IRpcProxyBuffer*, void**, int>)(
                (*lpVtbl)[3]
            )
        )(this, pUnkOuter, riid, ppProxy, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateStub(
        [NativeTypeName("const IID &")] Guid* riid,
        IUnknown pUnkServer,
        IRpcStubBuffer* ppStub
    )
    {
        return (
            (delegate* unmanaged<IPSFactoryBuffer, Guid*, IUnknown, IRpcStubBuffer*, int>)(
                (*lpVtbl)[4]
            )
        )(this, riid, pUnkServer, ppStub);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateProxy(
            IUnknown pUnkOuter,
            [NativeTypeName("const IID &")] Guid* riid,
            IRpcProxyBuffer* ppProxy,
            void** ppv
        );

        [VtblIndex(4)]
        HRESULT CreateStub(
            [NativeTypeName("const IID &")] Guid* riid,
            IUnknown pUnkServer,
            IRpcStubBuffer* ppStub
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
            "HRESULT (IUnknown *, const IID &, IRpcProxyBuffer **, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            Guid*,
            IRpcProxyBuffer*,
            void**,
            int> CreateProxy;

        [NativeTypeName(
            "HRESULT (const IID &, IUnknown *, IRpcStubBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown, IRpcStubBuffer*, int> CreateStub;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPSFactoryBuffer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPSFactoryBuffer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPSFactoryBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPSFactoryBuffer(Silk.NET.Windows.IUnknown value)
    {
        return new IPSFactoryBuffer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPSFactoryBuffer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPSFactoryBuffer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPSFactoryBuffer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
