// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0FAB9BDB-D250-4169-84E5-6BE118FDD7A8")]
[NativeTypeName("struct ITfQueryEmbedded : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfQueryEmbedded : ITfQueryEmbedded.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfQueryEmbedded));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfQueryEmbedded, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfQueryEmbedded, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfQueryEmbedded, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT QueryInsertEmbedded(
        [NativeTypeName("const GUID *")] Guid* pguidService,
        [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc,
        BOOL* pfInsertable
    )
    {
        return (
            (delegate* unmanaged<ITfQueryEmbedded, Guid*, FORMATETC*, BOOL*, int>)((*lpVtbl)[3])
        )(this, pguidService, pFormatEtc, pfInsertable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT QueryInsertEmbedded(
            [NativeTypeName("const GUID *")] Guid* pguidService,
            [NativeTypeName("const FORMATETC *")] FORMATETC* pFormatEtc,
            BOOL* pfInsertable
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
            "HRESULT (const GUID *, const FORMATETC *, BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, FORMATETC*, BOOL*, int> QueryInsertEmbedded;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfQueryEmbedded"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfQueryEmbedded(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfQueryEmbedded"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfQueryEmbedded(Silk.NET.Windows.IUnknown value)
    {
        return new ITfQueryEmbedded(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfQueryEmbedded"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfQueryEmbedded"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfQueryEmbedded value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
