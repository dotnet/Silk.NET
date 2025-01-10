// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A87A8574-A6C1-4E15-99F0-3D3965F548EB")]
[NativeTypeName("struct ITfFnLangProfileUtil : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnLangProfileUtil : ITfFnLangProfileUtil.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnLangProfileUtil));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnLangProfileUtil, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfFnLangProfileUtil, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnLangProfileUtil, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnLangProfileUtil, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RegisterActiveProfiles()
    {
        return ((delegate* unmanaged<ITfFnLangProfileUtil, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT IsProfileAvailableForLang(
        [NativeTypeName("LANGID")] ushort langid,
        BOOL* pfAvailable
    )
    {
        return ((delegate* unmanaged<ITfFnLangProfileUtil, ushort, BOOL*, int>)((*lpVtbl)[5]))(
            this,
            langid,
            pfAvailable
        );
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT RegisterActiveProfiles();

        [VtblIndex(5)]
        HRESULT IsProfileAvailableForLang(
            [NativeTypeName("LANGID")] ushort langid,
            BOOL* pfAvailable
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RegisterActiveProfiles;

        [NativeTypeName("HRESULT (LANGID, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, BOOL*, int> IsProfileAvailableForLang;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfFnLangProfileUtil"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfFnLangProfileUtil(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfFunction"/> to <see cref = "ITfFnLangProfileUtil"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfFunction"/> instance to be converted </param>
    public static explicit operator ITfFnLangProfileUtil(Silk.NET.Windows.ITfFunction value)
    {
        return new ITfFnLangProfileUtil(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnLangProfileUtil"/> to <see cref = "Silk.NET.Windows.ITfFunction"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnLangProfileUtil"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfFunction(ITfFnLangProfileUtil value)
    {
        return new Silk.NET.Windows.ITfFunction(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfFnLangProfileUtil"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfFnLangProfileUtil(Silk.NET.Windows.IUnknown value)
    {
        return new ITfFnLangProfileUtil(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnLangProfileUtil"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnLangProfileUtil"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfFnLangProfileUtil value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
