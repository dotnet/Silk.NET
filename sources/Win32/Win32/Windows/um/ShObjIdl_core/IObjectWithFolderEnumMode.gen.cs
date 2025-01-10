// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6A9D9026-0E6E-464C-B000-42ECC07DE673")]
[NativeTypeName("struct IObjectWithFolderEnumMode : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IObjectWithFolderEnumMode
    : IObjectWithFolderEnumMode.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IObjectWithFolderEnumMode));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IObjectWithFolderEnumMode, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IObjectWithFolderEnumMode, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IObjectWithFolderEnumMode, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetMode(FOLDER_ENUM_MODE feMode)
    {
        return (
            (delegate* unmanaged<IObjectWithFolderEnumMode, FOLDER_ENUM_MODE, int>)((*lpVtbl)[3])
        )(this, feMode);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMode(FOLDER_ENUM_MODE* pfeMode)
    {
        return (
            (delegate* unmanaged<IObjectWithFolderEnumMode, FOLDER_ENUM_MODE*, int>)((*lpVtbl)[4])
        )(this, pfeMode);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetMode(FOLDER_ENUM_MODE feMode);

        [VtblIndex(4)]
        HRESULT GetMode(FOLDER_ENUM_MODE* pfeMode);
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

        [NativeTypeName("HRESULT (FOLDER_ENUM_MODE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FOLDER_ENUM_MODE, int> SetMode;

        [NativeTypeName("HRESULT (FOLDER_ENUM_MODE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FOLDER_ENUM_MODE*, int> GetMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IObjectWithFolderEnumMode"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IObjectWithFolderEnumMode(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IObjectWithFolderEnumMode"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IObjectWithFolderEnumMode(Silk.NET.Windows.IUnknown value)
    {
        return new IObjectWithFolderEnumMode(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IObjectWithFolderEnumMode"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IObjectWithFolderEnumMode"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IObjectWithFolderEnumMode value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
