// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.Serialization;

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Represents errors that occur within GLFW.
    /// </summary>
    [Serializable]
    public class GLFWException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GLFWException" /> class.
        /// </summary>
        public GLFWException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLFWException" /> class with the specified detailed description.
        /// </summary>
        /// <param name="message">A detailed description of the error.</param>
        public GLFWException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLFWException" /> class with the specified detailed description
        /// and the specified exception.
        /// </summary>
        /// <param name="message">A detailed description of the error.</param>
        /// <param name="innerException">A reference to the inner exception that is the cause of this exception.</param>
        public GLFWException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GLFWException" /> class with the specified context
        /// and the serialization information.
        /// </summary>
        /// <param name="info">The <see cref="SerializationInfo" /> associated with this exception.</param>
        /// <param name="context">
        /// A <see cref="StreamingContext" /> that represents the context of this exception.
        /// </param>
        protected GLFWException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Gets or sets the underlying GLFW-error code.
        /// </summary>
        public ErrorCode ErrorCode { get; set; }
    }
}