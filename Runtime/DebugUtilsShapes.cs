using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Vertx.Debugging
{
	public static partial class DebugUtils
	{
		[Conditional("UNITY_EDITOR")]
		public static void DrawSphere(Vector3 position, float radius, Color color)
		{
			Vector3 up = Vector3.up;
			Vector3 right = Vector3.right;
			Vector3 forward = Vector3.forward;
			DrawCircleFast(position, up, right, radius, DrawLine);
			DrawCircleFast(position, right, up, radius, DrawLine);
			DrawCircleFast(position, forward, right, radius, DrawLine);
			void DrawLine(Vector3 a, Vector3 b, float f) => Debug.DrawLine(a, b, color);
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, Color color)
		{
			DrawBox(center, halfExtents, orientation, DrawLine);
			void DrawLine(Vector3 a, Vector3 b) => Debug.DrawLine(a, b, color);
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawBox(Vector3 center, Vector3 halfExtents, Color color) => DrawBox(center, halfExtents, Quaternion.identity, color);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsule(Vector3 start, Vector3 end, float radius, Color color)
		{
			Vector3 alignment = (start - end).normalized;
			Vector3 crossA = GetAxisAlignedPerpendicular(alignment);
			Vector3 crossB = Vector3.Cross(crossA, alignment);
			DrawCapsuleFast(start, end, radius, alignment, crossA, crossB, DrawLine);
			void DrawLine(Vector3 a, Vector3 b, float f) => Debug.DrawLine(a, b, color);
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawSurfacePoint(Vector3 point, Vector3 normal, Color color)
		{
			Debug.DrawRay(point, normal, color);
			DrawCircle(point, normal, 0.05f, DrawLine, 50);
			void DrawLine(Vector3 a, Vector3 b, float f) => Debug.DrawLine(a, b, color);
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawPoint(Vector3 point, Color color, float rayLength = 0.3f, float highlightRadius = 0.05f)
		{
			Vector3 up = new Vector3(0, rayLength, 0);
			Quaternion rot = Quaternion.AngleAxis(120, Vector3.right);
			Vector3 d1 = rot * up;
			Quaternion rot1 = Quaternion.AngleAxis(120, up);
			Vector3 d2 = rot1 * d1;
			Vector3 d3 = rot1 * d2;

			Debug.DrawRay(point, up, color);
			Debug.DrawRay(point, d1, color);
			Debug.DrawRay(point, d2, color);
			Debug.DrawRay(point, d3, color);

			Vector3 down = new Vector3(0, -highlightRadius, 0);
			Vector3 p1 = rot * down;
			Vector3 p2 = rot1 * p1;
			Vector3 p3 = rot1 * p2;

			down += point;
			p1 += point;
			p2 += point;
			p3 += point;

			Debug.DrawLine(down, p1, color);
			Debug.DrawLine(down, p2, color);
			Debug.DrawLine(down, p3, color);
			Debug.DrawLine(p1, p2, color);
			Debug.DrawLine(p2, p3, color);
			Debug.DrawLine(p3, p1, color);
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawArrow(Vector3 position, Vector3 direction, Color color)
		{
			Debug.DrawRay(position, direction, color);
			DrawArrowHead(position, direction, color);
		}

		[Conditional("UNITY_EDITOR")]
		public static void DrawAxis(Vector3 point, bool arrowHeads = false)
			=> DrawAxis(point, Quaternion.identity, arrowHeads);

		[Conditional("UNITY_EDITOR")]
		public static void DrawAxis(Vector3 point, Quaternion rotation, bool arrowHeads = false)
		{
			Vector3 right = rotation * Vector3.right;
			Vector3 up = rotation * Vector3.up;
			Vector3 forward = rotation * Vector3.forward;
			Color colorRight = ColorX;
			Debug.DrawRay(point, right, colorRight);
			Color colorUp = ColorY;
			Debug.DrawRay(point, up, colorUp);
			Color colorForward = ColorZ;
			Debug.DrawRay(point, forward, colorForward);

			if (!arrowHeads)
				return;

			DrawArrowHead(point, right, colorRight);
			DrawArrowHead(point, up, colorUp);
			DrawArrowHead(point, forward, colorForward);
		}
		
		private static void DrawArrowHead(Vector3 point, Vector3 dir, Color color)
		{
			const float arrowLength = 0.075f;
			const float arrowWidth = 0.05f;
			const int segments = 3;

			Vector3 arrowPoint = point + dir;
			dir.EnsureNormalized();
			DrawCircle(arrowPoint - dir * arrowLength, dir, arrowWidth, (a, b, f) =>
			{
				Debug.DrawLine(a, b, color);
				Debug.DrawLine(a, arrowPoint, color);
			}, segments);
		}
	}
}