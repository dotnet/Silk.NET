// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "MIXERCONTROLDETAILS_UNSIGNED"/> struct.</summary>
public static unsafe partial class MIXERCONTROLDETAILS_UNSIGNEDTests
{
    /// <summary>Validates that the <see cref = "MIXERCONTROLDETAILS_UNSIGNED"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIXERCONTROLDETAILS_UNSIGNED>(), Is.EqualTo(sizeof(MIXERCONTROLDETAILS_UNSIGNED)));
    }

    /// <summary>Validates that the <see cref = "MIXERCONTROLDETAILS_UNSIGNED"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIXERCONTROLDETAILS_UNSIGNED).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "MIXERCONTROLDETAILS_UNSIGNED"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIXERCONTROLDETAILS_UNSIGNED), Is.EqualTo(4));
    }
}