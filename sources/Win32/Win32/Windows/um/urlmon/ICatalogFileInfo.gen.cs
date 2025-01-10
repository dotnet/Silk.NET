// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("711C7600-6B48-11D1-B403-00AA00B92AF1")]
[NativeTypeName("struct ICatalogFileInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICatalogFileInfo : ICatalogFileInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICatalogFileInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICatalogFileInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICatalogFileInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICatalogFileInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCatalogFile([NativeTypeName("LPSTR *")] sbyte** ppszCatalogFile)
    {
        return ((delegate* unmanaged<ICatalogFileInfo, sbyte**, int>)((*lpVtbl)[3]))(
            this,
            ppszCatalogFile
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetJavaTrust(void** ppJavaTrust)
    {
        return ((delegate* unmanaged<ICatalogFileInfo, void**, int>)((*lpVtbl)[4]))(
            this,
            ppJavaTrust
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCatalogFile([NativeTypeName("LPSTR *")] sbyte** ppszCatalogFile);

        [VtblIndex(4)]
        HRESULT GetJavaTrust(void** ppJavaTrust);
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

        [NativeTypeName("HRESULT (LPSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte**, int> GetCatalogFile;

        [NativeTypeName("HRESULT (void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void**, int> GetJavaTrust;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICatalogFileInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICatalogFileInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICatalogFileInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICatalogFileInfo(Silk.NET.Windows.IUnknown value)
    {
        return new ICatalogFileInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICatalogFileInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICatalogFileInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICatalogFileInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
