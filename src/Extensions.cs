using System;
using System.Diagnostics;

namespace Microsoft.Xna.Framework;

public static class Extensions
{
	public static void Normalize(this ref Vector2 vec)
	{
		vec = Vector2.Normalize(vec);
	}

	public static void Normalize(this ref Vector3 vec)
	{
		vec = Vector3.Normalize(vec);
	}

	public static void Normalize(this ref Vector4 vec)
	{
		vec = Vector4.Normalize(vec);
	}

	[Conditional("DEBUG")]
	internal static void CheckForNaNs(this ref Vector2 vec)
	{
		if (float.IsNaN(vec.X) || float.IsNaN(vec.Y))
		{
			throw new InvalidOperationException("Vector2 contains NaNs!");
		}
	}

	[Conditional("DEBUG")]
	internal static void CheckForNaNs(this ref Vector3 vec)
	{
		if (float.IsNaN(vec.X) || float.IsNaN(vec.Y) || float.IsNaN(vec.Z))
		{
			throw new InvalidOperationException("Vector3 contains NaNs!");
		}
	}

	[Conditional("DEBUG")]
	internal static void CheckForNaNs(this ref Vector4 vec)
	{
		if (	float.IsNaN(vec.X) ||
		        float.IsNaN(vec.Y) ||
		        float.IsNaN(vec.Z) ||
		        float.IsNaN(vec.W)	)
		{
			throw new InvalidOperationException("Vector4 contains NaNs!");
		}
	}

	internal static void CheckForNaNs(this ref Matrix matrix)
	{
		if (	float.IsNaN(matrix.M11) ||
		        float.IsNaN(matrix.M12) ||
		        float.IsNaN(matrix.M13) ||
		        float.IsNaN(matrix.M14) ||
		        float.IsNaN(matrix.M21) ||
		        float.IsNaN(matrix.M22) ||
		        float.IsNaN(matrix.M23) ||
		        float.IsNaN(matrix.M24) ||
		        float.IsNaN(matrix.M31) ||
		        float.IsNaN(matrix.M32) ||
		        float.IsNaN(matrix.M33) ||
		        float.IsNaN(matrix.M34) ||
		        float.IsNaN(matrix.M41) ||
		        float.IsNaN(matrix.M42) ||
		        float.IsNaN(matrix.M43) ||
		        float.IsNaN(matrix.M44)	)
		{
			throw new InvalidOperationException("Matrix contains NaNs!");
		}
	}

	[Conditional("DEBUG")]
	internal static void CheckForNaNs(this ref Quaternion quat)
	{
		if (	float.IsNaN(quat.X) ||
		        float.IsNaN(quat.Y) ||
		        float.IsNaN(quat.Z) ||
		        float.IsNaN(quat.W)	)
		{
			throw new InvalidOperationException("Quaternion contains NaNs!");
		}
	}
}
