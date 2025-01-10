// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("55CE16BA-3014-41C1-9CEB-FADE1446AC6C")]
[NativeTypeName("struct ITfInsertAtSelection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfInsertAtSelection : ITfInsertAtSelection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfInsertAtSelection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfInsertAtSelection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfInsertAtSelection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfInsertAtSelection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT InsertTextAtSelection(
        [NativeTypeName("TfEditCookie")] uint ec,
        [NativeTypeName("DWORD")] uint dwFlags,
        [NativeTypeName("const WCHAR *")] ushort* pchText,
        [NativeTypeName("LONG")] int cch,
        ITfRange* ppRange
    )
    {
        return (
            (delegate* unmanaged<ITfInsertAtSelection, uint, uint, ushort*, int, ITfRange*, int>)(
                (*lpVtbl)[3]
            )
        )(this, ec, dwFlags, pchText, cch, ppRange);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT InsertEmbeddedAtSelection(
        [NativeTypeName("TfEditCookie")] uint ec,
        [NativeTypeName("DWORD")] uint dwFlags,
        IDataObject pDataObject,
        ITfRange* ppRange
    )
    {
        return (
            (delegate* unmanaged<ITfInsertAtSelection, uint, uint, IDataObject, ITfRange*, int>)(
                (*lpVtbl)[4]
            )
        )(this, ec, dwFlags, pDataObject, ppRange);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT InsertTextAtSelection(
            [NativeTypeName("TfEditCookie")] uint ec,
            [NativeTypeName("DWORD")] uint dwFlags,
            [NativeTypeName("const WCHAR *")] ushort* pchText,
            [NativeTypeName("LONG")] int cch,
            ITfRange* ppRange
        );

        [VtblIndex(4)]
        HRESULT InsertEmbeddedAtSelection(
            [NativeTypeName("TfEditCookie")] uint ec,
            [NativeTypeName("DWORD")] uint dwFlags,
            IDataObject pDataObject,
            ITfRange* ppRange
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
            "HRESULT (TfEditCookie, DWORD, const WCHAR *, LONG, ITfRange **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            ushort*,
            int,
            ITfRange*,
            int> InsertTextAtSelection;

        [NativeTypeName(
            "HRESULT (TfEditCookie, DWORD, IDataObject *, ITfRange **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            uint,
            IDataObject,
            ITfRange*,
            int> InsertEmbeddedAtSelection;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfInsertAtSelection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfInsertAtSelection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfInsertAtSelection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfInsertAtSelection(Silk.NET.Windows.IUnknown value)
    {
        return new ITfInsertAtSelection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfInsertAtSelection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfInsertAtSelection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfInsertAtSelection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
