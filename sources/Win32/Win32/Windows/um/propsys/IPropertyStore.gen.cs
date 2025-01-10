// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("886D8EEB-8CF2-4446-8D02-CDBA1DBDCF99")]
[NativeTypeName("struct IPropertyStore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyStore : IPropertyStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertyStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCount([NativeTypeName("DWORD *")] uint* cProps)
    {
        return ((delegate* unmanaged<IPropertyStore, uint*, int>)((*lpVtbl)[3]))(this, cProps);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetAt([NativeTypeName("DWORD")] uint iProp, PROPERTYKEY* pkey)
    {
        return ((delegate* unmanaged<IPropertyStore, uint, PROPERTYKEY*, int>)((*lpVtbl)[4]))(
            this,
            iProp,
            pkey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetValue(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
        PROPVARIANT* pv
    )
    {
        return (
            (delegate* unmanaged<IPropertyStore, PROPERTYKEY*, PROPVARIANT*, int>)((*lpVtbl)[5])
        )(this, key, pv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetValue(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar
    )
    {
        return (
            (delegate* unmanaged<IPropertyStore, PROPERTYKEY*, PROPVARIANT*, int>)((*lpVtbl)[6])
        )(this, key, propvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IPropertyStore, int>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCount([NativeTypeName("DWORD *")] uint* cProps);

        [VtblIndex(4)]
        HRESULT GetAt([NativeTypeName("DWORD")] uint iProp, PROPERTYKEY* pkey);

        [VtblIndex(5)]
        HRESULT GetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* pv);

        [VtblIndex(6)]
        HRESULT SetValue(
            [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
            [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar
        );

        [VtblIndex(7)]
        HRESULT Commit();
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (DWORD, PROPERTYKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PROPERTYKEY*, int> GetAt;

        [NativeTypeName("HRESULT (const PROPERTYKEY &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, PROPVARIANT*, int> GetValue;

        [NativeTypeName(
            "HRESULT (const PROPERTYKEY &, const PROPVARIANT &) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, PROPVARIANT*, int> SetValue;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Commit;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyStore(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
