// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, void** ppvObject)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, Guid*, void**, int>)LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint AddRef()
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint>)LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly uint Release()
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
                uint ret = default;
            ret = ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint>)LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetProcessingQuantum(uint* quantumNumerator, uint* quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumerator, quantumDenominator);
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetProcessingQuantum(uint* quantumNumerator, ref uint quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* quantumDenominatorPtr = &quantumDenominator)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumerator, quantumDenominatorPtr);
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetProcessingQuantum(ref uint quantumNumerator, uint* quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* quantumNumeratorPtr = &quantumNumerator)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominator);
            }
        }

        /// <summary>To be added.</summary>
        public readonly void GetProcessingQuantum(ref uint quantumNumerator, ref uint quantumDenominator)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* quantumNumeratorPtr = &quantumNumerator)
            {
                fixed (uint* quantumDenominatorPtr = &quantumDenominator)
                {
                    ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, uint*, void>)LpVtbl[3])(@this, quantumNumeratorPtr, quantumDenominatorPtr);
                }
            }
        }

        /// <summary>To be added.</summary>
        public readonly unsafe void GetProcessor(uint* processor)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, void>)LpVtbl[4])(@this, processor);
        }

        /// <summary>To be added.</summary>
        public readonly void GetProcessor(ref uint processor)
        {
            var @this = (IXAudio2Extension*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            fixed (uint* processorPtr = &processor)
            {
                ((delegate* unmanaged[Cdecl]<IXAudio2Extension*, uint*, void>)LpVtbl[4])(@this, processorPtr);
            }
        }

    }
}
