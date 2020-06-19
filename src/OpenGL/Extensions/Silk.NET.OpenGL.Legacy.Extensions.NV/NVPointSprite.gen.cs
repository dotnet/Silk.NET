// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.NV
{
    [Extension("NV_point_sprite")]
    public abstract unsafe partial class NVPointSprite : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_point_sprite";
        [NativeApi(EntryPoint = "glPointParameteriNV")]
        public abstract void PointParameter([Flow(FlowDirection.In)] NV pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPointParameterivNV")]
        public abstract unsafe void PointParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameterivNV")]
        public abstract void PointParameter([Flow(FlowDirection.In)] NV pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glPointParameteriNV")]
        public abstract void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Flow(FlowDirection.In)] int param);

        [NativeApi(EntryPoint = "glPointParameterivNV")]
        public abstract unsafe void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glPointParameterivNV")]
        public abstract void PointParameter([Flow(FlowDirection.In)] PointParameterNameARB pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        public NVPointSprite(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

