using System;
using System.Collections.Generic;
using System.Drawing;
using System.Numerics;
using System.Runtime.CompilerServices;
using ImGuiNET;
using Silk.NET.Input.Common;
using Silk.NET.Input.Extensions;
using Silk.NET.OpenGL;
using Silk.NET.Windowing.Common;

namespace Ultz.SilkExtensions.ImGui.OpenGL
{
    public class ImGuiController : IDisposable
    {
        private readonly GL GL;
        private readonly IView _view;
        private readonly IInputContext _input;
        private bool _frameBegun;

        // OpenGL objects
        private uint _vertexArray;
        private uint _vertexBuffer;
        private uint _vertexBufferSize;
        private uint _indexBuffer;
        private uint _indexBufferSize;
        private Version _glVersion;

        private Texture _fontTexture;
        private Shader _shader;
        
        private int _windowWidth;
        private int _windowHeight;

        private System.Numerics.Vector2 _scaleFactor = System.Numerics.Vector2.One;

        /// <summary>
        /// Constructs a new ImGuiController.
        /// </summary>
        public ImGuiController(GL gl, IView view, IInputContext input)
        {
            GL = gl;
            _glVersion = new Version(gl.GetInteger(GLEnum.MajorVersion), gl.GetInteger(GLEnum.MinorVersion));
            _view = view;
            _input = input;
            _windowWidth = view.Size.Width;
            _windowHeight = view.Size.Height;

            IntPtr context = ImGuiNET.ImGui.CreateContext();
            ImGuiNET.ImGui.SetCurrentContext(context);
            var io = ImGuiNET.ImGui.GetIO();
            io.Fonts.AddFontDefault();

            io.BackendFlags |= ImGuiBackendFlags.RendererHasVtxOffset;

            CreateDeviceResources();
            SetKeyMappings();

            SetPerFrameImGuiData(1f / 60f);

            ImGuiNET.ImGui.NewFrame();
            _frameBegun = true;
            _keyboard = _input.Keyboards[0];
            _view.Resize += WindowResized;
            _keyboard.KeyChar += OnKeyChar;
        }

        private void OnKeyChar(IKeyboard arg1, char arg2)
        {
            PressedChars.Add(arg2);
        }

        private void WindowResized(Size s)
        {
            _windowWidth = s.Width;
            _windowHeight = s.Height;
        }

        public void DestroyDeviceObjects()
        {
            Dispose();
        }

        public unsafe void CreateDeviceResources()
        {
            GL.CreateVertexArray("ImGui", out _vertexArray);

            _vertexBufferSize = 10000;
            _indexBufferSize = 2000;

            GL.CreateVertexBuffer("ImGui", out _vertexBuffer);
            GL.CreateElementBuffer("ImGui", out _indexBuffer);
            GL.NamedBufferData(_vertexBuffer, _vertexBufferSize, null, VertexBufferObjectUsage.DynamicDraw);
            GL.NamedBufferData(_indexBuffer, _indexBufferSize, null, VertexBufferObjectUsage.DynamicDraw);

            RecreateFontDeviceTexture();

            string VertexSource = @"#version 330 core

uniform mat4 projection_matrix;

in vec2 in_position;
in vec2 in_texCoord;
in vec4 in_color;

out vec4 color;
out vec2 texCoord;

void main()
{
    gl_Position = projection_matrix * vec4(in_position, 0, 1);
    color = in_color;
    texCoord = in_texCoord;
}";
            string FragmentSource = @"#version 330 core

uniform sampler2D in_fontTexture;

in vec4 color;
in vec2 texCoord;

out vec4 outputColor;

void main()
{
    outputColor = color * texture(in_fontTexture, texCoord);
}";
            _shader = new Shader(GL, "ImGui", VertexSource, FragmentSource);

            GL.VertexArrayVertexBuffer(_vertexArray, 0, _vertexBuffer, IntPtr.Zero, (uint)Unsafe.SizeOf<ImDrawVert>());
            GL.VertexArrayElementBuffer(_vertexArray, _indexBuffer);

            GL.EnableVertexArrayAttrib(_vertexArray, 0);
            GL.VertexArrayAttribBinding(_vertexArray, 0, 0);
            GL.VertexArrayAttribFormat(_vertexArray, 0, 2, VertexAttribType.Float, false, 0);

            GL.EnableVertexArrayAttrib(_vertexArray, 1);
            GL.VertexArrayAttribBinding(_vertexArray, 1, 0);
            GL.VertexArrayAttribFormat(_vertexArray, 1, 2, VertexAttribType.Float, false, 8);

            GL.EnableVertexArrayAttrib(_vertexArray, 2);
            GL.VertexArrayAttribBinding(_vertexArray, 2, 0);
            GL.VertexArrayAttribFormat(_vertexArray, 2, 4, VertexAttribType.UnsignedByte, true, 16);

            GL.CheckGLError("End of ImGui setup");
        }

