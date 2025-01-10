// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("3A3DFC9C-AEDE-4DC7-9E6C-41C044BD3592")]
[NativeTypeName("struct ISelectableWordSegmentsTokenizingHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISelectableWordSegmentsTokenizingHandler
    : ISelectableWordSegmentsTokenizingHandler.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISelectableWordSegmentsTokenizingHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISelectableWordSegmentsTokenizingHandler, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<ISelectableWordSegmentsTokenizingHandler, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<ISelectableWordSegmentsTokenizingHandler, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *"
        )]
            IIterable<IntPtr>* precedingWords,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *"
        )]
            IIterable<IntPtr>* words
    )
    {
        return (
            (delegate* unmanaged<
                ISelectableWordSegmentsTokenizingHandler,
                IIterable<IntPtr>*,
                IIterable<IntPtr>*,
                int>)((*lpVtbl)[3])
        )(this, precedingWords, words);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *"
            )]
                IIterable<IntPtr>* precedingWords,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *"
            )]
                IIterable<IntPtr>* words
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IIterable<IntPtr>*, IIterable<IntPtr>*, int> Invoke;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISelectableWordSegmentsTokenizingHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISelectableWordSegmentsTokenizingHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISelectableWordSegmentsTokenizingHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISelectableWordSegmentsTokenizingHandler(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISelectableWordSegmentsTokenizingHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISelectableWordSegmentsTokenizingHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISelectableWordSegmentsTokenizingHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISelectableWordSegmentsTokenizingHandler value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
