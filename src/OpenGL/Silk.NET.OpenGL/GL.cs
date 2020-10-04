using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Platform;
using Ultz.SuperInvoke;

namespace Silk.NET.OpenGL
{
    public partial class GL
    {
        [Obsolete
        (
            "Parameterless GetApi calls are deprecated and will be removed in a future release. Please create" +
            "your GL instances using a context"
        )]
        public static GL GetApi() => LibraryLoader<GL>.Load
            (new GLCoreLibraryNameContainer(), SilkManager.Get<GLSymbolLoader>());

        public static GL GetApi(IGLContextSource contextSource) => GetApi
        (
            contextSource.GLContext ?? throw new InvalidOperationException
                ("The given IGLContextSource is not configured with a context.")
        );

        public static GL GetApi(IGLContext ctx) => GetApi((INativeContext)ctx);
        public static GL GetApi(Func<string, IntPtr> getProcAddress) => GetApi(new LamdaNativeContext(getProcAddress));

        public static GL GetApi(INativeContext ctx) => LibraryActivator.CreateInstance<GL>
            (new GLCoreLibraryNameContainer().GetLibraryName(), SilkManager.Get(ctx));

        public bool TryGetExtension<T>(out T ext)
            where T : NativeExtension<GL>
        {
            ext = LibraryLoader<GL>.Load<T>(this);
            return ext != null;
        }

        private List<string> _extensions;

        public override bool IsExtensionPresent(string extension)
        {
            _extensions ??= Enumerable.Range(0, GetInteger(GLEnum.NumExtensions))
                .Select(x => GetString(StringName.Extensions, (uint)x))
                .ToList();

            return _extensions.Contains("GL_" + (extension.StartsWith("GL_") ? extension.Substring(3) : extension));
        }

        public void ClearColor(Color color)
        {
            ClearColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public void BlendColor(Color color)
        {
            BlendColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public void Uniform2(int location, ref Vector2 vector)
        {
            Uniform2(location, vector.X, vector.Y);
        }

        public void Uniform3(int location, ref Vector3 vector)
        {
            Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        public void Uniform4(int location, ref Vector4 vector)
        {
            Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public void Uniform2(int location, Vector2 vector)
        {
            Uniform2(location, vector.X, vector.Y);
        }

        public void Uniform3(int location, Vector3 vector)
        {
            Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        public void Uniform4(int location, Vector4 vector)
        {
            Uniform4(location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public void Uniform4(int location, Quaternion quaternion)
        {
            Uniform4(location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        public void ProgramUniform2(uint program, int location, ref Vector2 vector)
        {
            ProgramUniform2(program, location, vector.X, vector.Y);
        }

        public void ProgramUniform3(uint program, int location, ref Vector3 vector)
        {
            ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);
        }

        public void ProgramUniform4(uint program, int location, ref Vector4 vector)
        {
            ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public void ProgramUniform2(uint program, int location, Vector2 vector)
        {
            ProgramUniform2(program, location, vector.X, vector.Y);
        }

        public void ProgramUniform3(uint program, int location, Vector3 vector)
        {
            ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);
        }

        public void ProgramUniform4(uint program, int location, Vector4 vector)
        {
            ProgramUniform4(program, location, vector.X, vector.Y, vector.Z, vector.W);
        }

        public void ProgramUniform4(uint program, int location, Quaternion quaternion)
        {
            ProgramUniform4(program, location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        public string GetActiveAttrib(uint program, uint index, out int size, out AttributeType type)
        {
            uint length;
            GetProgram(program, GLEnum.ActiveAttributeMaxLength, out var lengthTmp);
            length = (uint)lengthTmp;

            GetActiveAttrib
                (program, index, (uint)(length == 0 ? 1 : length * 2), out length, out size, out type, out string str);

            return str.Substring(0, (int)length);
        }

        public string GetActiveUniform(uint program, uint uniformIndex, out int size, out UniformType type)
        {
            uint length;
            GetProgram(program, GLEnum.ActiveUniformMaxLength, out var lengthTmp);
            length = (uint)lengthTmp;
            GetActiveUniform
                (program, uniformIndex, length == 0 ? 1 : length, out length, out size, out type, out string str);
            return str.Substring(0, (int)length);
        }

        public void ShaderSource(uint shader, string @string)
        {
            unsafe
            {
                int length = @string.Length;
                ShaderSource((uint)shader, 1, new string[] { @string }, &length);
            }
        }

        public string GetShaderInfoLog(uint shader)
        {
            GetShaderInfoLog(shader, out var info);
            return info;
        }

        public void GetShaderInfoLog(uint shader, out string info)
        {
            GetShader(shader, GLEnum.InfoLogLength, out var length2);
            var length = (uint)length2;
            GetShaderInfoLog(shader, length * 2, out length, out info);
            info = info.Substring(0, (int)length);
        }

        public string GetProgramInfoLog(uint program)
        {
            GetProgramInfoLog(program, out var info);
            return info;
        }

        public void GetProgramInfoLog(uint program, out string info)
        {
            GetProgram(program, GLEnum.InfoLogLength, out var length2);
            var length = (uint)length2;
            GetProgramInfoLog(program, length * 2, out length, out info);
            info = info.Substring(0, (int)length);
        }

        [CLSCompliant(false)]
        public void VertexAttrib2(uint index, ref Vector2 v)
        {
            VertexAttrib2(index, v.X, v.Y);
        }

        [CLSCompliant(false)]
        public void VertexAttrib3(uint index, ref Vector3 v)
        {
            VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        [CLSCompliant(false)]
        public void VertexAttrib4(uint index, ref Vector4 v)
        {
            VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        public void VertexAttrib2(uint index, Vector2 v)
        {
            VertexAttrib2(index, v.X, v.Y);
        }

        public void VertexAttrib3(uint index, Vector3 v)
        {
            VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        public void VertexAttrib4(uint index, Vector4 v)
        {
            VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        //public unsafe void VertexAttribPointer(uint index, int size, GLEnum type, bool normalized, uint stride, int offset)
        //{
        //    VertexAttribPointer(index, size, type, normalized, stride, (void*)offset);
        //}

        //public unsafe void DrawElements(GLEnum mode, uint count, GLEnum type, int offset)
        //{
        //    DrawElements((GLEnum)mode, count, type, (void*)(offset));
        //}

        public void GetFloat(GLEnum pname, out Vector2 vector)
        {
            unsafe
            {
                fixed (Vector2* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public void GetFloat(GLEnum pname, out Vector3 vector)
        {
            unsafe
            {
                fixed (Vector3* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public void GetFloat(GLEnum pname, out Vector4 vector)
        {
            unsafe
            {
                fixed (Vector4* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public void GetFloat(GLEnum pname, out Matrix4x4 matrix)
        {
            unsafe
            {
                fixed (Matrix4x4* ptr = &matrix)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public void Viewport(Size size)
        {
            Viewport(0, 0, (uint)size.Width, (uint)size.Height);
        }

        public void Viewport(Point location, Size size)
        {
            Viewport(location.X, location.Y, (uint)size.Width, (uint)size.Height);
        }

        public void Viewport(Rectangle rectangle)
        {
            Viewport(rectangle.X, rectangle.Y, (uint)rectangle.Width, (uint)rectangle.Height);
        }
    }
}
