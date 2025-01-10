// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000019-0000-0000-C000-000000000046")]
[NativeTypeName("struct IExternalConnection : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IExternalConnection : IExternalConnection.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IExternalConnection));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IExternalConnection, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IExternalConnection, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IExternalConnection, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint AddConnection(
        [NativeTypeName("DWORD")] uint extconn,
        [NativeTypeName("DWORD")] uint reserved
    )
    {
        return ((delegate* unmanaged<IExternalConnection, uint, uint, uint>)((*lpVtbl)[3]))(
            this,
            extconn,
            reserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("DWORD")]
    public uint ReleaseConnection(
        [NativeTypeName("DWORD")] uint extconn,
        [NativeTypeName("DWORD")] uint reserved,
        BOOL fLastReleaseCloses
    )
    {
        return ((delegate* unmanaged<IExternalConnection, uint, uint, BOOL, uint>)((*lpVtbl)[4]))(
            this,
            extconn,
            reserved,
            fLastReleaseCloses
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint AddConnection(
            [NativeTypeName("DWORD")] uint extconn,
            [NativeTypeName("DWORD")] uint reserved
        );

        [VtblIndex(4)]
        [return: NativeTypeName("DWORD")]
        uint ReleaseConnection(
            [NativeTypeName("DWORD")] uint extconn,
            [NativeTypeName("DWORD")] uint reserved,
            BOOL fLastReleaseCloses
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

        [NativeTypeName("DWORD (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint> AddConnection;

        [NativeTypeName("DWORD (DWORD, DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, BOOL, uint> ReleaseConnection;
    }

    /// <summary>Initializes a new instance of the <see cref = "IExternalConnection"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IExternalConnection(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IExternalConnection"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IExternalConnection(Silk.NET.Windows.IUnknown value)
    {
        return new IExternalConnection(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IExternalConnection"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IExternalConnection"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IExternalConnection value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
