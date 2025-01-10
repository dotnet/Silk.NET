// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("91956D21-9276-11D1-921A-006097DF5BD4")]
[NativeTypeName("struct ICurrentWorkingDirectory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICurrentWorkingDirectory
    : ICurrentWorkingDirectory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICurrentWorkingDirectory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICurrentWorkingDirectory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICurrentWorkingDirectory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICurrentWorkingDirectory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDirectory(
        [NativeTypeName("PWSTR")] ushort* pwzPath,
        [NativeTypeName("DWORD")] uint cchSize
    )
    {
        return ((delegate* unmanaged<ICurrentWorkingDirectory, ushort*, uint, int>)((*lpVtbl)[3]))(
            this,
            pwzPath,
            cchSize
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetDirectory([NativeTypeName("PCWSTR")] ushort* pwzPath)
    {
        return ((delegate* unmanaged<ICurrentWorkingDirectory, ushort*, int>)((*lpVtbl)[4]))(
            this,
            pwzPath
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetDirectory(
            [NativeTypeName("PWSTR")] ushort* pwzPath,
            [NativeTypeName("DWORD")] uint cchSize
        );

        [VtblIndex(4)]
        HRESULT SetDirectory([NativeTypeName("PCWSTR")] ushort* pwzPath);
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

        [NativeTypeName("HRESULT (PWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> GetDirectory;

        [NativeTypeName("HRESULT (PCWSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDirectory;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICurrentWorkingDirectory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICurrentWorkingDirectory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICurrentWorkingDirectory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICurrentWorkingDirectory(Silk.NET.Windows.IUnknown value)
    {
        return new ICurrentWorkingDirectory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICurrentWorkingDirectory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICurrentWorkingDirectory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICurrentWorkingDirectory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
