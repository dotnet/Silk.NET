// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WS_ATTRIBUTE_DESCRIPTION"/> struct.</summary>
public static unsafe partial class WS_ATTRIBUTE_DESCRIPTIONTests
{
    /// <summary>Validates that the <see cref = "WS_ATTRIBUTE_DESCRIPTION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WS_ATTRIBUTE_DESCRIPTION>(), Is.EqualTo(sizeof(WS_ATTRIBUTE_DESCRIPTION)));
    }

    /// <summary>Validates that the <see cref = "WS_ATTRIBUTE_DESCRIPTION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WS_ATTRIBUTE_DESCRIPTION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WS_ATTRIBUTE_DESCRIPTION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WS_ATTRIBUTE_DESCRIPTION), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(WS_ATTRIBUTE_DESCRIPTION), Is.EqualTo(16));
        }
    }
}