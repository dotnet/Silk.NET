// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FEE47777-163C-4769-996A-6E9C50AD8F54")]
[NativeTypeName("struct ITfDisplayAttributeProvider : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfDisplayAttributeProvider
    : ITfDisplayAttributeProvider.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfDisplayAttributeProvider));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfDisplayAttributeProvider, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfDisplayAttributeProvider, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfDisplayAttributeProvider, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EnumDisplayAttributeInfo(IEnumTfDisplayAttributeInfo* ppEnum)
    {
        return (
            (delegate* unmanaged<ITfDisplayAttributeProvider, IEnumTfDisplayAttributeInfo*, int>)(
                (*lpVtbl)[3]
            )
        )(this, ppEnum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetDisplayAttributeInfo(
        [NativeTypeName("const GUID &")] Guid* guid,
        ITfDisplayAttributeInfo* ppInfo
    )
    {
        return (
            (delegate* unmanaged<
                ITfDisplayAttributeProvider,
                Guid*,
                ITfDisplayAttributeInfo*,
                int>)((*lpVtbl)[4])
        )(this, guid, ppInfo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EnumDisplayAttributeInfo(IEnumTfDisplayAttributeInfo* ppEnum);

        [VtblIndex(4)]
        HRESULT GetDisplayAttributeInfo(
            [NativeTypeName("const GUID &")] Guid* guid,
            ITfDisplayAttributeInfo* ppInfo
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

        [NativeTypeName("HRESULT (IEnumTfDisplayAttributeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            IEnumTfDisplayAttributeInfo*,
            int> EnumDisplayAttributeInfo;

        [NativeTypeName(
            "HRESULT (const GUID &, ITfDisplayAttributeInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ITfDisplayAttributeInfo*,
            int> GetDisplayAttributeInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfDisplayAttributeProvider"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfDisplayAttributeProvider(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfDisplayAttributeProvider"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfDisplayAttributeProvider(Silk.NET.Windows.IUnknown value)
    {
        return new ITfDisplayAttributeProvider(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfDisplayAttributeProvider"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfDisplayAttributeProvider"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfDisplayAttributeProvider value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
