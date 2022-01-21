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

namespace Silk.NET.XAudio
{
    [Guid("84ac29bb-d619-44d2-b197-e4acf7df3ed6")]
    [NativeName("Name", "IXAudio2Extension")]
    public unsafe partial struct IXAudio2Extension
    {
        public static readonly Guid Guid = new("84ac29bb-d619-44d2-b197-e4acf7df3ed6");

        public static implicit operator Silk.NET.Core.Native.IUnknown(IXAudio2Extension val)
            => Unsafe.As<IXAudio2Extension, Silk.NET.Core.Native.IUnknown>(ref val);

        public IXAudio2Extension
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
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            #if NET5_0_OR_GREATER
            ret = ((delegate* unmanaged<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            else
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            }
            #endif
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
            #if NET5_0_OR_GREATER
                ret = ((delegate* unmanaged<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
                else
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
                }
            #endif
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
            #if NET5_0_OR_GREATER
                    ret = ((delegate* unmanaged<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
                    else
                    {
                        ret = ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                    }
            #endif
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetProcessingQuantum(uint* quantumNumerator, uint* quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumerator, quantumDenominator);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumerator, quantumDenominator);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumerator, quantumDenominator);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetProcessingQuantum(uint* quantumNumerator, ref uint quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* quantumDenominatorPtr = &quantumDenominator)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumerator, quantumDenominatorPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumerator, quantumDenominatorPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumerator, quantumDenominatorPtr);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetProcessingQuantum(ref uint quantumNumerator, uint* quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* quantumNumeratorPtr = &quantumNumerator)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominator);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominator);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominator);
                }
            #endif
            }
        }

        /// <summary>To be documented.</summary>
        public readonly void GetProcessingQuantum(ref uint quantumNumerator, ref uint quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* quantumNumeratorPtr = &quantumNumerator)
            {
                fixed (uint* quantumDenominatorPtr = &quantumDenominator)
                {
            #if NET5_0_OR_GREATER
                    ((delegate* unmanaged<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominatorPtr);
            #else
                    if (SilkMarshal.IsWinapiStdcall)
                    {
                        ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominatorPtr);
                    }
                    else
                    {
                        ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominatorPtr);
                    }
            #endif
                }
            }
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe void GetProcessor(uint* processor)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            #if NET5_0_OR_GREATER
            ((delegate* unmanaged<IXAudio2Extension*, uint*, void>)LpVtbl[4])(@this, processor);
            #else
            if (SilkMarshal.IsWinapiStdcall)
            {
                ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, void>)LpVtbl[4])(@this, processor);
            }
            else
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, void>)LpVtbl[4])(@this, processor);
            }
            #endif
        }

        /// <summary>To be documented.</summary>
        public readonly void GetProcessor(ref uint processor)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* processorPtr = &processor)
            {
            #if NET5_0_OR_GREATER
                ((delegate* unmanaged<IXAudio2Extension*, uint*, void>)LpVtbl[4])(@this, processorPtr);
            #else
                if (SilkMarshal.IsWinapiStdcall)
                {
                    ((delegate* unmanaged[Stdcall]<IXAudio2Extension*, uint*, void>)LpVtbl[4])(@this, processorPtr);
                }
                else
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, void>)LpVtbl[4])(@this, processorPtr);
                }
            #endif
            }
        }

    }
}
