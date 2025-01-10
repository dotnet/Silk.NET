// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D3EEF34C-0667-4AFC-8D13-867607B0FE91")]
[NativeTypeName("struct ICompositorInterop2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICompositorInterop2 : ICompositorInterop2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositorInterop2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICompositorInterop2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICompositorInterop2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositorInterop2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CheckCompositionTextureSupport(
        IUnknown renderingDevice,
        BOOL* supportsCompositionTextures
    )
    {
        return ((delegate* unmanaged<ICompositorInterop2, IUnknown, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            renderingDevice,
            supportsCompositionTextures
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateCompositionTexture(
        IUnknown d3dTexture,
        ICompositionTexture* compositionTexture
    )
    {
        return (
            (delegate* unmanaged<ICompositorInterop2, IUnknown, ICompositionTexture*, int>)(
                (*lpVtbl)[4]
            )
        )(this, d3dTexture, compositionTexture);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CheckCompositionTextureSupport(
            IUnknown renderingDevice,
            BOOL* supportsCompositionTextures
        );

        [VtblIndex(4)]
        HRESULT CreateCompositionTexture(
            IUnknown d3dTexture,
            ICompositionTexture* compositionTexture
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
            "HRESULT (IUnknown *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUnknown, BOOL*, int> CheckCompositionTextureSupport;

        [NativeTypeName(
            "HRESULT (IUnknown *, ICompositionTexture **) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            ICompositionTexture*,
            int> CreateCompositionTexture;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositorInterop2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositorInterop2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositorInterop2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositorInterop2(Silk.NET.Windows.IUnknown value)
    {
        return new ICompositorInterop2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositorInterop2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositorInterop2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICompositorInterop2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
