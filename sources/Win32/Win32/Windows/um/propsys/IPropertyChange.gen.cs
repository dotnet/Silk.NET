// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F917BC8A-1BBA-4478-A245-1BDE03EB9431")]
[NativeTypeName("struct IPropertyChange : IObjectWithPropertyKey")]
[NativeInheritance("IObjectWithPropertyKey")]
public unsafe partial struct IPropertyChange : IPropertyChange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyChange));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyChange, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertyChange, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyChange, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key)
    {
        return ((delegate* unmanaged<IPropertyChange, PROPERTYKEY*, int>)((*lpVtbl)[3]))(this, key);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPropertyKey(PROPERTYKEY* pkey)
    {
        return ((delegate* unmanaged<IPropertyChange, PROPERTYKEY*, int>)((*lpVtbl)[4]))(
            this,
            pkey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT ApplyToPropVariant(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
        PROPVARIANT* ppropvarOut
    )
    {
        return (
            (delegate* unmanaged<IPropertyChange, PROPVARIANT*, PROPVARIANT*, int>)((*lpVtbl)[5])
        )(this, propvarIn, ppropvarOut);
    }

    public interface Interface : IObjectWithPropertyKey.Interface
    {
        [VtblIndex(5)]
        HRESULT ApplyToPropVariant(
            [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvarIn,
            PROPVARIANT* ppropvarOut
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

        [NativeTypeName("HRESULT (const PROPERTYKEY &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> SetPropertyKey;

        [NativeTypeName("HRESULT (PROPERTYKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPERTYKEY*, int> GetPropertyKey;

        [NativeTypeName("HRESULT (const PROPVARIANT &, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, PROPVARIANT*, int> ApplyToPropVariant;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyChange"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyChange(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IObjectWithPropertyKey"/> to <see cref = "IPropertyChange"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IObjectWithPropertyKey"/> instance to be converted </param>
    public static explicit operator IPropertyChange(Silk.NET.Windows.IObjectWithPropertyKey value)
    {
        return new IPropertyChange(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyChange"/> to <see cref = "Silk.NET.Windows.IObjectWithPropertyKey"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyChange"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IObjectWithPropertyKey(IPropertyChange value)
    {
        return new Silk.NET.Windows.IObjectWithPropertyKey(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyChange"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyChange(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyChange(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyChange"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyChange"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyChange value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
