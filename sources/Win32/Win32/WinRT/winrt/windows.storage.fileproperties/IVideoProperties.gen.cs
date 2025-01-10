// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.fileproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("719AE507-68DE-4DB8-97DE-49998C059F2F")]
[NativeTypeName("struct IVideoProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IVideoProperties : IVideoProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IVideoProperties));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IVideoProperties, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IVideoProperties, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IVideoProperties, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IVideoProperties, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IVideoProperties, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IVideoProperties, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Rating([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IVideoProperties, uint*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Rating([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IVideoProperties, uint, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Keywords(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IVideoProperties, IVector<HSTRING>**, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Width([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IVideoProperties, uint*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Height([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IVideoProperties, uint*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Duration(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IVideoProperties, TimeSpan*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Latitude(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
            IReference<double>** value
    )
    {
        return ((delegate* unmanaged<IVideoProperties, IReference<double>**, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Longitude(
        [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
            IReference<double>** value
    )
    {
        return ((delegate* unmanaged<IVideoProperties, IReference<double>**, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged<IVideoProperties, HSTRING*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged<IVideoProperties, HSTRING, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Subtitle(HSTRING* value)
    {
        return ((delegate* unmanaged<IVideoProperties, HSTRING*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_Subtitle(HSTRING value)
    {
        return ((delegate* unmanaged<IVideoProperties, HSTRING, int>)((*lpVtbl)[17]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_Producers(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IVideoProperties, IVector<HSTRING>**, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_Publisher(HSTRING* value)
    {
        return ((delegate* unmanaged<IVideoProperties, HSTRING*, int>)((*lpVtbl)[19]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_Publisher(HSTRING value)
    {
        return ((delegate* unmanaged<IVideoProperties, HSTRING, int>)((*lpVtbl)[20]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Writers(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IVideoProperties, IVector<HSTRING>**, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Year([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IVideoProperties, uint*, int>)((*lpVtbl)[22]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Year([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IVideoProperties, uint, int>)((*lpVtbl)[23]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_Bitrate([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IVideoProperties, uint*, int>)((*lpVtbl)[24]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_Directors(
        [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
            IVector<HSTRING>** value
    )
    {
        return ((delegate* unmanaged<IVideoProperties, IVector<HSTRING>**, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_Orientation(
        [NativeTypeName("ABI::Windows::Storage::FileProperties::VideoOrientation *")]
            VideoOrientation* value
    )
    {
        return ((delegate* unmanaged<IVideoProperties, VideoOrientation*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Rating([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        HRESULT put_Rating([NativeTypeName("UINT32")] uint value);

        [VtblIndex(8)]
        HRESULT get_Keywords(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(9)]
        HRESULT get_Width([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        HRESULT get_Height([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT get_Duration(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(12)]
        HRESULT get_Latitude(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
                IReference<double>** value
        );

        [VtblIndex(13)]
        HRESULT get_Longitude(
            [NativeTypeName("ABI::Windows::Foundation::__FIReference_1_double_t **")]
                IReference<double>** value
        );

        [VtblIndex(14)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(15)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(16)]
        HRESULT get_Subtitle(HSTRING* value);

        [VtblIndex(17)]
        HRESULT put_Subtitle(HSTRING value);

        [VtblIndex(18)]
        HRESULT get_Producers(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(19)]
        HRESULT get_Publisher(HSTRING* value);

        [VtblIndex(20)]
        HRESULT put_Publisher(HSTRING value);

        [VtblIndex(21)]
        HRESULT get_Writers(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(22)]
        HRESULT get_Year([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(23)]
        HRESULT put_Year([NativeTypeName("UINT32")] uint value);

        [VtblIndex(24)]
        HRESULT get_Bitrate([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(25)]
        HRESULT get_Directors(
            [NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **")]
                IVector<HSTRING>** value
        );

        [VtblIndex(26)]
        HRESULT get_Orientation(
            [NativeTypeName("ABI::Windows::Storage::FileProperties::VideoOrientation *")]
                VideoOrientation* value
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Rating;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_Rating;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_Keywords;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Width;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Height;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_Duration;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<double>**, int> get_Latitude;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIReference_1_double_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IReference<double>**, int> get_Longitude;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Subtitle;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Subtitle;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_Producers;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Publisher;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Publisher;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_Writers;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Year;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_Year;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_Bitrate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_HSTRING_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IVector<HSTRING>**, int> get_Directors;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::FileProperties::VideoOrientation *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, VideoOrientation*, int> get_Orientation;
    }

    /// <summary>Initializes a new instance of the <see cref = "IVideoProperties"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IVideoProperties(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IVideoProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IVideoProperties(Silk.NET.WinRT.IInspectable value)
    {
        return new IVideoProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoProperties"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IVideoProperties value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IVideoProperties"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IVideoProperties(Silk.NET.Windows.IUnknown value)
    {
        return new IVideoProperties(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IVideoProperties"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IVideoProperties"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IVideoProperties value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
