using UnityEngine;
using MoreMountains.CorgiEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.CorgiExensions.AI.Graph
{
    /// <summary>
    /// A node representing a Corgi <see cref="MoreMountains.CorgiEngine.AIDecisionTargetIsNull"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Target Is Null")]
    public class AIDecisionTargetIsNullNode : AIDecisionNode
    {
        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionTargetIsNull>();
            decision.Label = label;
            return decision;
        }
    }
}
