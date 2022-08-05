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
    [Guid("0359dc30-95e6-4568-9055-27720d130e93")]
    [NativeName("Name", "ID2D1AnalysisTransform")]
    public unsafe partial struct ID2D1AnalysisTransform
    {
        public static readonly Guid Guid = new("0359dc30-95e6-4568-9055-27720d130e93");

        public static implicit operator Silk.NET.Core.Native.IUnknown(ID2D1AnalysisTransform val)
            => Unsafe.As<ID2D1AnalysisTransform, Silk.NET.Core.Native.IUnknown>(ref val);

        public ID2D1AnalysisTransform
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
            var @this = (ID2D1AnalysisTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1AnalysisTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (ID2D1AnalysisTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1AnalysisTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (ID2D1AnalysisTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1AnalysisTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (ID2D1AnalysisTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<ID2D1AnalysisTransform*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (ID2D1AnalysisTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1AnalysisTransform*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (ID2D1AnalysisTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1AnalysisTransform*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int ProcessAnalysisResults(byte* analysisData, uint analysisDataCount)
        {
            var @this = (ID2D1AnalysisTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<ID2D1AnalysisTransform*, byte*, uint, int>)LpVtbl[3])(@this, analysisData, analysisDataCount);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ProcessAnalysisResults(ref byte analysisData, uint analysisDataCount)
        {
            var @this = (ID2D1AnalysisTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (byte* analysisDataPtr = &analysisData)
            {
                ret = ((delegate* unmanaged[Stdcall]<ID2D1AnalysisTransform*, byte*, uint, int>)LpVtbl[3])(@this, analysisDataPtr, analysisDataCount);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int ProcessAnalysisResults([UnmanagedType(Silk.NET.Core.Native.UnmanagedType.LPUTF8Str)] string analysisData, uint analysisDataCount)
        {
            var @this = (ID2D1AnalysisTransform*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            var analysisDataPtr = (byte*) SilkMarshal.StringToPtr(analysisData, NativeStringEncoding.UTF8);
            ret = ((delegate* unmanaged[Stdcall]<ID2D1AnalysisTransform*, byte*, uint, int>)LpVtbl[3])(@this, analysisDataPtr, analysisDataCount);
            SilkMarshal.Free((nint)analysisDataPtr);
            return ret;
        }

    }
}
