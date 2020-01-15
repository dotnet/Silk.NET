namespace Tutorial

open Silk.NET.OpenGL

type VertexArrayObject = {
    gl: GL
    handle: uint32
}

module VertexArrayObject =
    let bind (vao: VertexArrayObject) =
        vao.gl.BindVertexArray(vao.handle)


    let create (gl: GL) vbo ebo =
        let handle = gl.GenVertexArray()
        let vao = {
            gl = gl
            handle = handle
        }

        bind vao
        BufferObject.bind vbo
        BufferObject.bind ebo
        vao


    let attributePointer index count (dataType: GLEnum) vertexSize offset vao =
        let typeSize =
            match dataType with
            | GLEnum.Float -> uint32 sizeof<float32>
            | GLEnum.UnsignedInt -> uint32 sizeof<uint32>
            | _ -> failwithf "attributePointer cannot set data of type: %A" dataType

        vao.gl.VertexAttribPointer(index, count, dataType, false, vertexSize * typeSize, offset * int typeSize)
        vao.gl.EnableVertexAttribArray(index)

    let destroy (vao: VertexArrayObject) =
        vao.gl.DeleteVertexArray(vao.handle)

