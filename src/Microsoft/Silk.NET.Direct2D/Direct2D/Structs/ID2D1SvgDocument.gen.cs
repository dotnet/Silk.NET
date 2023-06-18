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
    [Guid("86b88e4d-afa4-4d7b-88e4-68a51c4a0aec")]
    [NativeName("Name", "ID2D1SvgDocument")]
    public unsafe partial struct ID2D1SvgDocument : IComVtbl<ID2D1SvgDocument>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("86b88e4d-afa4-4d7b-88e4-68a51c4a0aec");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Resource(ID2D1SvgDocument val)
            => Unsafe.As<ID2D1SvgDocument, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1SvgDocument val)
            => Unsafe.As<ID2D1SvgDocument, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1SvgDocument
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
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetViewportSize(Silk.NET.Maths.Vector2D<float> viewportSize)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Maths.Vector2D<float>, int>)@this->LpVtbl[4])(@this, viewportSize);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Maths.Vector2D<float> GetViewportSize()
        {
            Silk.NET.Maths.Vector2D<float> silkDotNetReturnFixupResult;
            var pSilkDotNetReturnFixupResult = &silkDotNetReturnFixupResult;
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Maths.Vector2D<float>* ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Maths.Vector2D<float>*, Silk.NET.Maths.Vector2D<float>*>)@this->LpVtbl[5])(@this, pSilkDotNetReturnFixupResult);
            return *ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetRoot(ID2D1SvgElement* root)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement*, int>)@this->LpVtbl[6])(@this, root);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetRoot(ID2D1SvgElement** root)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, ID2D1SvgElement**, void>)@this->LpVtbl[7])(@this, root);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int FindElementById([Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ID2D1SvgElement** svgElement)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, char*, ID2D1SvgElement**, int>)@this->LpVtbl[8])(@this, id, svgElement);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Serialize(Silk.NET.Core.Win32Extras.IStream* outputXmlStream, ID2D1SvgElement* subtree)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Core.Win32Extras.IStream*, ID2D1SvgElement*, int>)@this->LpVtbl[9])(@this, outputXmlStream, subtree);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Deserialize(Silk.NET.Core.Win32Extras.IStream* inputXmlStream, ID2D1SvgElement** subtree)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Core.Win32Extras.IStream*, ID2D1SvgElement**, int>)@this->LpVtbl[10])(@this, inputXmlStream, subtree);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePaint(SvgPaintType paintType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.DXGI.D3Dcolorvalue* color, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char* id, ID2D1SvgPaint** paint)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgPaintType, Silk.NET.DXGI.D3Dcolorvalue*, char*, ID2D1SvgPaint**, int>)@this->LpVtbl[11])(@this, paintType, color, id, paint);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreateStrokeDashArray([Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgLength* dashes, uint dashesCount, ID2D1SvgStrokeDashArray** strokeDashArray)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, SvgLength*, uint, ID2D1SvgStrokeDashArray**, int>)@this->LpVtbl[12])(@this, dashes, dashesCount, strokeDashArray);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePointCollection([Flow(Silk.NET.Core.Native.FlowDirection.In)] Silk.NET.Maths.Vector2D<float>* points, uint pointsCount, ID2D1SvgPointCollection** pointCollection)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, Silk.NET.Maths.Vector2D<float>*, uint, ID2D1SvgPointCollection**, int>)@this->LpVtbl[13])(@this, points, pointsCount, pointCollection);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int CreatePathData([Flow(Silk.NET.Core.Native.FlowDirection.In)] float* segmentData, uint segmentDataCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] SvgPathCommand* commands, uint commandsCount, ID2D1SvgPathData** pathData)
        {
            var @this = (ID2D1SvgDocument*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1SvgDocument*, float*, uint, SvgPathCommand*, uint, ID2D1SvgPathData**, int>)@this->LpVtbl[14])(@this, segmentData, segmentDataCount, commands, commandsCount, pathData);
            return ret;
        }

    }
}
