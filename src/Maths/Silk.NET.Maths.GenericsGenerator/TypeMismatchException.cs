// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.

using System;
using System.Runtime.Serialization;

namespace GenericMathsGenerator
{
    public class TypeMismatchException : Exception
    {
        public TypeMismatchException() { }
        protected TypeMismatchException(SerializationInfo info, StreamingContext context) : base(info, context) { }
        public TypeMismatchException(string message) : base(message) { }
        public TypeMismatchException(string message, Exception innerException) : base(message, innerException) { }
    }
}
