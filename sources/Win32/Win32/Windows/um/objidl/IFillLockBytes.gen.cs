// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("99CAF010-415E-11CF-8814-00AA00B569F5")]
[NativeTypeName("struct IFillLockBytes : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFillLockBytes : IFillLockBytes.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFillLockBytes));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFillLockBytes, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFillLockBytes, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFillLockBytes, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT FillAppend(
        [NativeTypeName("const void *")] void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbWritten
    )
    {
        return ((delegate* unmanaged<IFillLockBytes, void*, uint, uint*, int>)((*lpVtbl)[3]))(
            this,
            pv,
            cb,
            pcbWritten
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FillAt(
        ULARGE_INTEGER ulOffset,
        [NativeTypeName("const void *")] void* pv,
        [NativeTypeName("ULONG")] uint cb,
        [NativeTypeName("ULONG *")] uint* pcbWritten
    )
    {
        return (
            (delegate* unmanaged<IFillLockBytes, ULARGE_INTEGER, void*, uint, uint*, int>)(
                (*lpVtbl)[4]
            )
        )(this, ulOffset, pv, cb, pcbWritten);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFillSize(ULARGE_INTEGER ulSize)
    {
        return ((delegate* unmanaged<IFillLockBytes, ULARGE_INTEGER, int>)((*lpVtbl)[5]))(
            this,
            ulSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Terminate(BOOL bCanceled)
    {
        return ((delegate* unmanaged<IFillLockBytes, BOOL, int>)((*lpVtbl)[6]))(this, bCanceled);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT FillAppend(
            [NativeTypeName("const void *")] void* pv,
            [NativeTypeName("ULONG")] uint cb,
            [NativeTypeName("ULONG *")] uint* pcbWritten
        );

        [VtblIndex(4)]
        HRESULT FillAt(
            ULARGE_INTEGER ulOffset,
            [NativeTypeName("const void *")] void* pv,
            [NativeTypeName("ULONG")] uint cb,
            [NativeTypeName("ULONG *")] uint* pcbWritten
        );

        [VtblIndex(5)]
        HRESULT SetFillSize(ULARGE_INTEGER ulSize);

        [VtblIndex(6)]
        HRESULT Terminate(BOOL bCanceled);
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

        [NativeTypeName("HRESULT (const void *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, uint, uint*, int> FillAppend;

        [NativeTypeName(
            "HRESULT (ULARGE_INTEGER, const void *, ULONG, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER, void*, uint, uint*, int> FillAt;

        [NativeTypeName("HRESULT (ULARGE_INTEGER) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ULARGE_INTEGER, int> SetFillSize;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Terminate;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFillLockBytes"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFillLockBytes(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFillLockBytes"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFillLockBytes(Silk.NET.Windows.IUnknown value)
    {
        return new IFillLockBytes(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFillLockBytes"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFillLockBytes"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFillLockBytes value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
