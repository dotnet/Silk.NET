// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Desktop
{
    internal interface IGlfwSubscriber
    {
        void Subscribe(GlfwEvents events);
        void Unsubscribe(GlfwEvents events);
    }
}
