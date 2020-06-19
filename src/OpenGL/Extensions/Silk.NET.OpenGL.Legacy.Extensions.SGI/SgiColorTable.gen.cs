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

namespace Silk.NET.OpenGL.Legacy.Extensions.SGI
{
    [Extension("SGI_color_table")]
    public abstract unsafe partial class SgiColorTable : NativeExtension<GL>
    {
        public const string ExtensionName = "SGI_color_table";
        [NativeApi(EntryPoint = "glColorTableSGI")]
        public abstract unsafe void ColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public abstract void ColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public abstract unsafe void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public abstract void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public abstract unsafe void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public abstract void ColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glCopyColorTableSGI")]
        public abstract void CopyColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public abstract unsafe void GetColorTable([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public abstract void GetColorTable<T0>([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI format, [Flow(FlowDirection.In)] SGI type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public abstract unsafe void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public abstract void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public abstract unsafe void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public abstract void GetColorTableParameter([Flow(FlowDirection.In)] SGI target, [Flow(FlowDirection.In)] SGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public abstract unsafe void ColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] void* table);

        [NativeApi(EntryPoint = "glColorTableSGI")]
        public abstract void ColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "format, type, width"), Flow(FlowDirection.In)] ref T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public abstract unsafe void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] float* @params);

        [NativeApi(EntryPoint = "glColorTableParameterfvSGI")]
        public abstract void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref float @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public abstract unsafe void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] int* @params);

        [NativeApi(EntryPoint = "glColorTableParameterivSGI")]
        public abstract void ColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] ColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.In)] ref int @params);

        [NativeApi(EntryPoint = "glCopyColorTableSGI")]
        public abstract void CopyColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] InternalFormat internalformat, [Flow(FlowDirection.In)] int x, [Flow(FlowDirection.In)] int y, [Flow(FlowDirection.In)] uint width);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public abstract unsafe void GetColorTable([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] void* table);

        [NativeApi(EntryPoint = "glGetColorTableSGI")]
        public abstract void GetColorTable<T0>([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] PixelFormat format, [Flow(FlowDirection.In)] PixelType type, [Count(Computed = "target, format, type"), Flow(FlowDirection.Out)] out T0 table) where T0 : unmanaged;

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public abstract unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] float* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterfvSGI")]
        public abstract void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out float @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public abstract unsafe void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] int* @params);

        [NativeApi(EntryPoint = "glGetColorTableParameterivSGI")]
        public abstract void GetColorTableParameter([Flow(FlowDirection.In)] ColorTableTargetSGI target, [Flow(FlowDirection.In)] GetColorTableParameterPNameSGI pname, [Count(Computed = "pname"), Flow(FlowDirection.Out)] out int @params);

        public SgiColorTable(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

