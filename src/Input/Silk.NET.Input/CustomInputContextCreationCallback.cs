// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using Silk.NET.Input.Common;
using Silk.NET.Windowing.Common;

namespace Silk.NET.Input
{
    public delegate bool CustomInputContextCreationCallback(IView view, out IInputContext context);
}
