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

namespace Ultz.SilkExtensions.ImGui
{
    public class ImGuiController : IDisposable
    {
        private readonly GL _gl;
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
            _gl = gl;
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
            _pressedChars.Add(arg2);
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

        private unsafe void CreateDeviceResources()
        {
            _gl.CreateVertexArray("ImGui", out _vertexArray);

            _vertexBufferSize = 10000;
            _indexBufferSize = 2000;

            _gl.CreateVertexBuffer("ImGui", out _vertexBuffer);
            _gl.CreateElementBuffer("ImGui", out _indexBuffer);
            _gl.NamedBufferData(_vertexBuffer, _vertexBufferSize, null, VertexBufferObjectUsage.DynamicDraw);
            _gl.NamedBufferData(_indexBuffer, _indexBufferSize, null, VertexBufferObjectUsage.DynamicDraw);

            RecreateFontDeviceTexture();

            string vertexSource = @"#version 330 core

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
            string fragmentSource = @"#version 330 core

uniform sampler2D in_fontTexture;

in vec4 color;
in vec2 texCoord;

out vec4 outputColor;

void main()
{
    outputColor = color * texture(in_fontTexture, texCoord);
}";
            _shader = new Shader(_gl, "ImGui", vertexSource, fragmentSource);

            _gl.VertexArrayVertexBuffer(_vertexArray, 0, _vertexBuffer, IntPtr.Zero, (uint)Unsafe.SizeOf<ImDrawVert>());
            _gl.VertexArrayElementBuffer(_vertexArray, _indexBuffer);

            _gl.EnableVertexArrayAttrib(_vertexArray, 0);
            _gl.VertexArrayAttribBinding(_vertexArray, 0, 0);
            _gl.VertexArrayAttribFormat(_vertexArray, 0, 2, VertexAttribType.Float, false, 0);

            _gl.EnableVertexArrayAttrib(_vertexArray, 1);
            _gl.VertexArrayAttribBinding(_vertexArray, 1, 0);
            _gl.VertexArrayAttribFormat(_vertexArray, 1, 2, VertexAttribType.Float, false, 8);

            _gl.EnableVertexArrayAttrib(_vertexArray, 2);
            _gl.VertexArrayAttribBinding(_vertexArray, 2, 0);
            _gl.VertexArrayAttribFormat(_vertexArray, 2, 4, VertexAttribType.UnsignedByte, true, 16);

            _gl.CheckGlError("End of ImGui setup");
        }

