// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F4AA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementBehaviorRender : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IElementBehaviorRender : IElementBehaviorRender.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementBehaviorRender));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementBehaviorRender, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IElementBehaviorRender, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementBehaviorRender, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Draw(
        HDC hdc,
        [NativeTypeName("LONG")] int lLayer,
        RECT* pRect,
        IUnknown pReserved
    )
    {
        return (
            (delegate* unmanaged<IElementBehaviorRender, HDC, int, RECT*, IUnknown, int>)(
                (*lpVtbl)[3]
            )
        )(this, hdc, lLayer, pRect, pReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRenderInfo([NativeTypeName("LONG *")] int* plRenderInfo)
    {
        return ((delegate* unmanaged<IElementBehaviorRender, int*, int>)((*lpVtbl)[4]))(
            this,
            plRenderInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT HitTestPoint(POINT* pPoint, IUnknown pReserved, BOOL* pbHit)
    {
        return (
            (delegate* unmanaged<IElementBehaviorRender, POINT*, IUnknown, BOOL*, int>)(
                (*lpVtbl)[5]
            )
        )(this, pPoint, pReserved, pbHit);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Draw(HDC hdc, [NativeTypeName("LONG")] int lLayer, RECT* pRect, IUnknown pReserved);

        [VtblIndex(4)]
        HRESULT GetRenderInfo([NativeTypeName("LONG *")] int* plRenderInfo);

        [VtblIndex(5)]
        HRESULT HitTestPoint(POINT* pPoint, IUnknown pReserved, BOOL* pbHit);
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

        [NativeTypeName("HRESULT (HDC, LONG, RECT *, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, int, RECT*, IUnknown, int> Draw;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetRenderInfo;

        [NativeTypeName("HRESULT (POINT *, IUnknown *, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, POINT*, IUnknown, BOOL*, int> HitTestPoint;
    }

    /// <summary>Initializes a new instance of the <see cref = "IElementBehaviorRender"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IElementBehaviorRender(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IElementBehaviorRender"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IElementBehaviorRender(Silk.NET.Windows.IUnknown value)
    {
        return new IElementBehaviorRender(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IElementBehaviorRender"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IElementBehaviorRender"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IElementBehaviorRender value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
