using System;
using System.Numerics;
using Silk.NET.OpenGL;

namespace Silk.NET.OpenGL.Abstactions
{
    public class GLObject
    {
        public readonly float[] verts;
        public readonly uint[] indices;
        public BufferObject<float> Vbo;
        public BufferObject<uint> Ebo;
        public VertexArrayObject<float, uint> Vao;
        public Shader Shader;
        public GL Gl;
        public GLObject(GL Gl, float[] verts, uint[] indices)
        {
            this.verts = verts;
            this.indices = indices;
            this.Gl = Gl;
        }
        public void SetUniform(string name, int value)
        {
            Shader.SetUniform(name, value);
        }
        public unsafe void SetUniform(string name, Matrix4x4 value)
        {
            Shader.SetUniform(name, value);
        }
        public void SetUniform(string name, float value)
        {
            Shader.SetUniform(name, value);
        }
        public void CreateResources(string vertexPath, string fragmentPath)
        {
            Ebo = new BufferObject<uint>(Gl, new Span<uint>(indices), BufferTargetARB.ElementArrayBuffer);
            Vbo = new BufferObject<float>(Gl, verts, BufferTargetARB.ArrayBuffer);
            Vao = new VertexArrayObject<float, uint>(Gl, Vbo, Ebo);
            Vao.VertexAttributePointer(0, 3, VertexAttribPointerType.Float, 0, 0);
            Shader = new Shader(Gl, vertexPath, fragmentPath);
        }

        public void DisposeResources()
        {
            Vbo.Dispose();
            Ebo.Dispose();
            Vao.Dispose();
            Shader.Dispose();
        }

        public unsafe void Render()
        {
            Vao.Bind();
            Shader.Use();
            Gl.DrawElements(PrimitiveType.Triangles, (uint) indices.Length, DrawElementsType.UnsignedInt, null);
        }
    }
}
