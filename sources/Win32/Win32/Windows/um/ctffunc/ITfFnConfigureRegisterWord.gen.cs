// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BB95808A-6D8F-4BCA-8400-5390B586AEDF")]
[NativeTypeName("struct ITfFnConfigureRegisterWord : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnConfigureRegisterWord
    : ITfFnConfigureRegisterWord.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnConfigureRegisterWord));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfFnConfigureRegisterWord, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnConfigureRegisterWord, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnConfigureRegisterWord, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnConfigureRegisterWord, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Show(
        HWND hwndParent,
        [NativeTypeName("LANGID")] ushort langid,
        [NativeTypeName("const GUID &")] Guid* rguidProfile,
        [NativeTypeName("BSTR")] ushort* bstrRegistered
    )
    {
        return (
            (delegate* unmanaged<ITfFnConfigureRegisterWord, HWND, ushort, Guid*, ushort*, int>)(
                (*lpVtbl)[4]
            )
        )(this, hwndParent, langid, rguidProfile, bstrRegistered);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT Show(
            HWND hwndParent,
            [NativeTypeName("LANGID")] ushort langid,
            [NativeTypeName("const GUID &")] Guid* rguidProfile,
            [NativeTypeName("BSTR")] ushort* bstrRegistered
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

        [NativeTypeName("HRESULT (HWND, LANGID, const GUID &, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, ushort, Guid*, ushort*, int> Show;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfFnConfigureRegisterWord"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfFnConfigureRegisterWord(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfFunction"/> to <see cref = "ITfFnConfigureRegisterWord"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfFunction"/> instance to be converted </param>
    public static explicit operator ITfFnConfigureRegisterWord(Silk.NET.Windows.ITfFunction value)
    {
        return new ITfFnConfigureRegisterWord(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnConfigureRegisterWord"/> to <see cref = "Silk.NET.Windows.ITfFunction"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnConfigureRegisterWord"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfFunction(ITfFnConfigureRegisterWord value)
    {
        return new Silk.NET.Windows.ITfFunction(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfFnConfigureRegisterWord"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfFnConfigureRegisterWord(Silk.NET.Windows.IUnknown value)
    {
        return new ITfFnConfigureRegisterWord(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnConfigureRegisterWord"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnConfigureRegisterWord"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfFnConfigureRegisterWord value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
