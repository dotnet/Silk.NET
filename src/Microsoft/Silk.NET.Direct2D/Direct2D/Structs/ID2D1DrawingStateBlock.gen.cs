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
    [Guid("28506e39-ebf6-46a1-bb47-fd85565ab957")]
    [NativeName("Name", "ID2D1DrawingStateBlock")]
    public unsafe partial struct ID2D1DrawingStateBlock : IComVtbl<ID2D1DrawingStateBlock>, IComVtbl<ID2D1Resource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("28506e39-ebf6-46a1-bb47-fd85565ab957");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1Resource(ID2D1DrawingStateBlock val)
            => Unsafe.As<ID2D1DrawingStateBlock, ID2D1Resource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1DrawingStateBlock val)
            => Unsafe.As<ID2D1DrawingStateBlock, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1DrawingStateBlock
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
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ID2D1Factory** factory)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factory);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetFactory(ref ID2D1Factory* factory)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (ID2D1Factory** factoryPtr = &factory)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, ID2D1Factory**, void>)@this->LpVtbl[3])(@this, factoryPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDescription(DrawingStateDescription* stateDescription)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, DrawingStateDescription*, void>)@this->LpVtbl[4])(@this, stateDescription);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDescription(ref DrawingStateDescription stateDescription)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DrawingStateDescription* stateDescriptionPtr = &stateDescription)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, DrawingStateDescription*, void>)@this->LpVtbl[4])(@this, stateDescriptionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDescription([Flow(Silk.NET.Core.Native.FlowDirection.In)] DrawingStateDescription* stateDescription)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, DrawingStateDescription*, void>)@this->LpVtbl[5])(@this, stateDescription);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDescription([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in DrawingStateDescription stateDescription)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (DrawingStateDescription* stateDescriptionPtr = &stateDescription)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, DrawingStateDescription*, void>)@this->LpVtbl[5])(@this, stateDescriptionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetTextRenderingParams(IDWriteRenderingParams* textRenderingParams)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, IDWriteRenderingParams*, void>)@this->LpVtbl[6])(@this, textRenderingParams);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTextRenderingParams(IDWriteRenderingParams** textRenderingParams)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, IDWriteRenderingParams**, void>)@this->LpVtbl[7])(@this, textRenderingParams);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetTextRenderingParams(ref IDWriteRenderingParams* textRenderingParams)
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (IDWriteRenderingParams** textRenderingParamsPtr = &textRenderingParams)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1DrawingStateBlock*, IDWriteRenderingParams**, void>)@this->LpVtbl[7])(@this, textRenderingParamsPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly void GetFactory<TI0>(ref ComPtr<TI0> factory) where TI0 : unmanaged, IComVtbl<ID2D1Factory>, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            @this->GetFactory((ID2D1Factory**) factory.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawingStateBlock*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
