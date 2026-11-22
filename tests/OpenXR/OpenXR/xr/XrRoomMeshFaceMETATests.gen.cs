// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenXR headers and corresponding dependencies.
// Original source is Copyright 2017-2026 The Khronos Group Inc. Licensed under the MIT license.
namespace Silk.NET.OpenXR.UnitTests;

/// <summary>Provides validation of the <see cref = "RoomMeshFaceMETA"/> struct.</summary>
public static unsafe partial class XrRoomMeshFaceMETATests
{
    /// <summary>Validates that the <see cref = "RoomMeshFaceMETA"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<RoomMeshFaceMETA>(), Is.EqualTo(sizeof(RoomMeshFaceMETA)));
    }

    /// <summary>Validates that the <see cref = "RoomMeshFaceMETA"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(RoomMeshFaceMETA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "RoomMeshFaceMETA"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(RoomMeshFaceMETA), Is.EqualTo(36));
    }
}
