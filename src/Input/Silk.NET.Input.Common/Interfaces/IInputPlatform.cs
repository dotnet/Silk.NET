// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Windowing.Common;

namespace Silk.NET.Input.Common
{
    public interface IInputPlatform
    {
        bool IsApplicable(IWindow window);
        IInputContext GetInput(IWindow window);
    }
}