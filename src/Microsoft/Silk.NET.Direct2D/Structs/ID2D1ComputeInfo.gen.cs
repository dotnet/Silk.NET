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
    [Guid("5598b14b-9fd7-48b7-9bdb-8f0964eb38bc")]
    [NativeName("Name", "ID2D1ComputeInfo")]
    public unsafe partial struct ID2D1ComputeInfo
    {
        public static readonly Guid Guid = new("5598b14b-9fd7-48b7-9bdb-8f0964eb38bc");

        public static implicit operator ID2D1RenderInfo(ID2D1ComputeInfo val)
            => Unsafe.As<ID2D1ComputeInfo, ID2D1RenderInfo>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1ComputeInfo val)
            => Unsafe.As<ID2D1ComputeInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1ComputeInfo
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
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInputDescription(uint inputIndex, InputDescription inputDescription)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, InputDescription, int>)LpVtbl[3])(@this, inputIndex, inputDescription);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputBuffer(BufferPrecision bufferPrecision, ChannelDepth channelDepth)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, BufferPrecision, ChannelDepth, int>)LpVtbl[4])(@this, bufferPrecision, channelDepth);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetCached(int isCached)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, int, void>)LpVtbl[5])(@this, isCached);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetInstructionCountHint(uint instructionCount)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, void>)LpVtbl[6])(@this, instructionCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetComputeShaderConstantBuffer(byte* buffer, uint bufferCount)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, byte*, uint, int>)LpVtbl[7])(@this, buffer, bufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetComputeShaderConstantBuffer(ref byte buffer, uint bufferCount)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, byte*, uint, int>)LpVtbl[7])(@this, bufferPtr, bufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetComputeShaderConstantBuffer([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer, uint bufferCount)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bufferPtr = (byte*) SilkMarshal.StringToPtr(buffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, byte*, uint, int>)LpVtbl[7])(@this, bufferPtr, bufferCount);
            SilkMarshal.Free((nint)bufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetComputeShader(Guid* shaderId)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, int>)LpVtbl[8])(@this, shaderId);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetComputeShader(ref Guid shaderId)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* shaderIdPtr = &shaderId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, Guid*, int>)LpVtbl[8])(@this, shaderIdPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetResourceTexture(uint textureIndex, ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, ID2D1ResourceTexture*, int>)LpVtbl[9])(@this, textureIndex, resourceTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetResourceTexture(uint textureIndex, ref ID2D1ResourceTexture resourceTexture)
        {
            var @this = (ID2D1ComputeInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ResourceTexture* resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1ComputeInfo*, uint, ID2D1ResourceTexture*, int>)LpVtbl[9])(@this, textureIndex, resourceTexturePtr);
            }
            return ret;
        }

    }
}
