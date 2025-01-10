// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F6EF6140-E26F-4D82-BAC4-E9BA5FD239A8")]
[NativeTypeName("struct ICreateProcessInputs : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICreateProcessInputs : ICreateProcessInputs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICreateProcessInputs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICreateProcessInputs, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICreateProcessInputs, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICreateProcessInputs, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCreateFlags([NativeTypeName("DWORD *")] uint* pdwCreationFlags)
    {
        return ((delegate* unmanaged<ICreateProcessInputs, uint*, int>)((*lpVtbl)[3]))(
            this,
            pdwCreationFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetCreateFlags([NativeTypeName("DWORD")] uint dwCreationFlags)
    {
        return ((delegate* unmanaged<ICreateProcessInputs, uint, int>)((*lpVtbl)[4]))(
            this,
            dwCreationFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddCreateFlags([NativeTypeName("DWORD")] uint dwCreationFlags)
    {
        return ((delegate* unmanaged<ICreateProcessInputs, uint, int>)((*lpVtbl)[5]))(
            this,
            dwCreationFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetHotKey([NativeTypeName("WORD")] ushort wHotKey)
    {
        return ((delegate* unmanaged<ICreateProcessInputs, ushort, int>)((*lpVtbl)[6]))(
            this,
            wHotKey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddStartupFlags([NativeTypeName("DWORD")] uint dwStartupInfoFlags)
    {
        return ((delegate* unmanaged<ICreateProcessInputs, uint, int>)((*lpVtbl)[7]))(
            this,
            dwStartupInfoFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle)
    {
        return ((delegate* unmanaged<ICreateProcessInputs, ushort*, int>)((*lpVtbl)[8]))(
            this,
            pszTitle
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetEnvironmentVariableW(
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        [NativeTypeName("LPCWSTR")] ushort* pszValue
    )
    {
        return ((delegate* unmanaged<ICreateProcessInputs, ushort*, ushort*, int>)((*lpVtbl)[9]))(
            this,
            pszName,
            pszValue
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCreateFlags([NativeTypeName("DWORD *")] uint* pdwCreationFlags);

        [VtblIndex(4)]
        HRESULT SetCreateFlags([NativeTypeName("DWORD")] uint dwCreationFlags);

        [VtblIndex(5)]
        HRESULT AddCreateFlags([NativeTypeName("DWORD")] uint dwCreationFlags);

        [VtblIndex(6)]
        HRESULT SetHotKey([NativeTypeName("WORD")] ushort wHotKey);

        [VtblIndex(7)]
        HRESULT AddStartupFlags([NativeTypeName("DWORD")] uint dwStartupInfoFlags);

        [VtblIndex(8)]
        HRESULT SetTitle([NativeTypeName("LPCWSTR")] ushort* pszTitle);

        [VtblIndex(9)]
        HRESULT SetEnvironmentVariableW(
            [NativeTypeName("LPCWSTR")] ushort* pszName,
            [NativeTypeName("LPCWSTR")] ushort* pszValue
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

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCreateFlags;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCreateFlags;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> AddCreateFlags;

        [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> SetHotKey;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> AddStartupFlags;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetTitle;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> SetEnvironmentVariableW;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICreateProcessInputs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICreateProcessInputs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICreateProcessInputs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICreateProcessInputs(Silk.NET.Windows.IUnknown value)
    {
        return new ICreateProcessInputs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICreateProcessInputs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICreateProcessInputs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICreateProcessInputs value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
