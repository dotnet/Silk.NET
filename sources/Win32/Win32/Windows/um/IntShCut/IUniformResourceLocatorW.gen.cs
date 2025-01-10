// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("CABB0DA0-DA57-11CF-9974-0020AFD79762")]
[NativeTypeName("struct IUniformResourceLocatorW : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUniformResourceLocatorW
    : IUniformResourceLocatorW.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUniformResourceLocatorW));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorW, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUniformResourceLocatorW, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUniformResourceLocatorW, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetURL(
        [NativeTypeName("LPCWSTR")] ushort* pcszURL,
        [NativeTypeName("DWORD")] uint dwInFlags
    )
    {
        return ((delegate* unmanaged<IUniformResourceLocatorW, ushort*, uint, int>)((*lpVtbl)[3]))(
            this,
            pcszURL,
            dwInFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetURL([NativeTypeName("LPWSTR *")] ushort** ppszURL)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorW, ushort**, int>)((*lpVtbl)[4]))(
            this,
            ppszURL
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InvokeCommand(
        [NativeTypeName("PURLINVOKECOMMANDINFOW")] URLINVOKECOMMANDINFOW* purlici
    )
    {
        return (
            (delegate* unmanaged<IUniformResourceLocatorW, URLINVOKECOMMANDINFOW*, int>)(
                (*lpVtbl)[5]
            )
        )(this, purlici);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetURL(
            [NativeTypeName("LPCWSTR")] ushort* pcszURL,
            [NativeTypeName("DWORD")] uint dwInFlags
        );

        [VtblIndex(4)]
        HRESULT GetURL([NativeTypeName("LPWSTR *")] ushort** ppszURL);

        [VtblIndex(5)]
        HRESULT InvokeCommand(
            [NativeTypeName("PURLINVOKECOMMANDINFOW")] URLINVOKECOMMANDINFOW* purlici
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

        [NativeTypeName(
            "HRESULT (LPCWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetURL;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetURL;

        [NativeTypeName(
            "HRESULT (PURLINVOKECOMMANDINFOW) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, URLINVOKECOMMANDINFOW*, int> InvokeCommand;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUniformResourceLocatorW"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUniformResourceLocatorW(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUniformResourceLocatorW"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUniformResourceLocatorW(Silk.NET.Windows.IUnknown value)
    {
        return new IUniformResourceLocatorW(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUniformResourceLocatorW"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUniformResourceLocatorW"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUniformResourceLocatorW value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
