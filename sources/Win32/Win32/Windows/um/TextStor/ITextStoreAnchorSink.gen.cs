// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("AA80E905-2021-11D2-93E0-0060B067B86E")]
[NativeTypeName("struct ITextStoreAnchorSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITextStoreAnchorSink : ITextStoreAnchorSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITextStoreAnchorSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITextStoreAnchorSink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITextStoreAnchorSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITextStoreAnchorSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnTextChange(
        [NativeTypeName("DWORD")] uint dwFlags,
        IAnchor paStart,
        IAnchor paEnd
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchorSink, uint, IAnchor, IAnchor, int>)((*lpVtbl)[3])
        )(this, dwFlags, paStart, paEnd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnSelectionChange()
    {
        return ((delegate* unmanaged<ITextStoreAnchorSink, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT OnLayoutChange(TsLayoutCode lcode, [NativeTypeName("TsViewCookie")] uint vcView)
    {
        return ((delegate* unmanaged<ITextStoreAnchorSink, TsLayoutCode, uint, int>)((*lpVtbl)[5]))(
            this,
            lcode,
            vcView
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OnStatusChange([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITextStoreAnchorSink, uint, int>)((*lpVtbl)[6]))(
            this,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OnAttrsChange(
        IAnchor paStart,
        IAnchor paEnd,
        [NativeTypeName("ULONG")] uint cAttrs,
        [NativeTypeName("const TS_ATTRID *")] Guid* paAttrs
    )
    {
        return (
            (delegate* unmanaged<ITextStoreAnchorSink, IAnchor, IAnchor, uint, Guid*, int>)(
                (*lpVtbl)[7]
            )
        )(this, paStart, paEnd, cAttrs, paAttrs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT OnLockGranted([NativeTypeName("DWORD")] uint dwLockFlags)
    {
        return ((delegate* unmanaged<ITextStoreAnchorSink, uint, int>)((*lpVtbl)[8]))(
            this,
            dwLockFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT OnStartEditTransaction()
    {
        return ((delegate* unmanaged<ITextStoreAnchorSink, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT OnEndEditTransaction()
    {
        return ((delegate* unmanaged<ITextStoreAnchorSink, int>)((*lpVtbl)[10]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnTextChange(
            [NativeTypeName("DWORD")] uint dwFlags,
            IAnchor paStart,
            IAnchor paEnd
        );

        [VtblIndex(4)]
        HRESULT OnSelectionChange();

        [VtblIndex(5)]
        HRESULT OnLayoutChange(TsLayoutCode lcode, [NativeTypeName("TsViewCookie")] uint vcView);

        [VtblIndex(6)]
        HRESULT OnStatusChange([NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(7)]
        HRESULT OnAttrsChange(
            IAnchor paStart,
            IAnchor paEnd,
            [NativeTypeName("ULONG")] uint cAttrs,
            [NativeTypeName("const TS_ATTRID *")] Guid* paAttrs
        );

        [VtblIndex(8)]
        HRESULT OnLockGranted([NativeTypeName("DWORD")] uint dwLockFlags);

        [VtblIndex(9)]
        HRESULT OnStartEditTransaction();

        [VtblIndex(10)]
        HRESULT OnEndEditTransaction();
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

        [NativeTypeName("HRESULT (DWORD, IAnchor *, IAnchor *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IAnchor, IAnchor, int> OnTextChange;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnSelectionChange;

        [NativeTypeName("HRESULT (TsLayoutCode, TsViewCookie) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TsLayoutCode, uint, int> OnLayoutChange;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnStatusChange;

        [NativeTypeName(
            "HRESULT (IAnchor *, IAnchor *, ULONG, const TS_ATTRID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IAnchor, IAnchor, uint, Guid*, int> OnAttrsChange;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> OnLockGranted;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnStartEditTransaction;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnEndEditTransaction;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITextStoreAnchorSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITextStoreAnchorSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITextStoreAnchorSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITextStoreAnchorSink(Silk.NET.Windows.IUnknown value)
    {
        return new ITextStoreAnchorSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITextStoreAnchorSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITextStoreAnchorSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITextStoreAnchorSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
