// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("71C6E74E-0F28-11D8-A82A-00065B84435C")]
[NativeTypeName("struct ITfInputProcessorProfileActivationSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfInputProcessorProfileActivationSink
    : ITfInputProcessorProfileActivationSink.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfInputProcessorProfileActivationSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfInputProcessorProfileActivationSink, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfInputProcessorProfileActivationSink, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfInputProcessorProfileActivationSink, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnActivated(
        [NativeTypeName("DWORD")] uint dwProfileType,
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const IID &")] Guid* clsid,
        [NativeTypeName("const GUID &")] Guid* catid,
        [NativeTypeName("const GUID &")] Guid* guidProfile,
        HKL hkl,
        [NativeTypeName("DWORD")] uint dwFlags
    )
    {
        return (
            (delegate* unmanaged<
                ITfInputProcessorProfileActivationSink,
                uint,
                ushort,
                Guid*,
                Guid*,
                Guid*,
                HKL,
                uint,
                int>)((*lpVtbl)[3])
        )(this, dwProfileType, langid, clsid, catid, guidProfile, hkl, dwFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnActivated(
            [NativeTypeName("DWORD")] uint dwProfileType,
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const IID &")] Guid* clsid,
            [NativeTypeName("const GUID &")] Guid* catid,
            [NativeTypeName("const GUID &")] Guid* guidProfile,
            HKL hkl,
            [NativeTypeName("DWORD")] uint dwFlags
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
            "HRESULT (DWORD, LANGID, const IID &, const GUID &, const GUID &, HKL, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort,
            Guid*,
            Guid*,
            Guid*,
            HKL,
            uint,
            int> OnActivated;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfInputProcessorProfileActivationSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfInputProcessorProfileActivationSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfInputProcessorProfileActivationSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfInputProcessorProfileActivationSink(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ITfInputProcessorProfileActivationSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfInputProcessorProfileActivationSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfInputProcessorProfileActivationSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ITfInputProcessorProfileActivationSink value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
