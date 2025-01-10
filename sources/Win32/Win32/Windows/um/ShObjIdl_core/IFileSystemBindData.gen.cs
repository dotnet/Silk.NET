// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("01E18D10-4D8B-11D2-855D-006008059367")]
[NativeTypeName("struct IFileSystemBindData : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileSystemBindData : IFileSystemBindData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSystemBindData));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSystemBindData, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileSystemBindData, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSystemBindData, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFindData([NativeTypeName("const WIN32_FIND_DATAW *")] WIN32_FIND_DATAW* pfd)
    {
        return ((delegate* unmanaged<IFileSystemBindData, WIN32_FIND_DATAW*, int>)((*lpVtbl)[3]))(
            this,
            pfd
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFindData(WIN32_FIND_DATAW* pfd)
    {
        return ((delegate* unmanaged<IFileSystemBindData, WIN32_FIND_DATAW*, int>)((*lpVtbl)[4]))(
            this,
            pfd
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetFindData([NativeTypeName("const WIN32_FIND_DATAW *")] WIN32_FIND_DATAW* pfd);

        [VtblIndex(4)]
        HRESULT GetFindData(WIN32_FIND_DATAW* pfd);
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

        [NativeTypeName("HRESULT (const WIN32_FIND_DATAW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WIN32_FIND_DATAW*, int> SetFindData;

        [NativeTypeName("HRESULT (WIN32_FIND_DATAW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WIN32_FIND_DATAW*, int> GetFindData;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileSystemBindData"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileSystemBindData(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileSystemBindData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileSystemBindData(Silk.NET.Windows.IUnknown value)
    {
        return new IFileSystemBindData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSystemBindData"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSystemBindData"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileSystemBindData value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
