// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F848-98B5-11CF-BB82-00AA00BDCE0D")]
[NativeTypeName("struct IHTMLEditHost2 : IHTMLEditHost")]
[NativeInheritance("IHTMLEditHost")]
public unsafe partial struct IHTMLEditHost2 : IHTMLEditHost2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLEditHost2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLEditHost2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLEditHost2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLEditHost2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SnapRect(IHTMLElement pIElement, RECT* prcNew, ELEMENT_CORNER eHandle)
    {
        return (
            (delegate* unmanaged<IHTMLEditHost2, IHTMLElement, RECT*, ELEMENT_CORNER, int>)(
                (*lpVtbl)[3]
            )
        )(this, pIElement, prcNew, eHandle);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT PreDrag()
    {
        return ((delegate* unmanaged<IHTMLEditHost2, int>)((*lpVtbl)[4]))(this);
    }

    public interface Interface : IHTMLEditHost.Interface
    {
        [VtblIndex(4)]
        HRESULT PreDrag();
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
            "HRESULT (IHTMLElement *, RECT *, ELEMENT_CORNER) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHTMLElement, RECT*, ELEMENT_CORNER, int> SnapRect;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> PreDrag;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLEditHost2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLEditHost2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IHTMLEditHost"/> to <see cref = "IHTMLEditHost2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IHTMLEditHost"/> instance to be converted </param>
    public static explicit operator IHTMLEditHost2(Silk.NET.Windows.IHTMLEditHost value)
    {
        return new IHTMLEditHost2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLEditHost2"/> to <see cref = "Silk.NET.Windows.IHTMLEditHost"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLEditHost2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IHTMLEditHost(IHTMLEditHost2 value)
    {
        return new Silk.NET.Windows.IHTMLEditHost(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLEditHost2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLEditHost2(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLEditHost2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLEditHost2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLEditHost2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLEditHost2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
