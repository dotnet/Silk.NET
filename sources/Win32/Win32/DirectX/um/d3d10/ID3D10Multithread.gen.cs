// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("9B7E4E00-342C-4106-A19F-4F2704F689F0")]
[NativeTypeName("struct ID3D10Multithread : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D10Multithread : ID3D10Multithread.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID3D10Multithread));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D10Multithread, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ID3D10Multithread, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D10Multithread, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void Enter()
    {
        ((delegate* unmanaged<ID3D10Multithread, void>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Leave()
    {
        ((delegate* unmanaged<ID3D10Multithread, void>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public BOOL SetMultithreadProtected(BOOL bMTProtect)
    {
        return ((delegate* unmanaged<ID3D10Multithread, BOOL, int>)((*lpVtbl)[5]))(
            this,
            bMTProtect
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public BOOL GetMultithreadProtected()
    {
        return ((delegate* unmanaged<ID3D10Multithread, int>)((*lpVtbl)[6]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void Enter();

        [VtblIndex(4)]
        void Leave();

        [VtblIndex(5)]
        BOOL SetMultithreadProtected(BOOL bMTProtect);

        [VtblIndex(6)]
        BOOL GetMultithreadProtected();
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

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Enter;

        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Leave;

        [NativeTypeName("BOOL (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> SetMultithreadProtected;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> GetMultithreadProtected;
    }

    /// <summary>Initializes a new instance of the <see cref = "ID3D10Multithread"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ID3D10Multithread(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ID3D10Multithread"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ID3D10Multithread(Silk.NET.Windows.IUnknown value)
    {
        return new ID3D10Multithread(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ID3D10Multithread"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ID3D10Multithread"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ID3D10Multithread value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
