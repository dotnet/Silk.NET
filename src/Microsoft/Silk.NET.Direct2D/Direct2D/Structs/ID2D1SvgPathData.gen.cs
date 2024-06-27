// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct2D
{
    [Guid("c095e4f4-bb98-43d6-9745-4d1b84ec9888")]
    [NativeName("Name", "ID2D1SvgPathData")]
    public unsafe partial struct ID2D1SvgPathData : IComVtbl<ID2D1SvgPathData>, IComVtbl<ID2D1SvgAttribute>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c095e4f4-bb98-43d6-9745-4d1b84ec9888");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1SvgAttribute(ID2D1SvgPathData val)
            => Unsafe.As<ID2D1SvgPathData, ID2D1SvgAttribute>(ref val);

        public static implicit operator ID2D1Resource(ID2D1SvgPathData val)
            => Unsafe.As<ID2D1SvgPathData, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SvgPathData val)
            => Unsafe.As<ID2D1SvgPathData, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SvgPathData
        (
            void** lpVtbl = null
        ) : this()
        {
            if (lpVtbl is not null)
            {
                LpVtbl = lpVtbl;
            }
        }


        [NativeName("Type", "")]
        [NativeName("Type.Name", "")]
        [NativeName("Name", "lpVtbl")]
        public void** LpVtbl;
        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ID2D1SvgElement** element)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, element);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ref ID2D1SvgElement* element)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** elementPtr = &element)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgElement**, void>)@this->LpVtbl[4])(@this, elementPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ID2D1SvgAttribute** attribute)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attribute);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ref ID2D1SvgAttribute* attribute)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgAttribute** attributePtr = &attribute)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgAttribute**, int>)@this->LpVtbl[5])(@this, attributePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveSegmentDataAtEnd(uint dataCount)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint, int>)@this->LpVtbl[6])(@this, dataCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSegmentData([Flow(Silk.NET.Core.Native.FlowDirection.In)] float* data, uint dataCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)@this->LpVtbl[7])(@this, data, dataCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateSegmentData([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float data, uint dataCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)@this->LpVtbl[7])(@this, dataPtr, dataCount, startIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSegmentData(float* data, uint dataCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)@this->LpVtbl[8])(@this, data, dataCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSegmentData(ref float data, uint dataCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)@this->LpVtbl[8])(@this, dataPtr, dataCount, startIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetSegmentDataCount()
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveCommandsAtEnd(uint commandsCount)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint, int>)@this->LpVtbl[10])(@this, commandsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgPathCommand* commands, uint commandsCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)@this->LpVtbl[11])(@this, commands, commandsCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateCommands([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in SvgPathCommand commands, uint commandsCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SvgPathCommand* commandsPtr = &commands)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)@this->LpVtbl[11])(@this, commandsPtr, commandsCount, startIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCommands(SvgPathCommand* commands, uint commandsCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)@this->LpVtbl[12])(@this, commands, commandsCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCommands(ref SvgPathCommand commands, uint commandsCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SvgPathCommand* commandsPtr = &commands)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)@this->LpVtbl[12])(@this, commandsPtr, commandsCount, startIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetCommandsCount()
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathGeometry(FillMode fillMode, ID2D1PathGeometry1** pathGeometry)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, FillMode, ID2D1PathGeometry1**, int>)@this->LpVtbl[14])(@this, fillMode, pathGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathGeometry(FillMode fillMode, ref ID2D1PathGeometry1* pathGeometry)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1PathGeometry1** pathGeometryPtr = &pathGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, FillMode, ID2D1PathGeometry1**, int>)@this->LpVtbl[14])(@this, fillMode, pathGeometryPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFactory<TI0>(ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetElement<TI0>(ref ComPtr<TI0> element) where TI0 : unmanaged, IComVtbl<ID2D1SvgElement>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetElement((ID2D1SvgElement**) element.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int Clone<TI0>(ref ComPtr<TI0> attribute) where TI0 : unmanaged, IComVtbl<ID2D1SvgAttribute>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->Clone((ID2D1SvgAttribute**) attribute.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int CreatePathGeometry<TI0>(FillMode fillMode, ref ComPtr<TI0> pathGeometry) where TI0 : unmanaged, IComVtbl<ID2D1PathGeometry1>, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->CreatePathGeometry(fillMode, (ID2D1PathGeometry1**) pathGeometry.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
