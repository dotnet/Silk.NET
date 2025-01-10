// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UIAnimation.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.DirectX;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("95609569-C5F0-47F9-8804-5345F2E2767E")]
[NativeTypeName("struct IPresentationSurface2 : IPresentationSurface")]
[NativeInheritance("IPresentationSurface")]
public unsafe partial struct IPresentationSurface2 : IPresentationSurface2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPresentationSurface2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPresentationSurface2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPresentationSurface2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPresentationSurface2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void SetTag([NativeTypeName("UINT_PTR")] nuint tag)
    {
        ((delegate* unmanaged<IPresentationSurface2, nuint, void>)((*lpVtbl)[3]))(this, tag);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetBuffer(IPresentationBuffer presentationBuffer)
    {
        return (
            (delegate* unmanaged<IPresentationSurface2, IPresentationBuffer, int>)((*lpVtbl)[4])
        )(this, presentationBuffer);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetColorSpace(DXGI_COLOR_SPACE_TYPE colorSpace)
    {
        return (
            (delegate* unmanaged<IPresentationSurface2, DXGI_COLOR_SPACE_TYPE, int>)((*lpVtbl)[5])
        )(this, colorSpace);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetAlphaMode(DXGI_ALPHA_MODE alphaMode)
    {
        return ((delegate* unmanaged<IPresentationSurface2, DXGI_ALPHA_MODE, int>)((*lpVtbl)[6]))(
            this,
            alphaMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetSourceRect([NativeTypeName("const RECT *")] RECT* sourceRect)
    {
        return ((delegate* unmanaged<IPresentationSurface2, RECT*, int>)((*lpVtbl)[7]))(
            this,
            sourceRect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTransform(PresentationTransform* transform)
    {
        return (
            (delegate* unmanaged<IPresentationSurface2, PresentationTransform*, int>)((*lpVtbl)[8])
        )(this, transform);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RestrictToOutput(IUnknown output)
    {
        return ((delegate* unmanaged<IPresentationSurface2, IUnknown, int>)((*lpVtbl)[9]))(
            this,
            output
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDisableReadback([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IPresentationSurface2, byte, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetLetterboxingMargins(
        float leftLetterboxSize,
        float topLetterboxSize,
        float rightLetterboxSize,
        float bottomLetterboxSize
    )
    {
        return (
            (delegate* unmanaged<IPresentationSurface2, float, float, float, float, int>)(
                (*lpVtbl)[11]
            )
        )(this, leftLetterboxSize, topLetterboxSize, rightLetterboxSize, bottomLetterboxSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void SetIsHdrContent([NativeTypeName("boolean")] byte isHdrContent)
    {
        ((delegate* unmanaged<IPresentationSurface2, byte, void>)((*lpVtbl)[12]))(
            this,
            isHdrContent
        );
    }

    public interface Interface : IPresentationSurface.Interface
    {
        [VtblIndex(12)]
        void SetIsHdrContent([NativeTypeName("boolean")] byte isHdrContent);
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

        [NativeTypeName("void (UINT_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, void> SetTag;

        [NativeTypeName("HRESULT (IPresentationBuffer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IPresentationBuffer, int> SetBuffer;

        [NativeTypeName("HRESULT (DXGI_COLOR_SPACE_TYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_COLOR_SPACE_TYPE, int> SetColorSpace;

        [NativeTypeName("HRESULT (DXGI_ALPHA_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DXGI_ALPHA_MODE, int> SetAlphaMode;

        [NativeTypeName("HRESULT (const RECT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, int> SetSourceRect;

        [NativeTypeName("HRESULT (PresentationTransform *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PresentationTransform*, int> SetTransform;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> RestrictToOutput;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> SetDisableReadback;

        [NativeTypeName("HRESULT (float, float, float, float) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float, float, float, float, int> SetLetterboxingMargins;

        [NativeTypeName("void (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, void> SetIsHdrContent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPresentationSurface2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPresentationSurface2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPresentationSurface"/> to <see cref = "IPresentationSurface2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPresentationSurface"/> instance to be converted </param>
    public static explicit operator IPresentationSurface2(
        Silk.NET.Windows.IPresentationSurface value
    )
    {
        return new IPresentationSurface2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPresentationSurface2"/> to <see cref = "Silk.NET.Windows.IPresentationSurface"/>.</summary>
    /// <param name = "value">The <see cref = "IPresentationSurface2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPresentationSurface(
        IPresentationSurface2 value
    )
    {
        return new Silk.NET.Windows.IPresentationSurface(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPresentationContent"/> to <see cref = "IPresentationSurface2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPresentationContent"/> instance to be converted </param>
    public static explicit operator IPresentationSurface2(
        Silk.NET.Windows.IPresentationContent value
    )
    {
        return new IPresentationSurface2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPresentationSurface2"/> to <see cref = "Silk.NET.Windows.IPresentationContent"/>.</summary>
    /// <param name = "value">The <see cref = "IPresentationSurface2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPresentationContent(
        IPresentationSurface2 value
    )
    {
        return new Silk.NET.Windows.IPresentationContent(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPresentationSurface2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPresentationSurface2(Silk.NET.Windows.IUnknown value)
    {
        return new IPresentationSurface2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPresentationSurface2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPresentationSurface2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPresentationSurface2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
