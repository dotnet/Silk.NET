// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6F77C993-D2B1-446E-853E-5912EFC8A286")]
[NativeTypeName("struct ITfPreservedKeyNotifySink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfPreservedKeyNotifySink
    : ITfPreservedKeyNotifySink.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfPreservedKeyNotifySink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfPreservedKeyNotifySink, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfPreservedKeyNotifySink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfPreservedKeyNotifySink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnUpdated([NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey)
    {
        return (
            (delegate* unmanaged<ITfPreservedKeyNotifySink, TF_PRESERVEDKEY*, int>)((*lpVtbl)[3])
        )(this, pprekey);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnUpdated([NativeTypeName("const TF_PRESERVEDKEY *")] TF_PRESERVEDKEY* pprekey);
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

        [NativeTypeName("HRESULT (const TF_PRESERVEDKEY *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TF_PRESERVEDKEY*, int> OnUpdated;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfPreservedKeyNotifySink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfPreservedKeyNotifySink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfPreservedKeyNotifySink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfPreservedKeyNotifySink(Silk.NET.Windows.IUnknown value)
    {
        return new ITfPreservedKeyNotifySink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfPreservedKeyNotifySink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfPreservedKeyNotifySink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfPreservedKeyNotifySink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