        /// <summary>
        /// Recreates the device texture used to render text.
        /// </summary>
        private void RecreateFontDeviceTexture()
        {
            ImGuiIOPtr io = ImGuiNET.ImGui.GetIO();
            io.Fonts.GetTexDataAsRGBA32(out IntPtr pixels, out int width, out int height, out int bytesPerPixel);

            _fontTexture = new Texture(_gl, "ImGui Text Atlas", width, height, pixels);
            _fontTexture.SetMagFilter(TextureMagFilter.Linear);
            _fontTexture.SetMinFilter(TextureMinFilter.Linear);
            
            io.Fonts.SetTexID((IntPtr)_fontTexture.GlTexture);

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

        MouseState _prevMouseState;
        readonly List<char> _pressedChars = new List<char>();
        private IKeyboard _keyboard;

        private void UpdateImGuiInput()
        {
            ImGuiIOPtr io = ImGuiNET.ImGui.GetIO();

            MouseState mouseState = _input.Mice[0].CaptureState();
            var keyboardState = _input.Keyboards[0];

            io.MouseDown[0] = mouseState.IsButtonPressed(MouseButton.Left);
            io.MouseDown[1] = mouseState.IsButtonPressed(MouseButton.Right);
            io.MouseDown[2] = mouseState.IsButtonPressed(MouseButton.Middle);

            var point = new System.Drawing.Point((int) mouseState.Position.X, (int) mouseState.Position.Y);
            //var screenPoint = new System.Drawing.Point((int) MouseState.Position.X, (int) MouseState.Position.Y);
            //var point = _view.PointToClient(screenPoint);
            io.MousePos = new System.Numerics.Vector2(point.X, point.Y);

            //var wheel = MouseState.GetScrollWheels()[0];
            //var prevWheel = PrevMouseState?.GetScrollWheels()[0] ?? default;
            //io.MouseWheel = wheel.Y - prevWheel.Y;
            //io.MouseWheelH = wheel.X - prevWheel.X;
            var wheel = mouseState.GetScrollWheels()[0];
            io.MouseWheel = wheel.Y;
            io.MouseWheelH = wheel.X;
            
            foreach (Key key in Enum.GetValues(typeof(Key)))
            {
                if (key == Key.Unknown)
                {
                    continue;
                }
                io.KeysDown[(int)key] = keyboardState.IsKeyPressed(key);
            }

            foreach (var c in _pressedChars)
            {
                io.AddInputCharacter(c);
            }
            _pressedChars.Clear();

            io.KeyCtrl = keyboardState.IsKeyPressed(Key.ControlLeft) || keyboardState.IsKeyPressed(Key.ControlRight);
            io.KeyAlt = keyboardState.IsKeyPressed(Key.AltLeft) || keyboardState.IsKeyPressed(Key.AltRight);
            io.KeyShift = keyboardState.IsKeyPressed(Key.ShiftLeft) || keyboardState.IsKeyPressed(Key.ShiftRight);
            io.KeySuper = keyboardState.IsKeyPressed(Key.SuperLeft) || keyboardState.IsKeyPressed(Key.SuperRight);

            _prevMouseState = mouseState;
        }


        internal void PressChar(char keyChar)
        {
            _pressedChars.Add(keyChar);
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

        private unsafe void RenderImDrawData(ImDrawDataPtr drawData)
        {
            uint vertexOffsetInVertices = 0;
            uint indexOffsetInElements = 0;

            if (drawData.CmdListsCount == 0)
            {
                return;
            }

            uint totalVbSize = (uint)(drawData.TotalVtxCount * Unsafe.SizeOf<ImDrawVert>());
            if (totalVbSize > _vertexBufferSize)
            {
                int newSize = (int)Math.Max(_vertexBufferSize * 1.5f, totalVbSize);
                _gl.NamedBufferData(_vertexBuffer, (uint) newSize, null, VertexBufferObjectUsage.DynamicDraw);
                _vertexBufferSize = (uint) newSize;

                if (_glVersion >= new Version(4, 3))
                {
                    var str = $"Silk.NET ImGui: Resized vertex buffer to new size {_vertexBufferSize}";
                    _gl.DebugMessageInsert(DebugSource.DebugSourceApi, DebugType.DontCare, 1879701u, DebugSeverity.DebugSeverityNotification, (uint)str.Length, str);
                }
            }

            uint totalIbSize = (uint)(drawData.TotalIdxCount * sizeof(ushort));
            if (totalIbSize > _indexBufferSize)
            {
                int newSize = (int)Math.Max(_indexBufferSize * 1.5f, totalIbSize);
                _gl.NamedBufferData(_indexBuffer, (uint) newSize, null, VertexBufferObjectUsage.DynamicDraw);
                _indexBufferSize = (uint) newSize;

                if (_glVersion >= new Version(4, 3))
                {
                    var str = $"Silk.NET ImGui: Resized index buffer to new size {_indexBufferSize}";
                    _gl.DebugMessageInsert(DebugSource.DebugSourceApi, DebugType.DontCare, 1879702u, DebugSeverity.DebugSeverityNotification, (uint)str.Length, str);
                }
            }


            for (int i = 0; i < drawData.CmdListsCount; i++)
            {
                ImDrawListPtr cmdList = drawData.CmdListsRange[i];

                _gl.NamedBufferSubData(_vertexBuffer, (IntPtr)(vertexOffsetInVertices * Unsafe.SizeOf<ImDrawVert>()), (UIntPtr)(cmdList.VtxBuffer.Size * Unsafe.SizeOf<ImDrawVert>()), (void*)cmdList.VtxBuffer.Data);
                _gl.CheckGlError($"Data Vert {i}");
                _gl.NamedBufferSubData(_indexBuffer, (IntPtr)(indexOffsetInElements * sizeof(ushort)), (UIntPtr)(cmdList.IdxBuffer.Size * sizeof(ushort)), (void*)cmdList.IdxBuffer.Data);

                _gl.CheckGlError($"Data Idx {i}");

                vertexOffsetInVertices += (uint)cmdList.VtxBuffer.Size;
                indexOffsetInElements += (uint)cmdList.IdxBuffer.Size;
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
            _gl.ProgramUniformMatrix4(_shader.Program, _shader.GetUniformLocation("projection_matrix"), 1, false,
                (float*) Unsafe.AsPointer(ref mvp));
            _gl.ProgramUniform1(_shader.Program, _shader.GetUniformLocation("in_fontTexture"), 0);
            _gl.CheckGlError("Projection");

            _gl.BindVertexArray(_vertexArray);
            _gl.CheckGlError("VAO");

            drawData.ScaleClipRects(io.DisplayFramebufferScale);

            _gl.Enable(EnableCap.Blend);
            _gl.Enable(EnableCap.ScissorTest);
            _gl.BlendEquation(BlendEquationModeEXT.FuncAdd);
            _gl.BlendFunc(BlendingFactor.SrcAlpha, BlendingFactor.OneMinusSrcAlpha);
            _gl.Disable(EnableCap.CullFace);
            _gl.Disable(EnableCap.DepthTest);

            // Render command lists
            int vtxOffset = 0;
            int idxOffset = 0;
            for (int n = 0; n < drawData.CmdListsCount; n++)
            {
                ImDrawListPtr cmdList = drawData.CmdListsRange[n];
                for (int cmdI = 0; cmdI < cmdList.CmdBuffer.Size; cmdI++)
                {
                    ImDrawCmdPtr pcmd = cmdList.CmdBuffer[cmdI];
                    if (pcmd.UserCallback != IntPtr.Zero)
                    {
                        throw new NotImplementedException();
                    }
                    else
                    {
                        _gl.ActiveTexture(TextureUnit.Texture0);
                        _gl.BindTexture(TextureTarget.Texture2D, (uint)pcmd.TextureId);
                        _gl.CheckGlError("Texture");

                        // We do _windowHeight - (int)clip.W instead of (int)clip.Y because gl has flipped Y when it comes to these coordinates
                        var clip = pcmd.ClipRect;
                        _gl.Scissor((int)clip.X, _windowHeight - (int)clip.W, (uint)(clip.Z - clip.X), (uint)(clip.W - clip.Y));
                        _gl.CheckGlError("Scissor");

                        _gl.DrawElementsBaseVertex(PrimitiveType.Triangles, (uint)pcmd.ElemCount, DrawElementsType.UnsignedShort, (void*)(idxOffset * sizeof(ushort)), vtxOffset);
                        _gl.CheckGlError("Draw");
                    }

                    idxOffset += (int)pcmd.ElemCount;
                }
                vtxOffset += cmdList.VtxBuffer.Size;
            }

            _gl.Disable(EnableCap.Blend);
            _gl.Disable(EnableCap.ScissorTest);
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
