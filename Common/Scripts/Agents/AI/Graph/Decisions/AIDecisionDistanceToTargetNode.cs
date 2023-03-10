using UnityEngine;
using XNode;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.CorgiExensions.AI.Graph
{
	/// <summary>
	/// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionDistanceToTarget"/> decision.
	/// </summary>
	[CreateNodeMenu("AI/Decision/Distance To Target")]
	public class AIDecisionDistanceToTargetNode : AIDecisionNode
	{

		[Header("Settings")]
		
		[NodeEnum] public AIDecisionDistanceToTarget.ComparisonModes comparisonMode =
			AIDecisionDistanceToTarget.ComparisonModes.GreatherThan;

		public float distance;

		public override AIDecision AddDecisionComponent(GameObject go)
		{
			var decision = go.AddComponent<AIDecisionDistanceToTarget>();
			decision.Label = label;
			decision.Distance = distance;
			decision.ComparisonMode = comparisonMode;
			return decision;
		}
	}
}