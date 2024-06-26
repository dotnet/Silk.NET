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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGIX
{
    [Extension("SGIX_igloo_interface")]
    public unsafe partial class SgixIglooInterface : NativeExtension<GL>
    {
        public const string ExtensionName = "SGIX_igloo_interface";
        [NativeApi(EntryPoint = "glIglooInterfaceSGIX", Convention = CallingConvention.Winapi)]
        public unsafe partial void IglooInterface([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] void* @params);

        [NativeApi(EntryPoint = "glIglooInterfaceSGIX", Convention = CallingConvention.Winapi)]
        public partial void IglooInterface<T0>([Flow(Silk.NET.Core.Native.FlowDirection.In)] SGIX pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.In)] [RequiresLocation] in T0 @params) where T0 : unmanaged;

        public SgixIglooInterface(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

