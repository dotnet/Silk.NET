// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000010B-0000-0000-C000-000000000046")]
[NativeTypeName("struct IPersistFile : IPersist")]
[NativeInheritance("IPersist")]
public unsafe partial struct IPersistFile : IPersistFile.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPersistFile));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPersistFile, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPersistFile, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPersistFile, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClassID([NativeTypeName("CLSID *")] Guid* pClassID)
    {
        return ((delegate* unmanaged<IPersistFile, Guid*, int>)((*lpVtbl)[3]))(this, pClassID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT IsDirty()
    {
        return ((delegate* unmanaged<IPersistFile, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Load(
        [NativeTypeName("LPCOLESTR")] ushort* pszFileName,
        [NativeTypeName("DWORD")] uint dwMode
    )
    {
        return ((delegate* unmanaged<IPersistFile, ushort*, uint, int>)((*lpVtbl)[5]))(
            this,
            pszFileName,
            dwMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Save([NativeTypeName("LPCOLESTR")] ushort* pszFileName, BOOL fRemember)
    {
        return ((delegate* unmanaged<IPersistFile, ushort*, BOOL, int>)((*lpVtbl)[6]))(
            this,
            pszFileName,
            fRemember
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SaveCompleted([NativeTypeName("LPCOLESTR")] ushort* pszFileName)
    {
        return ((delegate* unmanaged<IPersistFile, ushort*, int>)((*lpVtbl)[7]))(this, pszFileName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName)
    {
        return ((delegate* unmanaged<IPersistFile, ushort**, int>)((*lpVtbl)[8]))(
            this,
            ppszFileName
        );
    }

    public interface Interface : IPersist.Interface
    {
        [VtblIndex(4)]
        HRESULT IsDirty();

        [VtblIndex(5)]
        HRESULT Load(
            [NativeTypeName("LPCOLESTR")] ushort* pszFileName,
            [NativeTypeName("DWORD")] uint dwMode
        );

        [VtblIndex(6)]
        HRESULT Save([NativeTypeName("LPCOLESTR")] ushort* pszFileName, BOOL fRemember);

        [VtblIndex(7)]
        HRESULT SaveCompleted([NativeTypeName("LPCOLESTR")] ushort* pszFileName);

        [VtblIndex(8)]
        HRESULT GetCurFile([NativeTypeName("LPOLESTR *")] ushort** ppszFileName);
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

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetClassID;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> IsDirty;

        [NativeTypeName("HRESULT (LPCOLESTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> Load;

        [NativeTypeName("HRESULT (LPCOLESTR, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, BOOL, int> Save;

        [NativeTypeName("HRESULT (LPCOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SaveCompleted;

        [NativeTypeName("HRESULT (LPOLESTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetCurFile;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPersistFile"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPersistFile(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPersist"/> to <see cref = "IPersistFile"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPersist"/> instance to be converted </param>
    public static explicit operator IPersistFile(Silk.NET.Windows.IPersist value)
    {
        return new IPersistFile(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistFile"/> to <see cref = "Silk.NET.Windows.IPersist"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistFile"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPersist(IPersistFile value)
    {
        return new Silk.NET.Windows.IPersist(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPersistFile"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPersistFile(Silk.NET.Windows.IUnknown value)
    {
        return new IPersistFile(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPersistFile"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPersistFile"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPersistFile value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
