﻿namespace SingularityLab.Runtime.Extensions
{
    using System.Runtime.CompilerServices;
    using UnityEngine;

    public static partial class VectorExtension
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector2 GetPositionOnScreen(this RectTransform rect, in Camera camera = null)
        {
            return RectTransformUtility.WorldToScreenPoint(camera, rect.position);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 GetRandomPointInBounds(this Bounds bounds)
        {
            return new Vector3(
                UnityEngine.Random.Range(bounds.min.x, bounds.max.x),
                UnityEngine.Random.Range(bounds.min.y, bounds.max.y),
                UnityEngine.Random.Range(bounds.min.z, bounds.max.z)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(this Vector3 originPos, in Vector3 pos, in float threshold = 0.1f)
        {
            var distance = Vector3.Distance(originPos, pos);

            return Mathf.Abs(distance) <= threshold;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OnlyX(this Vector3 vector)
        {
            vector.y = 0.0f;
            vector.z = 0.0f;
            return vector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OnlyY(this Vector3 vector)
        {
            vector.x = 0.0f;
            vector.z = 0.0f;
            return vector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OnlyZ(this Vector3 vector)
        {
            vector.x = 0.0f;
            vector.y = 0.0f;
            return vector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OnlyXY(this Vector3 vector)
        {
            vector.z = 0.0f;
            return vector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OnlyXZ(this Vector3 vector)
        {
            vector.y = 0.0f;
            return vector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 OnlyYZ(this Vector3 vector)
        {
            vector.x = 0.0f;
            return vector;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 XZ0(this Vector3 vector)
        {
            return new Vector3(vector.x, vector.z, 0.0f);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vector3 X0Y(this Vector3 vector)
        {
            return new Vector3(vector.x, 0.0f, vector.y);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsNaN(this Vector3 vector)
        {
            return float.IsNaN(vector.x) == true || float.IsNaN(vector.y) == true || float.IsNaN(vector.z) == true;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsZero(this Vector3 vector)
        {
            return vector.x == 0.0f && vector.y == 0.0f && vector.z == 0.0f;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsAlmostZero(this Vector3 vector, float tolerance = 0.01f)
        {
            return vector.x < tolerance && vector.x > -tolerance
                && vector.y < tolerance && vector.y > -tolerance
                && vector.z < tolerance && vector.z > -tolerance;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsEqual(this Vector3 vector, Vector3 other)
        {
            return vector.x == other.x && vector.y == other.y && vector.z == other.z;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool AlmostEquals(this Vector3 vectorA, Vector3 vectorB, float tolerance = 0.01f)
        {
            return IsAlmostZero(vectorA - vectorB, tolerance);
        }
    }
}