// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_draw_buffers2")]
    public unsafe partial class ExtDrawBuffers2 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_buffers2";
        [NativeApi(EntryPoint = "glColorMaskIndexedEXT")]
        public partial void ColorMaskIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glDisableIndexedEXT")]
        public partial void DisableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableIndexedEXT")]
        public partial void DisableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableIndexedEXT")]
        public partial void EnableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableIndexedEXT")]
        public partial void EnableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public unsafe partial void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public partial void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public unsafe partial void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public partial void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public unsafe partial void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public partial void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public unsafe partial void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] Boolean* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public partial void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out Boolean data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        public unsafe partial void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        public partial void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        public unsafe partial void GetIntegerIndexed([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        public partial void GetIntegerIndexed([Flow(FlowDirection.In)] GetPName target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT")]
        public partial bool IsEnabledIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT")]
        public partial bool IsEnabledIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        public ExtDrawBuffers2(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

