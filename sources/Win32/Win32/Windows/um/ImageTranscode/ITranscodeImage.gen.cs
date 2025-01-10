// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ImageTranscode.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BAE86DDD-DC11-421C-B7AB-CC55D1D65C44")]
[NativeTypeName("struct ITranscodeImage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITranscodeImage : ITranscodeImage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITranscodeImage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITranscodeImage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITranscodeImage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITranscodeImage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT TranscodeImage(
        IShellItem pShellItem,
        uint uiMaxWidth,
        uint uiMaxHeight,
        [NativeTypeName("DWORD")] uint flags,
        IStream pvImage,
        uint* puiWidth,
        uint* puiHeight
    )
    {
        return (
            (delegate* unmanaged<
                ITranscodeImage,
                IShellItem,
                uint,
                uint,
                uint,
                IStream,
                uint*,
                uint*,
                int>)((*lpVtbl)[3])
        )(this, pShellItem, uiMaxWidth, uiMaxHeight, flags, pvImage, puiWidth, puiHeight);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT TranscodeImage(
            IShellItem pShellItem,
            uint uiMaxWidth,
            uint uiMaxHeight,
            [NativeTypeName("DWORD")] uint flags,
            IStream pvImage,
            uint* puiWidth,
            uint* puiHeight
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
            "HRESULT (IShellItem *, UINT, UINT, DWORD, IStream *, UINT *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            uint,
            uint,
            uint,
            IStream,
            uint*,
            uint*,
            int> TranscodeImage;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITranscodeImage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITranscodeImage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITranscodeImage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITranscodeImage(Silk.NET.Windows.IUnknown value)
    {
        return new ITranscodeImage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITranscodeImage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITranscodeImage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITranscodeImage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
