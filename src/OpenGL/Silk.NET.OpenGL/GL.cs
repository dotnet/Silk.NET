using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenGL
{
    public partial class GL
    {
        public static GL GetApi()
        {
             return LibraryLoader<GL>.Load(new GLCoreLibraryNameContainer());
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<GL>
        {
             ext = LibraryLoader<GL>.Load<T>(this);
             return ext != null;
        }

        private List<string> _extensions;
        public override bool IsExtensionPresent(string extension)
        {
            _extensions ??= Enumerable.Range(0, GetInteger(GLEnum.NumExtensions))
                .Select(x => GetStringManaged(GLEnum.Extensions, (uint) x)).ToList();

            return _extensions.Contains(extension);
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

        public string GetActiveAttrib(uint program, uint index, out int size, out GLEnum type)
        {
            uint length;
            GetProgram(program, GLEnum.ActiveAttributeMaxLength, out var lengthTmp);
            length = (uint) lengthTmp;
            var str = new string((char)0, (int) (length == 0 ? 1 : length * 2));

            GetActiveAttrib(program, index, (uint) (length == 0 ? 1 : length * 2), out length, out size, out type, str);

            return str.Substring(0, (int) length);
        }

        public string GetActiveUniform(uint program, uint uniformIndex, out int size, out GLEnum type)
        {
            uint length;
            GetProgram(program, GLEnum.ActiveUniformMaxLength, out var lengthTmp);
            length = (uint) lengthTmp;

            var str = new string((char)0, (int) length);
            GetActiveUniform(program, uniformIndex, length == 0 ? 1 : length, out length, out size, out type, str);
            return str.Substring(0, (int) length);
        }

        public void ShaderSource(Int32 shader, System.String @string)
        {
            unsafe
            {
                int length = @string.Length;
                ShaderSource((UInt32)shader, 1, new string[] { @string }, &length);
            }
        }

        public string GetShaderInfoLog(UInt32 shader)
        {
            string info;
            GetShaderInfoLog(shader, out info);
            return info;
        }

        public void GetShaderInfoLog(UInt32 shader, out string info)
        {
            unsafe
            {
                uint length;
                GetShader(shader, GLEnum.InfoLogLength, out var lengthTmp);
                length = (uint)lengthTmp;
                if (length == 0)
                {
                    info = string.Empty;
                    return;
                }
                info = new string((char)0, (int)length);
                GetShaderInfoLog(shader, length * 2, out length, info);
                info = info.Substring(0, (int) length);
            }
        }

        public string GetProgramInfoLog(UInt32 program)
        {
            string info;
            GetProgramInfoLog(program, out info);
            return info;
        }

        public void GetProgramInfoLog(UInt32 program, out string info)
        {
            unsafe
            {
                uint length;
                GetProgram(program, GLEnum.InfoLogLength, out var lengthTmp);
                length = (uint) lengthTmp;
                if (length == 0)
                {
                    info = string.Empty;
                    return;
                }
                info = new string((char)0, (int)length);
                GetProgramInfoLog(program, length * 2, out length, info);
            }
        }

        [CLSCompliant(false)]
        public void VertexAttrib2(UInt32 index, ref Vector2 v)
        {
            VertexAttrib2(index, v.X, v.Y);
        }

        [CLSCompliant(false)]
        public void VertexAttrib3(UInt32 index, ref Vector3 v)
        {
            VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        [CLSCompliant(false)]
        public void VertexAttrib4(UInt32 index, ref Vector4 v)
        {
            VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        public void VertexAttrib2(UInt32 index, Vector2 v)
        {
            VertexAttrib2(index, v.X, v.Y);
        }

        public void VertexAttrib3(UInt32 index, Vector3 v)
        {
            VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        public void VertexAttrib4(UInt32 index, Vector4 v)
        {
            VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        public unsafe void VertexAttribPointer(uint index, int size, GLEnum type, bool normalized, uint stride, int offset)
        {
            VertexAttribPointer(index, size, type, normalized, stride, (void*)offset);
        }

        public unsafe void DrawElements(GLEnum mode, uint count, GLEnum type, int offset)
        {
            DrawElements((GLEnum)mode, count, type, (void*)(offset));
        }

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
            Viewport(location.X, location.Y, (uint) size.Width, (uint) size.Height);
        }

        public void Viewport(Rectangle rectangle)
        {
            Viewport(rectangle.X, rectangle.Y, (uint) rectangle.Width, (uint) rectangle.Height);
        }
    }
}
