// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("045FA593-8799-42B8-BC8D-8968C6453507")]
[NativeTypeName("struct IMFMediaBuffer : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMFMediaBuffer : IMFMediaBuffer.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaBuffer));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaBuffer, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaBuffer, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaBuffer, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Lock(
        byte** ppbBuffer,
        [NativeTypeName("DWORD *")] uint* pcbMaxLength,
        [NativeTypeName("DWORD *")] uint* pcbCurrentLength
    )
    {
        return ((delegate* unmanaged<IMFMediaBuffer, byte**, uint*, uint*, int>)((*lpVtbl)[3]))(
            this,
            ppbBuffer,
            pcbMaxLength,
            pcbCurrentLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unlock()
    {
        return ((delegate* unmanaged<IMFMediaBuffer, int>)((*lpVtbl)[4]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCurrentLength([NativeTypeName("DWORD *")] uint* pcbCurrentLength)
    {
        return ((delegate* unmanaged<IMFMediaBuffer, uint*, int>)((*lpVtbl)[5]))(
            this,
            pcbCurrentLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetCurrentLength([NativeTypeName("DWORD")] uint cbCurrentLength)
    {
        return ((delegate* unmanaged<IMFMediaBuffer, uint, int>)((*lpVtbl)[6]))(
            this,
            cbCurrentLength
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength)
    {
        return ((delegate* unmanaged<IMFMediaBuffer, uint*, int>)((*lpVtbl)[7]))(
            this,
            pcbMaxLength
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Lock(
            byte** ppbBuffer,
            [NativeTypeName("DWORD *")] uint* pcbMaxLength,
            [NativeTypeName("DWORD *")] uint* pcbCurrentLength
        );

        [VtblIndex(4)]
        HRESULT Unlock();

        [VtblIndex(5)]
        HRESULT GetCurrentLength([NativeTypeName("DWORD *")] uint* pcbCurrentLength);

        [VtblIndex(6)]
        HRESULT SetCurrentLength([NativeTypeName("DWORD")] uint cbCurrentLength);

        [VtblIndex(7)]
        HRESULT GetMaxLength([NativeTypeName("DWORD *")] uint* pcbMaxLength);
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

        [NativeTypeName("HRESULT (BYTE **, DWORD *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte**, uint*, uint*, int> Lock;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unlock;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCurrentLength;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetCurrentLength;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMaxLength;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaBuffer"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaBuffer(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaBuffer"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaBuffer(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaBuffer(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaBuffer"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaBuffer"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaBuffer value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
