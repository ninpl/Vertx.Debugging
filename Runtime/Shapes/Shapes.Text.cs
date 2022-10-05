using UnityEngine;
// ReSharper disable ConvertToNullCoalescingCompoundAssignment
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable MemberHidesStaticFromOuterClass

namespace Vertx.Debugging
{
	public static partial class Shapes
	{
		/// <summary>
		/// Text drawn at a 3D position in the scene.
		/// </summary>
		public readonly struct Text : IDrawableCast
		{
			public readonly Vector3 Position;
			public readonly object Value;
			public readonly Camera Camera;
			
			/// <param name="position">Position to anchor the text to.</param>
			/// <param name="value">The value to be converted to a string.</param>
			/// <param name="camera">If a camera is not provided, the text will only draw in the Scene view.</param>
			public Text(Vector3 position, object value, Camera camera = null)
			{
				Camera = camera;
				Position = position;
				Value = value;
			}

#if UNITY_EDITOR
			public void Draw(CommandBuilder commandBuilder, Color color, float duration)
				=> Draw(commandBuilder, color, color == Color.white ? Color.black : Color.white, duration);

			public void Draw(CommandBuilder commandBuilder, Color backgroundColor, Color textColor, float duration)
				=> commandBuilder.AppendText(this, backgroundColor, textColor, duration);
#endif
		}
		
		/// <summary>
		/// Text drawn in the top left.<br/>
		/// Order is not maintained when mixing durations, including durations added with <see cref="Text"/>.
		/// </summary>
		public readonly struct ScreenText : IDrawableCast
		{
			public readonly object Value;

			/// <param name="value">The value to be converted to a string.</param>
			public ScreenText(object value) => Value = value;

#if UNITY_EDITOR
			public void Draw(CommandBuilder commandBuilder, Color color, float duration)
				=> Draw(commandBuilder, color, color == Color.white ? Color.black : Color.white, duration);
			
			public void Draw(CommandBuilder commandBuilder, Color backgroundColor, Color textColor, float duration)
				=> commandBuilder.AppendText(new Text(default, Value), backgroundColor, textColor, duration, DrawModifications.Custom);
#endif
		}

		internal sealed class TextData
		{
			public object Value;
			public Color BackgroundColor;
			public Color TextColor;
			public DrawModifications Modifications;

			// Only used for 3D Text
			public Vector3 Position;
			public Camera Camera;
			// Only used after 3D text is calculated.
			public Vector2 ScreenPosition;
			public float Distance;
			public float Alpha;
		}
	}
}