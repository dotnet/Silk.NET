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
    [Guid("63ac0b32-ba44-450f-8806-7f4ca1ff2f1b")]
    [NativeName("Name", "ID2D1BlendTransform")]
    public unsafe partial struct ID2D1BlendTransform
    {
        public static readonly Guid Guid = new("63ac0b32-ba44-450f-8806-7f4ca1ff2f1b");

        public static implicit operator ID2D1ConcreteTransform(ID2D1BlendTransform val)
            => Unsafe.As<ID2D1BlendTransform, ID2D1ConcreteTransform>(ref val);

        public static implicit operator ID2D1TransformNode(ID2D1BlendTransform val)
            => Unsafe.As<ID2D1BlendTransform, ID2D1TransformNode>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1BlendTransform val)
            => Unsafe.As<ID2D1BlendTransform, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1BlendTransform
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
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint GetInputCount()
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, uint>)LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputBuffer(BufferPrecision bufferPrecision, ChannelDepth channelDepth)
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, BufferPrecision, ChannelDepth, int>)LpVtbl[4])(@this, bufferPrecision, channelDepth);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetCached(int isCached)
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, int, void>)LpVtbl[5])(@this, isCached);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void SetDescription(BlendDescription* description)
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, BlendDescription*, void>)LpVtbl[6])(@this, description);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetDescription(ref BlendDescription description)
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (BlendDescription* descriptionPtr = &description)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, BlendDescription*, void>)LpVtbl[6])(@this, descriptionPtr);
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetDescription(BlendDescription* description)
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, BlendDescription*, void>)LpVtbl[7])(@this, description);
        }

        /// <summary>To be documented.</summary>
        public readonly void GetDescription(ref BlendDescription description)
        {
            var @this = (ID2D1BlendTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (BlendDescription* descriptionPtr = &description)
            {
                ((delegate* unmanaged[Stdcall]<ID2D1BlendTransform*, BlendDescription*, void>)LpVtbl[7])(@this, descriptionPtr);
            }
        }

    }
}
