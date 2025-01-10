// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("43C9FE15-F494-4C17-9DE2-B8A4AC350AA8")]
[NativeTypeName("struct ITfLanguageProfileNotifySink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfLanguageProfileNotifySink
    : ITfLanguageProfileNotifySink.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfLanguageProfileNotifySink));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfLanguageProfileNotifySink, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfLanguageProfileNotifySink, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfLanguageProfileNotifySink, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnLanguageChange([NativeTypeName("LANGID")] ushort langid, BOOL* pfAccept)
    {
        return (
            (delegate* unmanaged<ITfLanguageProfileNotifySink, ushort, BOOL*, int>)((*lpVtbl)[3])
        )(this, langid, pfAccept);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnLanguageChanged()
    {
        return ((delegate* unmanaged<ITfLanguageProfileNotifySink, int>)((*lpVtbl)[4]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnLanguageChange([NativeTypeName("LANGID")] ushort langid, BOOL* pfAccept);

        [VtblIndex(4)]
        HRESULT OnLanguageChanged();
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

        [NativeTypeName("HRESULT (LANGID, BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, BOOL*, int> OnLanguageChange;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> OnLanguageChanged;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfLanguageProfileNotifySink"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfLanguageProfileNotifySink(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfLanguageProfileNotifySink"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfLanguageProfileNotifySink(Silk.NET.Windows.IUnknown value)
    {
        return new ITfLanguageProfileNotifySink(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfLanguageProfileNotifySink"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfLanguageProfileNotifySink"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfLanguageProfileNotifySink value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
