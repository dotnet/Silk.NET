// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("48EFB120-AB49-11D2-AED2-00A0C995E8D5")]
[NativeTypeName("struct IDrawVideoImage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDrawVideoImage : IDrawVideoImage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDrawVideoImage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDrawVideoImage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDrawVideoImage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDrawVideoImage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DrawVideoImageBegin()
    {
        return ((delegate* unmanaged<IDrawVideoImage, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT DrawVideoImageEnd()
    {
        return ((delegate* unmanaged<IDrawVideoImage, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DrawVideoImageDraw(
        HDC hdc,
        [NativeTypeName("LPRECT")] RECT* lprcSrc,
        [NativeTypeName("LPRECT")] RECT* lprcDst
    )
    {
        return ((delegate* unmanaged<IDrawVideoImage, HDC, RECT*, RECT*, int>)((*lpVtbl)[5]))(
            this,
            hdc,
            lprcSrc,
            lprcDst
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DrawVideoImageBegin();

        [VtblIndex(4)]
        HRESULT DrawVideoImageEnd();

        [VtblIndex(5)]
        HRESULT DrawVideoImageDraw(
            HDC hdc,
            [NativeTypeName("LPRECT")] RECT* lprcSrc,
            [NativeTypeName("LPRECT")] RECT* lprcDst
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DrawVideoImageBegin;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DrawVideoImageEnd;

        [NativeTypeName("HRESULT (HDC, LPRECT, LPRECT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HDC, RECT*, RECT*, int> DrawVideoImageDraw;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDrawVideoImage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDrawVideoImage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDrawVideoImage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDrawVideoImage(Silk.NET.Windows.IUnknown value)
    {
        return new IDrawVideoImage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDrawVideoImage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDrawVideoImage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDrawVideoImage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
