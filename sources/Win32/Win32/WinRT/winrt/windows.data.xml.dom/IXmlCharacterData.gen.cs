// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("132E42AB-4E36-4DF6-B1C8-0CE62FD88B26")]
[NativeTypeName("struct IXmlCharacterData : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IXmlCharacterData : IXmlCharacterData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IXmlCharacterData));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IXmlCharacterData, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IXmlCharacterData, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IXmlCharacterData, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IXmlCharacterData, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IXmlCharacterData, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IXmlCharacterData, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Data(HSTRING* value)
    {
        return ((delegate* unmanaged<IXmlCharacterData, HSTRING*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Data(HSTRING value)
    {
        return ((delegate* unmanaged<IXmlCharacterData, HSTRING, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Length([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IXmlCharacterData, uint*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SubstringData(
        [NativeTypeName("UINT32")] uint offset,
        [NativeTypeName("UINT32")] uint count,
        HSTRING* data
    )
    {
        return ((delegate* unmanaged<IXmlCharacterData, uint, uint, HSTRING*, int>)((*lpVtbl)[9]))(
            this,
            offset,
            count,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT AppendData(HSTRING data)
    {
        return ((delegate* unmanaged<IXmlCharacterData, HSTRING, int>)((*lpVtbl)[10]))(this, data);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT InsertData([NativeTypeName("UINT32")] uint offset, HSTRING data)
    {
        return ((delegate* unmanaged<IXmlCharacterData, uint, HSTRING, int>)((*lpVtbl)[11]))(
            this,
            offset,
            data
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DeleteData(
        [NativeTypeName("UINT32")] uint offset,
        [NativeTypeName("UINT32")] uint count
    )
    {
        return ((delegate* unmanaged<IXmlCharacterData, uint, uint, int>)((*lpVtbl)[12]))(
            this,
            offset,
            count
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ReplaceData(
        [NativeTypeName("UINT32")] uint offset,
        [NativeTypeName("UINT32")] uint count,
        HSTRING data
    )
    {
        return ((delegate* unmanaged<IXmlCharacterData, uint, uint, HSTRING, int>)((*lpVtbl)[13]))(
            this,
            offset,
            count,
            data
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Data(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Data(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Length([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        HRESULT SubstringData(
            [NativeTypeName("UINT32")] uint offset,
            [NativeTypeName("UINT32")] uint count,
            HSTRING* data
        );

        [VtblIndex(10)]
        HRESULT AppendData(HSTRING data);

        [VtblIndex(11)]
        HRESULT InsertData([NativeTypeName("UINT32")] uint offset, HSTRING data);

        [VtblIndex(12)]
        HRESULT DeleteData(
            [NativeTypeName("UINT32")] uint offset,
            [NativeTypeName("UINT32")] uint count
        );

        [VtblIndex(13)]
        HRESULT ReplaceData(
            [NativeTypeName("UINT32")] uint offset,
            [NativeTypeName("UINT32")] uint count,
            HSTRING data
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Data;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Data;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Length;

        [NativeTypeName("HRESULT (UINT32, UINT32, HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, HSTRING*, int> SubstringData;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> AppendData;

        [NativeTypeName("HRESULT (UINT32, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HSTRING, int> InsertData;

        [NativeTypeName("HRESULT (UINT32, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> DeleteData;

        [NativeTypeName("HRESULT (UINT32, UINT32, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, HSTRING, int> ReplaceData;
    }

    /// <summary>Initializes a new instance of the <see cref = "IXmlCharacterData"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IXmlCharacterData(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IXmlCharacterData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IXmlCharacterData(Silk.NET.WinRT.IInspectable value)
    {
        return new IXmlCharacterData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlCharacterData"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlCharacterData"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IXmlCharacterData value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IXmlCharacterData"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IXmlCharacterData(Silk.NET.Windows.IUnknown value)
    {
        return new IXmlCharacterData(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IXmlCharacterData"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IXmlCharacterData"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IXmlCharacterData value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
