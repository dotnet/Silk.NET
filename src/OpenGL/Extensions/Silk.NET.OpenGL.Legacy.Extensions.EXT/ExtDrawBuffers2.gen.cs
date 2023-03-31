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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_draw_buffers2")]
    public unsafe partial class ExtDrawBuffers2 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_buffers2";
        [NativeApi(EntryPoint = "glColorMaskIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void ColorMaskIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool r, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool g, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool b, [Flow(Silk.NET.Core.Native.FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glDisableIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void DisableIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial void EnableIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBooleanIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetBooleanIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetBooleanIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetBooleanIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetIntegerIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetIntegerIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public unsafe partial void GetIntegerIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT", Convention = CallingConvention.Winapi)]
        public partial void GetIntegerIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(Silk.NET.Core.Native.FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabledIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT", Convention = CallingConvention.Winapi)]
        public partial bool IsEnabledIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EnableCap target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index);

        public unsafe bool GetBooleanIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetBooleanIndexed(target, index, out bool silkRet);
            return silkRet;
        }

        public unsafe bool GetBooleanIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] BufferTargetARB target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetBooleanIndexed(target, index, out bool silkRet);
            return silkRet;
        }

        public unsafe int GetIntegerIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] EXT target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetIntegerIndexed(target, index, out int silkRet);
            return silkRet;
        }

        public unsafe int GetIntegerIndexed([Flow(Silk.NET.Core.Native.FlowDirection.In)] GetPName target, [Flow(Silk.NET.Core.Native.FlowDirection.In)] uint index)
        {
            // NonKhrReturnTypeOverloader
            GetIntegerIndexed(target, index, out int silkRet);
            return silkRet;
        }

        public ExtDrawBuffers2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

