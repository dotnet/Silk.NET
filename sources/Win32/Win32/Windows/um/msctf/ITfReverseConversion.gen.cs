// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A415E162-157D-417D-8A8C-0AB26C7D2781")]
[NativeTypeName("struct ITfReverseConversion : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfReverseConversion : ITfReverseConversion.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfReverseConversion));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfReverseConversion, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfReverseConversion, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfReverseConversion, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DoReverseConversion(
        [NativeTypeName("LPCWSTR")] ushort* lpstr,
        ITfReverseConversionList* ppList
    )
    {
        return (
            (delegate* unmanaged<ITfReverseConversion, ushort*, ITfReverseConversionList*, int>)(
                (*lpVtbl)[3]
            )
        )(this, lpstr, ppList);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DoReverseConversion(
            [NativeTypeName("LPCWSTR")] ushort* lpstr,
            ITfReverseConversionList* ppList
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

        [NativeTypeName("HRESULT (LPCWSTR, ITfReverseConversionList **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ITfReverseConversionList*,
            int> DoReverseConversion;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfReverseConversion"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfReverseConversion(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfReverseConversion"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfReverseConversion(Silk.NET.Windows.IUnknown value)
    {
        return new ITfReverseConversion(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfReverseConversion"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfReverseConversion"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfReverseConversion value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
