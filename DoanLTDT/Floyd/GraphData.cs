using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DoanLTDT
{
	[Serializable]
	class GraphData
    {
		public List<Point> NodeLocations;
		public EdgeCollection Edges;
		public int FormNode;
		public int ToNode;
		public bool IsUndirectedGraph;

		public GraphData(int fromNode, int toNode)
		{
			FormNode = fromNode;
			ToNode = toNode;
			NodeLocations = new List<Point>();

		}
	}
}
