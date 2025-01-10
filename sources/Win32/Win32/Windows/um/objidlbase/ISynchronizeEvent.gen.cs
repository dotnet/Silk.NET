// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000032-0000-0000-C000-000000000046")]
[NativeTypeName("struct ISynchronizeEvent : ISynchronizeHandle")]
[NativeInheritance("ISynchronizeHandle")]
public unsafe partial struct ISynchronizeEvent : ISynchronizeEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISynchronizeEvent));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISynchronizeEvent, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISynchronizeEvent, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISynchronizeEvent, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetHandle(HANDLE* ph)
    {
        return ((delegate* unmanaged<ISynchronizeEvent, HANDLE*, int>)((*lpVtbl)[3]))(this, ph);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetEventHandle(HANDLE* ph)
    {
        return ((delegate* unmanaged<ISynchronizeEvent, HANDLE*, int>)((*lpVtbl)[4]))(this, ph);
    }

    public interface Interface : ISynchronizeHandle.Interface
    {
        [VtblIndex(4)]
        HRESULT SetEventHandle(HANDLE* ph);
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

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, int> GetHandle;

        [NativeTypeName("HRESULT (HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE*, int> SetEventHandle;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISynchronizeEvent"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISynchronizeEvent(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ISynchronizeHandle"/> to <see cref = "ISynchronizeEvent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ISynchronizeHandle"/> instance to be converted </param>
    public static explicit operator ISynchronizeEvent(Silk.NET.Windows.ISynchronizeHandle value)
    {
        return new ISynchronizeEvent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISynchronizeEvent"/> to <see cref = "Silk.NET.Windows.ISynchronizeHandle"/>.</summary>
    /// <param name = "value">The <see cref = "ISynchronizeEvent"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ISynchronizeHandle(ISynchronizeEvent value)
    {
        return new Silk.NET.Windows.ISynchronizeHandle(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISynchronizeEvent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISynchronizeEvent(Silk.NET.Windows.IUnknown value)
    {
        return new ISynchronizeEvent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISynchronizeEvent"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISynchronizeEvent"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISynchronizeEvent value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
