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

namespace Silk.NET.OpenGL.Legacy.Extensions.SUN
{
    [Extension("SUN_vertex")]
    public unsafe partial class SunVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "SUN_vertex";
        [NativeApi(EntryPoint = "glColor3fVertex3fSUN")]
        public partial void Color3fVertex3([Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glColor3fVertex3fvSUN")]
        public unsafe partial void Color3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor3fVertex3fvSUN")]
        public unsafe partial void Color3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glColor3fVertex3fvSUN")]
        public unsafe partial void Color3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor3fVertex3fvSUN")]
        public partial void Color3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fSUN")]
        public partial void Color4fNormal3fVertex3([Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float a, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4fNormal3fVertex3fvSUN")]
        public partial void Color4fNormal3fVertex3([Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fSUN")]
        public partial void Color4ubVertex2([Flow(FlowDirection.In)] byte r, [Flow(FlowDirection.In)] byte g, [Flow(FlowDirection.In)] byte b, [Flow(FlowDirection.In)] byte a, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN")]
        public unsafe partial void Color4ubVertex2([Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN")]
        public unsafe partial void Color4ubVertex2([Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 2), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN")]
        public unsafe partial void Color4ubVertex2([Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN")]
        public partial void Color4ubVertex2([Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 2), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN")]
        public unsafe partial void Color4ubVertex2([Flow(FlowDirection.In)] string c, [Count(Count = 2), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex2fvSUN")]
        public partial void Color4ubVertex2([Flow(FlowDirection.In)] string c, [Count(Count = 2), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fSUN")]
        public partial void Color4ubVertex3([Flow(FlowDirection.In)] byte r, [Flow(FlowDirection.In)] byte g, [Flow(FlowDirection.In)] byte b, [Flow(FlowDirection.In)] byte a, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN")]
        public unsafe partial void Color4ubVertex3([Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN")]
        public unsafe partial void Color4ubVertex3([Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN")]
        public unsafe partial void Color4ubVertex3([Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN")]
        public partial void Color4ubVertex3([Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN")]
        public unsafe partial void Color4ubVertex3([Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glColor4ubVertex3fvSUN")]
        public partial void Color4ubVertex3([Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glNormal3fVertex3fSUN")]
        public partial void Normal3fVertex3([Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glNormal3fVertex3fvSUN")]
        public unsafe partial void Normal3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glNormal3fVertex3fvSUN")]
        public unsafe partial void Normal3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glNormal3fVertex3fvSUN")]
        public unsafe partial void Normal3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glNormal3fVertex3fvSUN")]
        public partial void Normal3fVertex3([Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fSUN")]
        public partial void ReplacementCodeuiColor3fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 3), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor3fVertex3fvSUN")]
        public partial void ReplacementCodeuiColor3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 3), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fSUN")]
        public partial void ReplacementCodeuiColor4fNormal3fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float a, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4fNormal3fVertex3fvSUN")]
        public partial void ReplacementCodeuiColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fSUN")]
        public partial void ReplacementCodeuiColor4ubVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] byte r, [Flow(FlowDirection.In)] byte g, [Flow(FlowDirection.In)] byte b, [Flow(FlowDirection.In)] byte a, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiColor4ubVertex3fvSUN")]
        public partial void ReplacementCodeuiColor4ubVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fSUN")]
        public partial void ReplacementCodeuiNormal3fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiNormal3fVertex3fvSUN")]
        public partial void ReplacementCodeuiNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fSUN")]
        public partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float a, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public partial void ReplacementCodeuiTexCoord2fColor4fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fSUN")]
        public partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fNormal3fVertex3fvSUN")]
        public partial void ReplacementCodeuiTexCoord2fNormal3fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fSUN")]
        public partial void ReplacementCodeuiTexCoord2fVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiTexCoord2fVertex3fvSUN")]
        public partial void ReplacementCodeuiTexCoord2fVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fSUN")]
        public partial void ReplacementCodeuiVertex3([Flow(FlowDirection.In)] uint rc, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(FlowDirection.In)] uint* rc, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN")]
        public unsafe partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glReplacementCodeuiVertex3fvSUN")]
        public partial void ReplacementCodeuiVertex3([Count(Count = 1), Flow(FlowDirection.In)] in uint rc, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fSUN")]
        public partial void TexCoord2fColor3fVertex3([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor3fVertex3fvSUN")]
        public partial void TexCoord2fColor3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fSUN")]
        public partial void TexCoord2fColor4fNormal3fVertex3([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float a, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4fNormal3fVertex3fvSUN")]
        public partial void TexCoord2fColor4fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fSUN")]
        public partial void TexCoord2fColor4ubVertex3([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] byte r, [Flow(FlowDirection.In)] byte g, [Flow(FlowDirection.In)] byte b, [Flow(FlowDirection.In)] byte a, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] byte* c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in byte c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public unsafe partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fColor4ubVertex3fvSUN")]
        public partial void TexCoord2fColor4ubVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Flow(FlowDirection.In)] string c, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fSUN")]
        public partial void TexCoord2fNormal3fVertex3([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN")]
        public unsafe partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fNormal3fVertex3fvSUN")]
        public partial void TexCoord2fNormal3fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fVertex3fSUN")]
        public partial void TexCoord2fVertex3([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z);

        [NativeApi(EntryPoint = "glTexCoord2fVertex3fvSUN")]
        public unsafe partial void TexCoord2fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fVertex3fvSUN")]
        public unsafe partial void TexCoord2fVertex3([Count(Count = 2), Flow(FlowDirection.In)] float* tc, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord2fVertex3fvSUN")]
        public unsafe partial void TexCoord2fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord2fVertex3fvSUN")]
        public partial void TexCoord2fVertex3([Count(Count = 2), Flow(FlowDirection.In)] in float tc, [Count(Count = 3), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fSUN")]
        public partial void TexCoord4fColor4fNormal3fVertex4([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float p, [Flow(FlowDirection.In)] float q, [Flow(FlowDirection.In)] float r, [Flow(FlowDirection.In)] float g, [Flow(FlowDirection.In)] float b, [Flow(FlowDirection.In)] float a, [Flow(FlowDirection.In)] float nx, [Flow(FlowDirection.In)] float ny, [Flow(FlowDirection.In)] float nz, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] float* n, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public unsafe partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fColor4fNormal3fVertex4fvSUN")]
        public partial void TexCoord4fColor4fNormal3fVertex4([Count(Count = 4), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float c, [Count(Count = 3), Flow(FlowDirection.In)] in float n, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fVertex4fSUN")]
        public partial void TexCoord4fVertex4([Flow(FlowDirection.In)] float s, [Flow(FlowDirection.In)] float t, [Flow(FlowDirection.In)] float p, [Flow(FlowDirection.In)] float q, [Flow(FlowDirection.In)] float x, [Flow(FlowDirection.In)] float y, [Flow(FlowDirection.In)] float z, [Flow(FlowDirection.In)] float w);

        [NativeApi(EntryPoint = "glTexCoord4fVertex4fvSUN")]
        public unsafe partial void TexCoord4fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fVertex4fvSUN")]
        public unsafe partial void TexCoord4fVertex4([Count(Count = 4), Flow(FlowDirection.In)] float* tc, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        [NativeApi(EntryPoint = "glTexCoord4fVertex4fvSUN")]
        public unsafe partial void TexCoord4fVertex4([Count(Count = 4), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glTexCoord4fVertex4fvSUN")]
        public partial void TexCoord4fVertex4([Count(Count = 4), Flow(FlowDirection.In)] in float tc, [Count(Count = 4), Flow(FlowDirection.In)] in float v);

        public SunVertex(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

