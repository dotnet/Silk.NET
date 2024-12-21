const std = @import("std");
const fs = std.fs;

const vkd3d_folder = "../../../build/submodules/vkd3d/";
const vulkan_header_folder = "../../../build/submodules/Vulkan-Headers/";

pub fn build(b: *std.Build) void {
    const target = b.standardTargetOptions(.{});
    const optimize = b.standardOptimizeOption(.{});

    const vkd3d_compiler = b.addSharedLibrary(.{
        .name = "d3dcompile_vkd3d",
        .target = target,
        .optimize = optimize,
    });

    if (optimize != .Debug)
        vkd3d_compiler.root_module.strip = true;

    vkd3d_compiler.addLibraryPath(b.path("."));

    vkd3d_compiler.linkLibC();

    //Since we include vkd3d-shader sources, we need to dynamically link against SPIRV-Tools ourselves
    vkd3d_compiler.linkSystemLibrary("SPIRV-Tools-shared");

    vkd3d_compiler.addIncludePath(b.path(vulkan_header_folder ++ "include/"));

    vkd3d_compiler.addIncludePath(b.path(vkd3d_folder ++ "include/"));
    vkd3d_compiler.addIncludePath(b.path(vkd3d_folder ++ "include/private/"));
    vkd3d_compiler.addIncludePath(b.path(vkd3d_folder ++ "libs/vkd3d-utils/"));

    vkd3d_compiler.addCSourceFiles(.{
        .files = &.{vkd3d_folder ++ "libs/vkd3d-utils/vkd3d_utils_main.c"},
        .flags = &.{ "-std=c99", "-fPIC" },
    });

    b.installArtifact(vkd3d_compiler);
}
