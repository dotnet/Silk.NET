// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000015B-0000-0000-C000-000000000046")]
[NativeTypeName("struct IGlobalOptions : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IGlobalOptions : IGlobalOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IGlobalOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IGlobalOptions, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IGlobalOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IGlobalOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Set(GLOBALOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR")] nuint dwValue)
    {
        return (
            (delegate* unmanaged<IGlobalOptions, GLOBALOPT_PROPERTIES, nuint, int>)((*lpVtbl)[3])
        )(this, dwProperty, dwValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Query(
        GLOBALOPT_PROPERTIES dwProperty,
        [NativeTypeName("ULONG_PTR *")] nuint* pdwValue
    )
    {
        return (
            (delegate* unmanaged<IGlobalOptions, GLOBALOPT_PROPERTIES, nuint*, int>)((*lpVtbl)[4])
        )(this, dwProperty, pdwValue);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Set(GLOBALOPT_PROPERTIES dwProperty, [NativeTypeName("ULONG_PTR")] nuint dwValue);

        [VtblIndex(4)]
        HRESULT Query(
            GLOBALOPT_PROPERTIES dwProperty,
            [NativeTypeName("ULONG_PTR *")] nuint* pdwValue
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

        [NativeTypeName("HRESULT (GLOBALOPT_PROPERTIES, ULONG_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, GLOBALOPT_PROPERTIES, nuint, int> Set;

        [NativeTypeName("HRESULT (GLOBALOPT_PROPERTIES, ULONG_PTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, GLOBALOPT_PROPERTIES, nuint*, int> Query;
    }

    /// <summary>Initializes a new instance of the <see cref = "IGlobalOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IGlobalOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IGlobalOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IGlobalOptions(Silk.NET.Windows.IUnknown value)
    {
        return new IGlobalOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IGlobalOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IGlobalOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IGlobalOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
