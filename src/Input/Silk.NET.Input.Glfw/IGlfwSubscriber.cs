// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input.Glfw
{
    internal interface IGlfwSubscriber
    {
        void Subscribe(GlfwEvents events);
        void Unsubscribe(GlfwEvents events);
    }
}
