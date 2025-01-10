// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("196BF9A5-B346-4EF0-AA1E-5DCDB76768B1")]
[NativeTypeName("struct IPreviewHandlerVisuals : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPreviewHandlerVisuals : IPreviewHandlerVisuals.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPreviewHandlerVisuals));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPreviewHandlerVisuals, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPreviewHandlerVisuals, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPreviewHandlerVisuals, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetBackgroundColor(COLORREF color)
    {
        return ((delegate* unmanaged<IPreviewHandlerVisuals, COLORREF, int>)((*lpVtbl)[3]))(
            this,
            color
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetFont([NativeTypeName("const LOGFONTW *")] LOGFONTW* plf)
    {
        return ((delegate* unmanaged<IPreviewHandlerVisuals, LOGFONTW*, int>)((*lpVtbl)[4]))(
            this,
            plf
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetTextColor(COLORREF color)
    {
        return ((delegate* unmanaged<IPreviewHandlerVisuals, COLORREF, int>)((*lpVtbl)[5]))(
            this,
            color
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetBackgroundColor(COLORREF color);

        [VtblIndex(4)]
        HRESULT SetFont([NativeTypeName("const LOGFONTW *")] LOGFONTW* plf);

        [VtblIndex(5)]
        HRESULT SetTextColor(COLORREF color);
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

        [NativeTypeName("HRESULT (COLORREF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF, int> SetBackgroundColor;

        [NativeTypeName("HRESULT (const LOGFONTW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LOGFONTW*, int> SetFont;

        [NativeTypeName("HRESULT (COLORREF) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, COLORREF, int> SetTextColor;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPreviewHandlerVisuals"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPreviewHandlerVisuals(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPreviewHandlerVisuals"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPreviewHandlerVisuals(Silk.NET.Windows.IUnknown value)
    {
        return new IPreviewHandlerVisuals(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPreviewHandlerVisuals"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPreviewHandlerVisuals"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPreviewHandlerVisuals value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
