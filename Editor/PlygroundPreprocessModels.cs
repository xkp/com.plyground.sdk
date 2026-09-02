using System.Collections.Generic;
using UnityEngine;

// These models are part of the controller preprocessing contract.
public class NodeAttribute
{
	public string Name { get; set; }
	public string Value { get; set; }
}

public struct PostProcessNode
{
	public GameObject GameObject { get; set; }
	public IList<NodeAttribute> Attributes { get; set; }
}
