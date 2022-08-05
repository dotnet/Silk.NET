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
    public unsafe partial struct ID2D1SvgPathData
    {
        public static readonly Guid Guid = new("c095e4f4-bb98-43d6-9745-4d1b84ec9888");

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
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
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
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
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
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1Factory**, void>)LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1Factory**, void>)LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ID2D1SvgElement** element)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgElement**, void>)LpVtbl[4])(@this, element);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetElement(ref ID2D1SvgElement* element)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1SvgElement** elementPtr = &element)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgElement**, void>)LpVtbl[4])(@this, elementPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ID2D1SvgAttribute** attribute)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgAttribute**, int>)LpVtbl[5])(@this, attribute);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Clone(ref ID2D1SvgAttribute* attribute)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1SvgAttribute** attributePtr = &attribute)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, ID2D1SvgAttribute**, int>)LpVtbl[5])(@this, attributePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveSegmentDataAtEnd(uint dataCount)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint, int>)LpVtbl[6])(@this, dataCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateSegmentData(float* data, uint dataCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)LpVtbl[7])(@this, data, dataCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateSegmentData(ref float data, uint dataCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)LpVtbl[7])(@this, dataPtr, dataCount, startIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetSegmentData(float* data, uint dataCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)LpVtbl[8])(@this, data, dataCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetSegmentData(ref float data, uint dataCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (float* dataPtr = &data)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, float*, uint, uint, int>)LpVtbl[8])(@this, dataPtr, dataCount, startIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetSegmentDataCount()
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveCommandsAtEnd(uint commandsCount)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint, int>)LpVtbl[10])(@this, commandsCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int UpdateCommands(SvgPathCommand* commands, uint commandsCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)LpVtbl[11])(@this, commands, commandsCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int UpdateCommands(ref SvgPathCommand commands, uint commandsCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SvgPathCommand* commandsPtr = &commands)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)LpVtbl[11])(@this, commandsPtr, commandsCount, startIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetCommands(SvgPathCommand* commands, uint commandsCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)LpVtbl[12])(@this, commands, commandsCount, startIndex);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int GetCommands(ref SvgPathCommand commands, uint commandsCount, uint startIndex)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (SvgPathCommand* commandsPtr = &commands)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, SvgPathCommand*, uint, uint, int>)LpVtbl[12])(@this, commandsPtr, commandsCount, startIndex);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetCommandsCount()
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, uint>)LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathGeometry(FillMode fillMode, ID2D1PathGeometry1** pathGeometry)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, FillMode, ID2D1PathGeometry1**, int>)LpVtbl[14])(@this, fillMode, pathGeometry);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathGeometry(FillMode fillMode, ref ID2D1PathGeometry1* pathGeometry)
        {
            var @this = (ID2D1SvgPathData*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1PathGeometry1** pathGeometryPtr = &pathGeometry)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgPathData*, FillMode, ID2D1PathGeometry1**, int>)LpVtbl[14])(@this, fillMode, pathGeometryPtr);
            }
            return ret;
        }

    }
}
