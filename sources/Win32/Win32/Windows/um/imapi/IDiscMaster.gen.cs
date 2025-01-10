// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("520CCA62-51A5-11D3-9144-00104BA11C5E")]
[NativeTypeName("struct IDiscMaster : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiscMaster : IDiscMaster.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiscMaster));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiscMaster, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiscMaster, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiscMaster, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Open()
    {
        return ((delegate* unmanaged<IDiscMaster, int>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumDiscMasterFormats(IEnumDiscMasterFormats* ppEnum)
    {
        return ((delegate* unmanaged<IDiscMaster, IEnumDiscMasterFormats*, int>)((*lpVtbl)[4]))(
            this,
            ppEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetActiveDiscMasterFormat([NativeTypeName("LPIID")] Guid* lpiid)
    {
        return ((delegate* unmanaged<IDiscMaster, Guid*, int>)((*lpVtbl)[5]))(this, lpiid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetActiveDiscMasterFormat(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppUnk
    )
    {
        return ((delegate* unmanaged<IDiscMaster, Guid*, void**, int>)((*lpVtbl)[6]))(
            this,
            riid,
            ppUnk
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT EnumDiscRecorders(IEnumDiscRecorders* ppEnum)
    {
        return ((delegate* unmanaged<IDiscMaster, IEnumDiscRecorders*, int>)((*lpVtbl)[7]))(
            this,
            ppEnum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetActiveDiscRecorder(IDiscRecorder* ppRecorder)
    {
        return ((delegate* unmanaged<IDiscMaster, IDiscRecorder*, int>)((*lpVtbl)[8]))(
            this,
            ppRecorder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetActiveDiscRecorder(IDiscRecorder pRecorder)
    {
        return ((delegate* unmanaged<IDiscMaster, IDiscRecorder, int>)((*lpVtbl)[9]))(
            this,
            pRecorder
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ClearFormatContent()
    {
        return ((delegate* unmanaged<IDiscMaster, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ProgressAdvise(
        IDiscMasterProgressEvents pEvents,
        [NativeTypeName("UINT_PTR *")] nuint* pvCookie
    )
    {
        return (
            (delegate* unmanaged<IDiscMaster, IDiscMasterProgressEvents, nuint*, int>)(
                (*lpVtbl)[11]
            )
        )(this, pEvents, pvCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ProgressUnadvise([NativeTypeName("UINT_PTR")] nuint vCookie)
    {
        return ((delegate* unmanaged<IDiscMaster, nuint, int>)((*lpVtbl)[12]))(this, vCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RecordDisc(
        [NativeTypeName("boolean")] byte bSimulate,
        [NativeTypeName("boolean")] byte bEjectAfterBurn
    )
    {
        return ((delegate* unmanaged<IDiscMaster, byte, byte, int>)((*lpVtbl)[13]))(
            this,
            bSimulate,
            bEjectAfterBurn
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IDiscMaster, int>)((*lpVtbl)[14]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Open();

        [VtblIndex(4)]
        HRESULT EnumDiscMasterFormats(IEnumDiscMasterFormats* ppEnum);

        [VtblIndex(5)]
        HRESULT GetActiveDiscMasterFormat([NativeTypeName("LPIID")] Guid* lpiid);

        [VtblIndex(6)]
        HRESULT SetActiveDiscMasterFormat([NativeTypeName("const IID &")] Guid* riid, void** ppUnk);

        [VtblIndex(7)]
        HRESULT EnumDiscRecorders(IEnumDiscRecorders* ppEnum);

        [VtblIndex(8)]
        HRESULT GetActiveDiscRecorder(IDiscRecorder* ppRecorder);

        [VtblIndex(9)]
        HRESULT SetActiveDiscRecorder(IDiscRecorder pRecorder);

        [VtblIndex(10)]
        HRESULT ClearFormatContent();

        [VtblIndex(11)]
        HRESULT ProgressAdvise(
            IDiscMasterProgressEvents pEvents,
            [NativeTypeName("UINT_PTR *")] nuint* pvCookie
        );

        [VtblIndex(12)]
        HRESULT ProgressUnadvise([NativeTypeName("UINT_PTR")] nuint vCookie);

        [VtblIndex(13)]
        HRESULT RecordDisc(
            [NativeTypeName("boolean")] byte bSimulate,
            [NativeTypeName("boolean")] byte bEjectAfterBurn
        );

        [VtblIndex(14)]
        HRESULT Close();
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

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Open;

        [NativeTypeName("HRESULT (IEnumDiscMasterFormats **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumDiscMasterFormats*, int> EnumDiscMasterFormats;

        [NativeTypeName("HRESULT (LPIID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetActiveDiscMasterFormat;

        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> SetActiveDiscMasterFormat;

        [NativeTypeName("HRESULT (IEnumDiscRecorders **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumDiscRecorders*, int> EnumDiscRecorders;

        [NativeTypeName("HRESULT (IDiscRecorder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder*, int> GetActiveDiscRecorder;

        [NativeTypeName("HRESULT (IDiscRecorder *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDiscRecorder, int> SetActiveDiscRecorder;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ClearFormatContent;

        [NativeTypeName(
            "HRESULT (IDiscMasterProgressEvents *, UINT_PTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDiscMasterProgressEvents, nuint*, int> ProgressAdvise;

        [NativeTypeName("HRESULT (UINT_PTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, nuint, int> ProgressUnadvise;

        [NativeTypeName("HRESULT (boolean, boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, byte, int> RecordDisc;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiscMaster"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiscMaster(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiscMaster"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiscMaster(Silk.NET.Windows.IUnknown value)
    {
        return new IDiscMaster(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiscMaster"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiscMaster"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiscMaster value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
