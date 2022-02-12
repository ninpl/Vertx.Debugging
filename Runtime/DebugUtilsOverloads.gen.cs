//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Diagnostics;
using UnityEngine;

namespace Vertx.Debugging
{
	public static partial class DebugUtils
	{
		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycast(Ray ray, float distance, float duration = 0)
			=> DrawRaycast(ray, distance, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycast(Ray ray, float duration = 0)
			=> DrawRaycast(ray, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSphereCast(Ray ray, float radius, float distance, float duration = 0, int iterationCount = 10)
			=> DrawSphereCast(ray, radius, distance, StartColor, EndColor, duration, iterationCount);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSphereCast(Vector3 origin, float radius, Vector3 direction, float distance, float duration = 0, int iterationCount = 10)
			=> DrawSphereCast(origin, radius, direction, distance, StartColor, EndColor, duration, iterationCount);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float distance, float duration = 0, int iterationCount = 1)
			=> DrawBoxCast(center, halfExtents, direction, orientation, distance, StartColor, EndColor, duration, iterationCount);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, float distance, float duration = 0, int iterationCount = 10)
			=> DrawCapsuleCast(point1, point2, radius, direction, distance, StartColor, EndColor, duration, iterationCount);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycastHit(RaycastHit hit, float rayLength = 1, float duration = 0)
			=> DrawRaycastHit(hit, HitColor, rayLength, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycastHits(RaycastHit[] hits, int hitCount = -1, float rayLength = 1, float duration = 0)
			=> DrawRaycastHits(hits, HitColor, hitCount, rayLength, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSphereCastHit(RaycastHit hit, Ray ray, float radius, float duration = 0)
			=> DrawSphereCastHit(hit, ray, radius, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSphereCastHits(RaycastHit[] hits, Ray ray, float radius, int hitCount = -1, float duration = 0)
			=> DrawSphereCastHits(hits, ray, radius, HitColor, hitCount, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSphereCastHit(RaycastHit hit, Vector3 origin, float radius, Vector3 direction, float duration = 0)
			=> DrawSphereCastHit(hit, origin, radius, direction, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSphereCastHits(RaycastHit[] hits, Vector3 origin, float radius, Vector3 direction, int hitCount = -1, float duration = 0)
			=> DrawSphereCastHits(hits, origin, radius, direction, HitColor, hitCount, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBoxCastHit(RaycastHit hit, Vector3 origin, Vector3 halfExtents, Vector3 direction, Quaternion orientation, float duration = 0)
			=> DrawBoxCastHit(hit, origin, halfExtents, direction, orientation, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBoxCastHits(RaycastHit[] hits, Vector3 origin, Vector3 halfExtents, Vector3 direction, Quaternion orientation, int hitCount = -1, float duration = 0)
			=> DrawBoxCastHits(hits, origin, halfExtents, direction, orientation, HitColor, hitCount, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsuleCastHit(RaycastHit hit, Vector3 point1, Vector3 point2, float radius, Vector3 direction, float duration = 0)
			=> DrawCapsuleCastHit(hit, HitColor, point1, point2, radius, direction, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsuleCastHits(RaycastHit[] hits, Vector3 point1, Vector3 point2, float radius, Vector3 direction, int hitCount = -1, float duration = 0)
			=> DrawCapsuleCastHits(hits, HitColor, point1, point2, radius, direction, hitCount, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycast(Ray ray, RaycastHit hit, float distance, float hitRayLength = 1, float duration = 0)
			=> DrawRaycast(ray, hit, distance, RayColor, HitColor, hitRayLength, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycast(Ray ray, RaycastHit[] hits, float distance, int maxCount = -1, float hitRayLength = 1, float duration = 0)
			=> DrawRaycast(ray, hits, distance, RayColor, HitColor, maxCount, hitRayLength, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit hit, float distance, float duration = 0)
			=> DrawSphereCast(origin, radius, direction, hit, distance, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSphereCast(Vector3 origin, float radius, Vector3 direction, RaycastHit[] hits, float distance, int maxCount, float duration = 0)
			=> DrawSphereCast(origin, radius, direction, hits, distance, maxCount, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit hit, Quaternion orientation, float distance, float duration = 0)
			=> DrawBoxCast(center, halfExtents, direction, hit, orientation, distance, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBoxCast(Vector3 center, Vector3 halfExtents, Vector3 direction, RaycastHit[] hits, Quaternion orientation, float distance, int maxCount, float duration = 0)
			=> DrawBoxCast(center, halfExtents, direction, hits, orientation, distance, maxCount, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit hit, float distance, float duration = 0)
			=> DrawCapsuleCast(point1, point2, radius, direction, hit, distance, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsuleCast(Vector3 point1, Vector3 point2, float radius, Vector3 direction, RaycastHit[] hits, float distance, int count, float duration = 0)
			=> DrawCapsuleCast(point1, point2, radius, direction, hits, distance, count, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircleCast2D(Vector2 origin, float radius, Vector2 direction, float distance, float duration = 0)
			=> DrawCircleCast2D(origin, radius, direction, distance, StartColor, EndColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBoxCast2D(Vector2 origin, Vector2 size, float angle, Vector2 direction, float distance, float duration = 0)
			=> DrawBoxCast2D(origin, size, angle, direction, distance, StartColor, EndColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsuleCast2D(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float distance, float duration = 0)
			=> DrawCapsuleCast2D(origin, size, capsuleDirection, angle, direction, distance, StartColor, EndColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycast2DHit(RaycastHit2D hit, float rayLength = 1, float duration = 0)
			=> DrawRaycast2DHit(hit, HitColor, rayLength, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycast2DHits(RaycastHit2D[] hits, int hitCount = -1, float rayLength = 1, float duration = 0)
			=> DrawRaycast2DHits(hits, HitColor, hitCount, rayLength, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBoxCast2DHit(RaycastHit2D hit, Vector2 origin, Vector2 size, float angle, Vector2 direction, float duration = 0)
			=> DrawBoxCast2DHit(hit, origin, size, angle, direction, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBoxCast2DHits(RaycastHit2D[] hits, Vector2 origin, Vector2 size, float angle, Vector2 direction, int hitCount = -1, float duration = 0)
			=> DrawBoxCast2DHits(hits, origin, size, angle, direction, HitColor, hitCount, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircleCast2DHit(RaycastHit2D hit, Vector2 origin, float radius, Vector2 direction, float duration = 0)
			=> DrawCircleCast2DHit(hit, origin, radius, direction, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircleCast2DHits(RaycastHit2D[] hits, Vector2 origin, float radius, Vector2 direction, int hitCount = -1, float duration = 0)
			=> DrawCircleCast2DHits(hits, origin, radius, direction, HitColor, hitCount, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsuleCast2DHit(RaycastHit2D hit, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, float duration = 0)
			=> DrawCapsuleCast2DHit(hit, origin, size, capsuleDirection, angle, direction, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsuleCast2DHits(RaycastHit2D[] hits, Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, int hitCount = -1, float duration = 0)
			=> DrawCapsuleCast2DHits(hits, origin, size, capsuleDirection, angle, direction, HitColor, hitCount, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycast2D(Ray ray, RaycastHit2D hit, float distance, float hitRayLength = 1, float duration = 0)
			=> DrawRaycast2D(ray, hit, distance, RayColor, HitColor, hitRayLength, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycast2D(Ray ray, RaycastHit2D[] hits, float distance, int hitCount = -1, float hitRayLength = 1, float duration = 0)
			=> DrawRaycast2D(ray, hits, distance, RayColor, HitColor, hitCount, hitRayLength, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycast2D(Vector2 origin, Vector2 direction, RaycastHit2D hit, float distance, float hitRayLength = 1, float duration = 0)
			=> DrawRaycast2D(origin, direction, hit, distance, RayColor, HitColor, hitRayLength, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRaycast2D(Vector2 origin, Vector2 direction, RaycastHit2D[] hits, float distance, int hitCount = -1, float hitRayLength = 1, float duration = 0)
			=> DrawRaycast2D(origin, direction, hits, distance, RayColor, HitColor, hitCount, hitRayLength, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircleCast2D(Vector2 origin, float radius, Vector2 direction, RaycastHit2D hit, float distance, float duration = 0)
			=> DrawCircleCast2D(origin, radius, direction, hit, distance, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircleCast2D(Vector2 origin, float radius, Vector2 direction, RaycastHit2D[] hits, float distance, int hitCount, float duration = 0)
			=> DrawCircleCast2D(origin, radius, direction, hits, distance, hitCount, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBoxCast2D(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D hit, float distance, float duration = 0)
			=> DrawBoxCast2D(origin, size, angle, direction, hit, distance, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBoxCast2D(Vector2 origin, Vector2 size, float angle, Vector2 direction, RaycastHit2D[] hits, float distance, int hitCount, float duration = 0)
			=> DrawBoxCast2D(origin, size, angle, direction, hits, distance, hitCount, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsuleCast2D(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D hit, float distance, float duration = 0)
			=> DrawCapsuleCast2D(origin, size, capsuleDirection, angle, direction, hit, distance, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsuleCast2D(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, Vector2 direction, RaycastHit2D[] hits, float distance, int hitCount, float duration = 0)
			=> DrawCapsuleCast2D(origin, size, capsuleDirection, angle, direction, hits, distance, hitCount, StartColor, EndColor, HitColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSphere(Vector3 position, float radius, float duration = 0)
			=> DrawSphere(position, radius, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSphere(Vector3 position, float radius, bool hit, float duration = 0)
			=> DrawSphere(position, radius, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, float duration = 0)
			=> DrawBox(center, halfExtents, orientation, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBox(Vector3 center, Vector3 halfExtents, Quaternion orientation, bool hit, float duration = 0)
			=> DrawBox(center, halfExtents, orientation, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBox(Vector3 center, Vector3 halfExtents, float duration = 0)
			=> DrawBox(center, halfExtents, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBox(Vector3 center, Vector3 halfExtents, bool hit, float duration = 0)
			=> DrawBox(center, halfExtents, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsule(Vector3 start, Vector3 end, float radius, float duration = 0)
			=> DrawCapsule(start, end, radius, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsule(Vector3 start, Vector3 end, float radius, bool hit, float duration = 0)
			=> DrawCapsule(start, end, radius, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSurfacePoint(Vector3 point, Vector3 normal, float duration = 0)
			=> DrawSurfacePoint(point, normal, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSurfacePoint(Vector3 point, Vector3 normal, bool hit, float duration = 0)
			=> DrawSurfacePoint(point, normal, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawPoint(Vector3 point, float duration = 0, float rayLength = 0.3f, float highlightRadius = 0.05f)
			=> DrawPoint(point, RayColor, duration, rayLength, highlightRadius);

		[Conditional("UNITY_EDITOR")]
		public static void DrawPoint(Vector3 point, bool hit, float duration = 0, float rayLength = 0.3f, float highlightRadius = 0.05f)
			=> DrawPoint(point, hit ? HitColor : RayColor, duration, rayLength, highlightRadius);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArrow(Vector3 position, Vector3 direction, float duration = 0, float arrowheadScale = 1)
			=> DrawArrow(position, direction, RayColor, duration, arrowheadScale);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArrow(Vector3 position, Vector3 direction, bool hit, float duration = 0, float arrowheadScale = 1)
			=> DrawArrow(position, direction, hit ? HitColor : RayColor, duration, arrowheadScale);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArrowLine(Vector3 origin, Vector3 destination, float duration = 0, float arrowheadScale = 1)
			=> DrawArrowLine(origin, destination, RayColor, duration, arrowheadScale);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArrowLine(Vector3 origin, Vector3 destination, bool hit, float duration = 0, float arrowheadScale = 1)
			=> DrawArrowLine(origin, destination, hit ? HitColor : RayColor, duration, arrowheadScale);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBounds(Bounds bounds, float duration = 0)
			=> DrawBounds(bounds, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBounds(Bounds bounds, bool hit, float duration = 0)
			=> DrawBounds(bounds, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBounds(BoundsInt bounds, float duration = 0)
			=> DrawBounds(bounds, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBounds(BoundsInt bounds, bool hit, float duration = 0)
			=> DrawBounds(bounds, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArea2D(Vector2 point1, Vector2 point2, float duration = 0)
			=> DrawArea2D(point1, point2, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArea2D(Vector2 point1, Vector2 point2, bool hit, float duration = 0)
			=> DrawArea2D(point1, point2, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBox2D(Vector2 origin, Vector2 size, float angle, float duration = 0)
			=> DrawBox2D(origin, size, angle, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawBox2D(Vector2 origin, Vector2 size, float angle, bool hit, float duration = 0)
			=> DrawBox2D(origin, size, angle, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle2D(Vector2 origin, float radius, float duration = 0, int segments = 50)
			=> DrawCircle2D(origin, radius, RayColor, duration, segments);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle2D(Vector2 origin, float radius, bool hit, float duration = 0, int segments = 50)
			=> DrawCircle2D(origin, radius, hit ? HitColor : RayColor, duration, segments);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsule2D(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, float duration = 0)
			=> DrawCapsule2D(origin, size, capsuleDirection, angle, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCapsule2D(Vector2 origin, Vector2 size, CapsuleDirection2D capsuleDirection, float angle, bool hit, float duration = 0)
			=> DrawCapsule2D(origin, size, capsuleDirection, angle, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawPoint2D(Vector2 point, float duration = 0, float rayLength = 0.3f, float highlightRadius = 0.05f)
			=> DrawPoint2D(point, RayColor, duration, rayLength, highlightRadius);

		[Conditional("UNITY_EDITOR")]
		public static void DrawPoint2D(Vector2 point, bool hit, float duration = 0, float rayLength = 0.3f, float highlightRadius = 0.05f)
			=> DrawPoint2D(point, hit ? HitColor : RayColor, duration, rayLength, highlightRadius);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArrow2D(Vector2 point, float angle, float duration = 0)
			=> DrawArrow2D(point, angle, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArrow2D(Vector2 point, float angle, bool hit, float duration = 0)
			=> DrawArrow2D(point, angle, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArrow2D(Vector2 point, Vector2 direction, float duration = 0)
			=> DrawArrow2D(point, direction, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArrow2D(Vector2 point, Vector2 direction, bool hit, float duration = 0)
			=> DrawArrow2D(point, direction, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRect(Rect rect, float duration = 0)
			=> DrawRect(rect, RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawRect(Rect rect, bool hit, float duration = 0)
			=> DrawRect(rect, hit ? HitColor : RayColor, duration);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSpiral2D(Vector2 center, float radius, float angularOffset = 0, float revolutions = 4, float duration = 0, int segmentsPerRevolution = 50)
			=> DrawSpiral2D(center, radius, RayColor, angularOffset, revolutions, duration, segmentsPerRevolution);

		[Conditional("UNITY_EDITOR")]
		public static void DrawSpiral2D(Vector2 center, float radius, bool hit, float angularOffset = 0, float revolutions = 4, float duration = 0, int segmentsPerRevolution = 50)
			=> DrawSpiral2D(center, radius, hit ? HitColor : RayColor, angularOffset, revolutions, duration, segmentsPerRevolution);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 center, Vector3 normal, float radius, float duration = 0, int segmentCount = 100)
			=> DrawCircle(center, normal, radius, RayColor, duration, segmentCount);

		[Conditional("UNITY_EDITOR")]
		public static void DrawCircle(Vector3 center, Vector3 normal, float radius, bool hit, float duration = 0, int segmentCount = 100)
			=> DrawCircle(center, normal, radius, hit ? HitColor : RayColor, duration, segmentCount);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArc(Vector3 center, Vector3 normal, Vector3 startDirection, float radius, float totalAngle, float duration = 0, int segmentCount = 50)
			=> DrawArc(center, normal, startDirection, radius, totalAngle, RayColor, duration, segmentCount);

		[Conditional("UNITY_EDITOR")]
		public static void DrawArc(Vector3 center, Vector3 normal, Vector3 startDirection, float radius, float totalAngle, bool hit, float duration = 0, int segmentCount = 50)
			=> DrawArc(center, normal, startDirection, radius, totalAngle, hit ? HitColor : RayColor, duration, segmentCount);
	}
}