// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

namespace Silk.NET.Input.Common
{
    /// <summary>
    /// Available methods to control the deadzone of a control stick.
    /// </summary>
    public enum DeadzoneMethod
    {
        /// <summary>
        /// The traditional deadzone method, where the reported value is directly proportional with the actual value until the actual value is within the deadzone - the reported value will be 0 in this case.
        /// </summary>
        /// <remarks>
        /// <para>
        /// y = x except where |x| is between 0 and d
        /// </para>
        /// <para>
        /// y is the output, x is the raw value, and d is the deadzone value.
        /// </para>
        /// </remarks>
        Traditional,

        /// <summary>
        /// A deadzone method where the reported value adapts to the range of the deadzone. If the value is within the deadzone, the reported value is 0.
        /// After exiting the deadzone, the reported value increases from 0 (when the actual value first exits the deadzone) to 1 (when the actual value is 1).
        /// </summary>
        /// <remarks>
        /// <para>
        /// y = (1 - d)x + (d * sgn(x))
        /// </para>
        /// <para>
        /// y is the output, x is the raw value, and d is the deadzone value.
        /// </para>
        /// </remarks>
        AdaptiveGradient
    }
}
