using System;
using System.Drawing;
using System.Numerics;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;

namespace Silk.NET.OpenGLES
{
    partial class GL
    {
        public static GL GetApi()
        {
             return LibraryLoader<GL>.Load(new OpenGLESLibraryNameContainer());
        }

        public bool TryGetExtension<T>(out T ext)
            where T:NativeExtension<GL>
        {
             ext = LibraryLoader<GL>.Load<T>(this);
             return ext != null;
        }
        public override bool IsExtensionPresent(string extension)
        {
            throw new NotImplementedException();
        }
        
        public void ClearColor(Color color)
        {
            ClearColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        public void BlendColor(Color color)
        {
            BlendColor(color.R / 255.0f, color.G / 255.0f, color.B / 255.0f, color.A / 255.0f);
        }

        [CLSCompliant(false)]
        public void Uniform2(int location, ref Vector2 vector)
        {
            Uniform2(location, vector.X, vector.Y);
        }

        [CLSCompliant(false)]
        public void Uniform3(int location, ref Vector3 vector)
        {
            Uniform3(location, vector.X, vector.Y, vector.Z);
        }

        [CLSCompliant(false)]
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

        public void Uniform4(int location, Color color)
        {
            Uniform4(location, color.R, color.G, color.B, color.A);
        }

        public void Uniform4(int location, Quaternion quaternion)
        {
            Uniform4(location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        [CLSCompliant(false)]
        public void ProgramUniform2(uint program, int location, ref Vector2 vector)
        {
            ProgramUniform2(program, location, vector.X, vector.Y);
        }

        [CLSCompliant(false)]
        public void ProgramUniform3(uint program, int location, ref Vector3 vector)
        {
            ProgramUniform3(program, location, vector.X, vector.Y, vector.Z);
        }

        [CLSCompliant(false)]
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

        public void ProgramUniform4(uint program, int location, Color color)
        {
            ProgramUniform4(program, location, color.R, color.G, color.B, color.A);
        }

        public void ProgramUniform4(uint program, int location, Quaternion quaternion)
        {
            ProgramUniform4(program, location, quaternion.X, quaternion.Y, quaternion.Z, quaternion.W);
        }

        public string GetActiveAttrib(uint program, uint index, out int size, out int type)
        {
            GetProgram(program, (int)GLEnum.ActiveAttributeMaxLength, out var length);
            string str = null;
            var lengthu = (uint) length;
            GetActiveAttrib(program, index, lengthu == 0 ? 1 : lengthu * 2, out lengthu, out size, out type, str);
            return str;
        }

        public void ShaderSource(uint shader, string @string)
        {
            unsafe
            {
                int length = @string.Length;
                var strings = (new string[] {@string});
                fixed (char* strs = strings[0])
                {
                    ShaderSource((uint) shader, 1u, strs, length);
                }
            }
        }

        public string GetShaderInfoLog(uint shader)
        {
            string info;
            GetShaderInfoLog(shader, out info);
            return info;
        }

        public void GetShaderInfoLog(uint shader, out string info)
        {
            unsafe
            {
                GetShader(shader, (int)GLEnum.InfoLogLength, out var length);
                if (length == 0)
                {
                    info = string.Empty;
                    return;
                }

                var lengthu = (uint) length;
                info = null;
                GetShaderInfoLog(shader, lengthu * 2, out lengthu, info);
            }
        }

        public string GetProgramInfoLog(uint program)
        {
            string info;
            GetProgramInfoLog(program, out info);
            return info;
        }

        public void GetProgramInfoLog(uint program, out string info)
        {
            GetProgram(program, (int)GLEnum.InfoLogLength, out var length); if (length == 0)
            {
                info = string.Empty;
                return;
            }

            var lengthu = (uint) length;
            info = null;
            GetProgramInfoLog(program, lengthu * 2u, lengthu, info);
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

        public void VertexAttribPointer(uint index, int size, GLEnum type, bool normalized, int stride, int offset)
        {
            VertexAttribPointer(index, size, type, normalized, stride, offset);
        }

        [CLSCompliant(false)]
        public void VertexAttribPointer(uint index, int size, GLEnum type, bool normalized, uint stride, int offset)
        {
            unsafe
            {
                VertexAttribPointer(index, size, (int)type, normalized, stride, ((IntPtr)offset).ToPointer());
            }
        }

        public void DrawElements(GLEnum mode, int count, GLEnum type, int offset)
        {
            DrawElements(mode, count, type, offset);
        }

        public void GetFloat(GLEnum pname, out Vector2 vector)
        {
            unsafe
            {
                fixed (Vector2* ptr = &vector)
                {
                    GetFloat((int)pname, (float*)ptr);
                }
            }
        }

        public void GetFloat(int pname, out Vector3 vector)
        {
            unsafe
            {
                fixed (Vector3* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public void GetFloat(int pname, out Vector4 vector)
        {
            unsafe
            {
                fixed (Vector4* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public void GetFloat(int pname, out Matrix4x4 matrix)
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

