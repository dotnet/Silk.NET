// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
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

namespace Silk.NET.OpenGL.Legacy.Extensions.ATI
{
    [Extension("ATI_vertex_array_object")]
    public unsafe partial class AtiVertexArrayObject : NativeExtension<GL>
    {
        public const string ExtensionName = "ATI_vertex_array_object";
        [NativeApi(EntryPoint = "glArrayObjectATI")]
        public partial void ArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glArrayObjectATI")]
        public partial void ArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glArrayObjectATI")]
        public partial void ArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glArrayObjectATI")]
        public partial void ArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] int size, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glFreeObjectBufferATI")]
        public partial void FreeObjectBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectfvATI")]
        public partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public partial void GetArrayObject([Flow(FlowDirection.In)] ATI array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public unsafe partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetArrayObjectivATI")]
        public partial void GetArrayObject([Flow(FlowDirection.In)] EnableCap array, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        public unsafe partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        public partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        public unsafe partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetObjectBufferfvATI")]
        public partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        public unsafe partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        public partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        public unsafe partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetObjectBufferivATI")]
        public partial void GetObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        public unsafe partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        public partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        public unsafe partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectfvATI")]
        public partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        public unsafe partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        public partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        public unsafe partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetVariantArrayObjectivATI")]
        public partial void GetVariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ArrayObjectPNameATI pname, [Count(Count = 1), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glIsObjectBufferATI")]
        public partial bool IsObjectBuffer([Flow(FlowDirection.In)] uint buffer);

        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        public unsafe partial uint NewObjectBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ATI usage);

        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        public partial uint NewObjectBuffer<T0>([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 pointer, [Flow(FlowDirection.In)] ATI usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        public unsafe partial uint NewObjectBuffer([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ArrayObjectUsageATI usage);

        [NativeApi(EntryPoint = "glNewObjectBufferATI")]
        public partial uint NewObjectBuffer<T0>([Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 pointer, [Flow(FlowDirection.In)] ArrayObjectUsageATI usage) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        public unsafe partial void UpdateObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] ATI preserve);

        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        public partial void UpdateObjectBuffer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 pointer, [Flow(FlowDirection.In)] ATI preserve) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        public unsafe partial void UpdateObjectBuffer([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] void* pointer, [Flow(FlowDirection.In)] PreserveModeATI preserve);

        [NativeApi(EntryPoint = "glUpdateObjectBufferATI")]
        public partial void UpdateObjectBuffer<T0>([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset, [Flow(FlowDirection.In)] uint size, [Count(Parameter = "size"), Flow(FlowDirection.In)] in T0 pointer, [Flow(FlowDirection.In)] PreserveModeATI preserve) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glVariantArrayObjectATI")]
        public partial void VariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ATI type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        [NativeApi(EntryPoint = "glVariantArrayObjectATI")]
        public partial void VariantArrayObject([Flow(FlowDirection.In)] uint id, [Flow(FlowDirection.In)] ScalarType type, [Flow(FlowDirection.In)] uint stride, [Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] uint offset);

        public AtiVertexArrayObject(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

