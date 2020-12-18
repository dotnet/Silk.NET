// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;

namespace Silk.NET.Core.Attributes
{
    /// <summary>
    /// An attribute specifying an inject point to be injected by SilkTouch.
    /// </summary>
    /// <remarks>See SilkTouch documentation.</remarks>
    /// <seealso cref="SilkTouchStage"/>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class InjectAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InjectAttribute"/> class.
        /// </summary>
        /// <param name="silkTouchStage">The stage at which to inject.</param>
        /// <param name="code">The code to inject.</param>
        public InjectAttribute(SilkTouchStage silkTouchStage, string code) { }
    }

    /// <summary>
    /// An enum indicating where to inject code to SilkTouch. DO NOT RELY ON NUMERIC VALUES.
    /// </summary>
    /// <remarks>See SilkTouch documentation.</remarks>
    /// <seealso cref="InjectAttribute"/>
    public enum SilkTouchStage
    {
        // NOTE: These ARE IN ORDER. SilkTouch verifies correct ordering via the oder they are typed here.
        
        /// <summary>
        /// No stage. Default value.
        /// </summary>
        None = 0,
        /// <summary>
        /// The start of the pipeline.
        /// </summary>
        Begin,
        /// <summary>
        /// After basic values have been initialized.
        /// </summary>
        PostInit,
        /// <summary>
        /// After pinning occurs.
        /// </summary>
        /// <remarks>Currently there is no PostRelease or similar (that would occur after pins have been released), since SilkTouch currently never closes blocks.</remarks>
        PostPin,
        /// <summary>
        /// Just before loading.
        /// </summary>
        PreLoad,
        /// <summary>
        /// Just after loading.
        /// </summary>
        PostLoad,
        /// <summary>
        /// The end of the pipeline.
        /// </summary>
        End
    }
}
