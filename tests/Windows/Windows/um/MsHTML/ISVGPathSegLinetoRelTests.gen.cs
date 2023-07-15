// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISVGPathSegLinetoRel"/> struct.</summary>
public static unsafe partial class ISVGPathSegLinetoRelTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISVGPathSegLinetoRel"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISVGPathSegLinetoRel).GUID, Is.EqualTo(IID_ISVGPathSegLinetoRel));
    }

    /// <summary>Validates that the <see cref = "ISVGPathSegLinetoRel"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISVGPathSegLinetoRel>(), Is.EqualTo(sizeof(ISVGPathSegLinetoRel)));
    }

    /// <summary>Validates that the <see cref = "ISVGPathSegLinetoRel"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISVGPathSegLinetoRel).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISVGPathSegLinetoRel"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISVGPathSegLinetoRel), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISVGPathSegLinetoRel), Is.EqualTo(4));
        }
    }
}