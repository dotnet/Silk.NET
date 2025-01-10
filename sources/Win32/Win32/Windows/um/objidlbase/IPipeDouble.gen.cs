// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("DB2F3ACE-2F86-11D1-8E04-00C04FB9989A")]
[NativeTypeName("struct IPipeDouble : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPipeDouble : IPipeDouble.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPipeDouble));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPipeDouble, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPipeDouble, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPipeDouble, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Pull(
        double* buf,
        [NativeTypeName("ULONG")] uint cRequest,
        [NativeTypeName("ULONG *")] uint* pcReturned
    )
    {
        return ((delegate* unmanaged<IPipeDouble, double*, uint, uint*, int>)((*lpVtbl)[3]))(
            this,
            buf,
            cRequest,
            pcReturned
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Push(double* buf, [NativeTypeName("ULONG")] uint cSent)
    {
        return ((delegate* unmanaged<IPipeDouble, double*, uint, int>)((*lpVtbl)[4]))(
            this,
            buf,
            cSent
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Pull(
            double* buf,
            [NativeTypeName("ULONG")] uint cRequest,
            [NativeTypeName("ULONG *")] uint* pcReturned
        );

        [VtblIndex(4)]
        HRESULT Push(double* buf, [NativeTypeName("ULONG")] uint cSent);
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

        [NativeTypeName("HRESULT (DOUBLE *, ULONG, ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, uint, uint*, int> Pull;

        [NativeTypeName("HRESULT (DOUBLE *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, uint, int> Push;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPipeDouble"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPipeDouble(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPipeDouble"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPipeDouble(Silk.NET.Windows.IUnknown value)
    {
        return new IPipeDouble(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPipeDouble"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPipeDouble"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPipeDouble value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
