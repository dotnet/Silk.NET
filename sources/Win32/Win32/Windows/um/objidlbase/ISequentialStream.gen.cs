// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0C733A30-2A1C-11CE-ADE5-00AA0044773D")]
[NativeTypeName("struct ISequentialStream : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISequentialStream : ISequentialStream.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISequentialStream));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISequentialStream, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISequentialStream, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISequentialStream, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(
        void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbRead
    )
    {
        return ((delegate* unmanaged<ISequentialStream, void*, uint, uint*, int>)((*lpVtbl)[3]))(
            this,
            pv,
            cb,
            pcbRead
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write(
        [NativeTypeName("const void *")] void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbWritten
    )
    {
        return ((delegate* unmanaged<ISequentialStream, void*, uint, uint*, int>)((*lpVtbl)[4]))(
            this,
            pv,
            cb,
            pcbWritten
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Read(
            void* pv,
            [NativeTypeName("ULONG")] uint cb,
            [NativeTypeName("ULONG *")] uint* pcbRead
        );

        [VtblIndex(4)]
        HRESULT Write(
            [NativeTypeName("const void *")] void* pv,
            [NativeTypeName("ULONG")] uint cb,
            [NativeTypeName("ULONG *")] uint* pcbWritten
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

        [NativeTypeName("HRESULT (void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint*, int> Read;

        [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint*, int> Write;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISequentialStream"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISequentialStream(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISequentialStream"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISequentialStream(Silk.NET.Windows.IUnknown value)
    {
        return new ISequentialStream(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISequentialStream"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISequentialStream"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISequentialStream value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
