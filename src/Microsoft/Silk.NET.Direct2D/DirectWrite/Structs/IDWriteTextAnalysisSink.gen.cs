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

namespace Silk.NET.DirectWrite
{
    [Guid("5810cd44-0ca0-4701-b3fa-bec5182ae4f6")]
    [NativeName("Name", "IDWriteTextAnalysisSink")]
    public unsafe partial struct IDWriteTextAnalysisSink : IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("5810cd44-0ca0-4701-b3fa-bec5182ae4f6");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextAnalysisSink val)
            => Unsafe.As<IDWriteTextAnalysisSink, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextAnalysisSink
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
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(Guid* riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, void** ppvObject)
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int QueryInterface(ref Guid riid, ref void* ppvObject)
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (Guid* riidPtr = &riid)
            {
                fixed (void** ppvObjectPtr = &ppvObject)
                {
                    ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
                }
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetScriptAnalysis(uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis)
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, ScriptAnalysis*, int>)@this->LpVtbl[3])(@this, textPosition, textLength, scriptAnalysis);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetScriptAnalysis(uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in ScriptAnalysis scriptAnalysis)
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (ScriptAnalysis* scriptAnalysisPtr = &scriptAnalysis)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, ScriptAnalysis*, int>)@this->LpVtbl[3])(@this, textPosition, textLength, scriptAnalysisPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetLineBreakpoints(uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LineBreakpoint* lineBreakpoints)
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, LineBreakpoint*, int>)@this->LpVtbl[4])(@this, textPosition, textLength, lineBreakpoints);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetLineBreakpoints(uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in LineBreakpoint lineBreakpoints)
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (LineBreakpoint* lineBreakpointsPtr = &lineBreakpoints)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, LineBreakpoint*, int>)@this->LpVtbl[4])(@this, textPosition, textLength, lineBreakpointsPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBidiLevel(uint textPosition, uint textLength, byte explicitLevel, byte resolvedLevel)
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, byte, byte, int>)@this->LpVtbl[5])(@this, textPosition, textLength, explicitLevel, resolvedLevel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetNumberSubstitution(uint textPosition, uint textLength, IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, IDWriteNumberSubstitution*, int>)@this->LpVtbl[6])(@this, textPosition, textLength, numberSubstitution);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetNumberSubstitution(uint textPosition, uint textLength, ref IDWriteNumberSubstitution numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            fixed (IDWriteNumberSubstitution* numberSubstitutionPtr = &numberSubstitution)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink*, uint, uint, IDWriteNumberSubstitution*, int>)@this->LpVtbl[6])(@this, textPosition, textLength, numberSubstitutionPtr);
            }
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int QueryInterface<TI0>(out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            ppvObject = default;
            return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
        }

        /// <summary>To be documented.</summary>
        public readonly int SetNumberSubstitution<TI0>(uint textPosition, uint textLength, ComPtr<TI0> numberSubstitution) where TI0 : unmanaged, IComVtbl<IDWriteNumberSubstitution>, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // ComPtrOverloader
            return @this->SetNumberSubstitution(textPosition, textLength, (IDWriteNumberSubstitution*) numberSubstitution.Handle);
        }

        /// <summary>To be documented.</summary>
        public readonly ComPtr<TI0> QueryInterface<TI0>() where TI0 : unmanaged, IComVtbl<TI0>
        {
            var @this = (IDWriteTextAnalysisSink*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            // NonKhrReturnTypeOverloader
            SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
            return silkRet;
        }

    }
}
