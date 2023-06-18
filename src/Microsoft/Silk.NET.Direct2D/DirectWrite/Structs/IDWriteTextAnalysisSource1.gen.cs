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
    [Guid("639cfad8-0fb4-4b21-a58a-067920120009")]
    [NativeName("Name", "IDWriteTextAnalysisSource1")]
    public unsafe partial struct IDWriteTextAnalysisSource1 : IComVtbl<IDWriteTextAnalysisSource1>, IComVtbl<IDWriteTextAnalysisSource>, IComVtbl<Silk.NET.Core.Native.IUnknown>
    {
        public static readonly Guid Guid = new("639cfad8-0fb4-4b21-a58a-067920120009");

        void*** IComVtbl.AsVtblPtr()
            => (void***) Unsafe.AsPointer(ref Unsafe.AsRef(in this));

        public static implicit operator IDWriteTextAnalysisSource(IDWriteTextAnalysisSource1 val)
            => Unsafe.As<IDWriteTextAnalysisSource1, IDWriteTextAnalysisSource>(ref val);

        public static implicit operator Silk.NET.Core.Native.IUnknown(IDWriteTextAnalysisSource1 val)
            => Unsafe.As<IDWriteTextAnalysisSource1, Silk.NET.Core.Native.IUnknown>(ref val);

        public IDWriteTextAnalysisSource1
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
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint AddRef()
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint>)@this->LpVtbl[1])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly uint Release()
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            uint ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint>)@this->LpVtbl[2])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextAtPosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[3])(@this, textPosition, textString, textLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetTextBeforePosition(uint textPosition, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** textString, uint* textLength)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, char**, uint*, int>)@this->LpVtbl[4])(@this, textPosition, textString, textLength);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly ReadingDirection GetParagraphReadingDirection()
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            ReadingDirection ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, ReadingDirection>)@this->LpVtbl[5])(@this);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetLocaleName(uint textPosition, uint* textLength, [Flow(Silk.NET.Core.Native.FlowDirection.In)] char** localeName)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, char**, int>)@this->LpVtbl[6])(@this, textPosition, textLength, localeName);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetNumberSubstitution(uint textPosition, uint* textLength, IDWriteNumberSubstitution** numberSubstitution)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, IDWriteNumberSubstitution**, int>)@this->LpVtbl[7])(@this, textPosition, textLength, numberSubstitution);
            return ret;
        }

        /// <summary>To be documented.</summary>
        public readonly unsafe int GetVerticalGlyphOrientation(uint textPosition, uint* textLength, VerticalGlyphOrientation* glyphOrientation, byte* bidiLevel)
        {
            var @this = (IDWriteTextAnalysisSource1*) Unsafe.AsPointer(ref Unsafe.AsRef(in this));
            int ret = default;
            ret = ((delegate* unmanaged[Stdcall]<IDWriteTextAnalysisSource1*, uint, uint*, VerticalGlyphOrientation*, byte*, int>)@this->LpVtbl[8])(@this, textPosition, textLength, glyphOrientation, bidiLevel);
            return ret;
        }

    }
}
