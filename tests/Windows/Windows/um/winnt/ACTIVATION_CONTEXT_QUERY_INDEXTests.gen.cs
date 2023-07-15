// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ACTIVATION_CONTEXT_QUERY_INDEX"/> struct.</summary>
public static unsafe partial class ACTIVATION_CONTEXT_QUERY_INDEXTests
{
    /// <summary>Validates that the <see cref = "ACTIVATION_CONTEXT_QUERY_INDEX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ACTIVATION_CONTEXT_QUERY_INDEX>(), Is.EqualTo(sizeof(ACTIVATION_CONTEXT_QUERY_INDEX)));
    }

    /// <summary>Validates that the <see cref = "ACTIVATION_CONTEXT_QUERY_INDEX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ACTIVATION_CONTEXT_QUERY_INDEX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ACTIVATION_CONTEXT_QUERY_INDEX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ACTIVATION_CONTEXT_QUERY_INDEX), Is.EqualTo(8));
    }
}