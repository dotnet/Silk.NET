// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F6A6-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLPainter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IHTMLPainter : IHTMLPainter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLPainter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLPainter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLPainter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLPainter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Draw(
        RECT rcBounds,
        RECT rcUpdate,
        [NativeTypeName("LONG")] int lDrawFlags,
        HDC hdc,
        [NativeTypeName("LPVOID")] void* pvDrawObject
    )
    {
        return (
            (delegate* unmanaged<IHTMLPainter, RECT, RECT, int, HDC, void*, int>)((*lpVtbl)[3])
        )(this, rcBounds, rcUpdate, lDrawFlags, hdc, pvDrawObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnResize(SIZE size)
    {
        return ((delegate* unmanaged<IHTMLPainter, SIZE, int>)((*lpVtbl)[4]))(this, size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPainterInfo(HTML_PAINTER_INFO* pInfo)
    {
        return ((delegate* unmanaged<IHTMLPainter, HTML_PAINTER_INFO*, int>)((*lpVtbl)[5]))(
            this,
            pInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT HitTestPoint(POINT pt, BOOL* pbHit, [NativeTypeName("LONG *")] int* plPartID)
    {
        return ((delegate* unmanaged<IHTMLPainter, POINT, BOOL*, int*, int>)((*lpVtbl)[6]))(
            this,
            pt,
            pbHit,
            plPartID
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Draw(
            RECT rcBounds,
            RECT rcUpdate,
            [NativeTypeName("LONG")] int lDrawFlags,
            HDC hdc,
            [NativeTypeName("LPVOID")] void* pvDrawObject
        );

        [VtblIndex(4)]
        HRESULT OnResize(SIZE size);

        [VtblIndex(5)]
        HRESULT GetPainterInfo(HTML_PAINTER_INFO* pInfo);

        [VtblIndex(6)]
        HRESULT HitTestPoint(POINT pt, BOOL* pbHit, [NativeTypeName("LONG *")] int* plPartID);
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

        [NativeTypeName("HRESULT (RECT, RECT, LONG, HDC, LPVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT, RECT, int, HDC, void*, int> Draw;

        [NativeTypeName("HRESULT (SIZE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, SIZE, int> OnResize;

        [NativeTypeName("HRESULT (HTML_PAINTER_INFO *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HTML_PAINTER_INFO*, int> GetPainterInfo;

        [NativeTypeName("HRESULT (POINT, BOOL *, LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT, BOOL*, int*, int> HitTestPoint;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLPainter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLPainter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLPainter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLPainter(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLPainter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLPainter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLPainter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLPainter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
