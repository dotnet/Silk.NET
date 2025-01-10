// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("505F1513-6B3E-4892-A272-59F8889A4D3E")]
[NativeTypeName("struct IImageRecompress : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IImageRecompress : IImageRecompress.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IImageRecompress));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IImageRecompress, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IImageRecompress, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IImageRecompress, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RecompressImage(
        IShellItem psi,
        int cx,
        int cy,
        int iQuality,
        IStorage pstg,
        IStream* ppstrmOut
    )
    {
        return (
            (delegate* unmanaged<
                IImageRecompress,
                IShellItem,
                int,
                int,
                int,
                IStorage,
                IStream*,
                int>)((*lpVtbl)[3])
        )(this, psi, cx, cy, iQuality, pstg, ppstrmOut);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RecompressImage(
            IShellItem psi,
            int cx,
            int cy,
            int iQuality,
            IStorage pstg,
            IStream* ppstrmOut
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
            "HRESULT (IShellItem *, int, int, int, IStorage *, IStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            int,
            int,
            int,
            IStorage,
            IStream*,
            int> RecompressImage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IImageRecompress"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IImageRecompress(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IImageRecompress"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IImageRecompress(Silk.NET.Windows.IUnknown value)
    {
        return new IImageRecompress(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IImageRecompress"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IImageRecompress"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IImageRecompress value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