        /// <summary>
        /// Recreates the device texture used to render text.
        /// </summary>
        public void RecreateFontDeviceTexture()
        {
            ImGuiIOPtr io = ImGuiNET.ImGui.GetIO();
            io.Fonts.GetTexDataAsRGBA32(out IntPtr pixels, out int width, out int height, out int bytesPerPixel);

            _fontTexture = new Texture(GL, "ImGui Text Atlas", width, height, pixels);
            _fontTexture.SetMagFilter(TextureMagFilter.Linear);
            _fontTexture.SetMinFilter(TextureMinFilter.Linear);
            
            io.Fonts.SetTexID((IntPtr)_fontTexture.GLTexture);

            io.Fonts.ClearTexData();
        }

        /// <summary>
        /// Renders the ImGui draw list data.
        /// This method requires a <see cref="GraphicsDevice"/> because it may create new DeviceBuffers if the size of vertex
        /// or index data has increased beyond the capacity of the existing buffers.
        /// A <see cref="CommandList"/> is needed to submit drawing and resource update commands.
        /// </summary>
        public void Render()
        {
            if (_frameBegun)
            {
                _frameBegun = false;
                ImGuiNET.ImGui.Render();
                RenderImDrawData(ImGuiNET.ImGui.GetDrawData());
            }
        }

        /// <summary>
        /// Updates ImGui input and IO configuration state.
        /// </summary>
        public void Update(float deltaSeconds)
        {
            if (_frameBegun)
            {
                ImGuiNET.ImGui.Render();
            }

            SetPerFrameImGuiData(deltaSeconds);
            UpdateImGuiInput();

            _frameBegun = true;
            ImGuiNET.ImGui.NewFrame();
        }

        /// <summary>
        /// Sets per-frame data based on the associated window.
        /// This is called by Update(float).
        /// </summary>
        private void SetPerFrameImGuiData(float deltaSeconds)
        {
            ImGuiIOPtr io = ImGuiNET.ImGui.GetIO();
            io.DisplaySize = new System.Numerics.Vector2(
                _windowWidth / _scaleFactor.X,
                _windowHeight / _scaleFactor.Y);
            io.DisplayFramebufferScale = _scaleFactor;
            io.DeltaTime = deltaSeconds; // DeltaTime is in seconds.
        }

        MouseState PrevMouseState;
        readonly List<char> PressedChars = new List<char>();
        private IKeyboard _keyboard;

        private void UpdateImGuiInput()
        {
            ImGuiIOPtr io = ImGuiNET.ImGui.GetIO();

            MouseState MouseState = _input.Mice[0].CaptureState();
            var KeyboardState = _input.Keyboards[0];

            io.MouseDown[0] = MouseState.IsButtonPressed(MouseButton.Left);
            io.MouseDown[1] = MouseState.IsButtonPressed(MouseButton.Right);
            io.MouseDown[2] = MouseState.IsButtonPressed(MouseButton.Middle);

            var point = new System.Drawing.Point((int) MouseState.Position.X, (int) MouseState.Position.Y);
            //var screenPoint = new System.Drawing.Point((int) MouseState.Position.X, (int) MouseState.Position.Y);
            //var point = _view.PointToClient(screenPoint);
            io.MousePos = new System.Numerics.Vector2(point.X, point.Y);

            //var wheel = MouseState.GetScrollWheels()[0];
            //var prevWheel = PrevMouseState?.GetScrollWheels()[0] ?? default;
            //io.MouseWheel = wheel.Y - prevWheel.Y;
            //io.MouseWheelH = wheel.X - prevWheel.X;
            var wheel = MouseState.GetScrollWheels()[0];
            io.MouseWheel = wheel.Y;
            io.MouseWheelH = wheel.X;
            
            foreach (Key key in Enum.GetValues(typeof(Key)))
            {
                if (key == Key.Unknown)
                {
                    continue;
                }
                io.KeysDown[(int)key] = KeyboardState.IsKeyPressed(key);
            }

            foreach (var c in PressedChars)
            {
                io.AddInputCharacter(c);
            }
            PressedChars.Clear();

            io.KeyCtrl = KeyboardState.IsKeyPressed(Key.ControlLeft) || KeyboardState.IsKeyPressed(Key.ControlRight);
            io.KeyAlt = KeyboardState.IsKeyPressed(Key.AltLeft) || KeyboardState.IsKeyPressed(Key.AltRight);
            io.KeyShift = KeyboardState.IsKeyPressed(Key.ShiftLeft) || KeyboardState.IsKeyPressed(Key.ShiftRight);
            io.KeySuper = KeyboardState.IsKeyPressed(Key.SuperLeft) || KeyboardState.IsKeyPressed(Key.SuperRight);

            PrevMouseState = MouseState;
        }


