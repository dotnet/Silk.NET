// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

#nullable enable

namespace Silk.NET.Core.Contexts
{
    public interface IGLContextSource
    {
        IGLContext? GLContext { get; }
    }
}
