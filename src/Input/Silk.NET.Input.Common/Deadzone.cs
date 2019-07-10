// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    public struct Deadzone
    {
        public float Value { get; }
        public DeadzoneMethod Method { get; }

        public Deadzone(float value, DeadzoneMethod method)
        {
            Value = value;
            Method = method;
        }
    }
}