        internal void PressChar(char keyChar)
        {
            PressedChars.Add(keyChar);
        }

        private static void SetKeyMappings()
        {
            ImGuiIOPtr io = ImGuiNET.ImGui.GetIO();
            io.KeyMap[(int)ImGuiKey.Tab] = (int)Key.Tab;
            io.KeyMap[(int)ImGuiKey.LeftArrow] = (int)Key.Left;
            io.KeyMap[(int)ImGuiKey.RightArrow] = (int)Key.Right;
            io.KeyMap[(int)ImGuiKey.UpArrow] = (int)Key.Up;
            io.KeyMap[(int)ImGuiKey.DownArrow] = (int)Key.Down;
            io.KeyMap[(int)ImGuiKey.PageUp] = (int)Key.PageUp;
            io.KeyMap[(int)ImGuiKey.PageDown] = (int)Key.PageDown;
            io.KeyMap[(int)ImGuiKey.Home] = (int)Key.Home;
            io.KeyMap[(int)ImGuiKey.End] = (int)Key.End;
            io.KeyMap[(int)ImGuiKey.Delete] = (int)Key.Delete;
            io.KeyMap[(int)ImGuiKey.Backspace] = (int)Key.Backspace;
            io.KeyMap[(int)ImGuiKey.Enter] = (int)Key.Enter;
            io.KeyMap[(int)ImGuiKey.Escape] = (int)Key.Escape;
            io.KeyMap[(int)ImGuiKey.A] = (int)Key.A;
            io.KeyMap[(int)ImGuiKey.C] = (int)Key.C;
            io.KeyMap[(int)ImGuiKey.V] = (int)Key.V;
            io.KeyMap[(int)ImGuiKey.X] = (int)Key.X;
            io.KeyMap[(int)ImGuiKey.Y] = (int)Key.Y;
            io.KeyMap[(int)ImGuiKey.Z] = (int)Key.Z;
        }

