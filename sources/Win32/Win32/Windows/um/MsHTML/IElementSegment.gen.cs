// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F68F-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IElementSegment : ISegment")]
[NativeInheritance("ISegment")]
public unsafe partial struct IElementSegment : IElementSegment.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IElementSegment));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IElementSegment, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IElementSegment, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IElementSegment, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPointers(IMarkupPointer pIStart, IMarkupPointer pIEnd)
    {
        return (
            (delegate* unmanaged<IElementSegment, IMarkupPointer, IMarkupPointer, int>)(
                (*lpVtbl)[3]
            )
        )(this, pIStart, pIEnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetElement(IHTMLElement* ppIElement)
    {
        return ((delegate* unmanaged<IElementSegment, IHTMLElement*, int>)((*lpVtbl)[4]))(
            this,
            ppIElement
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrimary(BOOL fPrimary)
    {
        return ((delegate* unmanaged<IElementSegment, BOOL, int>)((*lpVtbl)[5]))(this, fPrimary);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsPrimary(BOOL* pfPrimary)
    {
        return ((delegate* unmanaged<IElementSegment, BOOL*, int>)((*lpVtbl)[6]))(this, pfPrimary);
    }

    public interface Interface : ISegment.Interface
    {
        [VtblIndex(4)]
        HRESULT GetElement(IHTMLElement* ppIElement);

        [VtblIndex(5)]
        HRESULT SetPrimary(BOOL fPrimary);

        [VtblIndex(6)]
        HRESULT IsPrimary(BOOL* pfPrimary);
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

        [NativeTypeName("HRESULT (IMarkupPointer *, IMarkupPointer *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMarkupPointer, IMarkupPointer, int> GetPointers;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> GetElement;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetPrimary;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsPrimary;
    }

    /// <summary>Initializes a new instance of the <see cref = "IElementSegment"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IElementSegment(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISegment"/> to <see cref = "IElementSegment"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISegment"/> instance to be converted </param>
    public static explicit operator IElementSegment(Silk.NET.Windows.ISegment value)
    {
        return new IElementSegment(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IElementSegment"/> to <see cref = "Silk.NET.Windows.ISegment"/>.</summary>
    /// <param name = "value">The <see cref = "IElementSegment"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISegment(IElementSegment value)
    {
        return new Silk.NET.Windows.ISegment(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IElementSegment"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IElementSegment(Silk.NET.Windows.IUnknown value)
    {
        return new IElementSegment(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IElementSegment"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IElementSegment"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IElementSegment value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
