// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7A5E5354-B114-4C72-B991-3131D75032EA")]
[NativeTypeName("struct IMFMediaEngineSrcElements : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IMFMediaEngineSrcElements
    : IMFMediaEngineSrcElements.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFMediaEngineSrcElements));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMFMediaEngineSrcElements, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("DWORD")]
    public uint GetLength()
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetURL(
        [NativeTypeName("DWORD")] uint index,
        [NativeTypeName("BSTR *")] ushort** pURL
    )
    {
        return (
            (delegate* unmanaged<IMFMediaEngineSrcElements, uint, ushort**, int>)((*lpVtbl)[4])
        )(this, index, pURL);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetType(
        [NativeTypeName("DWORD")] uint index,
        [NativeTypeName("BSTR *")] ushort** pType
    )
    {
        return (
            (delegate* unmanaged<IMFMediaEngineSrcElements, uint, ushort**, int>)((*lpVtbl)[5])
        )(this, index, pType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMedia(
        [NativeTypeName("DWORD")] uint index,
        [NativeTypeName("BSTR *")] ushort** pMedia
    )
    {
        return (
            (delegate* unmanaged<IMFMediaEngineSrcElements, uint, ushort**, int>)((*lpVtbl)[6])
        )(this, index, pMedia);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddElement(
        [NativeTypeName("BSTR")] ushort* pURL,
        [NativeTypeName("BSTR")] ushort* pType,
        [NativeTypeName("BSTR")] ushort* pMedia
    )
    {
        return (
            (delegate* unmanaged<IMFMediaEngineSrcElements, ushort*, ushort*, ushort*, int>)(
                (*lpVtbl)[7]
            )
        )(this, pURL, pType, pMedia);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveAllElements()
    {
        return ((delegate* unmanaged<IMFMediaEngineSrcElements, int>)((*lpVtbl)[8]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("DWORD")]
        uint GetLength();

        [VtblIndex(4)]
        HRESULT GetURL(
            [NativeTypeName("DWORD")] uint index,
            [NativeTypeName("BSTR *")] ushort** pURL
        );

        [VtblIndex(5)]
        HRESULT GetType(
            [NativeTypeName("DWORD")] uint index,
            [NativeTypeName("BSTR *")] ushort** pType
        );

        [VtblIndex(6)]
        HRESULT GetMedia(
            [NativeTypeName("DWORD")] uint index,
            [NativeTypeName("BSTR *")] ushort** pMedia
        );

        [VtblIndex(7)]
        HRESULT AddElement(
            [NativeTypeName("BSTR")] ushort* pURL,
            [NativeTypeName("BSTR")] ushort* pType,
            [NativeTypeName("BSTR")] ushort* pMedia
        );

        [VtblIndex(8)]
        HRESULT RemoveAllElements();
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

        [NativeTypeName("DWORD () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetLength;

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetURL;

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public new delegate* unmanaged<TSelf*, uint, ushort**, int> GetType;

        [NativeTypeName("HRESULT (DWORD, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, int> GetMedia;

        [NativeTypeName("HRESULT (BSTR, BSTR, BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ushort*, int> AddElement;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RemoveAllElements;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMFMediaEngineSrcElements"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMFMediaEngineSrcElements(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMFMediaEngineSrcElements"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMFMediaEngineSrcElements(Silk.NET.Windows.IUnknown value)
    {
        return new IMFMediaEngineSrcElements(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMFMediaEngineSrcElements"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMFMediaEngineSrcElements"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMFMediaEngineSrcElements value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
