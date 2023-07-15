// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "DML_BUFFER_BINDING"/> struct.</summary>
public static unsafe partial class DML_BUFFER_BINDINGTests
{
    /// <summary>Validates that the <see cref = "DML_BUFFER_BINDING"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DML_BUFFER_BINDING>(), Is.EqualTo(sizeof(DML_BUFFER_BINDING)));
    }

    /// <summary>Validates that the <see cref = "DML_BUFFER_BINDING"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DML_BUFFER_BINDING).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "DML_BUFFER_BINDING"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DML_BUFFER_BINDING), Is.EqualTo(24));
    }
}