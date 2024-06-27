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
using Silk.NET.OpenGL.Legacy;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_transpose_matrix")]
    public unsafe partial class ArbTransposeMatrix : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_transpose_matrix";
        [NativeApi(EntryPoint = "glLoadTransposeMatrixfARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void LoadTransposeMatrix([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixfARB", Convention = CallingConvention.Winapi)]
        public partial void LoadTransposeMatrix([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixdARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void LoadTransposeMatrix([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glLoadTransposeMatrixdARB", Convention = CallingConvention.Winapi)]
        public partial void LoadTransposeMatrix([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixfARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultTransposeMatrix([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] float* m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixfARB", Convention = CallingConvention.Winapi)]
        public partial void MultTransposeMatrix([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in float m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixdARB", Convention = CallingConvention.Winapi)]
        public unsafe partial void MultTransposeMatrix([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] double* m);

        [NativeApi(EntryPoint = "glMultTransposeMatrixdARB", Convention = CallingConvention.Winapi)]
        public partial void MultTransposeMatrix([Count(Count = 16), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in double m);

        public ArbTransposeMatrix(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

