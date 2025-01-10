// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("01689689-7ACB-4E9B-AB7C-7EA46B12B522")]
[NativeTypeName("struct ITfCleanupContextSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfCleanupContextSink : ITfCleanupContextSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfCleanupContextSink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfCleanupContextSink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfCleanupContextSink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfCleanupContextSink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnCleanupContext([NativeTypeName("TfEditCookie")] uint ecWrite, ITfContext pic)
    {
        return ((delegate* unmanaged<ITfCleanupContextSink, uint, ITfContext, int>)((*lpVtbl)[3]))(
            this,
            ecWrite,
            pic
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnCleanupContext([NativeTypeName("TfEditCookie")] uint ecWrite, ITfContext pic);
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

        [NativeTypeName("HRESULT (TfEditCookie, ITfContext *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ITfContext, int> OnCleanupContext;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfCleanupContextSink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfCleanupContextSink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfCleanupContextSink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfCleanupContextSink(Silk.NET.Windows.IUnknown value)
    {
        return new ITfCleanupContextSink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfCleanupContextSink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfCleanupContextSink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfCleanupContextSink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
