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

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_fog_coord")]
    public abstract unsafe partial class ExtFogCoord : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_fog_coord";
        [NativeApi(EntryPoint = "glFogCoordfEXT")]
        public abstract void FogCoord([Flow(FlowDirection.In)] float coord);

        [NativeApi(EntryPoint = "glFogCoordfvEXT")]
        public abstract unsafe void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] float* coord);

        [NativeApi(EntryPoint = "glFogCoordfvEXT")]
        public abstract void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] ref float coord);

        [NativeApi(EntryPoint = "glFogCoorddEXT")]
        public abstract void FogCoord([Flow(FlowDirection.In)] double coord);

        [NativeApi(EntryPoint = "glFogCoorddvEXT")]
        public abstract unsafe void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] double* coord);

        [NativeApi(EntryPoint = "glFogCoorddvEXT")]
        public abstract void FogCoord([Count(Count = 1), Flow(FlowDirection.In)] ref double coord);

        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        public abstract unsafe void FogCoordPointer([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        public abstract void FogCoordPointer<T0>([Flow(FlowDirection.In)] EXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        public abstract unsafe void FogCoordPointer([Flow(FlowDirection.In)] FogPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] void* pointer);

        [NativeApi(EntryPoint = "glFogCoordPointerEXT")]
        public abstract void FogCoordPointer<T0>([Flow(FlowDirection.In)] FogPointerTypeEXT type, [Flow(FlowDirection.In)] uint stride, [Count(Computed = "type, stride"), Flow(FlowDirection.In)] ref T0 pointer) where T0 : unmanaged;

        public ExtFogCoord(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

