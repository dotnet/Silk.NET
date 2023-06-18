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
    public unsafe partial class DWrite : NativeAPI
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "DWRITE_ALPHA_MAX")]
        public const int AlphaMax = unchecked((int) 0xFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "FACILITY_DWRITE")]
        public const int FacilityDwrite = unchecked((int) 0x898);
        [NativeName("Type", "int")]
        [NativeName("Name", "DWRITE_ERR_BASE")]
        public const int ErrBase = unchecked((int) 0x5000);
        [NativeName("Type", "int")]
        [NativeName("Name", "DWRITE_STANDARD_FONT_AXIS_COUNT")]
        public const int StandardFontAxisCount = unchecked((int) 0x5);

        /// <summary>To be documented.</summary>
        [NativeName("Src", "Line 5119, Column 32 in DWrite.h")]
        [NativeApi(EntryPoint = "DWriteCreateFactory", Convention = CallingConvention.StdCall)]
        public unsafe partial int DWriteCreateFactory(FactoryType factoryType, Guid* iid, Silk.NET.Core.Native.IUnknown** factory);


        public DWrite(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

