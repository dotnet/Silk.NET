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

namespace Silk.NET.MediaFoundation
{
    [Guid("e2cd3a4b-af25-4d3d-9110-da0e6f8ee877")]
    [NativeName("Name", "IMFSourceBuffer")]
    public unsafe partial struct IMFSourceBuffer : IComVtbl<IMFSourceBuffer>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("e2cd3a4b-af25-4d3d-9110-da0e6f8ee877");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IMFSourceBuffer val)
            => Unsafe.As<IMFSourceBuffer, Silk.NET.Core.Native.IUnknown>(ref val);

        public IMFSourceBuffer
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
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly Silk.NET.Core.Bool32 GetUpdating()
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            Silk.NET.Core.Bool32 ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, Silk.NET.Core.Bool32>)@this->LpVtbl[3])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffered(IMFMediaTimeRange** ppBuffered)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppBuffered);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetBuffered(ref IMFMediaTimeRange* ppBuffered)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFMediaTimeRange** ppBufferedPtr = &ppBuffered)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFMediaTimeRange**, int>)@this->LpVtbl[4])(@this, ppBufferedPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetTimeStampOffset()
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetTimeStampOffset(double offset)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double, int>)@this->LpVtbl[6])(@this, offset);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetAppendWindowStart()
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double>)@this->LpVtbl[7])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAppendWindowStart(double time)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double, int>)@this->LpVtbl[8])(@this, time);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly double GetAppendWindowEnd()
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            double ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double>)@this->LpVtbl[9])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetAppendWindowEnd(double time)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double, int>)@this->LpVtbl[10])(@this, time);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int Append([Flow(Silk.NET.Core.Native.FlowDirection.In)] byte* pData, uint len)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, byte*, uint, int>)@this->LpVtbl[11])(@this, pData, len);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Append([Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in byte pData, uint len)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* pDataPtr = &pData)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, byte*, uint, int>)@this->LpVtbl[11])(@this, pDataPtr, len);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Append([Flow(Silk.NET.Core.Native.FlowDirection.In), UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string pData, uint len)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var pDataPtr = (byte*) SilkMarshal.StringToPtr(pData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, byte*, uint, int>)@this->LpVtbl[11])(@this, pDataPtr, len);
            SilkMarshal.Free((nint)pDataPtr);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AppendByteStream(IMFByteStream* pStream, ulong* pMaxLen)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFByteStream*, ulong*, int>)@this->LpVtbl[12])(@this, pStream, pMaxLen);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AppendByteStream(IMFByteStream* pStream, ref ulong pMaxLen)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ulong* pMaxLenPtr = &pMaxLen)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFByteStream*, ulong*, int>)@this->LpVtbl[12])(@this, pStream, pMaxLenPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int AppendByteStream(ref IMFByteStream pStream, ulong* pMaxLen)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pStreamPtr = &pStream)
            {
                ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFByteStream*, ulong*, int>)@this->LpVtbl[12])(@this, pStreamPtr, pMaxLen);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int AppendByteStream(ref IMFByteStream pStream, ref ulong pMaxLen)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IMFByteStream* pStreamPtr = &pStream)
            {
                fixed (ulong* pMaxLenPtr = &pMaxLen)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, IMFByteStream*, ulong*, int>)@this->LpVtbl[12])(@this, pStreamPtr, pMaxLenPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Abort()
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, int>)@this->LpVtbl[13])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int Remove(double start, double end)
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IMFSourceBuffer*, double, double, int>)@this->LpVtbl[14])(@this, start, end);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int GetBuffered<TI0>(ref ComPtr<TI0> ppBuffered) where TI0 : unmanaged, IComVtbl<IMFMediaTimeRange>, IComVtbl<TI0>
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->GetBuffered((IMFMediaTimeRange**) ppBuffered.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IMFSourceBuffer*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
