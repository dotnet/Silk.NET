// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4FD67194-1002-4513-BFF2-C0DDF6258552")]
[NativeTypeName("struct ITfInputProcessorProfileSubstituteLayout : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfInputProcessorProfileSubstituteLayout
    : ITfInputProcessorProfileSubstituteLayout.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfInputProcessorProfileSubstituteLayout));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfileSubstituteLayout, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfileSubstituteLayout, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfileSubstituteLayout, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetSubstituteKeyboardLayout(
        [NativeTypeName("const IID &")] Guid* rclsid,
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const GUID &")] Guid* guidProfile,
        HKL* phKL
    )
    {
        return (
            (delegate* unmanaged<
                ITfInputProcessorProfileSubstituteLayout,
                Guid*,
                ushort,
                Guid*,
                HKL*,
                int>)((*lpVtbl)[3])
        )(this, rclsid, langid, guidProfile, phKL);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetSubstituteKeyboardLayout(
            [NativeTypeName("const IID &")] Guid* rclsid,
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const GUID &")] Guid* guidProfile,
            HKL* phKL
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
            "HRESULT (const IID &, LANGID, const GUID &, HKL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ushort,
            Guid*,
            HKL*,
            int> GetSubstituteKeyboardLayout;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfInputProcessorProfileSubstituteLayout"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfInputProcessorProfileSubstituteLayout(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfInputProcessorProfileSubstituteLayout"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfInputProcessorProfileSubstituteLayout(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ITfInputProcessorProfileSubstituteLayout(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfInputProcessorProfileSubstituteLayout"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfInputProcessorProfileSubstituteLayout"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ITfInputProcessorProfileSubstituteLayout value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
