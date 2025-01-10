// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("969DC708-5C76-11D1-8D86-0000F804B057")]
[NativeTypeName("struct IThumbnailExtractor : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IThumbnailExtractor : IThumbnailExtractor.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IThumbnailExtractor));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IThumbnailExtractor, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IThumbnailExtractor, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IThumbnailExtractor, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ExtractThumbnail(
        IStorage pStg,
        [NativeTypeName("ULONG")] uint ulLength,
        [NativeTypeName("ULONG")] uint ulHeight,
        [NativeTypeName("ULONG *")] uint* pulOutputLength,
        [NativeTypeName("ULONG *")] uint* pulOutputHeight,
        HBITMAP* phOutputBitmap
    )
    {
        return (
            (delegate* unmanaged<
                IThumbnailExtractor,
                IStorage,
                uint,
                uint,
                uint*,
                uint*,
                HBITMAP*,
                int>)((*lpVtbl)[3])
        )(this, pStg, ulLength, ulHeight, pulOutputLength, pulOutputHeight, phOutputBitmap);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnFileUpdated(IStorage pStg)
    {
        return ((delegate* unmanaged<IThumbnailExtractor, IStorage, int>)((*lpVtbl)[4]))(
            this,
            pStg
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ExtractThumbnail(
            IStorage pStg,
            [NativeTypeName("ULONG")] uint ulLength,
            [NativeTypeName("ULONG")] uint ulHeight,
            [NativeTypeName("ULONG *")] uint* pulOutputLength,
            [NativeTypeName("ULONG *")] uint* pulOutputHeight,
            HBITMAP* phOutputBitmap
        );

        [VtblIndex(4)]
        HRESULT OnFileUpdated(IStorage pStg);
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
            "HRESULT (IStorage *, ULONG, ULONG, ULONG *, ULONG *, HBITMAP *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorage,
            uint,
            uint,
            uint*,
            uint*,
            HBITMAP*,
            int> ExtractThumbnail;

        [NativeTypeName("HRESULT (IStorage *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStorage, int> OnFileUpdated;
    }

    /// <summary>Initializes a new instance of the <see cref = "IThumbnailExtractor"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IThumbnailExtractor(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IThumbnailExtractor"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IThumbnailExtractor(Silk.NET.Windows.IUnknown value)
    {
        return new IThumbnailExtractor(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IThumbnailExtractor"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IThumbnailExtractor"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IThumbnailExtractor value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
