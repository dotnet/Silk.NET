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

namespace Silk.NET.OpenGL.Legacy.Extensions.AMD
{
    [Extension("AMD_name_gen_delete")]
    public unsafe partial class AmdNameGenDelete : NativeExtension<GL>
    {
        public const string ExtensionName = "AMD_name_gen_delete";
        [NativeApi(EntryPoint = "glDeleteNamesAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void DeleteNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.In)] uint* names);

        [NativeApi(EntryPoint = "glDeleteNamesAMD", Convention = CallingConvention.Winapi)]
        public partial void DeleteNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.In)] in uint names);

        [NativeApi(EntryPoint = "glGenNamesAMD", Convention = CallingConvention.Winapi)]
        public unsafe partial void GenNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.Out)] uint* names);

        [NativeApi(EntryPoint = "glGenNamesAMD", Convention = CallingConvention.Winapi)]
        public partial void GenNames([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint num, [Count(Parameter = "num"), Flow(FlowDirection.Out)] out uint names);

        [NativeApi(EntryPoint = "glIsNameAMD", Convention = CallingConvention.Winapi)]
        public partial bool IsName([Flow(FlowDirection.In)] AMD identifier, [Flow(FlowDirection.In)] uint name);

        public unsafe void DeleteNames([Flow(FlowDirection.In)] AMD identifier, [Count(Parameter = "num"), Flow(FlowDirection.In)] ReadOnlySpan<uint> names)
        {
            // ImplicitCountSpanOverloader
            DeleteNames(identifier, (uint) names.Length, in names.GetPinnableReference());
        }

        public unsafe void GenNames([Flow(FlowDirection.In)] AMD identifier, [Count(Parameter = "num"), Flow(FlowDirection.Out)] Span<uint> names)
        {
            // ImplicitCountSpanOverloader
            GenNames(identifier, (uint) names.Length, out names.GetPinnableReference());
        }

        public AmdNameGenDelete(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

