// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BC110B6D-57E8-4148-A9C6-91015AB2F3A5")]
[NativeTypeName("struct IPropertyStoreFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyStoreFactory : IPropertyStoreFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyStoreFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyStoreFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertyStoreFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyStoreFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPropertyStore(
        GETPROPERTYSTOREFLAGS flags,
        IUnknown pUnkFactory,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<
                IPropertyStoreFactory,
                GETPROPERTYSTOREFLAGS,
                IUnknown,
                Guid*,
                void**,
                int>)((*lpVtbl)[3])
        )(this, flags, pUnkFactory, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyStoreForKeys(
        [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKeys,
        uint cKeys,
        GETPROPERTYSTOREFLAGS flags,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<
                IPropertyStoreFactory,
                PROPERTYKEY*,
                uint,
                GETPROPERTYSTOREFLAGS,
                Guid*,
                void**,
                int>)((*lpVtbl)[4])
        )(this, rgKeys, cKeys, flags, riid, ppv);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPropertyStore(
            GETPROPERTYSTOREFLAGS flags,
            IUnknown pUnkFactory,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(4)]
        HRESULT GetPropertyStoreForKeys(
            [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgKeys,
            uint cKeys,
            GETPROPERTYSTOREFLAGS flags,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
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
            "HRESULT (GETPROPERTYSTOREFLAGS, IUnknown *, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            GETPROPERTYSTOREFLAGS,
            IUnknown,
            Guid*,
            void**,
            int> GetPropertyStore;

        [NativeTypeName(
            "HRESULT (const PROPERTYKEY *, UINT, GETPROPERTYSTOREFLAGS, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            PROPERTYKEY*,
            uint,
            GETPROPERTYSTOREFLAGS,
            Guid*,
            void**,
            int> GetPropertyStoreForKeys;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyStoreFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyStoreFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyStoreFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyStoreFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyStoreFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyStoreFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyStoreFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyStoreFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
