// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EB0CB9E8-7996-11D2-872E-0000F8080859")]
[NativeTypeName("struct IReleaseMarshalBuffers : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IReleaseMarshalBuffers : IReleaseMarshalBuffers.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IReleaseMarshalBuffers));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IReleaseMarshalBuffers, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IReleaseMarshalBuffers, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IReleaseMarshalBuffers, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReleaseMarshalBuffer(
        RPCOLEMESSAGE* pMsg,
        [NativeTypeName("DWORD")] uint dwFlags,
        IUnknown pChnl
    )
    {
        return (
            (delegate* unmanaged<IReleaseMarshalBuffers, RPCOLEMESSAGE*, uint, IUnknown, int>)(
                (*lpVtbl)[3]
            )
        )(this, pMsg, dwFlags, pChnl);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReleaseMarshalBuffer(
            RPCOLEMESSAGE* pMsg,
            [NativeTypeName("DWORD")] uint dwFlags,
            IUnknown pChnl
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

        [NativeTypeName("HRESULT (RPCOLEMESSAGE *, DWORD, IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            RPCOLEMESSAGE*,
            uint,
            IUnknown,
            int> ReleaseMarshalBuffer;
    }

    /// <summary>Initializes a new instance of the <see cref = "IReleaseMarshalBuffers"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IReleaseMarshalBuffers(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IReleaseMarshalBuffers"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IReleaseMarshalBuffers(Silk.NET.Windows.IUnknown value)
    {
        return new IReleaseMarshalBuffers(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IReleaseMarshalBuffers"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IReleaseMarshalBuffers"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IReleaseMarshalBuffers value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
