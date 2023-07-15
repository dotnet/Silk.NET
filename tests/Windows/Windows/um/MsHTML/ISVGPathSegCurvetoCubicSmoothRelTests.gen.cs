// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISVGPathSegCurvetoCubicSmoothRel"/> struct.</summary>
public static unsafe partial class ISVGPathSegCurvetoCubicSmoothRelTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISVGPathSegCurvetoCubicSmoothRel"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISVGPathSegCurvetoCubicSmoothRel).GUID, Is.EqualTo(IID_ISVGPathSegCurvetoCubicSmoothRel));
    }

    /// <summary>Validates that the <see cref = "ISVGPathSegCurvetoCubicSmoothRel"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISVGPathSegCurvetoCubicSmoothRel>(), Is.EqualTo(sizeof(ISVGPathSegCurvetoCubicSmoothRel)));
    }

    /// <summary>Validates that the <see cref = "ISVGPathSegCurvetoCubicSmoothRel"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISVGPathSegCurvetoCubicSmoothRel).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISVGPathSegCurvetoCubicSmoothRel"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISVGPathSegCurvetoCubicSmoothRel), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISVGPathSegCurvetoCubicSmoothRel), Is.EqualTo(4));
        }
    }
}