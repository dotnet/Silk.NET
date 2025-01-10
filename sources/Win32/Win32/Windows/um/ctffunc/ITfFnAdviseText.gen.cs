// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3527268B-7D53-4DD9-92B7-7296AE461249")]
[NativeTypeName("struct ITfFnAdviseText : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnAdviseText : ITfFnAdviseText.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnAdviseText));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnAdviseText, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfFnAdviseText, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnAdviseText, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnAdviseText, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnTextUpdate(
        ITfRange pRange,
        [NativeTypeName("const WCHAR *")] ushort* pchText,
        [NativeTypeName("LONG")] int cch
    )
    {
        return ((delegate* unmanaged<ITfFnAdviseText, ITfRange, ushort*, int, int>)((*lpVtbl)[4]))(
            this,
            pRange,
            pchText,
            cch
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnLatticeUpdate(ITfRange pRange, ITfLMLattice pLattice)
    {
        return ((delegate* unmanaged<ITfFnAdviseText, ITfRange, ITfLMLattice, int>)((*lpVtbl)[5]))(
            this,
            pRange,
            pLattice
        );
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT OnTextUpdate(
            ITfRange pRange,
            [NativeTypeName("const WCHAR *")] ushort* pchText,
            [NativeTypeName("LONG")] int cch
        );

        [VtblIndex(5)]
        HRESULT OnLatticeUpdate(ITfRange pRange, ITfLMLattice pLattice);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;

        [NativeTypeName("HRESULT (ITfRange *, const WCHAR *, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange, ushort*, int, int> OnTextUpdate;

        [NativeTypeName("HRESULT (ITfRange *, ITfLMLattice *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange, ITfLMLattice, int> OnLatticeUpdate;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfFnAdviseText"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfFnAdviseText(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfFunction"/> to <see cref = "ITfFnAdviseText"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfFunction"/> instance to be converted </param>
    public static explicit operator ITfFnAdviseText(Silk.NET.Windows.ITfFunction value)
    {
        return new ITfFnAdviseText(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnAdviseText"/> to <see cref = "Silk.NET.Windows.ITfFunction"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnAdviseText"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfFunction(ITfFnAdviseText value)
    {
        return new Silk.NET.Windows.ITfFunction(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfFnAdviseText"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfFnAdviseText(Silk.NET.Windows.IUnknown value)
    {
        return new ITfFnAdviseText(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnAdviseText"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnAdviseText"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfFnAdviseText value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
