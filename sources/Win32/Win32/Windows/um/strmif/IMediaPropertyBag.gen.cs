// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("6025A880-C0D5-11D0-BD4E-00A0C911CE86")]
[NativeTypeName("struct IMediaPropertyBag : IPropertyBag")]
[NativeInheritance("IPropertyBag")]
public unsafe partial struct IMediaPropertyBag : IMediaPropertyBag.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaPropertyBag));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMediaPropertyBag, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMediaPropertyBag, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMediaPropertyBag, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Read(
        [NativeTypeName("LPCOLESTR")] ushort* pszPropName,
        VARIANT* pVar,
        IErrorLog pErrorLog
    )
    {
        return (
            (delegate* unmanaged<IMediaPropertyBag, ushort*, VARIANT*, IErrorLog, int>)(
                (*lpVtbl)[3]
            )
        )(this, pszPropName, pVar, pErrorLog);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Write([NativeTypeName("LPCOLESTR")] ushort* pszPropName, VARIANT* pVar)
    {
        return ((delegate* unmanaged<IMediaPropertyBag, ushort*, VARIANT*, int>)((*lpVtbl)[4]))(
            this,
            pszPropName,
            pVar
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumProperty(
        [NativeTypeName("ULONG")] uint iProperty,
        VARIANT* pvarPropertyName,
        VARIANT* pvarPropertyValue
    )
    {
        return (
            (delegate* unmanaged<IMediaPropertyBag, uint, VARIANT*, VARIANT*, int>)((*lpVtbl)[5])
        )(this, iProperty, pvarPropertyName, pvarPropertyValue);
    }

    public interface Interface : IPropertyBag.Interface
    {
        [VtblIndex(5)]
        HRESULT EnumProperty(
            [NativeTypeName("ULONG")] uint iProperty,
            VARIANT* pvarPropertyName,
            VARIANT* pvarPropertyValue
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

        [NativeTypeName("HRESULT (LPCOLESTR, VARIANT *, IErrorLog *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, IErrorLog, int> Read;

        [NativeTypeName("HRESULT (LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> Write;

        [NativeTypeName("HRESULT (ULONG, VARIANT *, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, VARIANT*, VARIANT*, int> EnumProperty;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMediaPropertyBag"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMediaPropertyBag(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IPropertyBag"/> to <see cref = "IMediaPropertyBag"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IPropertyBag"/> instance to be converted </param>
    public static explicit operator IMediaPropertyBag(Silk.NET.Windows.IPropertyBag value)
    {
        return new IMediaPropertyBag(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPropertyBag"/> to <see cref = "Silk.NET.Windows.IPropertyBag"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPropertyBag"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IPropertyBag(IMediaPropertyBag value)
    {
        return new Silk.NET.Windows.IPropertyBag(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMediaPropertyBag"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMediaPropertyBag(Silk.NET.Windows.IUnknown value)
    {
        return new IMediaPropertyBag(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMediaPropertyBag"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMediaPropertyBag"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMediaPropertyBag value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
