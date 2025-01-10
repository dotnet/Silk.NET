// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("71E806FB-8DEE-46FC-BF8C-7748A8A1AE13")]
[NativeTypeName("struct IObjectWithProgID : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IObjectWithProgID : IObjectWithProgID.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IObjectWithProgID));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IObjectWithProgID, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IObjectWithProgID, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IObjectWithProgID, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetProgID([NativeTypeName("LPCWSTR")] ushort* pszProgID)
    {
        return ((delegate* unmanaged<IObjectWithProgID, ushort*, int>)((*lpVtbl)[3]))(
            this,
            pszProgID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetProgID([NativeTypeName("LPWSTR *")] ushort** ppszProgID)
    {
        return ((delegate* unmanaged<IObjectWithProgID, ushort**, int>)((*lpVtbl)[4]))(
            this,
            ppszProgID
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetProgID([NativeTypeName("LPCWSTR")] ushort* pszProgID);

        [VtblIndex(4)]
        HRESULT GetProgID([NativeTypeName("LPWSTR *")] ushort** ppszProgID);
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

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetProgID;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetProgID;
    }

    /// <summary>Initializes a new instance of the <see cref = "IObjectWithProgID"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IObjectWithProgID(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IObjectWithProgID"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IObjectWithProgID(Silk.NET.Windows.IUnknown value)
    {
        return new IObjectWithProgID(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IObjectWithProgID"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IObjectWithProgID"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IObjectWithProgID value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
