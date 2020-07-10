/*
* Copyright (c) 2012-2014 AssimpNet - Nicholas Woodfield
* 
* Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
* The above copyright notice and this permission notice shall be included in
* all copies or substantial portions of the Software.
* 
* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
* THE SOFTWARE.
*/

namespace Silk.NET.Assimp
{
    /// <summary>
    /// Defines the desired file I/O mode is when opening a new file.
    /// </summary>
    public enum FileIOMode
    {
        /// <summary>
        /// Open the file for writing.
        /// </summary>
        Write = 0,

        /// <summary>
        /// Open the file for writing binary data to it.
        /// </summary>
        WriteBinary = 1,

        /// <summary>
        /// Open the file for writing text data to it.
        /// </summary>
        WriteText = 2,

        /// <summary>
        /// Open the file for reading.
        /// </summary>
        Read = 3,

        /// <summary>
        /// Open the file for reading binary data from it.
        /// </summary>
        ReadBinary = 4,

        /// <summary>
        /// Open the file for reading text data from it.
        /// </summary>
        ReadText = 5
    }
}