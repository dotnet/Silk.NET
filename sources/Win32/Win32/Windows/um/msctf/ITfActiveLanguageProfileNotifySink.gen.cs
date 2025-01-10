// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("B246CB75-A93E-4652-BF8C-B3FE0CFD7E57")]
[NativeTypeName("struct ITfActiveLanguageProfileNotifySink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfActiveLanguageProfileNotifySink
    : ITfActiveLanguageProfileNotifySink.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfActiveLanguageProfileNotifySink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfActiveLanguageProfileNotifySink, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfActiveLanguageProfileNotifySink, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfActiveLanguageProfileNotifySink, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnActivated(
        [NativeTypeName("const IID &")] Guid* clsid,
        [NativeTypeName("const GUID &")] Guid* guidProfile,
        BOOL fActivated
    )
    {
        return (
            (delegate* unmanaged<ITfActiveLanguageProfileNotifySink, Guid*, Guid*, BOOL, int>)(
                (*lpVtbl)[3]
            )
        )(this, clsid, guidProfile, fActivated);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnActivated(
            [NativeTypeName("const IID &")] Guid* clsid,
            [NativeTypeName("const GUID &")] Guid* guidProfile,
            BOOL fActivated
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

        [NativeTypeName("HRESULT (const IID &, const GUID &, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, BOOL, int> OnActivated;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfActiveLanguageProfileNotifySink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfActiveLanguageProfileNotifySink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfActiveLanguageProfileNotifySink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfActiveLanguageProfileNotifySink(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ITfActiveLanguageProfileNotifySink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfActiveLanguageProfileNotifySink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfActiveLanguageProfileNotifySink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ITfActiveLanguageProfileNotifySink value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
