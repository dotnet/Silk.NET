struct VertexOutputs {
    //The position of the vertex
    @builtin(position) position: vec4<f32>,
    //The texture cooridnate of the vertex
    @location(0) tex_coord: vec2<f32>
}

@group(1) @binding(0) var<uniform> projection_matrix: mat4x4<f32>;

@vertex
fn vs_main(
    @location(0) pos: vec2<f32>,
    @location(1) tex_coord: vec2<f32>
) -> VertexOutputs {
    var output: VertexOutputs;

    output.position = projection_matrix * vec4<f32>(pos, 0.0, 1.0);
    output.tex_coord = tex_coord;

    return output;
}

//The texture we're sampling
@group(0) @binding(0) var t: texture_2d<f32>;
//The sampler we're using to sample the texture
@group(0) @binding(1) var s: sampler;

@fragment
fn fs_main(input: VertexOutputs) -> @location(0) vec4<f32> {
    return textureSample(t, s, input.tex_coord);
}