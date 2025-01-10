// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/IntShCut.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FBF23B80-E3F0-101B-8488-00AA003E56F8")]
[NativeTypeName("struct IUniformResourceLocatorA : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IUniformResourceLocatorA
    : IUniformResourceLocatorA.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUniformResourceLocatorA));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorA, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUniformResourceLocatorA, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUniformResourceLocatorA, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetURL(
        [NativeTypeName("LPCSTR")] sbyte* pcszURL,
        [NativeTypeName("DWORD")] uint dwInFlags
    )
    {
        return ((delegate* unmanaged<IUniformResourceLocatorA, sbyte*, uint, int>)((*lpVtbl)[3]))(
            this,
            pcszURL,
            dwInFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetURL([NativeTypeName("LPSTR *")] sbyte** ppszURL)
    {
        return ((delegate* unmanaged<IUniformResourceLocatorA, sbyte**, int>)((*lpVtbl)[4]))(
            this,
            ppszURL
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT InvokeCommand(
        [NativeTypeName("PURLINVOKECOMMANDINFOA")] URLINVOKECOMMANDINFOA* purlici
    )
    {
        return (
            (delegate* unmanaged<IUniformResourceLocatorA, URLINVOKECOMMANDINFOA*, int>)(
                (*lpVtbl)[5]
            )
        )(this, purlici);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetURL(
            [NativeTypeName("LPCSTR")] sbyte* pcszURL,
            [NativeTypeName("DWORD")] uint dwInFlags
        );

        [VtblIndex(4)]
        HRESULT GetURL([NativeTypeName("LPSTR *")] sbyte** ppszURL);

        [VtblIndex(5)]
        HRESULT InvokeCommand(
            [NativeTypeName("PURLINVOKECOMMANDINFOA")] URLINVOKECOMMANDINFOA* purlici
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
            "HRESULT (LPCSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, sbyte*, uint, int> SetURL;

        [NativeTypeName("HRESULT (LPSTR *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte**, int> GetURL;

        [NativeTypeName(
            "HRESULT (PURLINVOKECOMMANDINFOA) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, URLINVOKECOMMANDINFOA*, int> InvokeCommand;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUniformResourceLocatorA"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUniformResourceLocatorA(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUniformResourceLocatorA"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUniformResourceLocatorA(Silk.NET.Windows.IUnknown value)
    {
        return new IUniformResourceLocatorA(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUniformResourceLocatorA"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUniformResourceLocatorA"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUniformResourceLocatorA value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
