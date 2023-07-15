// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1svg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='ID2D1SvgPathData.xml' path='doc/member[@name="ID2D1SvgPathData"]/*'/>
[Guid("C095E4F4-BB98-43D6-9745-4D1B84EC9888")]
[NativeTypeName("struct ID2D1SvgPathData : ID2D1SvgAttribute")]
[NativeInheritance("ID2D1SvgAttribute")]
public unsafe partial struct ID2D1SvgPathData : ID2D1SvgPathData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1SvgPathData));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, Guid*, void**, int> )(lpVtbl[0]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, uint> )(lpVtbl[1]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, uint> )(lpVtbl[2]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ID2D1Resource.GetFactory"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1SvgPathData*, ID2D1Factory**, void> )(lpVtbl[3]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), factory);
    }

    /// <inheritdoc cref = "ID2D1SvgAttribute.GetElement"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void GetElement(ID2D1SvgElement** element)
    {
        ((delegate* unmanaged<ID2D1SvgPathData*, ID2D1SvgElement**, void> )(lpVtbl[4]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), element);
    }

    /// <inheritdoc cref = "ID2D1SvgAttribute.Clone"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Clone(ID2D1SvgAttribute** attribute)
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, ID2D1SvgAttribute**, int> )(lpVtbl[5]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), attribute);
    }

    /// <include file='ID2D1SvgPathData.xml' path='doc/member[@name="ID2D1SvgPathData.RemoveSegmentDataAtEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveSegmentDataAtEnd([NativeTypeName("UINT32")] uint dataCount)
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, uint, int> )(lpVtbl[6]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), dataCount);
    }

    /// <include file='ID2D1SvgPathData.xml' path='doc/member[@name="ID2D1SvgPathData.UpdateSegmentData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT UpdateSegmentData([NativeTypeName("const FLOAT *")] float* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32")] uint startIndex = 0)
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, float*, uint, uint, int> )(lpVtbl[7]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), data, dataCount, startIndex);
    }

    /// <include file='ID2D1SvgPathData.xml' path='doc/member[@name="ID2D1SvgPathData.GetSegmentData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSegmentData(float* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32")] uint startIndex = 0)
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, float*, uint, uint, int> )(lpVtbl[8]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), data, dataCount, startIndex);
    }

    /// <include file='ID2D1SvgPathData.xml' path='doc/member[@name="ID2D1SvgPathData.GetSegmentDataCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [return: NativeTypeName("UINT32")]
    public uint GetSegmentDataCount()
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, uint> )(lpVtbl[9]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1SvgPathData.xml' path='doc/member[@name="ID2D1SvgPathData.RemoveCommandsAtEnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RemoveCommandsAtEnd([NativeTypeName("UINT32")] uint commandsCount)
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, uint, int> )(lpVtbl[10]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commandsCount);
    }

    /// <include file='ID2D1SvgPathData.xml' path='doc/member[@name="ID2D1SvgPathData.UpdateCommands"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT UpdateCommands([NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, D2D1_SVG_PATH_COMMAND*, uint, uint, int> )(lpVtbl[11]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commands, commandsCount, startIndex);
    }

    /// <include file='ID2D1SvgPathData.xml' path='doc/member[@name="ID2D1SvgPathData.GetCommands"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetCommands(D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("UINT32")] uint startIndex = 0)
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, D2D1_SVG_PATH_COMMAND*, uint, uint, int> )(lpVtbl[12]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), commands, commandsCount, startIndex);
    }

    /// <include file='ID2D1SvgPathData.xml' path='doc/member[@name="ID2D1SvgPathData.GetCommandsCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [return: NativeTypeName("UINT32")]
    public uint GetCommandsCount()
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, uint> )(lpVtbl[13]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1SvgPathData.xml' path='doc/member[@name="ID2D1SvgPathData.CreatePathGeometry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT CreatePathGeometry(D2D1_FILL_MODE fillMode, ID2D1PathGeometry1** pathGeometry)
    {
        return ((delegate* unmanaged<ID2D1SvgPathData*, D2D1_FILL_MODE, ID2D1PathGeometry1**, int> )(lpVtbl[14]))((ID2D1SvgPathData*)Unsafe.AsPointer(ref this), fillMode, pathGeometry);
    }

    public interface Interface : ID2D1SvgAttribute.Interface
    {
        [VtblIndex(6)]
        HRESULT RemoveSegmentDataAtEnd([NativeTypeName("UINT32")] uint dataCount);
        [VtblIndex(7)]
        HRESULT UpdateSegmentData([NativeTypeName("const FLOAT *")] float* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32")] uint startIndex = 0);
        [VtblIndex(8)]
        HRESULT GetSegmentData(float* data, [NativeTypeName("UINT32")] uint dataCount, [NativeTypeName("UINT32")] uint startIndex = 0);
        [VtblIndex(9)]
        [return: NativeTypeName("UINT32")]
        uint GetSegmentDataCount();
        [VtblIndex(10)]
        HRESULT RemoveCommandsAtEnd([NativeTypeName("UINT32")] uint commandsCount);
        [VtblIndex(11)]
        HRESULT UpdateCommands([NativeTypeName("const D2D1_SVG_PATH_COMMAND *")] D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("UINT32")] uint startIndex = 0);
        [VtblIndex(12)]
        HRESULT GetCommands(D2D1_SVG_PATH_COMMAND* commands, [NativeTypeName("UINT32")] uint commandsCount, [NativeTypeName("UINT32")] uint startIndex = 0);
        [VtblIndex(13)]
        [return: NativeTypeName("UINT32")]
        uint GetCommandsCount();
        [VtblIndex(14)]
        HRESULT CreatePathGeometry(D2D1_FILL_MODE fillMode, ID2D1PathGeometry1** pathGeometry);
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
        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Factory**, void> GetFactory;
        [NativeTypeName("void (ID2D1SvgElement **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgElement**, void> GetElement;
        [NativeTypeName("HRESULT (ID2D1SvgAttribute **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1SvgAttribute**, int> Clone;
        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveSegmentDataAtEnd;
        [NativeTypeName("HRESULT (const FLOAT *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, uint, int> UpdateSegmentData;
        [NativeTypeName("HRESULT (FLOAT *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, float*, uint, uint, int> GetSegmentData;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetSegmentDataCount;
        [NativeTypeName("HRESULT (UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RemoveCommandsAtEnd;
        [NativeTypeName("HRESULT (const D2D1_SVG_PATH_COMMAND *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_SVG_PATH_COMMAND*, uint, uint, int> UpdateCommands;
        [NativeTypeName("HRESULT (D2D1_SVG_PATH_COMMAND *, UINT32, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_SVG_PATH_COMMAND*, uint, uint, int> GetCommands;
        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetCommandsCount;
        [NativeTypeName("HRESULT (D2D1_FILL_MODE, ID2D1PathGeometry1 **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_FILL_MODE, ID2D1PathGeometry1**, int> CreatePathGeometry;
    }
}