        private unsafe void RenderImDrawData(ImDrawDataPtr draw_data)
        {
            uint vertexOffsetInVertices = 0;
            uint indexOffsetInElements = 0;

            if (draw_data.CmdListsCount == 0)
            {
                return;
            }

            uint totalVBSize = (uint)(draw_data.TotalVtxCount * Unsafe.SizeOf<ImDrawVert>());
            if (totalVBSize > _vertexBufferSize)
            {
                int newSize = (int)Math.Max(_vertexBufferSize * 1.5f, totalVBSize);
                GL.NamedBufferData(_vertexBuffer, (uint) newSize, null, VertexBufferObjectUsage.DynamicDraw);
                _vertexBufferSize = (uint) newSize;

                if (_glVersion >= new Version(4, 3))
                {
                    var str = $"Silk.NET ImGui: Resized vertex buffer to new size {_vertexBufferSize}";
                    GL.DebugMessageInsert(DebugSource.DebugSourceApi, DebugType.DontCare, 1879701u, DebugSeverity.DebugSeverityNotification, (uint)str.Length, str);
                }
            }

            uint totalIBSize = (uint)(draw_data.TotalIdxCount * sizeof(ushort));
            if (totalIBSize > _indexBufferSize)
            {
                int newSize = (int)Math.Max(_indexBufferSize * 1.5f, totalIBSize);
                GL.NamedBufferData(_indexBuffer, (uint) newSize, null, VertexBufferObjectUsage.DynamicDraw);
                _indexBufferSize = (uint) newSize;

                if (_glVersion >= new Version(4, 3))
                {
                    var str = $"Silk.NET ImGui: Resized index buffer to new size {_indexBufferSize}";
                    GL.DebugMessageInsert(DebugSource.DebugSourceApi, DebugType.DontCare, 1879702u, DebugSeverity.DebugSeverityNotification, (uint)str.Length, str);
                }
            }


            for (int i = 0; i < draw_data.CmdListsCount; i++)
            {
                ImDrawListPtr cmd_list = draw_data.CmdListsRange[i];

                GL.NamedBufferSubData(_vertexBuffer, (IntPtr)(vertexOffsetInVertices * Unsafe.SizeOf<ImDrawVert>()), (UIntPtr)(cmd_list.VtxBuffer.Size * Unsafe.SizeOf<ImDrawVert>()), (void*)cmd_list.VtxBuffer.Data);
                GL.CheckGLError($"Data Vert {i}");
                GL.NamedBufferSubData(_indexBuffer, (IntPtr)(indexOffsetInElements * sizeof(ushort)), (UIntPtr)(cmd_list.IdxBuffer.Size * sizeof(ushort)), (void*)cmd_list.IdxBuffer.Data);

                GL.CheckGLError($"Data Idx {i}");

                vertexOffsetInVertices += (uint)cmd_list.VtxBuffer.Size;
                indexOffsetInElements += (uint)cmd_list.IdxBuffer.Size;
            }

            // Setup orthographic projection matrix into our constant buffer
            ImGuiIOPtr io = ImGuiNET.ImGui.GetIO();
            Matrix4x4 mvp = Matrix4x4.CreateOrthographicOffCenter(
                -1.0f,
                io.DisplaySize.X,
                io.DisplaySize.Y,
                0.0f,
                -1.0f,
                1.0f);

            _shader.UseShader();
            GL.ProgramUniformMatrix4(_shader.Program, _shader.GetUniformLocation("projection_matrix"), 1, false,
                (float*) Unsafe.AsPointer(ref mvp));
            GL.ProgramUniform1(_shader.Program, _shader.GetUniformLocation("in_fontTexture"), 0);
            GL.CheckGLError("Projection");

            GL.BindVertexArray(_vertexArray);
            GL.CheckGLError("VAO");

            draw_data.ScaleClipRects(io.DisplayFramebufferScale);

            GL.Enable(EnableCap.Blend);
            GL.Enable(EnableCap.ScissorTest);
            GL.BlendEquation(BlendEquationModeEXT.FuncAdd);
            GL.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            GL.Disable(EnableCap.CullFace);
            GL.Disable(EnableCap.DepthTest);

            // Render command lists
            int vtx_offset = 0;
            int idx_offset = 0;
            for (int n = 0; n < draw_data.CmdListsCount; n++)
            {
                ImDrawListPtr cmd_list = draw_data.CmdListsRange[n];
                for (int cmd_i = 0; cmd_i < cmd_list.CmdBuffer.Size; cmd_i++)
                {
                    ImDrawCmdPtr pcmd = cmd_list.CmdBuffer[cmd_i];
                    if (pcmd.UserCallback != IntPtr.Zero)
                    {
                        throw new NotImplementedException();
                    }
                    else
                    {
                        GL.ActiveTexture(TextureUnit.Texture0);
                        GL.BindTexture(TextureTarget.Texture2D, (uint)pcmd.TextureId);
                        GL.CheckGLError("Texture");

                        // We do _windowHeight - (int)clip.W instead of (int)clip.Y because gl has flipped Y when it comes to these coordinates
                        var clip = pcmd.ClipRect;
                        GL.Scissor((int)clip.X, _windowHeight - (int)clip.W, (uint)(clip.Z - clip.X), (uint)(clip.W - clip.Y));
                        GL.CheckGLError("Scissor");

                        GL.DrawElementsBaseVertex(PrimitiveType.Triangles, (uint)pcmd.ElemCount, DrawElementsType.UnsignedShort, (void*)(idx_offset * sizeof(ushort)), vtx_offset);
                        GL.CheckGLError("Draw");
                    }

                    idx_offset += (int)pcmd.ElemCount;
                }
                vtx_offset += cmd_list.VtxBuffer.Size;
            }

            GL.Disable(EnableCap.Blend);
            GL.Disable(EnableCap.ScissorTest);
        }

        /// <summary>
        /// Frees all graphics resources used by the renderer.
        /// </summary>
        public void Dispose()
        {
            _view.Resize -= WindowResized;
            _keyboard.KeyChar -= OnKeyChar;
            _fontTexture.Dispose();
            _shader.Dispose();
        }
    }
}
