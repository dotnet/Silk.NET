// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using Android.App;
using Silk.NET.OpenGL;
using Silk.NET.Windowing;
using Silk.NET.Windowing.Sdl.Android;

namespace AndroidDemo
{
    /// <summary>
    /// Simple demo on how to use Silk on Android.
    /// The code used is mostly identical to the one on OpenGL Tutorial 1.4 - Textures.
    /// </summary>
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : SilkActivity
    {
        // Instead of IWindow, we use IView. 
        // IWindow inherits IView, so you can also use this with your desktop code.
        private static IView view;
        private static GL Gl;

        private static BufferObject<float> Vbo;
        private static BufferObject<uint> Ebo;
        private static VertexArrayObject<float, uint> Vao;
        //Create a texture object.
        private static Texture Texture;
        private static Shader Shader;

        private static readonly float[] Vertices =
        {
            //X    Y      Z     U   V
             0.5f,  0.5f, 0.0f, 1f, 0f,
             0.5f, -0.5f, 0.0f, 1f, 1f,
            -0.5f, -0.5f, 0.0f, 0f, 1f,
            -0.5f,  0.5f, 0.5f, 0f, 0f
        };

        private static readonly uint[] Indices =
        {
            0, 1, 3,
            1, 2, 3
        };

        /// <summary>
        /// This is where the application starts.
        /// Note that when using net6-android, you do not need to have a main method.
        /// </summary>
        protected override void OnRun()
        {
            // Included assets should be loaded with the help of Android.Content.Res.AssetManager.
            // The included example shaders and texture have build action of "AndroidAsset".
            FileManager.AssetManager = Assets;

            var options = ViewOptions.Default;
            // We need to tell Silk to use OpenGLES
            // Version 3.0 is supported by >90% of devices currently in use.
            // https://developer.android.com/about/dashboards#OpenGL
            options.API = new GraphicsAPI(ContextAPI.OpenGLES, ContextProfile.Compatability, ContextFlags.Default, new APIVersion(3, 0));
            view = Silk.NET.Windowing.Window.GetView(options); // note also GetView, instead of Window.Create.
            
            view.Load += OnLoad;
            view.Render += OnRender;
            view.Closing += OnClose;

            view.Run();

            view.Dispose();
        }

        private static unsafe void OnLoad()
        {
            Gl = GL.GetApi(view);

            Ebo = new BufferObject<uint>(Gl, Indices, BufferTargetARB.ElementArrayBuffer);
            Vbo = new BufferObject<float>(Gl, Vertices, BufferTargetARB.ArrayBuffer);
            Vao = new VertexArrayObject<float, uint>(Gl, Vbo, Ebo);

            Vao.VertexAttributePointer(0, 3, VertexAttribPointerType.Float, 5, 0);
            Vao.VertexAttributePointer(1, 2, VertexAttribPointerType.Float, 5, 3);

            Shader = new Shader(Gl, "shader.vert", "shader.frag");

            //Loading a texture.
            Texture = new Texture(Gl, "silk.png");
            Gl.ClearColor(1, 1, 1, 1);
        }

        private static unsafe void OnRender(double obj)
        {
            Gl.Clear((uint) ClearBufferMask.ColorBufferBit);

            Vao.Bind();
            Shader.Use();
            //Bind a texture and and set the uTexture0 to use texture0.
            Texture.Bind(TextureUnit.Texture0);
            Shader.SetUniform("uTexture0", 0);

            Gl.DrawElements(PrimitiveType.Triangles, (uint) Indices.Length, DrawElementsType.UnsignedInt, null);
        }

        private static void OnClose()
        {
            Vbo.Dispose();
            Ebo.Dispose();
            Vao.Dispose();
            Shader.Dispose();
            //Remember to dispose the texture.
            Texture.Dispose();
        }
    }
}