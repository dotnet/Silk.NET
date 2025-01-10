// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("75BD59AA-F23B-4963-ABA4-0B355752A91B")]
[NativeTypeName("struct IPropertyKeyStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyKeyStore : IPropertyKeyStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyKeyStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyKeyStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertyKeyStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyKeyStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetKeyCount(int* keyCount)
    {
        return ((delegate* unmanaged<IPropertyKeyStore, int*, int>)((*lpVtbl)[3]))(this, keyCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetKeyAt(int index, PROPERTYKEY* pkey)
    {
        return ((delegate* unmanaged<IPropertyKeyStore, int, PROPERTYKEY*, int>)((*lpVtbl)[4]))(
            this,
            index,
            pkey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AppendKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IPropertyKeyStore, PROPERTYKEY*, int>)((*lpVtbl)[5]))(
            this,
            key
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT DeleteKey(int index)
    {
        return ((delegate* unmanaged<IPropertyKeyStore, int, int>)((*lpVtbl)[6]))(this, index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT IsKeyInStore([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IPropertyKeyStore, PROPERTYKEY*, int>)((*lpVtbl)[7]))(
            this,
            key
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IPropertyKeyStore, PROPERTYKEY*, int>)((*lpVtbl)[8]))(
            this,
            key
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetKeyCount(int* keyCount);

        [VtblIndex(4)]
        HRESULT GetKeyAt(int index, PROPERTYKEY* pkey);

        [VtblIndex(5)]
        HRESULT AppendKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key);

        [VtblIndex(6)]
        HRESULT DeleteKey(int index);

        [VtblIndex(7)]
        HRESULT IsKeyInStore([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key);

        [VtblIndex(8)]
        HRESULT RemoveKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key);
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

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetKeyCount;

        [NativeTypeName("HRESULT (int, PROPERTYKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, PROPERTYKEY*, int> GetKeyAt;

        [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> AppendKey;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> DeleteKey;

        [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> IsKeyInStore;

        [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> RemoveKey;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyKeyStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyKeyStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyKeyStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyKeyStore(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyKeyStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyKeyStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyKeyStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyKeyStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
