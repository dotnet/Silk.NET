// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TF_PERSISTENT_PROPERTY_HEADER_ACP"/> struct.</summary>
public static unsafe partial class TF_PERSISTENT_PROPERTY_HEADER_ACPTests
{
    /// <summary>Validates that the <see cref = "TF_PERSISTENT_PROPERTY_HEADER_ACP"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TF_PERSISTENT_PROPERTY_HEADER_ACP>(), Is.EqualTo(sizeof(TF_PERSISTENT_PROPERTY_HEADER_ACP)));
    }

    /// <summary>Validates that the <see cref = "TF_PERSISTENT_PROPERTY_HEADER_ACP"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TF_PERSISTENT_PROPERTY_HEADER_ACP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TF_PERSISTENT_PROPERTY_HEADER_ACP"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TF_PERSISTENT_PROPERTY_HEADER_ACP), Is.EqualTo(48));
    }
}