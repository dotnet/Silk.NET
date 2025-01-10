// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IContact.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F941B671-BDA7-4F77-884A-F46462F226A7")]
[NativeTypeName("struct IContact : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IContact : IContact.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IContact));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IContact, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IContact, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IContact, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetContactID(
        [NativeTypeName("LPWSTR")] ushort* pszContactID,
        [NativeTypeName("DWORD")] uint cchContactID,
        [NativeTypeName("DWORD *")] uint* pdwcchContactIDRequired
    )
    {
        return ((delegate* unmanaged<IContact, ushort*, uint, uint*, int>)((*lpVtbl)[3]))(
            this,
            pszContactID,
            cchContactID,
            pdwcchContactIDRequired
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPath(
        [NativeTypeName("LPWSTR")] ushort* pszPath,
        [NativeTypeName("DWORD")] uint cchPath,
        [NativeTypeName("DWORD *")] uint* pdwcchPathRequired
    )
    {
        return ((delegate* unmanaged<IContact, ushort*, uint, uint*, int>)((*lpVtbl)[4]))(
            this,
            pszPath,
            cchPath,
            pdwcchPathRequired
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CommitChanges([NativeTypeName("DWORD")] uint dwCommitFlags)
    {
        return ((delegate* unmanaged<IContact, uint, int>)((*lpVtbl)[5]))(this, dwCommitFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetContactID(
            [NativeTypeName("LPWSTR")] ushort* pszContactID,
            [NativeTypeName("DWORD")] uint cchContactID,
            [NativeTypeName("DWORD *")] uint* pdwcchContactIDRequired
        );

        [VtblIndex(4)]
        HRESULT GetPath(
            [NativeTypeName("LPWSTR")] ushort* pszPath,
            [NativeTypeName("DWORD")] uint cchPath,
            [NativeTypeName("DWORD *")] uint* pdwcchPathRequired
        );

        [VtblIndex(5)]
        HRESULT CommitChanges([NativeTypeName("DWORD")] uint dwCommitFlags);
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

        [NativeTypeName("HRESULT (LPWSTR, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint*, int> GetContactID;

        [NativeTypeName("HRESULT (LPWSTR, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint*, int> GetPath;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> CommitChanges;
    }

    /// <summary>Initializes a new instance of the <see cref = "IContact"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IContact(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IContact"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IContact(Silk.NET.Windows.IUnknown value)
    {
        return new IContact(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IContact"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IContact"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IContact value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
