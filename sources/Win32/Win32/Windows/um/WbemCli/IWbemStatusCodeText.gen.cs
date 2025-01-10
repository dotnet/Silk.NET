// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EB87E1BC-3233-11D2-AEC9-00C04FB68820")]
[NativeTypeName("struct IWbemStatusCodeText : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemStatusCodeText : IWbemStatusCodeText.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemStatusCodeText));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemStatusCodeText, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWbemStatusCodeText, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemStatusCodeText, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetErrorCodeText(
        HRESULT hRes,
        [NativeTypeName("LCID")] uint LocaleId,
        [NativeTypeName("long")] int lFlags,
        [NativeTypeName("BSTR *")] ushort** MessageText
    )
    {
        return (
            (delegate* unmanaged<IWbemStatusCodeText, HRESULT, uint, int, ushort**, int>)(
                (*lpVtbl)[3]
            )
        )(this, hRes, LocaleId, lFlags, MessageText);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFacilityCodeText(
        HRESULT hRes,
        [NativeTypeName("LCID")] uint LocaleId,
        [NativeTypeName("long")] int lFlags,
        [NativeTypeName("BSTR *")] ushort** MessageText
    )
    {
        return (
            (delegate* unmanaged<IWbemStatusCodeText, HRESULT, uint, int, ushort**, int>)(
                (*lpVtbl)[4]
            )
        )(this, hRes, LocaleId, lFlags, MessageText);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetErrorCodeText(
            HRESULT hRes,
            [NativeTypeName("LCID")] uint LocaleId,
            [NativeTypeName("long")] int lFlags,
            [NativeTypeName("BSTR *")] ushort** MessageText
        );

        [VtblIndex(4)]
        HRESULT GetFacilityCodeText(
            HRESULT hRes,
            [NativeTypeName("LCID")] uint LocaleId,
            [NativeTypeName("long")] int lFlags,
            [NativeTypeName("BSTR *")] ushort** MessageText
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

        [NativeTypeName("HRESULT (HRESULT, LCID, long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, uint, int, ushort**, int> GetErrorCodeText;

        [NativeTypeName("HRESULT (HRESULT, LCID, long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT, uint, int, ushort**, int> GetFacilityCodeText;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWbemStatusCodeText"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWbemStatusCodeText(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWbemStatusCodeText"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWbemStatusCodeText(Silk.NET.Windows.IUnknown value)
    {
        return new IWbemStatusCodeText(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemStatusCodeText"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemStatusCodeText"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWbemStatusCodeText value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
