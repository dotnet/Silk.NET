// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("FB6904C4-42F0-4B62-9C46-983AF7DA7C83")]
[NativeTypeName("struct IDxcVersionInfo2 : IDxcVersionInfo")]
[NativeInheritance("IDxcVersionInfo")]
public unsafe partial struct IDxcVersionInfo2 : IDxcVersionInfo2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDxcVersionInfo2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDxcVersionInfo2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDxcVersionInfo2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDxcVersionInfo2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetVersion(
        [NativeTypeName("UINT32 *")] uint* pMajor,
        [NativeTypeName("UINT32 *")] uint* pMinor
    )
    {
        return ((delegate* unmanaged<IDxcVersionInfo2, uint*, uint*, int>)((*lpVtbl)[3]))(
            this,
            pMajor,
            pMinor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFlags([NativeTypeName("UINT32 *")] uint* pFlags)
    {
        return ((delegate* unmanaged<IDxcVersionInfo2, uint*, int>)((*lpVtbl)[4]))(this, pFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCommitInfo(
        [NativeTypeName("UINT32 *")] uint* pCommitCount,
        [NativeTypeName("char **")] sbyte** pCommitHash
    )
    {
        return ((delegate* unmanaged<IDxcVersionInfo2, uint*, sbyte**, int>)((*lpVtbl)[5]))(
            this,
            pCommitCount,
            pCommitHash
        );
    }

    public interface Interface : IDxcVersionInfo.Interface
    {
        [VtblIndex(5)]
        HRESULT GetCommitInfo(
            [NativeTypeName("UINT32 *")] uint* pCommitCount,
            [NativeTypeName("char **")] sbyte** pCommitHash
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

        [NativeTypeName("HRESULT (UINT32 *, UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, int> GetVersion;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetFlags;

        [NativeTypeName("HRESULT (UINT32 *, char **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, sbyte**, int> GetCommitInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDxcVersionInfo2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDxcVersionInfo2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDxcVersionInfo"/> to <see cref = "IDxcVersionInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDxcVersionInfo"/> instance to be converted </param>
    public static explicit operator IDxcVersionInfo2(Silk.NET.DirectX.IDxcVersionInfo value)
    {
        return new IDxcVersionInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcVersionInfo2"/> to <see cref = "Silk.NET.DirectX.IDxcVersionInfo"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcVersionInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDxcVersionInfo(IDxcVersionInfo2 value)
    {
        return new Silk.NET.DirectX.IDxcVersionInfo(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDxcVersionInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDxcVersionInfo2(Silk.NET.Windows.IUnknown value)
    {
        return new IDxcVersionInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDxcVersionInfo2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDxcVersionInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDxcVersionInfo2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
