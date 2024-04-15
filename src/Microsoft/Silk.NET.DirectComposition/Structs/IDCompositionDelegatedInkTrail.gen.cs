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

namespace Silk.NET.DirectComposition
{
    [Guid("c2448e9b-547d-4057-8cf5-8144ede1c2da")]
    [NativeName("Name", "IDCompositionDelegatedInkTrail")]
    public unsafe partial struct IDCompositionDelegatedInkTrail : IComVtbl<IDCompositionDelegatedInkTrail>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("c2448e9b-547d-4057-8cf5-8144ede1c2da");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDCompositionDelegatedInkTrail val)
            => Unsafe.As<IDCompositionDelegatedInkTrail, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDCompositionDelegatedInkTrail
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
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrailPoints([Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, uint* generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[3])(@this, inkPoints, inkPointsCount, generationId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrailPoints([Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, ref uint generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* generationIdPtr = &generationId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[3])(@this, inkPoints, inkPointsCount, generationIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrailPoints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, uint* generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[3])(@this, inkPointsPtr, inkPointsCount, generationId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddTrailPoints([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, ref uint generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
            {
                fixed (uint* generationIdPtr = &generationId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[3])(@this, inkPointsPtr, inkPointsCount, generationIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrailPointsWithPrediction([Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPoints, inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrailPointsWithPrediction([Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, ref uint generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (uint* generationIdPtr = &generationId)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPoints, inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrailPointsWithPrediction([Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkTrailPoint* predictedInkPointsPtr = &predictedInkPoints)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPoints, inkPointsCount, predictedInkPointsPtr, predictedInkPointsCount, generationId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrailPointsWithPrediction([Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint predictedInkPoints, uint predictedInkPointsCount, ref uint generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkTrailPoint* predictedInkPointsPtr = &predictedInkPoints)
            {
                fixed (uint* generationIdPtr = &generationId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPoints, inkPointsCount, predictedInkPointsPtr, predictedInkPointsCount, generationIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrailPointsWithPrediction([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPointsPtr, inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationId);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrailPointsWithPrediction([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] InkTrailPoint* predictedInkPoints, uint predictedInkPointsCount, ref uint generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
            {
                fixed (uint* generationIdPtr = &generationId)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPointsPtr, inkPointsCount, predictedInkPoints, predictedInkPointsCount, generationIdPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AddTrailPointsWithPrediction([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint predictedInkPoints, uint predictedInkPointsCount, uint* generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
            {
                fixed (InkTrailPoint* predictedInkPointsPtr = &predictedInkPoints)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPointsPtr, inkPointsCount, predictedInkPointsPtr, predictedInkPointsCount, generationId);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AddTrailPointsWithPrediction([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint inkPoints, uint inkPointsCount, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in InkTrailPoint predictedInkPoints, uint predictedInkPointsCount, ref uint generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (InkTrailPoint* inkPointsPtr = &inkPoints)
            {
                fixed (InkTrailPoint* predictedInkPointsPtr = &predictedInkPoints)
                {
                    fixed (uint* generationIdPtr = &generationId)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, InkTrailPoint*, uint, InkTrailPoint*, uint, uint*, int>)@this->LpVtbl[4])(@this, inkPointsPtr, inkPointsCount, predictedInkPointsPtr, predictedInkPointsCount, generationIdPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int RemoveTrailPoints(uint generationId)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, uint, int>)@this->LpVtbl[5])(@this, generationId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int StartNewTrail(Silk.NET.DXGI.D3Dcolorvalue* color)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[6])(@this, color);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int StartNewTrail(ref Silk.NET.DXGI.D3Dcolorvalue color)
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Silk.NET.DXGI.D3Dcolorvalue* colorPtr = &color)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDCompositionDelegatedInkTrail*, Silk.NET.DXGI.D3Dcolorvalue*, int>)@this->LpVtbl[6])(@this, colorPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDCompositionDelegatedInkTrail*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
