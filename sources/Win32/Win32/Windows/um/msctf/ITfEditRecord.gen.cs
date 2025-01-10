// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("42D4D099-7C1A-4A89-B836-6C6F22160DF0")]
[NativeTypeName("struct ITfEditRecord : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfEditRecord : ITfEditRecord.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfEditRecord));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfEditRecord, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfEditRecord, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfEditRecord, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSelectionStatus(BOOL* pfChanged)
    {
        return ((delegate* unmanaged<ITfEditRecord, BOOL*, int>)((*lpVtbl)[3]))(this, pfChanged);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTextAndPropertyUpdates(
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const GUID **")] Guid** prgProperties,
        [NativeTypeName("ULONG")] uint cProperties,
        IEnumTfRanges* ppEnum
    )
    {
        return (
            (delegate* unmanaged<ITfEditRecord, uint, Guid**, uint, IEnumTfRanges*, int>)(
                (*lpVtbl)[4]
            )
        )(this, dwFlags, prgProperties, cProperties, ppEnum);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSelectionStatus(BOOL* pfChanged);

        [VtblIndex(4)]
        HRESULT GetTextAndPropertyUpdates(
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("const GUID **")] Guid** prgProperties,
            [NativeTypeName("ULONG")] uint cProperties,
            IEnumTfRanges* ppEnum
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

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetSelectionStatus;

        [NativeTypeName(
            "HRESULT (DWORD, const GUID **, ULONG, IEnumTfRanges **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            Guid**,
            uint,
            IEnumTfRanges*,
            int> GetTextAndPropertyUpdates;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfEditRecord"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfEditRecord(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfEditRecord"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfEditRecord(Silk.NET.Windows.IUnknown value)
    {
        return new ITfEditRecord(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfEditRecord"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfEditRecord"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfEditRecord value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
