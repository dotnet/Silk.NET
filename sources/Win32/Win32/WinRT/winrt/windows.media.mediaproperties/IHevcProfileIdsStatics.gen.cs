// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.mediaproperties.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1E50D280-2AA7-53C1-973F-2189FA656F53")]
[NativeTypeName("struct IHevcProfileIdsStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IHevcProfileIdsStatics : IHevcProfileIdsStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHevcProfileIdsStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHevcProfileIdsStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_MainChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_MainChromaSubsampling420BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MainChromaSubsampling420BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MainChromaSubsampling422BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_MainChromaSubsampling422BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_MainChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_MainChromaSubsampling444BitDepth10([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_MainChromaSubsampling444BitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_MonochromeBitDepth12([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_MonochromeBitDepth16([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_MainIntraChromaSubsampling420BitDepth8(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[16]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_MainIntraChromaSubsampling420BitDepth10(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[17]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_MainIntraChromaSubsampling420BitDepth12(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[18]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_MainIntraChromaSubsampling422BitDepth10(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[19]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_MainIntraChromaSubsampling422BitDepth12(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[20]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_MainIntraChromaSubsampling444BitDepth8(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[21]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_MainIntraChromaSubsampling444BitDepth10(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[22]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_MainIntraChromaSubsampling444BitDepth12(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[23]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT get_MainIntraChromaSubsampling444BitDepth16(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[24]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_MainStillChromaSubsampling420BitDepth8(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[25]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT get_MainStillChromaSubsampling444BitDepth8(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[26]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT get_MainStillChromaSubsampling444BitDepth16(
        [NativeTypeName("INT32 *")] int* value
    )
    {
        return ((delegate* unmanaged<IHevcProfileIdsStatics, int*, int>)((*lpVtbl)[27]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_MainChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(7)]
        HRESULT get_MainChromaSubsampling420BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(8)]
        HRESULT get_MainChromaSubsampling420BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(9)]
        HRESULT get_MainChromaSubsampling422BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(10)]
        HRESULT get_MainChromaSubsampling422BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(11)]
        HRESULT get_MainChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(12)]
        HRESULT get_MainChromaSubsampling444BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT get_MainChromaSubsampling444BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(14)]
        HRESULT get_MonochromeBitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(15)]
        HRESULT get_MonochromeBitDepth16([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(16)]
        HRESULT get_MainIntraChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(17)]
        HRESULT get_MainIntraChromaSubsampling420BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(18)]
        HRESULT get_MainIntraChromaSubsampling420BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(19)]
        HRESULT get_MainIntraChromaSubsampling422BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(20)]
        HRESULT get_MainIntraChromaSubsampling422BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(21)]
        HRESULT get_MainIntraChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(22)]
        HRESULT get_MainIntraChromaSubsampling444BitDepth10([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(23)]
        HRESULT get_MainIntraChromaSubsampling444BitDepth12([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(24)]
        HRESULT get_MainIntraChromaSubsampling444BitDepth16([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(25)]
        HRESULT get_MainStillChromaSubsampling420BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(26)]
        HRESULT get_MainStillChromaSubsampling444BitDepth8([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(27)]
        HRESULT get_MainStillChromaSubsampling444BitDepth16([NativeTypeName("INT32 *")] int* value);
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

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainChromaSubsampling420BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainChromaSubsampling420BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainChromaSubsampling420BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainChromaSubsampling422BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainChromaSubsampling422BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainChromaSubsampling444BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainChromaSubsampling444BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainChromaSubsampling444BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MonochromeBitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MonochromeBitDepth16;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainIntraChromaSubsampling420BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainIntraChromaSubsampling420BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainIntraChromaSubsampling420BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainIntraChromaSubsampling422BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainIntraChromaSubsampling422BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainIntraChromaSubsampling444BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainIntraChromaSubsampling444BitDepth10;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainIntraChromaSubsampling444BitDepth12;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainIntraChromaSubsampling444BitDepth16;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainStillChromaSubsampling420BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainStillChromaSubsampling444BitDepth8;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_MainStillChromaSubsampling444BitDepth16;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHevcProfileIdsStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHevcProfileIdsStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IHevcProfileIdsStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IHevcProfileIdsStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IHevcProfileIdsStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHevcProfileIdsStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IHevcProfileIdsStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IHevcProfileIdsStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHevcProfileIdsStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHevcProfileIdsStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IHevcProfileIdsStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHevcProfileIdsStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHevcProfileIdsStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHevcProfileIdsStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
