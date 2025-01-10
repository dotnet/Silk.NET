// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2338AC6E-2B9D-44C0-A75E-EE64F256B3BD")]
[NativeTypeName("struct ITfFnPropertyUIStatus : ITfFunction")]
[NativeInheritance("ITfFunction")]
public unsafe partial struct ITfFnPropertyUIStatus : ITfFnPropertyUIStatus.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnPropertyUIStatus));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfFnPropertyUIStatus, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfFnPropertyUIStatus, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnPropertyUIStatus, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<ITfFnPropertyUIStatus, ushort**, int>)((*lpVtbl)[3]))(
            this,
            pbstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetStatus(
        [NativeTypeName("const GUID &")] Guid* refguidProp,
        [NativeTypeName("DWORD *")] uint* pdw
    )
    {
        return ((delegate* unmanaged<ITfFnPropertyUIStatus, Guid*, uint*, int>)((*lpVtbl)[4]))(
            this,
            refguidProp,
            pdw
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetStatus(
        [NativeTypeName("const GUID &")] Guid* refguidProp,
        [NativeTypeName("DWORD")] uint dw
    )
    {
        return ((delegate* unmanaged<ITfFnPropertyUIStatus, Guid*, uint, int>)((*lpVtbl)[5]))(
            this,
            refguidProp,
            dw
        );
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT GetStatus(
            [NativeTypeName("const GUID &")] Guid* refguidProp,
            [NativeTypeName("DWORD *")] uint* pdw
        );

        [VtblIndex(5)]
        HRESULT SetStatus(
            [NativeTypeName("const GUID &")] Guid* refguidProp,
            [NativeTypeName("DWORD")] uint dw
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

        [NativeTypeName("HRESULT (const GUID &, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, int> GetStatus;

        [NativeTypeName("HRESULT (const GUID &, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> SetStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfFnPropertyUIStatus"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfFnPropertyUIStatus(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfFunction"/> to <see cref = "ITfFnPropertyUIStatus"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfFunction"/> instance to be converted </param>
    public static explicit operator ITfFnPropertyUIStatus(Silk.NET.Windows.ITfFunction value)
    {
        return new ITfFnPropertyUIStatus(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnPropertyUIStatus"/> to <see cref = "Silk.NET.Windows.ITfFunction"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnPropertyUIStatus"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfFunction(ITfFnPropertyUIStatus value)
    {
        return new Silk.NET.Windows.ITfFunction(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfFnPropertyUIStatus"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfFnPropertyUIStatus(Silk.NET.Windows.IUnknown value)
    {
        return new ITfFnPropertyUIStatus(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnPropertyUIStatus"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnPropertyUIStatus"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfFnPropertyUIStatus value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
