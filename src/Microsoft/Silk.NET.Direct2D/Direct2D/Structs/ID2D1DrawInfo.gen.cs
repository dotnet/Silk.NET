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
    [Guid("693ce632-7f2f-45de-93fe-18d88b37aa21")]
    [NativeName("Name", "ID2D1DrawInfo")]
    public unsafe partial struct ID2D1DrawInfo : IComVtbl<ID2D1DrawInfo>, IComVtbl<ID2D1RenderInfo>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("693ce632-7f2f-45de-93fe-18d88b37aa21");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator ID2D1RenderInfo(ID2D1DrawInfo val)
            => Unsafe.As<ID2D1DrawInfo, ID2D1RenderInfo>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1DrawInfo val)
            => Unsafe.As<ID2D1DrawInfo, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1DrawInfo
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
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetInputDescription(uint inputIndex, InputDescription inputDescription)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint, InputDescription, int>)@this->LpVtbl[3])(@this, inputIndex, inputDescription);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetOutputBuffer(BufferPrecision bufferPrecision, ChannelDepth channelDepth)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, BufferPrecision, ChannelDepth, int>)@this->LpVtbl[4])(@this, bufferPrecision, channelDepth);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly void SetCached(Silk.NET.Core.Bool32 isCached)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Silk.NET.Core.Bool32, void>)@this->LpVtbl[5])(@this, isCached);
        }

        /// <summary>To be documented.</summary>
        public readonly void SetInstructionCountHint(uint instructionCount)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint, void>)@this->LpVtbl[6])(@this, instructionCount);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPixelShaderConstantBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buffer, uint bufferCount)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[7])(@this, buffer, bufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShaderConstantBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte buffer, uint bufferCount)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[7])(@this, bufferPtr, bufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShaderConstantBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer, uint bufferCount)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bufferPtr = (byte*) SilkMarshal.StringToPtr(buffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[7])(@this, bufferPtr, bufferCount);
            SilkMarshal.Free((nint)bufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetResourceTexture(uint textureIndex, ID2D1ResourceTexture* resourceTexture)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint, ID2D1ResourceTexture*, int>)@this->LpVtbl[8])(@this, textureIndex, resourceTexture);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetResourceTexture(uint textureIndex, ref ID2D1ResourceTexture resourceTexture)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1ResourceTexture* resourceTexturePtr = &resourceTexture)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, uint, ID2D1ResourceTexture*, int>)@this->LpVtbl[8])(@this, textureIndex, resourceTexturePtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexShaderConstantBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* buffer, uint bufferCount)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[9])(@this, buffer, bufferCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexShaderConstantBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte buffer, uint bufferCount)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* bufferPtr = &buffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[9])(@this, bufferPtr, bufferCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexShaderConstantBuffer([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string buffer, uint bufferCount)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var bufferPtr = (byte*) SilkMarshal.StringToPtr(buffer, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, byte*, uint, int>)@this->LpVtbl[9])(@this, bufferPtr, bufferCount);
            SilkMarshal.Free((nint)bufferPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetPixelShader(Guid* shaderId, PixelOptions pixelOptions)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, PixelOptions, int>)@this->LpVtbl[10])(@this, shaderId, pixelOptions);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetPixelShader(ref Guid shaderId, PixelOptions pixelOptions)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* shaderIdPtr = &shaderId)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, Guid*, PixelOptions, int>)@this->LpVtbl[10])(@this, shaderIdPtr, pixelOptions);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescription, vertexRange, vertexShader);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* vertexShaderPtr = &vertexShader)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescription, vertexRange, vertexShaderPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexRange* vertexRangePtr = &vertexRange)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescription, vertexRangePtr, vertexShader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (VertexRange* vertexRangePtr = &vertexRange)
            {
                fixed (Guid* vertexShaderPtr = &vertexShader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescription, vertexRangePtr, vertexShaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescriptionPtr, vertexRange, vertexShader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                fixed (Guid* vertexShaderPtr = &vertexShader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescriptionPtr, vertexRange, vertexShaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                fixed (VertexRange* vertexRangePtr = &vertexRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescriptionPtr, vertexRangePtr, vertexShader);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ID2D1VertexBuffer* vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
            {
                fixed (VertexRange* vertexRangePtr = &vertexRange)
                {
                    fixed (Guid* vertexShaderPtr = &vertexShader)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBuffer, vertexOptions, blendDescriptionPtr, vertexRangePtr, vertexShaderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescription, vertexRange, vertexShader);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
            {
                fixed (Guid* vertexShaderPtr = &vertexShader)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescription, vertexRange, vertexShaderPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
            {
                fixed (VertexRange* vertexRangePtr = &vertexRange)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescription, vertexRangePtr, vertexShader);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
            {
                fixed (VertexRange* vertexRangePtr = &vertexRange)
                {
                    fixed (Guid* vertexShaderPtr = &vertexShader)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescription, vertexRangePtr, vertexShaderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
            {
                fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescriptionPtr, vertexRange, vertexShader);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
            {
                fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
                {
                    fixed (Guid* vertexShaderPtr = &vertexShader)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescriptionPtr, vertexRange, vertexShaderPtr);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing(ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
            {
                fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
                {
                    fixed (VertexRange* vertexRangePtr = &vertexRange)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescriptionPtr, vertexRangePtr, vertexShader);
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexProcessing(ref ID2D1VertexBuffer vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader)
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ID2D1VertexBuffer* vertexBufferPtr = &vertexBuffer)
            {
                fixed (BlendDescription* blendDescriptionPtr = &blendDescription)
                {
                    fixed (VertexRange* vertexRangePtr = &vertexRange)
                    {
                        fixed (Guid* vertexShaderPtr = &vertexShader)
                        {
                            ret = ((delegate* unmanaged[Stdcall]<ID2D1DrawInfo*, ID2D1VertexBuffer*, VertexOptions, BlendDescription*, VertexRange*, Guid*, int>)@this->LpVtbl[11])(@this, vertexBufferPtr, vertexOptions, blendDescriptionPtr, vertexRangePtr, vertexShaderPtr);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetResourceTexture<TI0>(uint textureIndex, ComPtr<TI0> resourceTexture) where TI0 : unmanaged, IComVtbl<ID2D1ResourceTexture>, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetResourceTexture(textureIndex, (ID2D1ResourceTexture*) resourceTexture.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing<TI0>(ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, blendDescription, vertexRange, vertexShader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing<TI0>(ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, blendDescription, vertexRange, in vertexShader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing<TI0>(ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, blendDescription, in vertexRange, vertexShader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing<TI0>(ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] BlendDescription* blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, blendDescription, in vertexRange, in vertexShader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing<TI0>(ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, in blendDescription, vertexRange, vertexShader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing<TI0>(ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] VertexRange* vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, in blendDescription, vertexRange, in vertexShader);
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetVertexProcessing<TI0>(ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] Guid* vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, in blendDescription, in vertexRange, vertexShader);
        }

        /// <summary>To be documented.</summary>
        public readonly int SetVertexProcessing<TI0>(ComPtr<TI0> vertexBuffer, VertexOptions vertexOptions, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in BlendDescription blendDescription, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in VertexRange vertexRange, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in Guid vertexShader) where TI0 : unmanaged, IComVtbl<ID2D1VertexBuffer>, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetVertexProcessing((ID2D1VertexBuffer*) vertexBuffer.Handle, vertexOptions, in blendDescription, in vertexRange, in vertexShader);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (ID2D1DrawInfo*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
