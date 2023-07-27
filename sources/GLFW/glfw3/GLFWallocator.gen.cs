// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Ported from glfw3.h and corresponding dependencies of GLFW3
// Original source is Copyright © 2002-2006 Marcus Geelnard, 2006-2019 Camilla Löwy. Licensed under the zlib license.

namespace Silk.NET.GLFW{
    public unsafe partial struct GLFWallocator
    {
        [NativeTypeName("GLFWallocatefun")]
        public delegate* unmanaged<nuint, void*, void*> allocate;

        [NativeTypeName("GLFWreallocatefun")]
        public delegate* unmanaged<void*, nuint, void*, void*> reallocate;

        [NativeTypeName("GLFWdeallocatefun")]
        public delegate* unmanaged<void*, void*, void> deallocate;

        public void* user;
    }
}
