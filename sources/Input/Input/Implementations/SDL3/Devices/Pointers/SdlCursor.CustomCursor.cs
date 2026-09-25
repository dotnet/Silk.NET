// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Diagnostics;
using System.Runtime.InteropServices;
using Silk.NET.SDL;

namespace Silk.NET.Input.SDL3.Devices.Pointers;

internal unsafe partial class SdlCursor
{
    private struct CustomCursorSdl
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public bool Exists => _cursorHandle != default;
        public CursorHandle CursorHandle => _cursorHandle;

        public ReadOnlySpan<int> ImageData => _imagePtr == null
            ? default
            : new ReadOnlySpan<int>(_imagePtr, Width * Height);

        private Surface* _surface;
        private int* _imagePtr;
        private int _allocCapacity;
        private CursorHandle _cursorHandle;

        public void Free(ISdl sdl)
        {
            DisposeCursor(ref _cursorHandle, sdl);

            if (_surface != null)
            {
                sdl.DestroySurface(_surface);
                _surface = null;
            }

            if (_imagePtr != null)
            {
                NativeMemory.Free(_imagePtr);
                _imagePtr = null;
                _allocCapacity = 0;
                Width = 0;
                Height = 0;
            }
        }

        public bool PrepareCursorWith(ref readonly CustomCursor userCursor, ISdl sdl)
        {
            var width = userCursor.Width;
            var height = userCursor.Height;
            var pixelCount = width * height;
            if (pixelCount == 0)
            {
                InputLog.Error("Cannot create a cursor image with 0 pixels");
                return false;
            }

            var pixelsUser = userCursor.Data;
            if (pixelsUser.Length < pixelCount)
            {
                InputLog.Error($"Custom cursor image of size ({width}, {height}) " +
                                            $"must be at least {pixelCount} pixels long, " +
                                            $"got {pixelsUser.Length} pixels instead");
                return false;
            }

            if (pixelsUser.Length > pixelCount)
            {
                InputLog.Warn("Provided more cursor pixels than width/height suggests. Expect rendering issues if this " +
                              "was not intentional.");
            }

            if (!EnsureSurfaceCreated(sdl, width, height, in _surface, out var newSurface))
            {
                return false;
            }

            pixelsUser = pixelsUser[..pixelCount];

            // copy to sdl surface
            var pixelsSurface = new Span<int>(newSurface->Pixels, pixelCount);
            pixelsUser.CopyTo(pixelsSurface);

            // create our cursor
            var newHandle = sdl.CreateColorCursor(surface: newSurface, hot_x: 0, hot_y: 0);
            if (newHandle == default)
            {
                SdlLog.Error("Failed to create a cursor image");
                sdl.DestroySurface(newSurface);
                return false;
            }

            // replace our old surface
            if (_cursorHandle != default)
            {
                DisposeCursor(ref _cursorHandle, sdl);
            }

            _cursorHandle = newHandle;

            // replace our old surface if we're not re-using it
            if (_surface != newSurface)
            {
                if (_surface != null)
                {
                    sdl.DestroySurface(_surface);
                }

                _surface = newSurface;
            }

            // apply data to our fields
            _cursorHandle = newHandle;
            Width = width;
            Height = height;

            var pixelsCopy = Allocate(width, height, ref _allocCapacity, ref _imagePtr);
            pixelsUser.CopyTo(pixelsCopy);

            return true;

            static Span<int> Allocate(int width, int height, ref int allocCapacity, ref int* imagePtr)
            {
                var necessaryPixelCount = height * width;

                var byteCount = necessaryPixelCount * 4;
                if (byteCount > allocCapacity)
                {
                    if (imagePtr == null)
                    {
                        imagePtr = (int*)NativeMemory.Alloc((nuint)byteCount);
                    }
                    else
                    {
                        imagePtr = (int*)NativeMemory.Realloc(imagePtr, (nuint)byteCount);
                    }

                    allocCapacity = byteCount;
                }

                Debug.Assert(imagePtr != null, "Unexpected null image ptr");
                return new Span<int>(imagePtr, width * height);
            }

            static bool EnsureSurfaceCreated(ISdl sdl, int width, int height, in Surface* currentSurface, out Surface* newSurface)
            {
                if (currentSurface != null && currentSurface->H == height && currentSurface->W == width)
                {
                    // we can reuse the same surface
                    newSurface = currentSurface;
                    return true;
                }

                // we need to create a new one
                newSurface = sdl.CreateSurfaceRaw(width, height, PixelFormat.Rgba32);
                if (newSurface == null)
                {
                    SdlLog.Error("Failed to create cursor surface");
                    return false;
                }

                return true;
            }
        }
    }
}
