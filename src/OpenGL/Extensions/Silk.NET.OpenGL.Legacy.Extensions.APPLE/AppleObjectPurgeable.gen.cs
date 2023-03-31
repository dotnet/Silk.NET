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

namespace Silk.NET.OpenGL.Legacy.Extensions.APPLE
{
    [Extension("APPLE_object_purgeable")]
    public unsafe partial class AppleObjectPurgeable : NativeExtension<GL>
    {
        public const string ExtensionName = "APPLE_object_purgeable";
        [NativeApi(EntryPoint = "glGetObjectParameterivAPPLE", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE objectType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetObjectParameterivAPPLE", Convention = CallingConvention.Winapi)]
        public partial void GetObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE objectType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE pname, [Count(Computed = "pname"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glObjectPurgeableAPPLE", Convention = CallingConvention.Winapi)]
        public partial APPLE ObjectPurgeable([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE objectType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE option);

        [NativeApi(EntryPoint = "glObjectUnpurgeableAPPLE", Convention = CallingConvention.Winapi)]
        public partial APPLE ObjectUnpurgeable([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE objectType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE option);

        public unsafe int GetObjectParameter([Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE objectType, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint name, [Flow(Silk.NET.Core.Native.FlowDirection.In)] APPLE pname)
        {
            // NonKhrReturnTypeOverloader
            GetObjectParameter(objectType, name, pname, out int silkRet);
            return silkRet;
        }

        public AppleObjectPurgeable(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

