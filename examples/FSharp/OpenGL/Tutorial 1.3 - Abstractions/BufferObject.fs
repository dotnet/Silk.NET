#nowarn "9"
namespace Tutorial

open Microsoft.FSharp.NativeInterop
open Silk.NET.OpenGL

type BufferObject = {
    gl: GL
    handle: uint32
    bufferType: GLEnum
}

module BufferObject =
    let bind (bufferObject: BufferObject) =
        bufferObject.gl.BindBuffer(bufferObject.bufferType, bufferObject.handle)


    let create (gl: GL) (data: 'DataType[]) (bufferType: GLEnum) =
        use ptr = fixed data
        let voidPtr = NativePtr.toVoidPtr ptr
        let size = uint32 (data.Length * sizeof<DataType>)
        
        let handle = gl.GenBuffer()
        let bufferObject = {
            gl = gl
            handle = handle
            bufferType = bufferType
        }

        bind bufferObject
        gl.BufferData(bufferType, size, voidPtr, GLEnum.StaticDraw)

        bufferObject

    let destroy (bufferObject: BufferObject) =
        bufferObject.gl.DeleteBuffer(bufferObject.handle)
