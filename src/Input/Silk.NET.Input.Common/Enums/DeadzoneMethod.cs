// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    public enum DeadzoneMethod
    {
        // y = x except where |x| is between 0 and d (the deadzone value)
        Traditional,
        // y = (1 - d)x + (d * sgn(x))
        AdaptiveGradient
    }
}