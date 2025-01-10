// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ahadmin.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8F6D760F-F0CB-4D69-B5F6-848B33E9BDC6")]
[NativeTypeName("struct IAppHostConfigManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppHostConfigManager : IAppHostConfigManager.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppHostConfigManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppHostConfigManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppHostConfigManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppHostConfigManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetConfigFile(
        [NativeTypeName("BSTR")] ushort* bstrConfigPath,
        IAppHostConfigFile* ppConfigFile
    )
    {
        return (
            (delegate* unmanaged<IAppHostConfigManager, ushort*, IAppHostConfigFile*, int>)(
                (*lpVtbl)[3]
            )
        )(this, bstrConfigPath, ppConfigFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetUniqueConfigPath(
        [NativeTypeName("BSTR")] ushort* bstrConfigPath,
        [NativeTypeName("BSTR *")] ushort** pbstrUniquePath
    )
    {
        return ((delegate* unmanaged<IAppHostConfigManager, ushort*, ushort**, int>)((*lpVtbl)[4]))(
            this,
            bstrConfigPath,
            pbstrUniquePath
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetConfigFile(
            [NativeTypeName("BSTR")] ushort* bstrConfigPath,
            IAppHostConfigFile* ppConfigFile
        );

        [VtblIndex(4)]
        HRESULT GetUniqueConfigPath(
            [NativeTypeName("BSTR")] ushort* bstrConfigPath,
            [NativeTypeName("BSTR *")] ushort** pbstrUniquePath
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

        [NativeTypeName("HRESULT (BSTR, IAppHostConfigFile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IAppHostConfigFile*, int> GetConfigFile;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetUniqueConfigPath;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppHostConfigManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppHostConfigManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppHostConfigManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppHostConfigManager(Silk.NET.Windows.IUnknown value)
    {
        return new IAppHostConfigManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppHostConfigManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppHostConfigManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppHostConfigManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
