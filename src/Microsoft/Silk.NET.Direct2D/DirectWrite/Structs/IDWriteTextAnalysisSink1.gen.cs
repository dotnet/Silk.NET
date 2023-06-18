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
    [Guid("b0d941a0-85e7-4d8b-9fd3-5ced9934482a")]
    [NativeName("Name", "IDWriteTextAnalysisSink1")]
    public unsafe partial struct IDWriteTextAnalysisSink1 : IComVtbl<IDWriteTextAnalysisSink1>, IComVtbl<IDWriteTextAnalysisSink>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("b0d941a0-85e7-4d8b-9fd3-5ced9934482a");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteTextAnalysisSink(IDWriteTextAnalysisSink1 val)
            => Unsafe.As<IDWriteTextAnalysisSink1, IDWriteTextAnalysisSink>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextAnalysisSink1 val)
            => Unsafe.As<IDWriteTextAnalysisSink1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextAnalysisSink1
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
            var @this = (IDWriteTextAnalysisSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextAnalysisSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextAnalysisSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetScriptAnalysis(uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] ScriptAnalysis* scriptAnalysis)
        {
            var @this = (IDWriteTextAnalysisSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, ScriptAnalysis*, int>)@this->LpVtbl[3])(@this, textPosition, textLength, scriptAnalysis);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetLineBreakpoints(uint textPosition, uint textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] LineBreakpoint* lineBreakpoints)
        {
            var @this = (IDWriteTextAnalysisSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, LineBreakpoint*, int>)@this->LpVtbl[4])(@this, textPosition, textLength, lineBreakpoints);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetBidiLevel(uint textPosition, uint textLength, byte explicitLevel, byte resolvedLevel)
        {
            var @this = (IDWriteTextAnalysisSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, byte, byte, int>)@this->LpVtbl[5])(@this, textPosition, textLength, explicitLevel, resolvedLevel);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int SetNumberSubstitution(uint textPosition, uint textLength, IDWriteNumberSubstitution* numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, IDWriteNumberSubstitution*, int>)@this->LpVtbl[6])(@this, textPosition, textLength, numberSubstitution);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly int SetGlyphOrientation(uint textPosition, uint textLength, GlyphOrientationAngle glyphOrientationAngle, byte adjustedBidiLevel, Silk.NET.Core.Bool32 isSideways, Silk.NET.Core.Bool32 isRightToLeft)
        {
            var @this = (IDWriteTextAnalysisSink1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSink1*, uint, uint, GlyphOrientationAngle, byte, Silk.NET.Core.Bool32, Silk.NET.Core.Bool32, int>)@this->LpVtbl[7])(@this, textPosition, textLength, glyphOrientationAngle, adjustedBidiLevel, isSideways, isRightToLeft);
            return ret;
        }

    }
}
