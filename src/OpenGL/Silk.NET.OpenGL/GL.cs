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

        public string GetActiveAttrib(uint program, uint index, out uint size, out GLEnum type)
        {
            uint length;
            GetProgram(program, GLEnum.ActiveAttributeMaxLength, out var lengthTmp);
            length = (uint) lengthTmp;
            var str = new string((char)0, (int) (length == 0 ? 1 : length * 2));

            GetActiveAttrib(program, index, (uint) (length == 0 ? 1 : length * 2), out length, out size, out type, str);

            return str;
        }

        public string GetActiveUniform(int program, int uniformIndex, out int size, out ActiveUniformType type)
        {
            int length;
            GetProgram(program, OpenGL4.GetProgramParameterName.ActiveUniformMaxLength, out length);

            string str;
            GetActiveUniform(program, uniformIndex, length == 0 ? 1 : length, out length, out size, out type, out str);
            return str;
        }

        public void ShaderSource(Int32 shader, System.String @string)
        {
            unsafe
            {
                int length = @string.Length;
                ShaderSource((UInt32)shader, 1, new string[] { @string }, &length);
            }
        }

        public string GetShaderInfoLog(Int32 shader)
        {
            string info;
            GetShaderInfoLog(shader, out info);
            return info;
        }

        public void GetShaderInfoLog(Int32 shader, out string info)
        {
            unsafe
            {
                int length;
                GetShader(shader, ShaderParameter.InfoLogLength, out length);
                if (length == 0)
                {
                    info = String.Empty;
                    return;
                }
                GetShaderInfoLog((UInt32)shader, length * 2, &length, out info);
            }
        }

        public string GetProgramInfoLog(Int32 program)
        {
            string info;
            GetProgramInfoLog(program, out info);
            return info;
        }

        public void GetProgramInfoLog(Int32 program, out string info)
        {
            unsafe
            {
                int length;
                GetProgram(program, GLEnum.InfoLogLength, out length); if (length == 0)
                {
                    info = String.Empty;
                    return;
                }
                GetProgramInfoLog((UInt32)program, length * 2, &length, out info);
            }
        }

        [CLSCompliant(false)]
        public void VertexAttrib2(Int32 index, ref Vector2 v)
        {
            VertexAttrib2(index, v.X, v.Y);
        }

        [CLSCompliant(false)]
        public void VertexAttrib3(Int32 index, ref Vector3 v)
        {
            VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        [CLSCompliant(false)]
        public void VertexAttrib4(Int32 index, ref Vector4 v)
        {
            VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        public void VertexAttrib2(Int32 index, Vector2 v)
        {
            VertexAttrib2(index, v.X, v.Y);
        }

        public void VertexAttrib3(Int32 index, Vector3 v)
        {
            VertexAttrib3(index, v.X, v.Y, v.Z);
        }

        public void VertexAttrib4(Int32 index, Vector4 v)
        {
            VertexAttrib4(index, v.X, v.Y, v.Z, v.W);
        }

        public void VertexAttribPointer(int index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
        {
            VertexAttribPointer(index, size, type, normalized, stride, (IntPtr)offset);
        }

        [CLSCompliant(false)]
        public void VertexAttribPointer(uint index, int size, VertexAttribPointerType type, bool normalized, int stride, int offset)
        {
            VertexAttribPointer(index, size, type, normalized, stride, (IntPtr)offset);
        }

        public void DrawElements(BeginMode mode, int count, DrawElementsType type, int offset)
        {
            DrawElements((PrimitiveType)mode, count, type, new IntPtr(offset));
        }

        public void GetFloat(GetPName pname, out Vector2 vector)
        {
            unsafe
            {
                fixed (Vector2* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public void GetFloat(GetPName pname, out Vector3 vector)
        {
            unsafe
            {
                fixed (Vector3* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public void GetFloat(GetPName pname, out Vector4 vector)
        {
            unsafe
            {
                fixed (Vector4* ptr = &vector)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public void GetFloat(GetPName pname, out Matrix4 matrix)
        {
            unsafe
            {
                fixed (Matrix4* ptr = &matrix)
                {
                    GetFloat(pname, (float*)ptr);
                }
            }
        }

        public void Viewport(Size size)
        {
            Viewport(0, 0, size.Width, size.Height);
        }

        public void Viewport(Point location, Size size)
        {
            Viewport(location.X, location.Y, size.Width, size.Height);
        }

        public void Viewport(Rectangle rectangle)
        {
            Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
#if MINIMAL
        public void Viewport(OpenTK.Point location, OpenTK.Size size)
        {
            Viewport(location.X, location.Y, size.Width, size.Height);
        }

        public void Viewport(OpenTK.Rectangle rectangle)
        {
            Viewport(rectangle.X, rectangle.Y, rectangle.Width, rectangle.Height);
        }
    }
}
